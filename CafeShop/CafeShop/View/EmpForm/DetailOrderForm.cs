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

namespace CafeShop.View.EmpForm
{
    public partial class DetailOrderForm : Form
    {
        string MaMon = "M00000001";
        public DetailOrderForm()
        {
            InitializeComponent();
            BLLDetailOrder.Instance.SetDish(MaMon);
            label1.Text = BLLDetailOrder.Instance.ShowDetail();
            quantityTextbox.Texts = "0";
            totalTextbox.Texts = "0";
        }

        private void quantityTextbox__TextChanged(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(quantityTextbox.Texts);
            if (SoLuong >= 0)
                totalTextbox.Texts = BLLDetailOrder.Instance.CalculatePrice(SoLuong).ToString();
            else
                totalTextbox.Texts = "Số lượng phải lớn hơn 0";
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(quantityTextbox.Texts);
            string GhiChu = descriptionTextbox.Texts;
            BLLDetailOrder.Instance.ConfirmDetailOrder(SoLuong,GhiChu);
            this.Close();
        }
    }
}
