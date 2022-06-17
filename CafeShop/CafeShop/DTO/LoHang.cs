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
        [StringLength(20)]
        public string MaLoHang { get; set; }
        public int SoLuongNhap { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public int TienThanhToan { get; set; }

        [StringLength(10)]
        public string MaHangHoa { get; set; }
        [ForeignKey("MaHangHoa")]
        public virtual HangHoa HangHoa { get; set; }

        [StringLength(10)]
        public string IDNhanVien { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}