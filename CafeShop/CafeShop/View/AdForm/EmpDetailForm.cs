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

namespace CafeShop.View.AdForm
{
    public partial class EmpDetailForm : Form
    {
        public bool typeUpdate = false;
        public EmpDetailForm()
        {
            InitializeComponent();
            typeUpdate = false;
            IDTextbox.Texts = CafeShop.BLL.PrimaryKeyGenerator.NextPrimaryKey(CafeShop.BLL.PrimaryKeyGenerator.GetCurrentKey(CafeShop.DTO.DBModel.Instance.TaiKhoans.Select(x => x.ID).ToList()));
            foreach (string str in CafeShop.DTO.DBModel.Instance.VaiTroes.Select(x => x.TenVaiTro).ToList())
            {
                roleCombobox.Items.Add(str);
            }
        }
        public EmpDetailForm(string ID)
        {
            InitializeComponent();
            foreach (string str in CafeShop.DTO.DBModel.Instance.VaiTroes.Select(x => x.TenVaiTro).ToList())
            {
                roleCombobox.Items.Add(str);
            }
            typeUpdate = true;
            var i = CafeShop.DTO.DBModel.Instance.TaiKhoans.Where(x => x.ID == ID).FirstOrDefault();
            IDTextbox.Texts = i.ID;
            accountTextbox.Texts = i.TenTaiKhoan;
            nameTextbox.Texts = i.HoTen;
            birthdayTextbox.Texts = i.NgaySinh.ToString();
            addressTextbox.Texts = i.DiaChi;
            phoneNumberTextbox.Texts = i.SoDienThoai;
            roleCombobox.Text = CafeShop.DTO.DBModel.Instance.VaiTroes.SingleOrDefault(x => x.MaVaiTro == i.VaiTro.MaVaiTro).TenVaiTro;
            maleRadioButton.Checked = i.GioiTinh;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (typeUpdate == true)
            {
                var i = CafeShop.DTO.DBModel.Instance.TaiKhoans.Where(x => x.ID == IDTextbox.Texts).FirstOrDefault();
                i.TenTaiKhoan = accountTextbox.Texts;
                i.HoTen = nameTextbox.Texts;
                i.NgaySinh = DateTime.Parse(birthdayTextbox.Texts);
                i.DiaChi = addressTextbox.Texts;
                i.SoDienThoai = phoneNumberTextbox.Texts;
                i.VaiTro.MaVaiTro = CafeShop.DTO.DBModel.Instance.VaiTroes.Where(x => x.TenVaiTro == roleCombobox.Text).FirstOrDefault().MaVaiTro;
                i.GioiTinh = maleRadioButton.Checked;
                CafeShop.DTO.DBModel.Instance.SaveChanges();
                this.Close();
            }
            else
            {
                CafeShop.DTO.DBModel.Instance.TaiKhoans.Add(new DTO.TaiKhoan
                {
                    ID = IDTextbox.Texts,
                    TenTaiKhoan = accountTextbox.Texts,
                    HoTen = nameTextbox.Texts,
                    NgaySinh = DateTime.Parse(birthdayTextbox.Texts),
                    DiaChi = addressTextbox.Texts,
                    NgayBatDauLamViec = DateTime.Now,
                    SoDienThoai = phoneNumberTextbox.Texts,
                    MaVaiTro = CafeShop.DTO.DBModel.Instance.VaiTroes.Where(x => x.TenVaiTro == roleCombobox.Text).FirstOrDefault().MaVaiTro,
                    GioiTinh = maleRadioButton.Checked,
                    MatKhau = DateTime.Parse(birthdayTextbox.Texts).ToString("ddMMyyyy"),
                }); ;
                CafeShop.DTO.DBModel.Instance.SaveChanges();
                this.Close();
            }
        }
    }
}
