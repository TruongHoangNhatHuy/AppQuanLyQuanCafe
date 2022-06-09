using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLOrder
    {
        private static BLLOrder _Instance;
        public static BLLOrder Instance
        {
            private set { }
            get
            {
                if( _Instance == null )
                    _Instance = new BLLOrder();
                return _Instance;
            }
        }
        private List<HoaDon> currentBill = DBModel.Instance.HoaDons.Where(p => p.MaBan != "B000000000").ToList();
        private BLLOrder() 
        { }
        public List<KhuvucCBItem> GetKhuvucCBItem() 
            => DBModel.Instance.KhuVucs.ToList().Skip(1).Select(p => new KhuvucCBItem() { ID = p.MaKhuVuc, Name = p.TenKhuVuc }).ToList();
        public KhuVuc GetKhuVucByMaKhuVuc(string ID) => DBModel.Instance.KhuVucs.Find(ID);

        public List<Ban> GetAllBan() => DBModel.Instance.Bans.ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBModel.Instance.KhuVucs.ToList().Skip(1).ToList();
        public List<DanhMucThucDon> GetDanhMucThucDon() => DBModel.Instance.DanhMucThucDons.Where(p => p.Visible == true).ToList();

        public List<Mon> GetMonByMaDanhMuc(string MaDanhMuc) => DBModel.Instance.Mons.Where(p => p.MaDanhMuc == MaDanhMuc && p.Visible == true).ToList();

        public Ban GetBanByMaBan(string MaBan) => DBModel.Instance.Bans.Find(MaBan);

        public HoaDon CreateNewBill(string MaBan)
        {
            HoaDon bill = new HoaDon()
            {
                MaHoaDon = PrimaryKeyGenerator.OrderBillPrimaryKey(),
                IDKhachHang = "KH00000000",
                IDNhanVien = "TK00000000",
                MaBan = MaBan,
                Ban = GetBanByMaBan(MaBan),
                ThoiGianThanhToan = DateTime.Now
            };
            DBModel.Instance.HoaDons.Add(bill);
            DBModel.Instance.SaveChanges();
            currentBill.Add(bill);
            return bill;
        }
        public void SaveTableState(string MaBan)
        {
            Ban ban = GetBanByMaBan(MaBan);
            ban.TinhTrang = !ban.TinhTrang;
            DBModel.Instance.SaveChanges();
        }
        public void DeleteEmptyBill(string MaBan)
        {
            var bill = GetHoaDonByMaBan(MaBan);
            if(bill.DonGoiMons.Count == 0)
            {
                DBModel.Instance.HoaDons.Remove(bill);
                DBModel.Instance.SaveChanges();
            }    
            
        }
        public HoaDon GetHoaDonByMaBan(string MaBan) => currentBill.Where(p => p.MaBan == MaBan).FirstOrDefault();
        public List<DonGoiMonView> GetDonGoiMonViewsByMaBan(string MaBan) => GetHoaDonByMaBan(MaBan).DonGoiMons.Select(p => new DonGoiMonView(p)).ToList();
    }
}
