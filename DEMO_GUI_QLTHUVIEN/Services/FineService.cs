using System;
using System.Linq;
using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LibraryManagement.Services
{
    public class FineService
    {
        private readonly LibraryContext _context;
        private const decimal FINE_PER_DAY = 5000;
        private const decimal DAMAGED_PERCENTAGE = 0.5m;
        private const decimal LOST_PERCENTAGE = 1.0m;
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
            if (condition == "Hư hỏng") return price * DAMAGED_PERCENTAGE;
            if (condition == "Mất") return price * LOST_PERCENTAGE;
            return 0;
        }

        public void ReturnBook(int loanDetailId, string condition)
        {
            var detail = _context.LoanDetails
                .Include(d => d.Book)
                .FirstOrDefault(d => d.LoanDetailId == loanDetailId);

            if (detail == null) throw new Exception("Không tìm thấy chi tiết phiếu mượn");

            detail.NgayTra = DateTime.Now;
            detail.TinhTrangTra = condition;

            // Calculate Condition Fine
            decimal fineAmount = CalculateConditionFine(detail.Book, condition);
            if (fineAmount > 0)
            {
                CreateOverdueFine(detail.LoanId, fineAmount, $"Phạt sách {condition}: {detail.Book.Title}");
            }
            
            _context.SaveChanges();
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
    }
}
