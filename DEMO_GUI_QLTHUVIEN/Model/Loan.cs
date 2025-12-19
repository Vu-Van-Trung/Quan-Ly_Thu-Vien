using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng PHIEU_MUON - Phiếu mượn sách
    /// </summary>
    [Table("PHIEU_MUON")]
    public class Loan
    {
        [Key]
        [MaxLength(20)]
        [Column("MaPhieuMuon")]
        public string LoanId { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("MaDocGia")]
        public string MemberId { get; set; }

        [Required]
        [Column("MaNhanVien")]
        public int StaffId { get; set; }

        [Column("NgayMuon")]
        public DateTime LoanDate { get; set; } = DateTime.Now;

        [Required]
        [Column("HanTra")]
        public DateTime DueDate { get; set; }

        [Column("NgayTraThucTe")]
        public DateTime? NgayTraThucTe { get; set; }

        [MaxLength(50)]
        [Column("TrangThai")]
        public string TrangThai { get; set; } = "Đang mượn";

        [MaxLength(500)]
        [Column("GhiChu")]
        public string? GhiChu { get; set; }

        // Navigation properties
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }

        public virtual ICollection<LoanDetail>? LoanDetails { get; set; }
        public virtual ICollection<Fine>? Fines { get; set; }
    }
}
