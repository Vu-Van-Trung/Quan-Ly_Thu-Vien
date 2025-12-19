using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng THE_LOAI - Thể loại
    /// </summary>
    [Table("THE_LOAI")]
    public class Category
    {
        [Key]
        [Column("MaTheLoai")]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("TenTheLoai")]
        public string Name { get; set; }

        [MaxLength(500)]
        [Column("MoTa")]
        public string? MoTa { get; set; }

        [Column("NgayTao")]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ICollection<Book>? Books { get; set; }
    }
}
