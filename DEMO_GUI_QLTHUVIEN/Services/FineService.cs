using System;
using System.Linq;
using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DoAnDemoUI.Services;
using DoAnDemoUI.Model; // Add DoAnDemoUI.Model namespace

namespace LibraryManagement.Services
{
    public class FineService
    {
        private readonly LibraryContext _context;
        
        // ... (constants)
        
        public string GetStaffFullName(string username)
        {
             if (string.IsNullOrEmpty(username)) return "Admin";
             var user = _context.Users.Include(u => u.Staff).FirstOrDefault(u => u.Username == username);
             return user?.Staff?.HoTen ?? username; // Return Full Name or Username if null
        }
        private const decimal FINE_PER_DAY = 5000;
        private const decimal DAMAGED_PERCENTAGE = 0.5m; // Kept for reference, logic updated in method
        private const decimal LOST_PERCENTAGE = 1.0m; // Kept for reference, logic updated in method
        private const decimal DEFAULT_BOOK_PRICE = 50000;

        public FineService()
        {
            _context = new LibraryContext();
        }

        public FineService(LibraryContext context)
        {
            _context = context;
        }

        public Loan GetLoanWithDetails(string loanId)
        {
            // Clear cache to ensure we get fresh data including newly created fines
            // This is safe because this method is typically called after SaveChanges()
            try { _context.ChangeTracker.Clear(); } catch { } 
            
            return _context.Loans
                .Include(l => l.LoanDetails)
                    .ThenInclude(ld => ld.Book)
                .Include(l => l.Member)
                .Include(l => l.Fines)
                .FirstOrDefault(l => l.LoanId == loanId);
        }

        public decimal CalculateFineAmount(DateTime dueDate, DateTime returnDate)
        {
            if (returnDate <= dueDate) return 0;
            TimeSpan overdue = returnDate - dueDate;
            return (decimal)overdue.TotalDays * FINE_PER_DAY;
        }

        public decimal CalculateConditionFine(Book book, string condition)
        {
            decimal price = book.GiaTien ?? DEFAULT_BOOK_PRICE;
            if (condition == "Hư hỏng") return 10000; // Fixed fee
            if (condition == "Mất") return price * 3; // x3 Price
            return 0;
        }

        public decimal ReturnBook(int loanDetailId, string condition)
        {
            var detail = _context.LoanDetails
                .Include(d => d.Book)
                .FirstOrDefault(d => d.LoanDetailId == loanDetailId);

            if (detail == null) throw new Exception("Không tìm thấy chi tiết phiếu mượn");

            detail.NgayTra = DateTime.Now;
            detail.TinhTrangTra = condition;

            // Calculate Condition Fine
            // Calculate Condition Fine
            decimal fineAmount = CalculateConditionFine(detail.Book, condition);
            
            // Always create a transaction record, even if 0
            // If amount > 0, it's a Penalty. If 0, it's a Record of Return (Good/Paid).
            // We use CreateOverdueFine but maybe with a different reason format to ensure Uniqueness for this return instance?
            // "Trả sách: Title (Condition)"
            // Append LoanDetailId to ensure uniqueness if multiple copies of same book are in same loan
            string reason = $"Trả sách: {detail.Book.Title} ({condition}) #{detail.LoanDetailId}";
            if (fineAmount > 0) 
            {
                reason = $"Phạt sách {condition}: {detail.Book.Title} #{detail.LoanDetailId}";
            }
            
            CreateOverdueFine(detail.LoanId, fineAmount, reason);
            
            _context.SaveChanges();

            // Check if all books are returned
            bool isAllReturned = !_context.LoanDetails.Any(ld => ld.LoanId == detail.LoanId && ld.NgayTra == null);
            if (isAllReturned)
            {
                var loan = _context.Loans.FirstOrDefault(l => l.LoanId == detail.LoanId);
                if (loan != null && loan.TrangThai != "Đã trả")
                {
                    loan.TrangThai = "Đã trả";
                    loan.NgayTraThucTe = DateTime.Now;
                    _context.SaveChanges();
                }
            }
            
            return fineAmount;
        }

        public bool IsFineExists(string loanId, string reason)
        {
            return _context.Fines.Any(f => f.LoanId == loanId && f.LyDo == reason);
        }

        public Fine CreateOverdueFine(string loanId, decimal amount, string reason)
        {
            // Allow multiple fines for different reasons, but maybe check duplicates if needed
            // For damage/lost, we might want to allow it even if similar exists? 
            // Current logic prevents specific exact reason on same loan.
            if (IsFineExists(loanId, reason)) return null;

            var fine = new Fine
            {
                LoanId = loanId,
                SoTienPhat = amount,
                LyDo = reason,
                NgayPhat = DateTime.Now,
                TrangThaiThanhToan = "Chưa thanh toán"
            };

            _context.Fines.Add(fine);
            _context.SaveChanges();
            return fine;
        }

        public void PayFine(int fineId)
        {
            var fine = _context.Fines.Find(fineId);
            if (fine != null)
            {
                fine.TrangThaiThanhToan = "Đã thanh toán";
                fine.NgayThanhToan = DateTime.Now;
                _context.SaveChanges();
            }
        }
        public void ApplyDiscount(int fineId, int percentage)
        {
            var fine = _context.Fines.Find(fineId);
            if (fine != null && percentage >= 0 && percentage <= 100)
            {
                decimal discountAmount = fine.SoTienPhat * percentage / 100;
                fine.SoTienPhat -= discountAmount;
                fine.LyDo += $" (Đã giảm {percentage}%)";
                _context.SaveChanges();
            }
        }

        public void ApplyWaiver(int fineId, decimal value, bool isPercentage, string reason, string performer)
        {
            var fine = _context.Fines.Find(fineId);
            if (fine != null)
            {
                decimal discountAmount;
                if (isPercentage)
                {
                    discountAmount = fine.SoTienPhat * value / 100;
                }
                else
                {
                    discountAmount = value;
                }

                if (discountAmount > fine.SoTienPhat) discountAmount = fine.SoTienPhat;

                fine.SoTienPhat -= discountAmount;
                string waiverType = isPercentage ? "%" : " VNĐ";
                fine.LyDo += $" (Miễn giảm: {value:N0}{waiverType} - By: {performer} - Reason: {reason})";
                
                // If full waiver, mark as paid? Or just let it be 0? 
                // Usually if amount is 0, it's effectively paid, but status might need update if we want to "clear" it.
                // For now, keep it simple as per request, just reduce amount. User can "Pay" the 0 amount to clear it if needed, or system handles 0 payment.
                if (fine.SoTienPhat <= 0)
                {
                    fine.SoTienPhat = 0;
                    fine.TrangThaiThanhToan = "Đã thanh toán"; // Auto-close if 0
                    fine.NgayThanhToan = DateTime.Now;
                }

                _context.SaveChanges();

                // Audit Log
                Logger.Log("Quản lý Phạt", "Miễn giảm", 
                    $"Miễn giảm {discountAmount:N0} cho khoản phạt {fineId} (Phiếu {fine.LoanId}). Lý do: {reason}. Người thực hiện: {performer}");
            }
        }
        public List<string> GetAllLoanIds()
        {
            return _context.Loans.Select(l => l.LoanId).ToList();
        }
    }
}
