using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop.DTO
{
    public class DonGoiMonView
    {
        public DonGoiMonView(DonGoiMon dgm)
        {
            this.MaDonGoiMon = dgm.MaDonGoiMon;
            this.TenBan = DBModel.Instance.Bans.Find(DBModel.Instance.HoaDons.Find(dgm.MaHoaDon).MaBan).TenBan;
            this.TenMon = DBModel.Instance.Mons.Find(dgm.MaMon).TenMon;
            this.SoLuong = dgm.SoLuong;
            this.GhiChu = dgm.GhiChu;
            TimeSpan ts = DateTime.Now - dgm.ThoiGianGoiMon;
            this.ThoiGianTuKhiGoi = (int)ts.TotalMinutes;
            this.TinhTrang = dgm.TinhTrang;
        }
        public string MaDonGoiMon { get; set; }
        public string TenBan { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public int ThoiGianTuKhiGoi { get; set; }
        public string TinhTrang { get; set; }
    }
}
