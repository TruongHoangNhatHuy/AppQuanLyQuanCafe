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
        public List<KhachHangView> GetCustomerList()
        {
            List<KhachHangView> list = new List<KhachHangView>();
            foreach (KhachHang kh in DBContext.Instance.KhachHangs.Where(p => p.IDKhachHang != "KH00000000"))
                list.Add(new KhachHangView(kh));
            list.OrderBy(p => p.IDKhachHang).ToList();
            return list;
        }
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
        public List<KhachHangView> SearchCustomerList(string searchString, string searchBy)
        {
            List<KhachHangView> result = GetCustomerList();
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
        public List<KhachHangView> Sort(string orderBy, bool SortDirection)
        {
            var list = GetCustomerList();
            switch (orderBy)
            {
                case "Theo ID khách hàng":
                    list = list.OrderBy(p => p.IDKhachHang).ToList();
                    break;
                case "Theo họ tên":
                    list = list.OrderBy(p => p.HoTenKH).ToList();
                    break;
                case "Theo số điện thoại":
                    list = list.OrderBy(p => p.SoDienThoaiKH).ToList();
                    break;
                case "Theo ngày sinh":
                    list = list.OrderBy(p => p.NgaySinhKH).ToList();
                    break;
                case "Theo địa chỉ":
                    list = list.OrderBy(p => p.DiaChiKH).ToList();
                    break;
                case "Theo ngày đăng kí":
                    list = list.OrderBy(p => p.NgayDangKi).ToList();
                    break;
            }
            if (SortDirection)
                list.Reverse();
            return list;
        }
        //Pagination
        public List<KhachHangView> GetCurrentRecord(int page, int pageSize, List<KhachHangView> list)
        {
            if ((list.Count / pageSize + 1) == page)
                return list.Skip((page - 1) * pageSize).ToList();
            return list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
