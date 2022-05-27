﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLDetailOrder
    {
        private static BLLDetailOrder _Instance;
        public static BLLDetailOrder Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLDetailOrder();
                }
                return _Instance;
            }
            private set { }
        }
        private Mon mon = null;
        private string MaHoaDon;
        public void SetMaHoaDon(string MaHoaDon)
        {
            this.MaHoaDon = MaHoaDon;
        }
        public void SetDish(string MaMon)
        {
            mon = DBModel.Instance.Mons.Find(MaMon);
        }
        public string ShowDetail()
        {
            return mon.TenMon.ToString() + ", " + mon.DonGia.ToString() + "/" + mon.DonVi.ToString();
        }
        public int CalculatePrice(int SoLuong)
        {
            return mon.DonGia * SoLuong;
        }
        // phương thức kiểm tra kho còn đủ hàng hóa không
        public void CheckGoods(int SoLuong) 
        {
            HangHoa goods = mon.HangHoa.FirstOrDefault();
            if (goods != null)
            {
                if (goods.SoLuong < SoLuong)
                    throw new Exception("Hiện tại kho chỉ có " + goods.SoLuong + " " + goods.DonVi.ToLower());
                else
                {
                    goods.SoLuong -= SoLuong;
                    DBModel.Instance.SaveChanges();
                }
            }
        }
        public void ConfirmDetailOrder(int SoLuong, string GhiChu)
        {
            CheckGoods(SoLuong);
            DonGoiMon result = new DonGoiMon
            {
                MaDonGoiMon = PrimaryKeyGenerator.OrderBillPrimaryKey(),
                MaHoaDon = this.MaHoaDon,
                MaMon = mon.MaMon,
                SoLuong = SoLuong,
                GhiChu = GhiChu,
                GiaTien = CalculatePrice(SoLuong),
                ThoiGianGoiMon = DateTime.Now,
                TinhTrang = "Đang chờ"
            };
            DBModel.Instance.DonGoiMons.Add(result);
            DBModel.Instance.SaveChanges();
        }
    }
}