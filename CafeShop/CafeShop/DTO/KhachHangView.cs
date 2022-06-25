using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class KhachHangView
    {
        public KhachHangView(KhachHang kh)
        {
            this.IDKhachHang = kh.IDKhachHang;
            this.HoTenKH = kh.HoTenKH;
            this.GioiTinhKH = kh.GioiTinhKH ? "Nam" : "Nữ";
            this.NgaySinhKH = kh.NgaySinhKH.ToString("dd/MM/yyyy");
            this.DiaChiKH = kh.DiaChiKH;
            this.SoDienThoaiKH = kh.SoDienThoaiKH;
            this.NgayDangKi = kh.NgayDangKi.ToString("dd/MM/yyyy");
        }
        public string IDKhachHang { get; set; }
        public string HoTenKH { get; set; }
        public string GioiTinhKH { get; set; }
        public string NgaySinhKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SoDienThoaiKH { get; set; }
        public string NgayDangKi { get; set; }
    }
}
