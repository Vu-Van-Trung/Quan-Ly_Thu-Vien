using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime JoinDate { get; set; } = DateTime.Now;

        // Quan hệ: Một độc giả có nhiều phiếu mượn
        public virtual ICollection<Loan> Loans { get; set; }
    }
}