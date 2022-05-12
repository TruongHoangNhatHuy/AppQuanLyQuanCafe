using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    [Table("LoHang")]
    public class LoHang
    {
        [Key]
        [StringLength(10)]
        public string MaLoHang { get; set; }
        [StringLength(10)]
        public string MaNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhapKho { get; set; }
        [StringLength(10)]
        public string IDNhanVien { get; set; }
        [ForeignKey("MaNguyenLieu")]
        public virtual NguyenLieu NguyenLieu { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}