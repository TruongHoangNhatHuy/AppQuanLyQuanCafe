using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
            private set { }
        }
        private BLLInvoice() { }
        public List<HoaDon> GetAllHoaDon() => DBContext.Instance.HoaDons.Where(p => p.MaBan.Equals("B000000000")).ToList();
        public HoaDon GetHoaDonByMaHoaDon(string MaHoaDon) => DBContext.Instance.HoaDons.Find(MaHoaDon);
        public string GetBillCount(List<HoaDon> list) => list.Count.ToString();
        public string GetCustomerCount(List<HoaDon> list)
        {
            int nonMember = list.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = list.Select(p => new { p.IDKhachHang}).Distinct().Count();
            if (nonMember > 0)
                member--;
            return member.ToString();
        }
        public string GetRevenue(List<HoaDon> list) => list.Sum(p => p.ThanhTien).ToString();
        public List<HoaDonView> ChangeView(List<HoaDon> list)
        {
            return list.Select(d => new HoaDonView()
            {
                MaHoaDon = d.MaHoaDon,
                TenNhanVien = DBContext.Instance.TaiKhoans.Find(d.IDNhanVien).HoTen,
                TenKhachHang = DBContext.Instance.KhachHangs.Find(d.IDKhachHang).HoTenKH,
                ThoiGianThanhToan = d.ThoiGianThanhToan,
                GiamGia = d.GiamGia,
                PhuThu = d.PhuThu,
                ThanhTien = d.ThanhTien
            }
            ).ToList();
        }
        public List<HoaDonView> GetAllHoaDonView() => ChangeView(GetAllHoaDon());
        public List<HoaDon> GetHoaDonByTime(DateTime from, DateTime to)
            => GetAllHoaDon().Where(p => p.ThoiGianThanhToan.Date >= from.Date && p.ThoiGianThanhToan.Date <= to.Date).ToList();
        public List<HoaDon> Search(DateTime from, DateTime to, string MaHoaDon, string TenNhanVien, string TenKhachHang)
        {
            return GetHoaDonByTime(from, to).
                Where(p =>
                p.KhachHang.HoTenKH.ToLower().Contains(TenKhachHang.ToLower()) &&
                p.TaiKhoan.HoTen.ToLower().Contains(TenNhanVien.ToLower()) &&
                p.MaHoaDon.Contains(MaHoaDon)
                ).ToList();
        }
        
        public List<HoaDon> Sort(List<HoaDon> list, string orderBy, bool SortDirection)
        {
            switch (orderBy)
            {
                case "Theo mã hoá đơn":
                    //list.Sort((p1, p2) => p1.MaHoaDon.CompareTo(p2.MaHoaDon));
                    list = list.OrderBy(p => p.MaHoaDon).ToList();
                    break;
                case "Theo thời gian":
                    //list.Sort((p1, p2) => p1.ThoiGianThanhToan.CompareTo(p2.ThoiGianThanhToan));
                    list = list.OrderBy(p => p.ThoiGianThanhToan).ToList();
                    break;
                case "Theo giá trị":
                    //list.Sort((p1, p2) => p1.ThanhTien.CompareTo(p2.ThanhTien));
                    list = list.OrderBy(p => p.ThanhTien).ToList();
                    break;
            }
            if (SortDirection)
                list.Reverse();
            return list;
        }       
        //Pagination
        public List<HoaDonView> GetCurrentReCord(int page, int pageSize, List<HoaDon> list)
        {
            if ((list.Count / pageSize + 1) == page)
                return ChangeView(list.Skip((page - 1) * pageSize).ToList());
            return ChangeView(list.Skip((page - 1) * pageSize).Take(pageSize).ToList());
        }       
    }
}
