using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            this.LoHangs = new HashSet<LoHang>();
            this.HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        public string ID { get; set; }
        [Required]
        [StringLength(20)]
        [Index(IsUnique = true)]
        public string TenTaiKhoan { get; set; }
        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }
        [StringLength(50)]
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(11)]
        public string SoDienThoai { get; set; }
        public DateTime NgayBatDauLamViec { get; set; }
        [StringLength(10)]
        public string MaVaiTro { get; set; }
        [ForeignKey("MaVaiTro")]
        public virtual VaiTro VaiTro { get; set; }
        public virtual ICollection<LoHang> LoHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public override string ToString()
        {
            return HoTen;
        }
    }
}