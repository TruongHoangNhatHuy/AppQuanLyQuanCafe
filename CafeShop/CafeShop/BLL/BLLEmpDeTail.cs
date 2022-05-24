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
        public List<VaiTro> GetVaiTro() => DBModel.Instance.VaiTroes.Where(p => p.MaVaiTro != "VT00000000").ToList();
        public VaiTro GetVaiTroByMaVaiTro(string MaVaiTro) => DBModel.Instance.VaiTroes.Find(MaVaiTro);
        public TaiKhoan GetInfo(string ID) => DBModel.Instance.TaiKhoans.Where(x => x.ID == ID).FirstOrDefault();
        public bool ExistedAccount(string ID)
        {
            if (DBModel.Instance.TaiKhoans.Find(ID) == null)
                return false;
            else
                return true;
        }
        public void ExecuteDB(TaiKhoan tk)
        {
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
                DBModel.Instance.SaveChanges();
            }
            else
            {
                tk.MatKhau = tk.NgaySinh.ToString("ddMMyyyy");
                tk.NgayBatDauLamViec = DateTime.Now;
                DBModel.Instance.TaiKhoans.Add(tk);
                DBModel.Instance.SaveChanges();
                MessageBox.Show("Mật khẩu là: " + tk.MatKhau + "\nVui lòng đổi mật khẩu mới khi đăng nhập.");
            }
        }
    }
}
