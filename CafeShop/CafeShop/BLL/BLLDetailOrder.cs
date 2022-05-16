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
        private static BLLDetailOrder _instance;
        public static BLLDetailOrder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLDetailOrder();
                }
                return _instance;
            }
            private set { }
        }
        private Mon mon = null;

        public void SetDish(string MaMon)
        {
            mon = DBModel.Instance.Mons.Find(MaMon);
        }
        public string ShowDetail()
        {
            return mon.TenMon.ToString() + ", " + mon.DonGia.ToString() + "/" + mon.DonVi.ToString();
        }
        public int CalculatePrice(int SoLuong)
        {
            return mon.DonGia * SoLuong;
        }
<<<<<<< Updated upstream
        public DonGoiMon ConfirmDetailOrder(int SoLuong, string GhiChu)
        {
            // Lưu dữ liệu vào tầng trung gian
            return new DonGoiMon 
                { 
                    MaDonGoiMon = "",
                    MaHoaDon = "",
                    MaMon = mon.MaMon,
                    SoLuong = SoLuong,
                    GhiChu = GhiChu,
                    GiaTien = CalculatePrice(SoLuong),
                    ThoiGianGoiMon = DateTime.Now,
                    TinhTrang = "Đang chờ"
                };
=======
        // phương thức kiểm tra kho còn đủ nguyên liệu không
        public void CheckGoods() { }
        public void ConfirmDetailOrder(int SoLuong, string GhiChu)
        {
            DonGoiMon result = new DonGoiMon
            {
                MaDonGoiMon = PrimaryKeyGenerator.OrderBillPrimaryKey(),
                MaHoaDon = "2022051119401331",
                MaMon = mon.MaMon,
                SoLuong = SoLuong,
                GhiChu = GhiChu,
                GiaTien = CalculatePrice(SoLuong),
                ThoiGianGoiMon = DateTime.Now,
                TinhTrang = "Đang chờ"
            };
            DBModel.Instance.DonGoiMons.Add(result);
            //db.SaveChanges();
>>>>>>> Stashed changes
        }
    }
}