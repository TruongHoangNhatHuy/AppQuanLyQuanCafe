using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("HoaDon")]
    public class HoaDon
    {
        public HoaDon()
        {
            this.DonGoiMons = new HashSet<DonGoiMon>();
        }

        [Key]
        [StringLength(20)]
        public string MaHoaDon { get; set; }
        [StringLength(10)]
        public string PhuThu { get; set; }
        [StringLength(10)]
        public string GiamGia { get; set; }
        public int ThanhTien { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNhanVien { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual TaiKhoan TaiKhoan { get; set; }

        [StringLength(10)]
        public string IDKhachHang { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaBan { get; set; }
        [ForeignKey("MaBan")]
        public virtual Ban Ban { get; set; }

        public virtual ICollection<DonGoiMon> DonGoiMons { get; set; }
    }
}