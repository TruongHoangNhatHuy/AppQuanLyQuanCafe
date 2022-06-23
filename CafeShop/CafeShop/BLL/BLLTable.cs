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
            => DBContext.Instance.KhuVucs.ToList().Skip(1).Select(p => new KhuvucCBItem() { ID = p.MaKhuVuc, Name = p.TenKhuVuc }).ToList();
        public List<Ban> GetAllBan() => DBContext.Instance.Bans.ToList().Skip(1).ToList();
        public List<KhuVuc> GetAllKhuvuc() => DBContext.Instance.KhuVucs.ToList().Skip(1).ToList();
        public Ban GetBanByMaBan(string MaBan) => DBContext.Instance.Bans.Find(MaBan);

        public KhuVuc GetKhuVucByMaKhuVuc(string MaKhuVuc) => DBContext.Instance.KhuVucs.Find(MaKhuVuc);
        public List<Ban> GetBanByMaKhuvuc(string MaKhuVuc)
        {
            if (MaKhuVuc.Equals("0"))
                return GetAllBan();
            else
                return DBContext.Instance.Bans.Where(p => p.MaKhuVuc.Equals(MaKhuVuc)).ToList();
        }
        public List<Ban> SearchTable(string MaKhuVuc, string searchText)
            => GetBanByMaKhuvuc(MaKhuVuc).Where(p => p.TenBan.ToLower().Contains(searchText)).ToList();
        #region Execute Table DB        
        public bool Check(string MaBan)
        {
            foreach(var ban in DBContext.Instance.Bans)
                if (ban.MaBan.Equals(MaBan))
                    return true;
            return false;
        }
        public void Execute(Ban ban)
        {
            if(Check(ban.MaBan))
            {
                Ban newBan = DBContext.Instance.Bans.Find(ban.MaBan);
                if(newBan != null)
                {
                    newBan.TenBan = ban.TenBan;
                    newBan.MaKhuVuc = ban.MaKhuVuc;
                    newBan.KhuVuc = GetKhuVucByMaKhuVuc(newBan.MaKhuVuc);
                }    
            }
            else
                DBContext.Instance.Bans.Add(ban);
            DBContext.Instance.SaveChanges();
        }
        public void AddArea(KhuVuc khuvuc)
        {
            DBContext.Instance.KhuVucs.Add(khuvuc);
            DBContext.Instance.SaveChanges();
        }
        public bool DeleteTable(string MaBan)
        {
            if (GetBanByMaBan(MaBan).TinhTrang)
            {
                DBContext.Instance.Bans.Remove(GetBanByMaBan(MaBan));
                DBContext.Instance.SaveChanges();
                return true;
            }
            else
                return false;            
        }
        #endregion

        #region GenerateKey
        public List<string> GetTableKeyList() => DBContext.Instance.Bans.Select(p => p.MaBan).ToList();
        public string NewTableKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetTableKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }

        public List<string> GetAreaKeyList() => DBContext.Instance.KhuVucs.Select(p => p.MaKhuVuc).ToList();
        public string NewAreaKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetAreaKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }
        #endregion

        //Pagination
        public List<Ban> GetCurrentRecord(int page, int pageSize, List<Ban> list)
        {
            if ((list.Count / pageSize + 1) == page)
                return list.Skip((page - 1) * pageSize).ToList();
            return list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }

}
