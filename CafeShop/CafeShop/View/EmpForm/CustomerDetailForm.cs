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

namespace CafeShop.View.EmpForm
{
    public partial class CustomerDetailForm : Form
    {
        public CustomerDetailForm(string sdt)
        {
            InitializeComponent();
            GUI(sdt);
        }

        public void GUI(string sdt)
        {
            {
                nameTextbox.PlaceholderText = "Bắt buộc";
                phoneNumberTextbox.Texts = sdt;
                string currentKey = PrimaryKeyGenerator.GetCurrentKey(DBContext.Instance.KhachHangs.Select(x => x.IDKhachHang).ToList());
                IDTextbox.Texts = PrimaryKeyGenerator.NextPrimaryKey(currentKey);
                subTimeTextbox.Texts = DateTime.Now.ToString();
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
                if (birthdayPicker.Value >= DateTime.Now)
                    throw new Exception("Ngày sinh không hợp lệ");
                if (!Regex.IsMatch(phoneNumberTextbox.Texts, "^[0-9]{10}$"))
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
