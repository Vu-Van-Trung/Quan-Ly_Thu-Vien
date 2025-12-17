using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; }

        public int PublishedYear { get; set; }

        // Khóa ngoại (Foreign Key) tới Author
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        // Khóa ngoại tới Category
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        // Quan hệ: Một cuốn sách có thể nằm trong nhiều phiếu mượn
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
