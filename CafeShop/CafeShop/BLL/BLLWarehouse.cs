using CafeShop.DTO;
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
        public List<HangHoa> GetAllHangHoa() => DBModel.Instance.HangHoas.ToList();
        public HangHoa GetHangHoaByMa(string MaHangHoa) => DBModel.Instance.HangHoas.Find(MaHangHoa);
        public void DeleteGoods(HangHoa hangHoa)
        {
            //ở view xử lý số lượng : 
            // = 0: xoá luôn
            // > 0: xác nhận rồi mới xoá
            DBModel.Instance.HangHoas.Remove(hangHoa);
            DBModel.Instance.SaveChanges();
        }
        public void ImportExportGoods(string MaHangHoa, LoHang loHang = null)
        {
            if(loHang != null)
            {
                DBModel.Instance.LoHangs.Add(loHang);
                HangHoa hangHoa = GetHangHoaByMa(MaHangHoa);
                hangHoa.SoLuong += loHang.SoLuongNhap;
            }   
            DBModel.Instance.SaveChanges();
        }
        public void ExportGoods(string MaHangHoa, int SoLuongXuat)
        {
            HangHoa hangHoa = GetHangHoaByMa(MaHangHoa);
            hangHoa.SoLuong -= SoLuongXuat;
            DBModel.Instance.SaveChanges();
        }
        public void AddGoods(HangHoa goods)
        {
            DBModel.Instance.HangHoas.Add(goods);
            DBModel.Instance.SaveChanges();
        }
    }
}
