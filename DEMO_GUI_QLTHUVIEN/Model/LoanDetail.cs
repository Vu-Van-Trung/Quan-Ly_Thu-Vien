using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng CHI_TIET_PHIEU_MUON - Chi tiết phiếu mượn
    /// </summary>
    [Table("CHI_TIET_PHIEU_MUON")]
    public class LoanDetail
    {
        [Key]
        [Column("MaChiTiet")]
        public int LoanDetailId { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("MaPhieuMuon")]
        public string LoanId { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("MaSach")]
        public string BookId { get; set; }

        [Column("SoLuong")]
        public int SoLuong { get; set; } = 1;

        [MaxLength(100)]
        [Column("TinhTrangMuon")]
        public string TinhTrangMuon { get; set; } = "Tốt";

        [MaxLength(100)]
        [Column("TinhTrangTra")]
        public string? TinhTrangTra { get; set; }

        [Column("NgayTra")]
        public DateTime? NgayTra { get; set; }

        // Navigation properties
        [ForeignKey("LoanId")]
        public virtual Loan Loan { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
    }
}
