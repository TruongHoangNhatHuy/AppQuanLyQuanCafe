using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLInvoice
    {
        private static BLLInvoice _Instance;
        public static BLLInvoice Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLInvoice();
                return _Instance;
            }
            private set {}
        }
        public List<HoaDon> GetAllHoaDon() => DBModel.Instance.HoaDons.ToList();
        public List<HoaDonView> ChangeView(List<HoaDon> list)
        {
            return list.Select(d => new HoaDonView()
            {
                MaHoaDon = d.MaHoaDon,
                TenNhanVien = DBModel.Instance.TaiKhoans.Find(d.IDNhanVien).HoTen,
                TenKhachHang = DBModel.Instance.KhachHangs.Find(d.IDKhachHang).HoTenKH,
                ThoiGianThanhToan = d.ThoiGianThanhToan,
                GiamGia = d.GiamGia,
                PhuThu = d.PhuThu,
                ThanhTien = d.ThanhTien
            }
            ).ToList();
        }
        public List<HoaDonView> GetAllHoaDonView()
        {
            return ChangeView(GetAllHoaDon());
        }
        public List<HoaDon> GetHoaDonByTime(DateTime from, DateTime to)
        {
            return GetAllHoaDon().Where(p => p.ThoiGianThanhToan.Date >= from.Date && p.ThoiGianThanhToan.Date <= to.Date).ToList();
        }
        public List<HoaDon> Search(DateTime from, DateTime to, string MaHoaDon, string TenNhanVien, string TenKhachHang)
        {
            return GetHoaDonByTime(from, to).
                Where(p =>
                p.KhachHang.HoTenKH.ToLower().Contains(TenKhachHang.ToLower()) &&
                p.TaiKhoan.HoTen.ToLower().Contains(TenNhanVien.ToLower()) &&
                p.MaHoaDon.Contains(MaHoaDon)
                ).ToList();
        }
    }
}
