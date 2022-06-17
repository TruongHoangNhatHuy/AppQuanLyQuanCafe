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
        public int SoLuong { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public int GiaTien { get; set; }
        public DateTime ThoiGianGoiMon { get; set; }
        public OrderState TinhTrang { get; set; }

        [StringLength(20)]
        public string MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDon HoaDon { get; set; }

        [StringLength(10)]
        public string MaMon { get; set; }
        [ForeignKey("MaMon")]
        public virtual Mon Mon { get; set; }
    }
    public enum OrderState
    {
        Waiting,
        Processing,
        Completed
    }
}