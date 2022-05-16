using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLTable
    {
        private static BLLTable _Instance;
        public static BLLTable Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLLTable();
                return _Instance;
            }
            private set { }
        }
        private BLLTable() { }
        private DBModel db = new DBModel();
        public List<KhuvucCBItem> GetKhuvucCBItem()
        {
            List<KhuvucCBItem> data = new List<KhuvucCBItem>();
            foreach (KhuVuc khuvuc in db.KhuVucs)
            {
                data.Add(new KhuvucCBItem { ID = khuvuc.MaKhuVuc, Name = khuvuc.TenKhuVuc });
            }
            return data;
        }
        public List<Ban> GetAllBan() => db.Bans.ToList();
        public List<KhuVuc> GetAllKhuvuc() => db.KhuVucs.ToList();
        public Ban GetBanByMaBan(string MaBan) => db.Bans.Find(MaBan);

        public List<Ban> GetBanByMaKhuvuc(string MaKhuVuc)
        {
            if (MaKhuVuc.Equals("0"))
                return GetAllBan();
            else
                return db.Bans.Where(p => p.MaKhuVuc.Equals(MaKhuVuc)).ToList();
        }
        public List<Ban> SearchTable(string MaKhuVuc, string searchText)
            => GetBanByMaKhuvuc(MaKhuVuc).Where(p => p.TenBan.ToLower().Contains(searchText)).ToList();
        public void DeleteTable(List<string> delList)
        {
            foreach (string MaBan in delList)
                db.Bans.Remove(GetBanByMaBan(MaBan));
            db.SaveChanges();
        }
    }
}
