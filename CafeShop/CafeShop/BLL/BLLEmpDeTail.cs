using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLEmpDetail
    {
        private static BLLEmpDetail _Instance;
        public static BLLEmpDetail Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLEmpDetail();
                return _Instance;
            }
            private set { }
        }
        private BLLEmpDetail() { }
        public List<VaiTro> GetVaiTro() => DBContext.Instance.VaiTroes.Where(p => p.MaVaiTro != "VT00000000").ToList();
        public VaiTro GetVaiTroByMaVaiTro(string MaVaiTro) => DBContext.Instance.VaiTroes.Find(MaVaiTro);
        public TaiKhoan GetInfo(string ID) => DBContext.Instance.TaiKhoans.Where(x => x.ID == ID).FirstOrDefault();
        public bool ExistedAccount(string ID)
        {
            if (DBContext.Instance.TaiKhoans.Find(ID) == null)
                return false;
            else
                return true;
        }
        public TaiKhoan GetAccountByUserName(string username) => DBContext.Instance.TaiKhoans.Where(p => p.TenTaiKhoan == username).FirstOrDefault();
        public bool ExistedUsername(string username, string ID)
        {
            var tk = GetAccountByUserName(username);
            if (tk == null)
                return false;
            else
            {
                if (tk.ID == ID)
                    return false;
                return true;
            }    
        }
        public bool ExecuteDB(TaiKhoan tk)
        {
            if (ExistedUsername(tk.TenTaiKhoan, tk.ID))
                throw new Exception("Tên đăng nhập này đã tồn tại, vui lòng nhập tên khác");
            if (ExistedAccount(tk.ID))
            {
                
                TaiKhoan existed = GetInfo(tk.ID);
                existed.TenTaiKhoan = tk.TenTaiKhoan;
                existed.HoTen = tk.HoTen;
                existed.NgaySinh = tk.NgaySinh;
                existed.DiaChi = tk.DiaChi;
                existed.SoDienThoai = tk.SoDienThoai;
                existed.GioiTinh = tk.GioiTinh;
                existed.MaVaiTro = tk.MaVaiTro;
                DBContext.Instance.SaveChanges();
                return false;
            }
            else
            {                
                tk.MatKhau = tk.NgaySinh.ToString("ddMMyyyy");
                tk.NgayBatDauLamViec = DateTime.Now;
                DBContext.Instance.TaiKhoans.Add(tk);
                DBContext.Instance.SaveChanges();
                return true;
                //MessageBox.Show("Mật khẩu là: " + tk.MatKhau + "\nVui lòng đổi mật khẩu mới khi đăng nhập.");
            }
        }
    }
}
