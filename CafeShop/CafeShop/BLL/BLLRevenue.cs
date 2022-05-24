using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLRevenue
    {
        private static BLLRevenue _Instance;
        public static BLLRevenue Instance
        {
            get
            {
                if( _Instance == null )
                    _Instance = new BLLRevenue();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BLLRevenue()
        {

        }
        public List<HoaDon> GetHoaDon() => DBModel.Instance.HoaDons.ToList();
        #region Revenue
        public List<long> GetRevenueByYear(int from, int to)
        {
            int count = (to - from) + 1;
            List<long> data = new List<long>(count);
            for (int i = 0; i < count; i++)
            {
                long total = GetHoaDon().Where(p => p.ThoiGianThanhToan.Year == from + i).Sum(p => (long)p.ThanhTien);
                data.Add(total);
            }
            return data;
        }
        public List<long> GetRevenueByMonth(DateTime from, DateTime to)
        {
            List<long> data = new List<long>();
            int count = (to.Year - from.Year) * 12 + to.Month - from.Month + 1;
            var tempdata = GetHoaDon().Where(p => p.ThoiGianThanhToan >= from && p.ThoiGianThanhToan <= to).OrderBy(p => p.ThoiGianThanhToan);
            for (int i = 0; i < count; i++)
            {
                DateTime time = from.AddMonths(i);
                data.Add(tempdata.Where(p => p.ThoiGianThanhToan.Year == time.Year && p.ThoiGianThanhToan.Month == time.Month).Sum(p => (long)p.ThanhTien));
            }
            return data;
        }
        public List<int> GetRevenueByDate(DateTime time)
        {
            List<int> data = new List<int>();
            var bill = GetHoaDon().OrderBy(p => p.ThoiGianThanhToan);
            DateTime temp = new DateTime(time.Year, time.Month, 1);
            for (int i = 0; i < DateTime.DaysInMonth(time.Year, time.Month); i++)
            {
                data.Add(bill.Where(p => p.ThoiGianThanhToan.Date == temp.AddDays(i).Date).Sum(p => p.ThanhTien));
            }
            return data;
        }
        #endregion
        #region Bill
        public List<int> GetBillCountByYear(int from, int to)
        {
            int count = (to - from) + 1;
            List<int> data = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                int total = GetHoaDon().Where(p => p.ThoiGianThanhToan.Year == from + i).Count();
                data.Add(total);
            }
            return data;
        }
        public List<int> GetBillCountByMonth(DateTime from, DateTime to)
        {
            List<int> data = new List<int>();
            int count = (to.Year - from.Year) * 12 + to.Month - from.Month + 1;
            var tempdata = GetHoaDon().Where(p => p.ThoiGianThanhToan >= from && p.ThoiGianThanhToan <= to).OrderBy(p => p.ThoiGianThanhToan);
            for (int i = 0; i < count; i++)
            {
                DateTime time = from.AddMonths(i);
                data.Add(tempdata.Where(p => p.ThoiGianThanhToan.Year == time.Year && p.ThoiGianThanhToan.Month == time.Month).Count());
            }
            return data;
        }

        public List<int> GetBillCountDate(DateTime time)
        {
            List<int> data = new List<int>();
            int daysInMonth = DateTime.DaysInMonth(time.Year, time.Month);
            var bill = GetHoaDon().OrderBy(p => p.ThoiGianThanhToan);
            DateTime temp = new DateTime(time.Year, time.Month, 1);
            for (int i = 0; i < DateTime.DaysInMonth(time.Year, time.Month); i++)
            {
                data.Add(bill.Where(p => p.ThoiGianThanhToan.Date == temp.AddDays(i).Date).Count());
            }
            return data;
        }
        #endregion
        #region Customer
        public List<int> GetCustumerCountByYear(int from, int to)
        {
            List<int> data = new List<int>(2);
            var temp = GetHoaDon().Where(p => p.ThoiGianThanhToan.Year >= from && p.ThoiGianThanhToan.Year <= to);
            int nonMember = temp.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = temp.Select(p => new { p.IDKhachHang }).Distinct().Count();
            if (nonMember > 0)
                member--;
            data.Add(nonMember);
            data.Add(member);
            return data;
        }


        public List<int> GetCustumerCountByDate(DateTime from, DateTime to)
        {
            List<int> data = new List<int>(2);
            var temp = GetHoaDon().Where(p => p.ThoiGianThanhToan >= from && p.ThoiGianThanhToan <= to);
            int nonMember = temp.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = temp.Select(p => new { p.IDKhachHang }).Distinct().Count();
            if (nonMember > 0)
                member--;
            data.Add(nonMember);
            data.Add(member);
            return data;
        }
        public List<int> GetCustumerCountByMonth(DateTime from)
        {
            List<int> data = new List<int>(2);
            var temp = GetHoaDon().Where(p => p.ThoiGianThanhToan.Year == from.Year && p.ThoiGianThanhToan.Month == from.Month);
            int nonMember = temp.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = temp.Select(p => new { p.IDKhachHang }).Distinct().Count();
            if (nonMember > 0)
                member--;
            data.Add(nonMember);
            data.Add(member);
            return data;
        }
        #endregion

    }
}
