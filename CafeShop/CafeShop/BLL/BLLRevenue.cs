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
        public List<HoaDon> GetHoaDon() => DBContext.Instance.HoaDons.ToList();
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
            var tempdata = GetHoaDon().Where(p => p.ThoiGianThanhToan.Date >= from.Date && p.ThoiGianThanhToan.Date <= to.Date).OrderBy(p => p.ThoiGianThanhToan);
            for (int i = 0; i < count; i++)
            {
                DateTime time = from.AddMonths(i);
                data.Add(tempdata.Where(p => p.ThoiGianThanhToan.Year == time.Year && p.ThoiGianThanhToan.Month == time.Month).Sum(p => (long)p.ThanhTien));
            }
            return data;
        }
        public List<long> GetRevenueByDate(DateTime time)
        {
            List<long> data = new List<long>();
            var bill = GetHoaDon().OrderBy(p => p.ThoiGianThanhToan);
            DateTime temp = new DateTime(time.Year, time.Month, 1);
            for (int i = 0; i < DateTime.DaysInMonth(time.Year, time.Month); i++)
            {
                data.Add(bill.Where(p => p.ThoiGianThanhToan.Date == temp.AddDays(i).Date).Sum(p => p.ThanhTien));
            }
            return data;
        }
        public long GetRevenue(List<long> list) => list.Sum();
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
            var tempdata = GetHoaDon().Where(p => p.ThoiGianThanhToan.Date >= from.Date && p.ThoiGianThanhToan.Date <= to.Date).OrderBy(p => p.ThoiGianThanhToan);
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
        public int GetBillCount(List<int> list) => list.Sum();
        #endregion

        #region Customer
        public delegate bool CheckTime(DateTime p, DateTime from, DateTime to);
        public bool CheckYear(DateTime p, DateTime from, DateTime to)
        {
            return p.Year >= from.Year && p.Year <= to.Year;
        }
        public bool CheckDate(DateTime p, DateTime from, DateTime to)
        {
            return p.Year == from.Year && p.Month == from.Month;
        }
        public bool CheckMonth(DateTime p, DateTime from, DateTime to)
        {
            return p.Date >= from.Date && p.Date <= to.Date;
        }
        public int GetCustomerCount(DateTime from, DateTime to, StatisticsType type)
        {
            CheckTime checktime = new CheckTime(CheckYear);
            if (type == StatisticsType.ByYear)
                checktime = new CheckTime(CheckYear);
            else if (type == StatisticsType.ByDate)
                checktime = new CheckTime(CheckDate);
            else if (type == StatisticsType.ByMonth)
                checktime = new CheckTime(CheckMonth);
            var temp = GetHoaDon().Where(p => checktime(p.ThoiGianThanhToan, from, to));
            int nonMember = temp.Where(p => p.IDKhachHang == "KH00000000").Count();
            int member = temp.Select(p => new { p.IDKhachHang }).Distinct().Count();
            if (nonMember > 0)
                member--;
            return member;
        }      
        public List<long> GetCustomerRevenue(DateTime from, DateTime to, StatisticsType type)
        {
            List<long> data = new List<long>(2);
            CheckTime checktime = new CheckTime(CheckYear);
            if (type == StatisticsType.ByYear)
                checktime += new CheckTime(CheckYear);
            else if (type == StatisticsType.ByDate)
                checktime += new CheckTime(CheckDate);
            else if(type == StatisticsType.ByMonth)
                checktime += new CheckTime(CheckMonth);  
            var temp = GetHoaDon().Where(p => checktime.Invoke(p.ThoiGianThanhToan, from, to));
            long totalRevenue = temp.Sum(p => p.ThanhTien);
            long nonMember = temp.Where(p => p.IDKhachHang == "KH00000000").Sum(p => p.ThanhTien);
            long member = totalRevenue - nonMember;
            data.Add(nonMember);
            data.Add(member);
            return data;
        }

        public enum StatisticsType
        {
            ByYear,
            ByDate,
            ByMonth
        }
        #endregion

    }
}
