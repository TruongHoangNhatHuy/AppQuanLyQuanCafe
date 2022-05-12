using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("DonGoiMon")]
    public class DonGoiMon
    {
        [Key]
        [StringLength(20)]
        public string MaDonGoiMon { get; set; }
        [StringLength(20)]
        public string MaHoaDon { get; set; }
        [StringLength(10)]
        public string MaMon { get; set; }
        public int SoLuong { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public int GiaTien { get; set; }
        public DateTime ThoiGianGoiMon { get; set; }
        [StringLength(20)]
        public string TinhTrang { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        [ForeignKey("MaMon")]
        public virtual Mon Mon { get; set; }
    }
}