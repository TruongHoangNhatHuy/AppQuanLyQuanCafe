using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CafeShop.BLL
{
    public class BLLWarehouse
    {
        private static BLLWarehouse _Instance;
        public static BLLWarehouse Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLWarehouse();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLWarehouse() { }
        #region Warehouse
        public List<HangHoa> GetAllHangHoa() => DBContext.Instance.HangHoas.OrderBy(p => p.MaHangHoa).Skip(1).ToList();
        public HangHoa GetHangHoaByMa(string MaHangHoa) => DBContext.Instance.HangHoas.Find(MaHangHoa);

        public void DeleteGoods(HangHoa hangHoa)
        {
            DBContext.Instance.HangHoas.Remove(hangHoa);
            DBContext.Instance.SaveChanges();
        }
        public void ImportGoods(string MaHangHoa, LoHang loHang = null)
        {
            if (loHang != null)
            {
                DBContext.Instance.LoHangs.Add(loHang);
                HangHoa hangHoa = GetHangHoaByMa(MaHangHoa);
                hangHoa.SoLuong += loHang.SoLuongNhap;
            }
            DBContext.Instance.SaveChanges();
        }
        public void ExportGoods(string MaHangHoa, int SoLuong)
        {
            HangHoa hangHoa = GetHangHoaByMa(MaHangHoa);
            if (hangHoa.SoLuong > SoLuong)
                hangHoa.SoLuong = SoLuong;
            else
                throw new Exception("Số lượng còn lại phải nhỏ hơn số lượng hiện tại.");
            DBContext.Instance.SaveChanges();
        }
        #endregion

        #region Goods
        public string NewGoodsID()
        {
            string currentKey = PrimaryKeyGenerator.GetCurrentKey(DBContext.Instance.HangHoas.Select(p => p.MaHangHoa).ToList());
            return PrimaryKeyGenerator.NextPrimaryKey(currentKey);
        }
        public void ExecuteDB(HangHoa goods)
        {
            HangHoa existed = GetHangHoaByMa(goods.MaHangHoa);
            if (existed == null)
            {
                DBContext.Instance.HangHoas.Add(goods);
            }
            else
            {
                existed.TenHangHoa = goods.TenHangHoa;
                existed.DonVi = goods.DonVi;
                existed.MaMon = goods.MaMon;
            }
            DBContext.Instance.SaveChanges();
        }

        public List<DanhMucThucDon> GetDanhMucThucDon()
        {
            List<DanhMucThucDon> list = new List<DanhMucThucDon>();
            list.Add(DBContext.Instance.DanhMucThucDons.First());
            list.AddRange(DBContext.Instance.DanhMucThucDons.Where(p => p.Visible == true));
            return list;
        }
        #endregion
    }
}
