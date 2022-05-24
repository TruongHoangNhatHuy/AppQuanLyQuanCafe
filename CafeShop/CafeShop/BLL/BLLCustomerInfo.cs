using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLCustomerInfo
    {
        private static BLLCustomerInfo _Instance;
        public static BLLCustomerInfo Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLCustomerInfo();
                return _Instance;
            }
            private set { }
        }
        public List<KhachHang> GetCustomerList() => DBModel.Instance.KhachHangs.Where(p => p.IDKhachHang != "KH00000000").OrderBy(p => p.IDKhachHang).ToList();
        public void DeleteCustomer(string IDKhachHang)
        {
            DBModel.Instance.KhachHangs.Remove(DBModel.Instance.KhachHangs.Find(IDKhachHang));
            DBModel.Instance.SaveChanges();
        }
    }
}
