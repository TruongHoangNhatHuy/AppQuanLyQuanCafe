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
    }
}
