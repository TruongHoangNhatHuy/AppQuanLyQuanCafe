using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.View.AdForm
{
    public partial class CustomerDetailForm : Form
    {
        public bool typeUpdate = false;
        public CustomerDetailForm()
        {
            InitializeComponent();
            typeUpdate = false;
            IDTextbox.Texts = CafeShop.BLL.PrimaryKeyGenerator.NextPrimaryKey(CafeShop.BLL.PrimaryKeyGenerator.GetCurrentKey(CafeShop.DTO.DBModel.Instance.KhachHangs.Select(x => x.IDKhachHang).ToList()));
        }
        public CustomerDetailForm(string ID)
        {
            InitializeComponent();
            typeUpdate = true;
            var i = CafeShop.DTO.DBModel.Instance.KhachHangs.Where(x => x.IDKhachHang == ID).FirstOrDefault();
            IDTextbox.Texts = i.IDKhachHang;
            nameTextbox.Texts = i.HoTenKH;
            subTimeTextbox.Texts = i.NgayDangKi.ToString();
            birthdayTextbox.Texts = i.NgaySinhKH.ToString();
            addressTextbox.Texts = i.DiaChiKH;
            phoneNumberTextbox.Texts = i.SoDienThoaiKH;
            maleRadioButton.Checked = i.GioiTinhKH;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (typeUpdate == true)
            {
                var i = CafeShop.DTO.DBModel.Instance.KhachHangs.Where(x => x.IDKhachHang == IDTextbox.Texts).FirstOrDefault();
                i.IDKhachHang = IDTextbox.Texts;
                i.HoTenKH = nameTextbox.Texts;
                i.NgayDangKi = Convert.ToDateTime(subTimeTextbox.Texts);
                i.DiaChiKH = addressTextbox.Texts;
                i.SoDienThoaiKH = phoneNumberTextbox.Texts;
                i.GioiTinhKH = maleRadioButton.Checked;
                CafeShop.DTO.DBModel.Instance.SaveChanges();
                this.Close();
            }
            else
            {
                if (phoneNumberTextbox.Texts == "")
                {
                    MessageBox.Show("Số điện thoại là bắt buộc!");
                }
                else
                {
                    CafeShop.DTO.DBModel.Instance.KhachHangs.Add(new DTO.KhachHang
                    {
                        IDKhachHang = IDTextbox.Texts,
                        HoTenKH = nameTextbox.Texts,
                        NgayDangKi = DateTime.Now,
                        DiaChiKH = addressTextbox.Texts,
                        SoDienThoaiKH = phoneNumberTextbox.Texts,
                        GioiTinhKH = maleRadioButton.Checked,
                    });
                    CafeShop.DTO.DBModel.Instance.SaveChanges();
                    this.Close();
                }
                
            }
        }
    }
}
