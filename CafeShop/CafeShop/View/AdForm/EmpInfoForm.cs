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
    public partial class EmpInfoForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public EmpInfoForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.TaiKhoans.ToList();
        }

        private void adButton_Click(object sender, EventArgs e)
        {
            AdForm.EmpDetailForm form = new EmpDetailForm();
            form.ShowDialog();
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.TaiKhoans.ToList();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
            reload?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CafeShop.DTO.DBModel.Instance.TaiKhoans.Remove(CafeShop.DTO.DBModel.Instance.TaiKhoans.Find(dataGridView1.CurrentRow.Cells[0].Value));
            CafeShop.DTO.DBModel.Instance.SaveChanges();
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.TaiKhoans.ToList();
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var i = CafeShop.DTO.DBModel.Instance.TaiKhoans.Find(ID);
            i.MatKhau = i.NgaySinh.ToString("ddMMyyyy");
            CafeShop.DTO.DBModel.Instance.SaveChanges();
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.TaiKhoans.ToList();
            MessageBox.Show("Đã reset mật khẩu thành công");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            AdForm.EmpDetailForm form = new EmpDetailForm(ID);
            form.ShowDialog();
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.TaiKhoans.ToList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CafeShop.DTO.DBModel.Instance.KhachHangs.Where(x => x.HoTenKH.Contains(searchTextbox.Texts)).ToList();
        }
    }
}
