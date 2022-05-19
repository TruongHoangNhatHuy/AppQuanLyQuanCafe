using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class HoaDonView
    {
        public string MaHoaDon { get; set; }
        public string TenNhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public string PhuThu { get; set; }
        public string GiamGia { get; set; }
        public int ThanhTien { get; set; }
    }
}
