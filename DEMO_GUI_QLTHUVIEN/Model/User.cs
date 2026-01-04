#nullable enable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnDemoUI.Model
{
    /// <summary>
    /// Entity cho bảng TAI_KHOAN - Tài khoản đăng nhập
    /// </summary>
    [Table("TAI_KHOAN")]
    public class User
    {
        [Key]
        [Column("MaTaiKhoan")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("TenDangNhap")]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        [Column("MatKhau")]
        public string Password { get; set; } = null!;



        [Required]
        [Column("MaNhanVien")]
        public int StaffId { get; set; }

        [MaxLength(50)]
        [Column("QuyenHan")]
        public string Role { get; set; } = "Nhân viên";

        [MaxLength(20)]
        [Column("TrangThai")]
        public string TrangThai { get; set; } = "Hoạt động";

        [Column("NgayTao")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("LanDangNhapCuoi")]
        public DateTime? LanDangNhapCuoi { get; set; }

        // Navigation property
        [ForeignKey("StaffId")]
        public virtual LibraryManagement.Models.Staff Staff { get; set; } = null!;
    }
}
