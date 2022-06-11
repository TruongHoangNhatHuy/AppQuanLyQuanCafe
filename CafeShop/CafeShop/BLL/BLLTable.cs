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
        public List<KhuvucCBItem> GetKhuvucCBItem()
            => DBModel.Instance.KhuVucs.ToList().Skip(1).Select(p => new KhuvucCBItem() { ID = p.MaKhuVuc, Name = p.TenKhuVuc }).ToList();
        public List<Ban> GetAllBan() => DBModel.Instance.Bans.ToList().Skip(1).ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBModel.Instance.KhuVucs.ToList().Skip(1).ToList();
        public Ban GetBanByMaBan(string MaBan) => DBModel.Instance.Bans.Find(MaBan);

        public KhuVuc GetKhuVucByMaKhuVuc(string MaKhuVuc) => DBModel.Instance.KhuVucs.Find(MaKhuVuc);
        public List<Ban> GetBanByMaKhuvuc(string MaKhuVuc)
        {
            if (MaKhuVuc.Equals("0"))
                return GetAllBan();
            else
                return DBModel.Instance.Bans.Where(p => p.MaKhuVuc.Equals(MaKhuVuc)).ToList();
        }
        public List<Ban> SearchTable(string MaKhuVuc, string searchText)
            => GetBanByMaKhuvuc(MaKhuVuc).Where(p => p.TenBan.ToLower().Contains(searchText)).ToList();
        public void DeleteTable(List<string> delList)
        {
            foreach (string MaBan in delList)
                DBModel.Instance.Bans.Remove(GetBanByMaBan(MaBan));
            DBModel.Instance.SaveChanges();
        }
        public bool Check(string MaBan)
        {
            foreach(var ban in DBModel.Instance.Bans)
                if (ban.MaBan.Equals(MaBan))
                    return true;
            return false;
        }
        public void Execute(Ban ban)
        {
            if(Check(ban.MaBan))
            {
                Ban newBan = DBModel.Instance.Bans.Find(ban.MaBan);
                if(newBan != null)
                {
                    newBan.TenBan = ban.TenBan;
                    newBan.MaKhuVuc = ban.MaKhuVuc;
                    newBan.KhuVuc = GetKhuVucByMaKhuVuc(newBan.MaKhuVuc);
                }    
            }
            else
                DBModel.Instance.Bans.Add(ban);
            DBModel.Instance.SaveChanges();
        }
        public void AddArea(KhuVuc khuvuc)
        {
            DBModel.Instance.KhuVucs.Add(khuvuc);
            DBModel.Instance.SaveChanges();
        }

        public List<string> GetTableKeyList() => DBModel.Instance.Bans.Select(p => p.MaBan).ToList();
        public string NewTableKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetTableKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }

        public List<string> GetAreaKeyList() => DBModel.Instance.KhuVucs.Select(p => p.MaKhuVuc).ToList();
        public string NewAreaKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetAreaKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }
    }

}
