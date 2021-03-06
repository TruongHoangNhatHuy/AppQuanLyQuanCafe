using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
using CafeShop.DTO;

namespace CafeShop.View.AdForm
{
    public partial class EmpDetailForm : Form
    {
        public delegate void Reload();
        public Reload reload { get; set; }
        public EmpDetailForm(string ID = "", bool mode = false)
        {
            InitializeComponent();
            if (mode)
                roleCombobox.Enabled = false;
            GUI(ID);
        }
        public void GUI(string ID)
        {
            roleCombobox.Items.AddRange(BLLEmpDetail.Instance.GetVaiTro().ToArray());
            if (ID == "")
            {
                nameTextbox.PlaceholderText = "Bắt buộc";
                accountTextbox.PlaceholderText = "Bắt buộc";
                phoneNumberTextbox.PlaceholderText = "Bắt buộc";
                roleCombobox.Texts = "Bắt buộc";
                string currentKey = PrimaryKeyGenerator.GetCurrentKey(DBContext.Instance.TaiKhoans.Select(x => x.ID).ToList());
                IDTextbox.Texts = PrimaryKeyGenerator.NextPrimaryKey(currentKey);
            }
            else
            {
                TaiKhoan tk = BLLEmpDetail.Instance.GetInfo(ID);
                IDTextbox.Texts = tk.ID;
                accountTextbox.Texts = tk.TenTaiKhoan;
                nameTextbox.Texts = tk.HoTen;
                birthdayPicker.Value = tk.NgaySinh;
                addressTextbox.Texts = tk.DiaChi;
                phoneNumberTextbox.Texts = tk.SoDienThoai;
                roleCombobox.SelectedItem = BLLEmpDetail.Instance.GetVaiTroByMaVaiTro(tk.MaVaiTro);
                //maleRadioButton.Checked = tk.GioiTinh;
                if (tk.GioiTinh)
                    maleRadioButton.Checked = true;
                else
                    femaleRadioButton.Checked = true;
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
                if (nameTextbox.Texts == "" || phoneNumberTextbox.Texts == "" || accountTextbox.Texts == "" || roleCombobox.SelectedItem == null)
                    throw new Exception("Thiếu thông tin.");
                else if (birthdayPicker.Value >= DateTime.Now)
                    throw new Exception("Ngày sinh không hợp lệ");
                else if (!Regex.IsMatch(phoneNumberTextbox.Texts, "^[0-9]{10}$"))
                    throw new Exception("Số điện thoại nhập vào không đúng định dạng");
                TaiKhoan tk = new TaiKhoan
                {
                    ID = IDTextbox.Texts,
                    TenTaiKhoan = accountTextbox.Texts,
                    HoTen = nameTextbox.Texts,
                    NgaySinh = birthdayPicker.Value,
                    DiaChi = addressTextbox.Texts,
                    SoDienThoai = phoneNumberTextbox.Texts,
                    MaVaiTro = (roleCombobox.SelectedItem as VaiTro).MaVaiTro,
                    GioiTinh = maleRadioButton.Checked
                };
                if (BLLEmpDetail.Instance.ExecuteDB(tk))
                    MessageBox.Show("Mật khẩu là: " + tk.NgaySinh.ToString("ddMMyyyy") + "\nVui lòng đổi mật khẩu mới khi đăng nhập.");
                reload?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
