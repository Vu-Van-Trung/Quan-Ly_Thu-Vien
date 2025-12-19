using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    /// <summary>
    /// Entity cho bảng PHAT - Phạt
    /// </summary>
    [Table("PHAT")]
    public class Fine
    {
        [Key]
        [Column("MaPhat")]
        public int FineId { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("MaPhieuMuon")]
        public string LoanId { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("LyDo")]
        public string LyDo { get; set; }

        [Required]
        [Column("SoTienPhat", TypeName = "decimal(18,2)")]
        public decimal SoTienPhat { get; set; }

        [Column("NgayPhat")]
        public DateTime NgayPhat { get; set; } = DateTime.Now;

        [MaxLength(50)]
        [Column("TrangThaiThanhToan")]
        public string TrangThaiThanhToan { get; set; } = "Chưa thanh toán";

        [Column("NgayThanhToan")]
        public DateTime? NgayThanhToan { get; set; }

        // Navigation property
        [ForeignKey("LoanId")]
        public virtual Loan Loan { get; set; }
    }
}
