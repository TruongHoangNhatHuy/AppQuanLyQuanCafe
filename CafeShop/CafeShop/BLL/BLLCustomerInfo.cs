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
        private BLLCustomerInfo() { }
        public List<KhachHang> GetCustomerList() => DBContext.Instance.KhachHangs.Where(p => p.IDKhachHang != "KH00000000").OrderBy(p => p.IDKhachHang).ToList();
        public KhachHang GetCustomerByID(string ID) => DBContext.Instance.KhachHangs.Find(ID);
        public void DeleteCustomer(string IDKhachHang)
        {
            var customer = DBContext.Instance.KhachHangs.Find(IDKhachHang);
            if (customer != null)
            {
                customer.HoaDons.ToList().ForEach(p => p.IDKhachHang = "KH00000000");
                DBContext.Instance.KhachHangs.Remove(DBContext.Instance.KhachHangs.Find(IDKhachHang));
                DBContext.Instance.SaveChanges();
            }            
        }
        public List<KhachHang> SearchCustomerList(string searchString, string searchBy)
        {
            List<KhachHang> result = GetCustomerList();
            if (searchString != null)
            {
                switch (searchBy)
                {
                    case "Theo ID khách hàng":
                        {
                            result = result.Where(p => p.IDKhachHang.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo họ tên":
                        {
                            result = result.Where(p => p.HoTenKH.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo số điện thoại":
                        {
                            result = result.Where(p => p.SoDienThoaiKH.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo ngày sinh":
                        {
                            result = result.Where(p => p.NgaySinhKH.ToString().Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo địa chỉ":
                        {
                            result = result.Where(p => p.DiaChiKH.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo ngày đăng kí":
                        {
                            result = result.Where(p => p.NgayDangKi.ToString().Contains(searchString)).ToList();
                            break;
                        }
                }
            }
            return result.OrderBy(p => p.IDKhachHang).ToList();
        }
        public List<KhachHang> SortCustomerList(List<KhachHang> list)
        {
            list.Reverse();
            return list;
        }
    }
}
