using CafeShop.BLL;
using System;
using System.Windows.Forms;

namespace CafeShop.View.EmpForm
{
    public partial class DetailOrderForm : Form
    {
        //string MaMon = "M00000001";
        public DetailOrderForm(string MaMon = "M00000001")
        {
            InitializeComponent();
            BLLDetailOrder.Instance.SetDish(MaMon);
            foodLabel.Text = BLLDetailOrder.Instance.ShowDetail();
            quantityTextbox.Texts = "0";
            totalTextbox.Texts = "0";
        }
        private void quantityTextbox__TextChanged(object sender, EventArgs e)
        {
            int SoLuong = 0;
            try
            {
                SoLuong = Convert.ToInt32(quantityTextbox.Texts);
                if (SoLuong >= 0)
                    totalTextbox.Texts = BLLDetailOrder.Instance.CalculatePrice(SoLuong).ToString();
                else
                    totalTextbox.Texts = "Số lượng phải lớn hơn 0";
            }
            catch (Exception ex) { }
            
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            int SoLuong = 0;
            try
            {
                SoLuong = Convert.ToInt32(quantityTextbox.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đúng định dạng số", "Cảnh Báo");
                return;
            }
            
            string GhiChu = descriptionTextbox.Texts;
            BLLDetailOrder.Instance.ConfirmDetailOrder(SoLuong, GhiChu);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
