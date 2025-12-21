using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng DOC_GIA - Độc giả/Thành viên
    /// </summary>
    [Table("DOC_GIA")]
    public class Member
    {
        [Key]
        [MaxLength(20)]
        [Column("MaDocGia")]
        public string MemberId { get; set; }

        [Required]
        [MaxLength(300)]
        [Column("HoTen")]
        public string FullName { get; set; }

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
        public string? PhoneNumber { get; set; }

        [MaxLength(300)]
        [Column("Email")]
        public string? Email { get; set; }

        [MaxLength(20)]
        [Column("CMND")]
        public string? CMND { get; set; }

        [Column("NgayDangKy")]
        public DateTime JoinDate { get; set; } = DateTime.Now;

        [Column("NgayHetHan")]
        public DateTime? NgayHetHan { get; set; }

        [MaxLength(50)]
        [Column("TrangThai")]
        public string TrangThai { get; set; } = "Hoạt động";

        [MaxLength(500)]
        [Column("GhiChu")]
        public string? GhiChu { get; set; }

        // Navigation property
        public virtual ICollection<Loan>? Loans { get; set; }
    }
}
