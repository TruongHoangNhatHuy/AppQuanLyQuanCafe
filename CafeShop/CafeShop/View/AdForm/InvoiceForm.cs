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
    public partial class InvoiceForm : Form
    {
        public delegate void Reload();
        private List<HoaDon> billList;
        public Reload reload;
        public InvoiceForm()
        {
            InitializeComponent();
        }        
        #region EventHandler
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            sortJCombobox.Items.AddRange(new string[] { "Theo mã hoá đơn", "Theo thời gian", "Theo giá trị" });
            fromPicker.Value = new DateTime(2022, 1, 1);
            SetHoaDon();
            SetPage();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaHoaDon = dataGridView1.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();
                DetailOrderListForm form = new DetailOrderListForm(MaHoaDon);
                form.ShowDialog();
            }
        }

        private void Picker_ValueChanged(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
        }

        private void SetHoaDon()
        {
            DateTime from = fromPicker.Value, to = toPicker.Value;
            if (from > to)
            {
                from = to;
                fromPicker.Value = toPicker.Value = from;
            }
            string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;
            var list = BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
            this.billList = list;
            TotalPage = this.billList.Count / PageSize;
            if (this.billList.Count % PageSize > 0)
                TotalPage++;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            SetHoaDon();
            CurrentIndex = 1;
            SetPage();
        }
        private string lastOrder;
        private bool SortDirection = false;
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (sortJCombobox.SelectedItem != null)
            {
                string orderBy = sortJCombobox.SelectedItem.ToString();
                if (orderBy.Equals(lastOrder))
                    SortDirection = !SortDirection;
                else
                {
                    lastOrder = orderBy;
                    SortDirection = false;
                }
                SetHoaDon();
                this.billList = BLLInvoice.Instance.Sort(this.billList, orderBy, SortDirection);
                CurrentIndex = 1;
                SetPage();
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            //SetHoaDon();
            billCountLabel.Text = BLLInvoice.Instance.GetBillCount(this.billList);
            customerCountLabel.Text = BLLInvoice.Instance.GetCustomerCount(this.billList);
            revenueLabel.Text = BLLInvoice.Instance.GetRevenue(this.billList);
        }
        #endregion

        #region Pagination
        private const int PageSize = 6;
        private int CurrentIndex = 1;
        private int TotalPage = 0;
        private void SetPage()
        {
            if(this.billList != null)
            {
                dataGridView1.DataSource = BLLInvoice.Instance.GetCurrentReCord(CurrentIndex, PageSize, this.billList);
                pageLabel.Text = $" {CurrentIndex}  /  {TotalPage} ";
            }                
        }
        private void firstPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = 1;
            SetPage();
        }

        private void lastPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = TotalPage;
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
        #endregion        
    }
}
