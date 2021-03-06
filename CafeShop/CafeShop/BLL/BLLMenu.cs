using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;
namespace CafeShop.BLL
{
    public class BLLMenu
    {
        private static BLLMenu _Instance;
        public static BLLMenu Instance
        {
            get
            {
                if( _Instance == null )
                    _Instance = new BLLMenu();
                return _Instance;
            }
            private set { }
        }
        private BLLMenu() { }
        public List<DanhMucThucDon> GetDanhMucThucDon() => DBContext.Instance.DanhMucThucDons.OrderBy(p => p.MaDanhMuc).Skip(1).ToList();
        public DanhMucThucDon GetDanhMucByMa(string MaDanhMuc) => DBContext.Instance.DanhMucThucDons.Find(MaDanhMuc);
        public List<Mon> GetMonByMaDanhMuc(string MaDanhMuc, string searchText = "")
        {
            searchText = searchText.ToLower();
            if (MaDanhMuc == null)
                return GetAllMon().Where(p => p.TenMon.ToLower().Contains(searchText)).ToList();
            else
                return DBContext.Instance.Mons.Where(p => p.MaDanhMuc == MaDanhMuc && p.TenMon.ToLower().Contains(searchText)).ToList();
        }
        public List<Mon> GetAllMon() => DBContext.Instance.Mons.OrderBy(p => p.MaMon).Skip(1).ToList();
        //--------------
        public List<Mon> GetVisibleMon(List<Mon> list) => list.Where(p => p.Visible == true).ToList();

        public List<Mon> GetHiddenMon(List<Mon> list) => list.Where(p => p.Visible == false).ToList();
        public Mon GetMonByMaMon(string MaMon) => DBContext.Instance.Mons.Find(MaMon);
        public bool CheckCategory(string MaDanhMuc)
        {
            if (DBContext.Instance.DanhMucThucDons.Find(MaDanhMuc) != null)
                return true;
            return false;
        }
        public void ExecuteCategory(DanhMucThucDon category)
        {
            if (CheckCategory(category.MaDanhMuc))
            {
                var existed = GetDanhMucByMa(category.MaDanhMuc);
                //existed.MaDanhMuc = category.MaDanhMuc;
                existed.TenDanhMuc = category.TenDanhMuc;
            }
            else
            {
                DBContext.Instance.DanhMucThucDons.Add(category);
            }              
            DBContext.Instance.SaveChanges();
        }
        public bool CheckFood(string MaMon)
        {
            if (DBContext.Instance.Mons.Find(MaMon) != null)
                return true;
            return false;
        }
        public void ExecuteFood(Mon food)
        {
            if(CheckFood(food.MaMon))
            {
                var existed = GetMonByMaMon(food.MaMon);
                existed.TenMon = food.TenMon;
                existed.MaDanhMuc = food.MaDanhMuc;
                existed.DonVi = food.DonVi;
                existed.DonGia = food.DonGia;
            }
            else
            {
                DBContext.Instance.Mons.Add(food);
            }    

            DBContext.Instance.SaveChanges();
        }
        public List<string> GetCategoryKeyList() => DBContext.Instance.DanhMucThucDons.Select(p => p.MaDanhMuc).ToList();
        public string NewCategoryKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetCategoryKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }

        public List<string> GetFoodKeyList() => DBContext.Instance.Mons.Select(p => p.MaMon).ToList();
        public string NewFoodKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetFoodKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }

        //public List<Mon> GetAvailableFood() => DBModel.Instance.Mons.Where(p => p.Visible == true).ToList();
        //public List<Mon> GetHiddenFood() => DBModel.Instance.Mons.Where(p => p.Visible == false).ToList();
        //public List<Mon> GetAllFood()
        //{
        //    var result = GetAvailableFood();
        //    result.AddRange(GetHiddenFood());
        //    return result;
        //}
        public void ChangeFoodState(string MaMon)
        {
            Mon food = GetMonByMaMon(MaMon);
            food.Visible = !food.Visible;
            DBContext.Instance.SaveChanges();
        }

        public void ChangeCategoryState(string MaDanhMuc)
        {
            DanhMucThucDon category = GetDanhMucByMa(MaDanhMuc);
            category.Visible = !category.Visible;
            DBContext.Instance.SaveChanges();
        }
    }
}
