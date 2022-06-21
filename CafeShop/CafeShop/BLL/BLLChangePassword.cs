using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLChangePassword
    {
        private static BLLChangePassword _Instance;
        public static BLLChangePassword Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLChangePassword();
                return _Instance;
            }
            private set {}
        }
        private BLLChangePassword() { }
        public bool CheckPassword(string ID, string password)
        {
            var account = DBContext.Instance.TaiKhoans.Find(ID);
            if (account.MatKhau.Equals(password))
                return true;
            return false;
        }
        public bool ChangePassword(string ID, string password)
        {
            try
            {
                var account = DBContext.Instance.TaiKhoans.Find(ID);
                account.MatKhau = password;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
