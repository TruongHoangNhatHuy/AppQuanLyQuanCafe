using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DTO;

namespace CafeShop.BLL
{
    public class BLLBill
    {
        private static BLLBill _Instance;
        public static BLLBill Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLBill();
                }
                return _Instance;
            }
            private set { }
        }
        public int tongTien { get; private set; }
        private HoaDon GetHoaDonByMaBan(string MaBan)
        {
            return DBModel.Instance.HoaDons.Where(x => x.MaBan == MaBan).FirstOrDefault();
        }
        public void GetBillCostOfTable(string MaBan)
        {

            string maHoaDon = GetHoaDonByMaBan(MaBan).MaHoaDon;
            var listDonGoiMon = DBModel.Instance.DonGoiMons.Where(x => x.TinhTrang == "Hoàn thành" && x.MaHoaDon == maHoaDon).ToList();
            foreach (var i in listDonGoiMon)
            {
                tongTien += i.GiaTien * i.SoLuong;
            }
        }
        public double SurchargeAndDiscount(double surcharge = 0, bool isSurchargePercent = false, double discount = 0, bool isDiscountPercent = false)
        {
            double surchargePercent = 0, discountPercent = 0;
            if (isSurchargePercent)
            {
                surchargePercent = surcharge / 100;
                surcharge = 0;
            }
            if (isDiscountPercent)
            {
                discountPercent = discount / 100;
                discount = 0;
            }
            double totalPercent = 1 + surchargePercent - discountPercent;
            return (tongTien * totalPercent) + surcharge - discount;
        }
        public KhachHang GetKHBySDT(string sdt)
        {
            return DBModel.Instance.KhachHangs.Where(x => x.SoDienThoaiKH == sdt).FirstOrDefault();
        }
        public void ConfirmBill(string MaBan, string sdt, string PhuThu, string GiamGia, int ThanhTien)
        {
            HoaDon bill = GetHoaDonByMaBan(MaBan);
            bill.IDKhachHang = GetKHBySDT(sdt).IDKhachHang;
            bill.IDNhanVien = "TK00000000";
            bill.PhuThu = PhuThu;
            bill.GiamGia = GiamGia;
            bill.ThanhTien = ThanhTien;
            bill.ThoiGianThanhToan = DateTime.Now;
            DBModel.Instance.SaveChanges();
        }
    }
}
