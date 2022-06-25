using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeShop.BLL
{
    public class BLLEmpInfo
    {
        private static BLLEmpInfo _Instance;
        public static BLLEmpInfo Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLEmpInfo();
                return _Instance;
            }
            private set { }
        }

        private BLLEmpInfo() { }
        public List<TaiKhoanView> GetAccountList()
        {
            List<TaiKhoanView> result = new List<TaiKhoanView>();
            foreach (TaiKhoan i in DBContext.Instance.TaiKhoans.Where(p => p.ID != "TK00000000"))
                result.Add(new TaiKhoanView(i));
            return result.OrderBy(p => p.ID).ToList();
        }
        public TaiKhoanView GetAccountByID(string ID) => GetAccountList().Where(p => p.ID == ID).FirstOrDefault();
        public void ResetPassword(string ID)
        {
            var i = DBContext.Instance.TaiKhoans.Find(ID);
            i.MatKhau = i.NgaySinh.ToString("ddMMyyyy");
            DBContext.Instance.SaveChanges();
            throw new Exception("Đã reset mật khẩu thành: " + i.MatKhau + "\nVui lòng đổi mật khẩu mới khi đăng nhập.");
        }
        public void DeleteAccount(string ID)
        {
            TaiKhoan tk = DBContext.Instance.TaiKhoans.Find(ID);
            if (tk != null)
            {
                tk.HoaDons.ToList().ForEach(p => p.IDNhanVien = "TK00000000");
                tk.LoHangs.ToList().ForEach(p => p.IDNhanVien = "TK00000000");
                DBContext.Instance.TaiKhoans.Remove(DBContext.Instance.TaiKhoans.Find(ID));
                DBContext.Instance.SaveChanges();
            }
        }
        public List<TaiKhoanView> SearchAccountList(string searchString, string searchBy)
        {
            List<TaiKhoanView> result = GetAccountList();
            if (searchString != null)
            {
                switch (searchBy)
                {
                    case "Theo ID":
                        {
                            result = result.Where(p => p.ID.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo tên đăng nhập":
                        {
                            result = result.Where(p => p.TenTaiKhoan.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo họ tên":
                        {
                            result = result.Where(p => p.HoTen.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo ngày sinh":
                        {
                            result = result.Where(p => p.NgaySinh.ToString().Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo địa chỉ":
                        {
                            result = result.Where(p => p.DiaChi.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo số điện thoại":
                        {
                            result = result.Where(p => p.SoDienThoai.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo ngày bắt đầu":
                        {
                            result = result.Where(p => p.NgayBatDauLamViec.Contains(searchString)).ToList();
                            break;
                        }
                    case "Theo vai trò":
                        {
                            result = result.Where(p => p.TenVaiTro.Contains(searchString)).ToList();
                            break;
                        }
                }
            }
            return result.OrderBy(p => p.ID).ToList();
        }
        public List<TaiKhoanView> SortAccountList(List<TaiKhoanView> list)
        {
            list.Reverse();
            return list;
        }
    }
}
