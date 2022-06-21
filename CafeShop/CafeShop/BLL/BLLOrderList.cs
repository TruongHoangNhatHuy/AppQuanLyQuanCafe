using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLOrderList
    {
        private static BLLOrderList _Instance;
        public static BLLOrderList Instance
        {
            private set { }
            get
            {
                if (_Instance == null)
                    _Instance = new BLLOrderList();
                return _Instance;
            }
        }
        private BLLOrderList() { }
        public List<DonGoiMonView> GetOrderListSortByTime(string searchText = "")
        {
            List<DonGoiMonView> result = new List<DonGoiMonView>();
            foreach (DonGoiMon i in DBContext.Instance.DonGoiMons)
                if (i.TinhTrang != OrderState.Completed && (i.Mon.TenMon.ToLower().Contains(searchText) || i.HoaDon.Ban.TenBan.ToLower().Contains(searchText)))
                    result.Add(new DonGoiMonView(i));
            return result.OrderByDescending(p => p.ThoiGianTuKhiGoi).ToList();
        }
        public void StateChange(string MaDonGoiMon)
        {
            DonGoiMon dgm = DBContext.Instance.DonGoiMons.Find(MaDonGoiMon);
            var state = dgm.TinhTrang;
            if (state == OrderState.Waiting)
                state = OrderState.Processing;
            else if (state == OrderState.Processing)
                state = OrderState.Completed;
            dgm.TinhTrang = state;
            DBContext.Instance.SaveChanges();
        }
        public bool CancelOrder(string MaDonGoiMon)
        {
            DonGoiMon dgm = DBContext.Instance.DonGoiMons.Find(MaDonGoiMon);
            if (dgm != null && dgm.TinhTrang == OrderState.Waiting)
            {
                DBContext.Instance.DonGoiMons.Remove(dgm);
                DBContext.Instance.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}