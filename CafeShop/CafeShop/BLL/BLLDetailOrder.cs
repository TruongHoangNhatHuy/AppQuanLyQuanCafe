using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLDetailOrder
    {
        private static BLLDetailOrder _Instance;
        public static BLLDetailOrder Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLDetailOrder();
                }
                return _Instance;
            }
            private set { }
        }
        private DBModel db = new DBModel();
        private Mon mon = null;

        public void SetDish(string MaMon)
        {
            mon = db.Mons.Find(MaMon);
        }
        public string ShowDetail()
        {
            return mon.TenMon.ToString() + ", " + mon.DonGia.ToString() + "/" + mon.DonVi.ToString();
        }
        public int CalculatePrice(int SoLuong)
        {
            return mon.DonGia * SoLuong;
        }
        public void ConfirmDetailOrder(int SoLuong, string GhiChu)
        {
            DonGoiMon result = new DonGoiMon
            {
                MaDonGoiMon = "2002051318036283",
                MaHoaDon = "2022051119401331",
                MaMon = mon.MaMon,
                SoLuong = SoLuong,
                GhiChu = GhiChu,
                GiaTien = CalculatePrice(SoLuong),
                ThoiGianGoiMon = DateTime.Now,
                TinhTrang = "Đang chờ"
            };
            db.DonGoiMons.Add(result);
            //db.SaveChanges();
        }
    }
}