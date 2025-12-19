using DoAnDemoUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng NHAN_VIEN - Nhân viên
    /// </summary>
    [Table("NHAN_VIEN")]
    public class Staff
    {
        [Key]
        [Column("MaNhanVien")]
        public int StaffId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("HoTen")]
        public string HoTen { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("ChucVu")]
        public string ChucVu { get; set; }

        [Column("NgaySinh")]
        public DateTime? NgaySinh { get; set; }

        [MaxLength(10)]
        [Column("GioiTinh")]
        public string? GioiTinh { get; set; }

        [MaxLength(300)]
        [Column("DiaChi")]
        public string? DiaChi { get; set; }

        [MaxLength(15)]
        [Column("SoDienThoai")]
        public string? SoDienThoai { get; set; }

        [MaxLength(100)]
        [Column("Email")]
        public string? Email { get; set; }

        [Column("NgayVaoLam")]
        public DateTime NgayVaoLam { get; set; } = DateTime.Now;

        [MaxLength(20)]
        [Column("TrangThai")]
        public string TrangThai { get; set; } = "Đang làm việc";

        [Column("NgayTao")]
        public DateTime NgayTao { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual User? User { get; set; }
        public virtual ICollection<Loan>? Loans { get; set; }
    }
}
