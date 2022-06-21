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
        }
        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            ReloadData();
            searchByComboBox.Items.AddRange(new string[] { "Tìm kiếm theo", "Theo ID khách hàng", "Theo họ tên", "Theo số điện thoại", "Theo ngày sinh", "Theo địa chỉ", "Theo ngày đăng kí" });
            searchByComboBox.SelectedIndex = 0;
        }
        public void ReloadData()
        {
            dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }
        private void adButton_Click(object sender, EventArgs e)
        {
            CustomerDetailForm form = new CustomerDetailForm();
            form.reload += ReloadData;
            form.ShowDialog();
            //dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCustomerList();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string IDKhachHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắn chắn muốn xoá khách hàng có mã {IDKhachHang} không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BLLCustomerInfo.Instance.DeleteCustomer(IDKhachHang);
                ReloadData();
            }            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CustomerDetailForm form = new CustomerDetailForm(ID);
            form.reload += ReloadData;
            form.ShowDialog();            
        }

        private void search(object sender, EventArgs e)
        {
            string searchBy = searchByComboBox.Texts;
            string searchString = searchTextbox.Texts;
            dataGridView1.DataSource = BLLCustomerInfo.Instance.SearchCustomerList(searchString, searchBy);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<KhachHang> list = new List<KhachHang>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                list.Add(BLLCustomerInfo.Instance.GetCustomerByID(row.Cells[0].Value.ToString()));
            dataGridView1.DataSource = BLLCustomerInfo.Instance.SortCustomerList(list);
        }

        
    }
}
