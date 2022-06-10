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
        public List<DanhMucThucDon> GetDanhMucThucDon() => DBModel.Instance.DanhMucThucDons.OrderBy(p => p.MaDanhMuc).Skip(1).ToList();
        public DanhMucThucDon GetDanhMucByMa(string MaDanhMuc) => DBModel.Instance.DanhMucThucDons.Find(MaDanhMuc);
        //public List<Mon> GetMonByMaDanhMuc(string MaDanhMuc) => DBModel.Instance.Mons.Where(p => p.MaDanhMuc == MaDanhMuc).ToList();
        public List<Mon> GetMonByMaDanhMuc(string MaDanhMuc)
        {
            if (MaDanhMuc == null)
                return GetAllMon();
            else
                return DBModel.Instance.Mons.Where(p => p.MaDanhMuc == MaDanhMuc).ToList();
        }
        public List<Mon> GetAllMon() => DBModel.Instance.Mons.OrderBy(p => p.MaMon).Skip(1).ToList();
        //--------------
        public List<Mon> GetVisibleMon(List<Mon> list) => list.Where(p => p.Visible == true).ToList();

        public List<Mon> GetHiddenMon(List<Mon> list) => list.Where(p => p.Visible == false).ToList();





        public Mon GetMonByMaMon(string MaMon) => DBModel.Instance.Mons.Find(MaMon);
        public bool CheckCategory(string MaDanhMuc)
        {
            if (DBModel.Instance.DanhMucThucDons.Find(MaDanhMuc) != null)
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
                DBModel.Instance.DanhMucThucDons.Add(category);
            }              
            DBModel.Instance.SaveChanges();
        }
        public bool CheckFood(string MaMon)
        {
            if (DBModel.Instance.Mons.Find(MaMon) != null)
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
                DBModel.Instance.Mons.Add(food);
            }    

            DBModel.Instance.SaveChanges();
        }
        public List<string> GetCategoryKeyList() => DBModel.Instance.DanhMucThucDons.Select(p => p.MaDanhMuc).ToList();
        public string NewCategoryKey()
        {
            string CurrentKey = PrimaryKeyGenerator.GetCurrentKey(GetCategoryKeyList());
            return PrimaryKeyGenerator.NextPrimaryKey(CurrentKey);
        }

        public List<string> GetFoodKeyList() => DBModel.Instance.Mons.Select(p => p.MaMon).ToList();
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
            DBModel.Instance.SaveChanges();
        }

        public void ChangeCategoryState(string MaDanhMuc)
        {
            DanhMucThucDon category = GetDanhMucByMa(MaDanhMuc);
            category.Visible = !category.Visible;
            DBModel.Instance.SaveChanges();
        }
        public List<Mon> SearchFood(List<Mon> list, string text) => list.Where(p => p.TenMon.ToLower().Contains(text)).ToList();
    }
}
