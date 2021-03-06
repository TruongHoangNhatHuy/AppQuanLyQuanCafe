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
    public partial class EmpInfoForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public EmpInfoForm()
        {
            InitializeComponent();                       
        }
        private void EmpInfoForm_Load(object sender, EventArgs e)
        {
            ReloadData();
            searchByComboBox.Items.AddRange(new string[] { "Tìm kiếm theo", "Theo ID", "Theo tên đăng nhập", "Theo họ tên", "Theo ngày sinh", "Theo địa chỉ", "Theo số điện thoại", "Theo ngày bắt đầu", "Theo vai trò" });
            searchByComboBox.SelectedIndex = 0;
        }
        public void ReloadData()
        {
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }
        private void adButton_Click(object sender, EventArgs e)
        {
            EmpDetailForm form = new EmpDetailForm();
            form.reload += ReloadData;
            form.ShowDialog();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá tài khoản có mã {ID} không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                BLLEmpInfo.Instance.DeleteAccount(ID);
                ReloadData();
            }                
        }
        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                BLLEmpInfo.Instance.ResetPassword(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EmpDetailForm form = new EmpDetailForm(ID);
            form.reload += ReloadData;
            form.ShowDialog();
        }

        private void search(object sender, EventArgs e)
        {
            string searchBy = searchByComboBox.Texts;
            string searchString = searchTextbox.Texts;
            dataGridView1.DataSource = BLLEmpInfo.Instance.SearchAccountList(searchString, searchBy);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<TaiKhoanView> list = new List<TaiKhoanView>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                list.Add(BLLEmpInfo.Instance.GetAccountByID(row.Cells[0].Value.ToString()));
            dataGridView1.DataSource = BLLEmpInfo.Instance.SortAccountList(list);
        }        
    }
}
