using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng SACH - Sách
    /// </summary>
    [Table("SACH")]
    public class Book
    {
        [Key]
        [MaxLength(20)]
        [Column("MaSach")]
        public string BookId { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("TenSach")]
        public string Title { get; set; }

        [Required]
        [Column("MaTacGia")]
        public int AuthorId { get; set; }

        [Required]
        [Column("MaTheLoai")]
        public int CategoryId { get; set; }

        [Column("MaNhaXuatBan")]
        public int PublisherId { get; set; } = 1; // Default publisher

        // Compatibility property - không map vào database
        [NotMapped]
        public string? ISBN { get; set; }

        [Column("NamXuatBan")]
        public int? PublishedYear { get; set; }

        [Column("SoLuongTon")]
        public int SoLuongTon { get; set; } = 0;

        [MaxLength(50)]
        [Column("ViTri")]
        public string? ViTri { get; set; }

        [MaxLength(50)]
        [Column("TrangThai")]
        public string TrangThai { get; set; } = "Có sẵn";

        [Column("MoTa", TypeName = "nvarchar(max)")]
        public string? MoTa { get; set; }

        [Column("GiaTien", TypeName = "decimal(18,2)")]
        public decimal? GiaTien { get; set; }

        [Column("NgayNhap")]
        public DateTime NgayNhap { get; set; } = DateTime.Now;

        // Navigation properties
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<LoanDetail>? LoanDetails { get; set; }
       // public object ISBN { get; internal set; }
    }
}
