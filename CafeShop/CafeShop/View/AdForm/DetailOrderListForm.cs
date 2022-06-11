using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
using CafeShop.DTO;
namespace CafeShop.View.AdForm
{
    public partial class DetailOrderListForm : Form
    {
        public DetailOrderListForm()
        {
            InitializeComponent();
        }
        public DetailOrderListForm(string MaHoaDon)
        {
            InitializeComponent();
            HoaDon bill = BLLInvoice.Instance.GetHoaDonByMaHoaDon(MaHoaDon);
            if (bill != null)
                InitGUI(bill);
        }
        public void InitGUI(HoaDon bill)
        {
            billIDTextbox.ForeColor = timeTextbox.ForeColor = customerNameTextbox.ForeColor = employeeNameTextbox.ForeColor = Color.Crimson;
            billIDTextbox.Texts = bill.MaHoaDon;
            timeTextbox.Texts = bill.ThoiGianThanhToan.ToString();
            customerNameTextbox.Texts = bill.KhachHang.HoTenKH;
            employeeNameTextbox.Texts = bill.TaiKhoan.HoTen;
            totalTextbox.Texts = bill.ThanhTien.ToString();
            surchargeTextbox.Texts = bill.PhuThu;
            discountTextbox.Texts = bill.GiamGia;
            dataGridView1.DataSource = bill.DonGoiMons.ToList();
            
        }
        #region EventHanlder
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            CustomControl.JButton button = (sender as CustomControl.JButton);
            button.BackColor = Color.Crimson;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            CustomControl.JButton button = (sender as CustomControl.JButton);
            button.BackColor = Color.Transparent;
        }
        #endregion
    }
}
