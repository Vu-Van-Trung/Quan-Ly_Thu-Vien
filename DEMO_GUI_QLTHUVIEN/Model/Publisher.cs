using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng NHA_XUAT_BAN - Nhà xuất bản
    /// </summary>
    [Table("NHA_XUAT_BAN")]
    public class Publisher
    {
        [Key]
        [Column("MaNhaXuatBan")]
        public int PublisherId { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("TenNhaXuatBan")]
        public string TenNhaXuatBan { get; set; }

        [MaxLength(300)]
        [Column("DiaChi")]
        public string? DiaChi { get; set; }

        [MaxLength(15)]
        [Column("SoDienThoai")]
        public string? SoDienThoai { get; set; }

        [MaxLength(100)]
        [Column("Email")]
        public string? Email { get; set; }

        [Column("NgayTao")]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        [Column("NgayCapNhat")]
        public DateTime NgayCapNhat { get; set; } = DateTime.Now;

        // Navigation property
        public virtual ICollection<Book>? Books { get; set; }
    }
}
