using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class TaiKhoanView
    {
        public TaiKhoanView(TaiKhoan tk)
        {
            ID = tk.ID;
            TenTaiKhoan = tk.TenTaiKhoan;
            HoTen = tk.HoTen;
            GioiTinh = (tk.GioiTinh) ? "Nam" : "Nữ";
            NgaySinh = tk.NgaySinh.ToString("dd/MM/yyyy");
            DiaChi = tk.DiaChi;
            SoDienThoai = tk.SoDienThoai;
            NgayBatDauLamViec = tk.NgayBatDauLamViec.ToString("dd/MM/yyyy");
            TenVaiTro = DBContext.Instance.VaiTroes.Where(x => x.MaVaiTro == tk.MaVaiTro).FirstOrDefault().TenVaiTro;
        }
        public string ID { get; set; }
        public string TenTaiKhoan { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string NgayBatDauLamViec { get; set; }
        public string TenVaiTro { get; set; }
    }
}
