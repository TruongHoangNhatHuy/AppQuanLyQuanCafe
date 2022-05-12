using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        public KhachHang()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [StringLength(10)]
        public string IDKhachHang { get; set; }
        [StringLength(50)]
        public string HoTenKH { get; set; }
        public bool GioiTinhKH { get; set; }
        public DateTime NgaySinhKH { get; set; }
        [StringLength(50)]
        public string DiaChiKH { get; set; }
        [Required]
        [StringLength(11)]
        [Index(IsUnique = true)]
        public string SoDienThoaiKH { get; set; }
        public DateTime NgayDangKi { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}