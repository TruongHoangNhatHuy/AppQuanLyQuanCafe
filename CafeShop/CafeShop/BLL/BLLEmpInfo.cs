using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DTO;

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
        public List<TaiKhoanView> GetAccountList()
        {
            List<TaiKhoanView> result = new List<TaiKhoanView>();
            foreach(TaiKhoan i in DBModel.Instance.TaiKhoans.Where(p => p.ID != "TK00000000"))
            {
                result.Add(new TaiKhoanView(i));
            }
            return result.OrderBy(p => p.ID).ToList();
        }
        public void ResetPassword(string ID)
        {
            var i = DBModel.Instance.TaiKhoans.Find(ID);
            i.MatKhau = i.NgaySinh.ToString("ddMMyyyy");
            DBModel.Instance.SaveChanges();
            MessageBox.Show("Đã reset mật khẩu thành: " + i.MatKhau + "\nVui lòng đổi mật khẩu mới khi đăng nhập.");
        }
        public void DeleteAccount(string ID)
        {
            DBModel.Instance.TaiKhoans.Remove(DBModel.Instance.TaiKhoans.Find(ID));
            DBModel.Instance.SaveChanges();
        }
    }
}
