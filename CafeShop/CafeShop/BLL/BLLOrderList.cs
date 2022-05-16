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
        public List<DonGoiMonView> GetOrderListSortByTime()
        {
            List<DonGoiMonView> result = new List<DonGoiMonView>();
            foreach (DonGoiMon i in DBModel.Instance.DonGoiMons)
                if (i.TinhTrang != "Hoàn thành")
                {
                    result.Add(new DonGoiMonView(i));
                }
            return result.OrderBy(p => p.ThoiGianTuKhiGoi).ToList();
        }
        public void StateChange(string MaDonGoiMon)
        {
            DonGoiMon dgm = DBModel.Instance.DonGoiMons.Find(MaDonGoiMon);
            string state = dgm.TinhTrang.ToString();
            if (state == "Đang chờ")
                state = "Đang thực hiện";
            else if (state == "Đang thực hiện")
                state = "Hoàn thành";
            dgm.TinhTrang = state;
        }
    }
}