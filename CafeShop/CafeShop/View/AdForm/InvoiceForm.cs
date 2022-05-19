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
            sortCombobox.Items.AddRange(new string[] { "Theo thời gian", "Theo giá trị", "Theo mã hoá đơn" });
            dataGridView1.DataSource = BLLInvoice.Instance.GetAllHoaDonView();
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime from = fromPicker.Value, to = toPicker.Value;
            string MaHoaDon = invoiceTextbox.Texts, TenNhanVien = empTextbox.Texts, TenKhachHang = customerTextbox.Texts;
            var list = BLLInvoice.Instance.Search(from, to, MaHoaDon, TenNhanVien, TenKhachHang);
            dataGridView1.DataSource = BLLInvoice.Instance.ChangeView(list);
            
        }
    }
}
