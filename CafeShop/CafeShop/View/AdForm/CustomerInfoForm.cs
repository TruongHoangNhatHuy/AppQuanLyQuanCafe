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
        private List<KhachHangView> CustomerList;
        public delegate void Reload();
        public Reload reload;
        public CustomerInfoForm()
        {
            InitializeComponent();            
        }
        #region EventHandler
        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            ReloadData();
            searchByComboBox.Items.AddRange(new string[] { "Tìm kiếm theo", "Theo ID khách hàng", "Theo họ tên", "Theo số điện thoại", "Theo ngày sinh", "Theo địa chỉ", "Theo ngày đăng kí" });
            searchByComboBox.SelectedIndex = 0;
        }
        public void ReloadData()
        {
            Show();
        }
        public void Show(string searchString = "", string searchBy = "Theo ID khách hàng")
        {
            CustomerList = BLLCustomerInfo.Instance.SearchCustomerList(searchString, searchBy);
            TotalPage = (CustomerList.Count / PageSize);
            if (CustomerList.Count % PageSize > 0)
                TotalPage++;
            CurrentIndex = 1;
            SetPage();
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
            Show(searchString, searchBy);
        }
        
        private string lastOrder;
        private bool SortDirection = false;
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (searchByComboBox.SelectedItem != null)
            {
                string orderBy = searchByComboBox.SelectedItem.ToString();
                if (orderBy.Equals(lastOrder))
                    SortDirection = !SortDirection;
                else
                {
                    lastOrder = orderBy;
                    SortDirection = false;
                }
                CustomerList = BLLCustomerInfo.Instance.Sort(orderBy, SortDirection);
                CurrentIndex = 1;
                SetPage();
            }
        }
        #endregion

        #region Pagination
        private const int PageSize = 10;
        private int CurrentIndex = 1;
        private int TotalPage = 0;

        private void SetPage()
        {
            if (CustomerList != null)
            {
                dataGridView1.DataSource = BLLCustomerInfo.Instance.GetCurrentRecord(CurrentIndex, PageSize, CustomerList);
                pageLabel.Text = $" {CurrentIndex}  /  {TotalPage} ";
            }
        }

        private void firstPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = 1;
            SetPage();
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 1)
            {
                CurrentIndex--;
                SetPage();
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < TotalPage)
            {
                CurrentIndex++;
                SetPage();
            }
        }

        private void lastPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = TotalPage;
            SetPage();
        }
        #endregion
    }
}
