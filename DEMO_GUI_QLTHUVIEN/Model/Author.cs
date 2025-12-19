using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng TAC_GIA - Tác giả
    /// </summary>
    [Table("TAC_GIA")]
    public class Author
    {
        [Key]
        [Column("MaTacGia")]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("TenTacGia")]
        public string Name { get; set; }

        [Column("NgaySinh")]
        public DateTime? NgaySinh { get; set; }

        [MaxLength(50)]
        [Column("QuocTich")]
        public string? QuocTich { get; set; }

        [Column("TieuSu", TypeName = "nvarchar(max)")]
        public string? Bio { get; set; }

        [Column("NgayTao")]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        [Column("NgayCapNhat")]
        public DateTime NgayCapNhat { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ICollection<Book>? Books { get; set; }
    }
}
