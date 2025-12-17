using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagement.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Bio { get; set; } // Tiểu sử (có thể null)

        // Quan hệ: Một tác giả có nhiều sách
        public virtual ICollection<Book> Books { get; set; }
    }
}