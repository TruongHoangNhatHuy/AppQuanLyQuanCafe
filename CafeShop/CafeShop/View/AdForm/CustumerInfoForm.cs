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

namespace CafeShop.View.AdForm
{
    public partial class CustomerInfoForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public CustomerInfoForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }

        private void adButton_Click(object sender, EventArgs e)
        {
            AdForm.CustomerDetailForm form = new CustomerDetailForm();
            form.ShowDialog();
            dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
            reload?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string IDKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BLLCustomerInfo.Instance.DeleteCustomer(IDKhachHang);
            dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            AdForm.CustomerDetailForm form = new CustomerDetailForm(ID);
            form.ShowDialog();
            dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //tìm kiếm theo tên
            dataGridView1.DataSource = DBModel.Instance.KhachHangs.Where(x => x.HoTenKH.Contains(searchTextbox.Texts)).ToList();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
