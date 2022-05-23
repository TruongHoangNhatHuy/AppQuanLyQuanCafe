using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
using CafeShop.DTO;

namespace CafeShop.View.AdForm
{
    public partial class EmpDetailForm : Form
    {
        public EmpDetailForm(string ID = "")
        {
            InitializeComponent();
            GUI(ID);
        }
        public void GUI(string ID = "")
        {
            roleCombobox.Items.AddRange(BLLEmpDetail.Instance.GetVaiTro().ToArray());
            if (ID == "")
            {
                nameTextbox.PlaceholderText = "Bắt buộc";
                accountTextbox.PlaceholderText = "Bắt buộc";
                phoneNumberTextbox.PlaceholderText = "Bắt buộc";
                roleCombobox.Texts = "Bắt buộc";
                string currentKey = PrimaryKeyGenerator.GetCurrentKey(DBModel.Instance.TaiKhoans.Select(x => x.ID).ToList());
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
                maleRadioButton.Checked = tk.GioiTinh;
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
                BLLEmpDetail.Instance.ExecuteDB(tk);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
