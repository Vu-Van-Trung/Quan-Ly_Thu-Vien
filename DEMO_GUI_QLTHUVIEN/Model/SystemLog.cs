#nullable enable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    [Table("NHAT_KY_HE_THONG")]
    public class SystemLog
    {
        [Key]
        [Column("MaLog")]
        public int LogId { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string ChucNang { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string HanhDong { get; set; } = null!;

        [StringLength(500)]
        public string NoiDung { get; set; } = null!;

        public DateTime ThoiGian { get; set; } = DateTime.Now;
    }
}
