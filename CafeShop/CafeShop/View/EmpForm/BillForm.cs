using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
using CafeShop.DTO;


namespace CafeShop.View.EmpForm
{
    public partial class BillForm : Form
    {
        private string MaBan = "";
        public delegate void ReloadTableDelegate();
        public ReloadTableDelegate ReloadTable { get; set; }
        public delegate void ReloadTableInfoDelegate(string MaBan);
        public ReloadTableInfoDelegate ReloadInfo { get; set; }
        public BillForm(string MaBan)
        {
            InitializeComponent();
            this.MaBan = MaBan;
            BLLBill.Instance.GetBillCostOfTable(MaBan);
            TongTienTextBox.Texts = BLLBill.Instance.tongTien.ToString();
            ThanhTienTextBox.Texts = BLLBill.Instance.SurchargeAndDiscount().ToString();
            surchargeTextbox.Texts = "0";
            discountTextbox.Texts = "0";
            //surchargeTextbox.Enabled = false;
            //discountTextbox.Enabled = false;
        }

        private void CalculateCharge(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Text[0].Equals(0) && ((TextBox)sender).Text.Length > 2)
            //{
            //    ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(0, 1);
            //}
            //if (surchargePercent.Checked == true)
            //    if (discountPercent.Checked == true)
            //        soTienSauCungTextBox.Texts = (BLLBill.Instance.GetBillCostOfTable(MaBan) * (1 + Convert.ToDouble(surchargeTextbox.Texts) / 100 - Convert.ToDouble(discountTextbox.Texts) / 100)).ToString();
            //    else
            //        soTienSauCungTextBox.Texts = (BLLBill.Instance.GetBillCostOfTable(MaBan) * (1 + Convert.ToInt32(surchargeTextbox.Texts) / 100) - Convert.ToInt32(discountTextbox.Texts)).ToString();
            //else if (discountPercent.Checked == true)
            //    soTienSauCungTextBox.Texts = (BLLBill.Instance.GetBillCostOfTable(MaBan) * (1 - Convert.ToInt32(discountTextbox.Texts) / 100) + Convert.ToInt32(surchargeTextbox.Texts)).ToString();
            //else
            //    soTienSauCungTextBox.Texts = (BLLBill.Instance.GetBillCostOfTable(MaBan) + Convert.ToInt32(surchargeTextbox.Texts) - Convert.ToInt32(discountTextbox.Texts)).ToString();

            //tienThuaTextBox.Texts = (Convert.ToInt32(soTienKhachDuaTextBox.Texts) - Convert.ToInt32(soTienSauCungTextBox.Texts)).ToString();
            try
            {
                int surcharge, discount;
                if (surchargeTextbox.Texts == "")
                    surcharge = 0;
                else
                    surcharge = Convert.ToInt32(surchargeTextbox.Texts);
                if (discountTextbox.Texts == "")
                    discount = 0;
                else
                    discount = Convert.ToInt32(discountTextbox.Texts);
                bool isSurchargePercent = surchargePercent.Checked;
                bool isDiscountPercent = discountPercent.Checked;
                ThanhTienTextBox.Texts = BLLBill.Instance.SurchargeAndDiscount(surcharge, isSurchargePercent, discount, isDiscountPercent).ToString();
                tienThuaTextBox.Texts = (Convert.ToInt32(soTienKhachDuaTextBox.Texts) - Convert.ToInt32(ThanhTienTextBox.Texts)).ToString();
            }
            catch (Exception ex) { }
        }

        private void jButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    tenKHTextBox.Texts = BLLBill.Instance.GetKHBySDT(SDTKhachHangTextBox.Texts).HoTenKH;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Khách hàng không phải là thành viên");
            //    SDTKhachHangTextBox.Texts = "";
            //}
            KhachHang kh = BLLBill.Instance.GetKHBySDT(SDTKhachHangTextBox.Texts);
            if (kh != null)
                tenKHTextBox.Texts = kh.HoTenKH;
            else
                tenKHTextBox.Texts = "Không phải là thành viên";
        }

        private void jButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jButton3_Click(object sender, EventArgs e)
        {
            //string IDKhachHang = db.KhachHangs.Where(x => x.SoDienThoaiKH == SDTKhachHangTextBox.Texts).FirstOrDefault().IDKhachHang;
            //string maBan = db.Bans.Where(x => x.MaBan == MaBan).FirstOrDefault().MaBan;
            //string maHoaDon = db.HoaDons.Where(x => x.MaBan == maBan).FirstOrDefault().MaHoaDon;
            //var objectHoaDon = db.HoaDons.Where(x => x.MaHoaDon == maHoaDon).FirstOrDefault();
            //objectHoaDon.ThanhTien = Convert.ToInt32(soTienSauCungTextBox.Texts);
            //objectHoaDon.IDKhachHang = IDKhachHang;
            //if (surchargePercent.Checked == true)
            //    objectHoaDon.PhuThu = Convert.ToInt32(surchargeTextbox.Texts).ToString() + "%";
            //else
            //    objectHoaDon.PhuThu = Convert.ToInt32(surchargeTextbox.Texts).ToString();

            //if (discountPercent.Checked == true)
            //    objectHoaDon.GiamGia = Convert.ToInt32(discountTextbox.Texts).ToString() + "%";
            //else 
            //    objectHoaDon.GiamGia = Convert.ToInt32(discountTextbox.Texts).ToString();
            //db.SaveChanges();
            try
            {
                double TienThua = Convert.ToDouble(tienThuaTextBox.Texts);
                if (Convert.ToInt32(surchargeTextbox.Texts) >= 0 && Convert.ToInt32(discountTextbox.Texts) >= 0 && TienThua >= 0)
                {
                    int ThanhTien = Convert.ToInt32(ThanhTienTextBox.Texts);
                    string PhuThu = "+" + surchargeTextbox.Texts;
                    string GiamGia = "-" + discountTextbox.Texts;
                    if (surchargePercent.Checked)
                    {
                        PhuThu += "%";
                    }
                    if (discountPercent.Checked)
                    {
                        GiamGia += "%";
                    }
                    if (tenKHTextBox.Texts == "Không phải là thành viên" || tenKHTextBox.Texts == "")
                        SDTKhachHangTextBox.Texts = "0";
                    BLLBill.Instance.ConfirmBill(this.MaBan, SDTKhachHangTextBox.Texts, PhuThu, GiamGia, ThanhTien);
                    ReloadTable?.Invoke();
                    ReloadInfo?.Invoke(this.MaBan);
                    this.Close();
                }
                else if (Convert.ToInt32(surchargeTextbox.Texts) < 0)
                    throw new Exception("Phụ thu phải lớn hơn 0");
                else if (Convert.ToInt32(discountTextbox.Texts) < 0)
                    throw new Exception("Giảm giá phải lớn hơn 0");
                else if (TienThua < 0)
                    throw new Exception("Tiền thừa phải lớn hơn 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void soTienKhachDuaTextBox__TextChanged(object sender, EventArgs e)
        //{
        //    if (soTienKhachDuaTextBox.Texts == "")
        //    {
        //        surchargeTextbox.Enabled = false;
        //        discountTextbox.Enabled = false;
        //    }
        //    else
        //    {
        //        surchargeTextbox.Enabled = true;
        //        discountTextbox.Enabled = true;
        //    }    
        //}
    }
}
