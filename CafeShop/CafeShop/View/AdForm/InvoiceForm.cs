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
        public Reload reload;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            sortCombobox.Items.AddRange(new string[] { "Theo mã hoá đơn", "Theo thời gian", "Theo giá trị" });
            fromPicker.Value = new DateTime(2022, 1, 1);
            dataGridView1.DataSource = BLLInvoice.Instance.GetAllHoaDonView();         
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }
        private List<HoaDon> GetHoaDon()
        {
            DateTime from = fromPicker.Value, to = toPicker.Value;  
            string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;
            return BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            //DateTime from = fromPicker.Value, to = toPicker.Value;
            //string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;
            //var list = BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
            dataGridView1.DataSource = BLLInvoice.Instance.ChangeView(GetHoaDon());   
        }
        public string lastOrder;
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (sortCombobox.SelectedItem != null)
            {
                //DateTime from = fromPicker.Value, to = toPicker.Value;
                //string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;     
                //var list = BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
                string orderBy = sortCombobox.SelectedItem.ToString();
                bool SortDirection = false;
                if (orderBy.Equals(lastOrder))
                    SortDirection = !SortDirection;
                else
                {
                    lastOrder = orderBy;
                    SortDirection = false;
                }                    
                dataGridView1.DataSource = BLLInvoice.Instance.Sort(GetHoaDon(), orderBy, SortDirection);
                
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            //DateTime from = fromPicker.Value, to = toPicker.Value;
            //string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;
            //var list = BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
            var list = GetHoaDon();
            billCountLabel.Text = BLLInvoice.Instance.GetBillCount(list);
            customerCountLabel.Text = BLLInvoice.Instance.GetCustomerCount(list);
            revenueLabel.Text = BLLInvoice.Instance.GetRevenue(list);
        }
    }
}
