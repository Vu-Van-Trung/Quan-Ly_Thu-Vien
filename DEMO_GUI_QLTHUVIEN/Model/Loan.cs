using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        public DateTime LoanDate { get; set; } = DateTime.Now; // Ngày mượn
        public DateTime DueDate { get; set; } // Ngày phải trả
        public DateTime? ReturnDate { get; set; } // Ngày trả thực tế (Null nếu chưa trả)

        // Khóa ngoại tới Book
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        // Khóa ngoại tới Member
        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
    }
}