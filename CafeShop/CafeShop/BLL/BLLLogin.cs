using CafeShop.DTO;
using System;
using System.Linq;

namespace CafeShop.BLL
{
    public class BLLLogin
    {
        private static BLLLogin _Instance;
        public static BLLLogin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLLogin();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLLogin() { }
        public string currentID { get;private set; }
        public bool ValidateAccount(string account, string password)
        {
            bool isEmployee = false;
            TaiKhoan tk = DBContext.Instance.TaiKhoans.Where(p => p.TenTaiKhoan == account).FirstOrDefault();
            if (tk != null && tk != DBContext.Instance.TaiKhoans.Where(p => p.ID == "TK00000000").FirstOrDefault())
            {
                if (tk.MatKhau == password)
                {
                    currentID = tk.ID;
                    // Mã vai trò khác chủ cửa hàng thì là nhân viên
                    if (tk.MaVaiTro != DBContext.Instance.VaiTroes.Where(p => p.TenVaiTro == "Chủ cửa hàng").FirstOrDefault().MaVaiTro)
                        isEmployee = true;
                }
                else
                    throw new Exception("Mật khẩu sai");
            }
            else
                throw new Exception("Tài khoản không tồn tại");
            return isEmployee;
        }
        public string GetCurrentIDName()
        {
            return DBContext.Instance.TaiKhoans.Where(p => p.ID == BLLLogin.Instance.currentID).FirstOrDefault().HoTen;
        }
        public void ResetCurrentID()
        {
            currentID = "";
        }
    }
}
