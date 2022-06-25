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
        public List<string> GetAllMaMon() => DBContext.Instance.Mons.Where(p => p.Visible).Select(p => p.MaMon).ToList();        
        public string GetTenMonByMaMon(string MaMon) => DBContext.Instance.Mons.Find(MaMon)?.TenMon;
        public List<HoaDon> GetHoaDonInDay(DateTime time)
            => DBContext.Instance.HoaDons.Where(p => p.ThoiGianThanhToan.Day == time.Day && p.ThoiGianThanhToan.Month == time.Month && p.ThoiGianThanhToan.Year == time.Year).ToList();
        public string GetBillCount(DateTime time) => GetHoaDonInDay(time).Count().ToString();
        public string GetCustomerCount(DateTime time)
        {
            var list = GetHoaDonInDay(time);
            int nonMember = list.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = list.Select(p => new { p.IDKhachHang }).Distinct().Count();
            if (nonMember > 0)
                member--;
            return member.ToString();
        }
        public string GetRevenue(DateTime time) => GetHoaDonInDay(time).Sum(p => p.ThanhTien).ToString();
        public List<FoodStatistics> GetFoodStatistics(DateTime time, int countFood = 0)
        {
            DateTime last30Day = time.AddDays(-30);
            var list = DBContext.Instance.DonGoiMons.Where(p => p.ThoiGianGoiMon >= last30Day).
                GroupBy(p => p.Mon).Select(p => new FoodStatistics
                {
                    FoodID = p.Select(x => x.Mon.MaMon).FirstOrDefault(),
                    Count = p.Sum(count => count.SoLuong)
                }
                ).OrderByDescending(p => p.Count).ToList();
            if (countFood > 0)
                return list.Take(countFood).ToList();
            else
                return list;
        }
        public List<FoodStatistics> GetAllFoodStatistics(DateTime time)
        {
            var list = GetFoodStatistics(time);
            foreach (string MaMon in GetAllMaMon())
                if (!list.Exists(p => p.FoodID == MaMon))
                    list.Add(new FoodStatistics() { FoodID = MaMon, Count = 0 });
            return list;
        }
        #region AreaAndTable
        public List<KhuvucCBItem> GetKhuvucCBItem()
            => DBContext.Instance.KhuVucs.ToList().Skip(1).Select(p => new KhuvucCBItem() { ID = p.MaKhuVuc, Name = p.TenKhuVuc }).ToList();
        public KhuVuc GetKhuVucByMaKhuVuc(string ID) => DBContext.Instance.KhuVucs.Find(ID);

        public List<Ban> GetAllBan() => DBContext.Instance.Bans.ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBContext.Instance.KhuVucs.ToList().Skip(1).ToList();
        public Ban GetBanByMaBan(string MaBan) => DBContext.Instance.Bans.Find(MaBan);
        public List<HoaDon> GetCurrentBill() => DBContext.Instance.HoaDons.Where(p => p.MaBan != "B000000000").ToList();
        public HoaDon GetHoaDonByMaBan(string MaBan) => GetCurrentBill().Where(p => p.MaBan == MaBan).FirstOrDefault();
        #endregion
    }
}
