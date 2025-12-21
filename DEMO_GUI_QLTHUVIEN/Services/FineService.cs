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

        public void ReturnBook(int loanDetailId, string condition, bool isDamaged)
        {
            var detail = _context.LoanDetails.Find(loanDetailId);
            if (detail == null) throw new Exception("Không tìm thấy chi tiết phiếu mượn");

            detail.NgayTra = DateTime.Now;
            detail.TinhTrangTra = condition;
            
            _context.SaveChanges();
        }

        public bool IsFineExists(string loanId, string reason)
        {
            return _context.Fines.Any(f => f.LoanId == loanId && f.LyDo == reason);
        }

        public Fine CreateOverdueFine(string loanId, decimal amount, string reason)
        {
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
