using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLAdminHome
    {
        private static BLLAdminHome _Instance;
        public static BLLAdminHome Instance
        { 
            get
            {
                if( _Instance == null )
                    _Instance = new BLLAdminHome();
                return _Instance;
            }
            private set {}
        }
        private BLLAdminHome() { }
        public List<FoodStatistics> GetFoodStatistics(DateTime time)
        {
            return DBModel.Instance.DonGoiMons.Where(p => p.ThoiGianGoiMon.Year == time.Year && p.ThoiGianGoiMon.Month == time.Month).
                GroupBy(p => p.Mon).Select(p => new FoodStatistics 
                { 
                    FoodName = p.Select(x => x.Mon.TenMon).FirstOrDefault(),
                    Count = p.Sum(count => count.SoLuong)
                }                    
                ).OrderByDescending(p => p.Count).Take(5).ToList();
        }
        public List<HoaDon> GetHoaDonInDay(DateTime time)
        {
            return DBModel.Instance.HoaDons.Where(p => p.ThoiGianThanhToan.Day == time.Day && p.ThoiGianThanhToan.Month == time.Month && p.ThoiGianThanhToan.Year == time.Year).ToList();
        }
        public string GetBillCount(DateTime time) => GetHoaDonInDay(time).Count().ToString();
        public string GetCustomerCount(DateTime time) => GetHoaDonInDay(time).Select(p => new { p.KhachHang }).Distinct().Count().ToString();
        public string GetRevenue(DateTime time) => GetHoaDonInDay(time).Sum(p => p.ThanhTien).ToString();
        #region AreaAndTable
        public List<KhuvucCBItem> GetKhuvucCBItem()
            => DBModel.Instance.KhuVucs.ToList().Skip(1).Select(p => new KhuvucCBItem() { ID = p.MaKhuVuc, Name = p.TenKhuVuc }).ToList();
        public KhuVuc GetKhuVucByMaKhuVuc(string ID) => DBModel.Instance.KhuVucs.Find(ID);

        public List<Ban> GetAllBan() => DBModel.Instance.Bans.ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBModel.Instance.KhuVucs.ToList().Skip(1).ToList();
        public Ban GetBanByMaBan(string MaBan) => DBModel.Instance.Bans.Find(MaBan);
        public List<HoaDon> GetCurrentBill() => DBModel.Instance.HoaDons.Where(p => p.MaBan != "B000000000").ToList();
        public HoaDon GetHoaDonByMaBan(string MaBan) => GetCurrentBill().Where(p => p.MaBan == MaBan).FirstOrDefault();
        #endregion
    }
}
