using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DTO;
using CafeShop.BLL;
using System.Text.RegularExpressions;
using System.Data.Entity.Infrastructure;
namespace CafeShop.View.AdForm
{
    public partial class CustomerDetailForm : Form
    {
        public delegate void Reload();
        public Reload reload { get; set; }
        public CustomerDetailForm(string ID = "")
        {
            InitializeComponent();
            GUI(ID);
        }
        public void GUI(string ID)
        {
            if (ID == "")
            {
                nameTextbox.PlaceholderText = "Bắt buộc";
                phoneNumberTextbox.PlaceholderText = "Bắt buộc";
                string currentKey = PrimaryKeyGenerator.GetCurrentKey(DBContext.Instance.KhachHangs.Select(x => x.IDKhachHang).ToList());
                IDTextbox.Texts = PrimaryKeyGenerator.NextPrimaryKey(currentKey);
                subTimeTextbox.Texts = DateTime.Now.ToString();
            }
            else
            {
                KhachHang kh = BLLCustomerDetail.Instance.GetKH(ID);
                nameTextbox.Texts = kh.HoTenKH;
                phoneNumberTextbox.Texts = kh.SoDienThoaiKH;
                birthdayPicker.Value = kh.NgaySinhKH;
                addressTextbox.Texts = kh.DiaChiKH;
                //maleRadioButton.Checked = kh.GioiTinhKH;
                if (kh.GioiTinhKH)
                    maleRadioButton.Checked = true;
                else
                    femaleRadioButton.Checked = true;
                IDTextbox.Texts = kh.IDKhachHang;
                subTimeTextbox.Texts = kh.NgayDangKi.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextbox.Texts == "" || phoneNumberTextbox.Texts == "")
                    throw new Exception("Thiếu thông tin.");
                else if (birthdayPicker.Value >= DateTime.Now)
                    throw new Exception("Ngày sinh không hợp lệ");
                else if (!Regex.IsMatch(phoneNumberTextbox.Texts, "^[0-9]{10}$"))
                    throw new Exception("Số điện thoại nhập vào không đúng định dạng.");
                KhachHang kh = new KhachHang
                {
                    IDKhachHang = IDTextbox.Texts,
                    HoTenKH = nameTextbox.Texts,
                    SoDienThoaiKH = phoneNumberTextbox.Texts,
                    DiaChiKH = addressTextbox.Texts,
                    NgaySinhKH = birthdayPicker.Value,
                    GioiTinhKH = maleRadioButton.Checked,
                    NgayDangKi = Convert.ToDateTime(subTimeTextbox.Texts),
                };
                BLLCustomerDetail.Instance.ExecuteDB(kh);
                reload?.Invoke();
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Số điện thoại đã được đăng ký");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
