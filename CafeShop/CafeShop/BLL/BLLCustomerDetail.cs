using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLCustomerDetail
    {
        private static BLLCustomerDetail _Instance;
        public static BLLCustomerDetail Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLCustomerDetail();
                return _Instance;
            }
            private set { }
        }
        public KhachHang GetKH(string ID) => DBModel.Instance.KhachHangs.Where(x => x.IDKhachHang == ID).FirstOrDefault();
        public KhachHang GetKHBySDT(string sdt) => DBModel.Instance.KhachHangs.Where(x => x.SoDienThoaiKH == sdt).FirstOrDefault();
        
        public bool ExistedCustomer(string IDKhachHang)
        {
            if (DBModel.Instance.KhachHangs.Find(IDKhachHang) == null)
                return false;
            else
                return true;
        }
        
        public void ExecuteDB(KhachHang kh)
        {
            if (ExistedCustomer(kh.IDKhachHang))
            {
                KhachHang existed = GetKH(kh.IDKhachHang);
                existed.HoTenKH = kh.HoTenKH;
                existed.NgaySinhKH = kh.NgaySinhKH;
                existed.DiaChiKH = kh.DiaChiKH;
                existed.SoDienThoaiKH = kh.SoDienThoaiKH;
                existed.GioiTinhKH = kh.GioiTinhKH;
                DBModel.Instance.SaveChanges();
            }
            else
            {
                if (GetKHBySDT(kh.SoDienThoaiKH) != null)
                    throw new Exception("Số điện thoại này đã được đăng kí.");
                DBModel.Instance.KhachHangs.Add(kh);
                DBModel.Instance.SaveChanges();
            }
        }
    }
}
