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
        private BLLDetailOrder() { }
        public Mon GetMonByMaMon(string MaMon) => DBContext.Instance.Mons.Find(MaMon);

        public string ShowDetail(String MaMon)
        {
            Mon mon = GetMonByMaMon(MaMon);
            return mon.TenMon.ToString() + ", " + mon.DonGia.ToString() + "/" + mon.DonVi.ToString();
        }
        public int CalculatePrice(String MaMon, int SoLuong)
        {
            Mon mon = GetMonByMaMon(MaMon);
            return mon.DonGia * SoLuong;
        }
        public void CheckGoods(string MaMon, int SoLuong) 
        {
            Mon mon = GetMonByMaMon(MaMon);
            HangHoa goods = mon.HangHoa.FirstOrDefault();
            if (goods != null)
            {
                if (goods.SoLuong < SoLuong)
                    throw new Exception("Hiện tại kho chỉ có " + goods.SoLuong + " " + goods.DonVi.ToLower());
                else
                {
                    goods.SoLuong -= SoLuong;
                    DBContext.Instance.SaveChanges();
                }
            }
        }
        public void ConfirmDetailOrder(string MaHoaDon, string MaMon, int SoLuong, string GhiChu)
        {
            CheckGoods(MaMon, SoLuong);
            Mon mon = GetMonByMaMon(MaMon);
            DonGoiMon result = new DonGoiMon
            {
                MaDonGoiMon = PrimaryKeyGenerator.OrderBillPrimaryKey(),
                MaHoaDon = MaHoaDon,
                MaMon = mon.MaMon,
                SoLuong = SoLuong,
                GhiChu = GhiChu,
                GiaTien = CalculatePrice(MaMon, SoLuong),
                ThoiGianGoiMon = DateTime.Now,
                TinhTrang = OrderState.Waiting
            };
            DBContext.Instance.DonGoiMons.Add(result);
            DBContext.Instance.SaveChanges();
        }
    }
}