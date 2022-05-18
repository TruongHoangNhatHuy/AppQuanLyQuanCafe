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
        {
            List<KhuvucCBItem> data = new List<KhuvucCBItem> ();
            foreach(KhuVuc khuvuc in DBModel.Instance.KhuVucs)
            {
                data.Add(new KhuvucCBItem { ID = khuvuc.MaKhuVuc, Name = khuvuc.TenKhuVuc });
            } 
            return data;
        }
        public KhuVuc GetKhuVucByMaKhuVuc(string ID) => DBModel.Instance.KhuVucs.Find(ID);

        public List<Ban> GetAllBan() => DBModel.Instance.Bans.ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBModel.Instance.KhuVucs.ToList();
        public List<DanhMucThucDon> GetDanhMucThucDon() => DBModel.Instance.DanhMucThucDons.ToList();

        public List<Mon> GetMonByMaDanhMuc(string MaDanhMuc) => DBModel.Instance.Mons.Where(p => p.MaDanhMuc == MaDanhMuc).ToList();

        public Ban GetBanByMaBan(string MaBan) => DBModel.Instance.Bans.Find(MaBan);
        //public string GetMaHoaDonByMaBan(string MaBan)
        //{
        //    foreach(HoaDon hoadon in DBModel.Instance.HoaDons)
        //    {
        //        if(hoadon.MaBan.Equals(MaBan))
        //            return hoadon.MaHoaDon;
        //    }
        //    return null;
        //}
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
        public HoaDon GetHoaDonByMaBan(string MaBan) => currentBill.Where(p => p.MaBan == MaBan).FirstOrDefault();
    }
}
