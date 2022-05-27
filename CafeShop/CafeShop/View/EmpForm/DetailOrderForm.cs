using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Windows.Forms;
namespace CafeShop.View.EmpForm
{
    public partial class DetailOrderForm : Form
    {
        //string MaMon = "M00000001";
        public delegate void DetailOrderDel(HoaDon bill);
        public DetailOrderDel orderDel;
        public DetailOrderForm(string MaMon, string MaHoaDon)
        {
            InitializeComponent();
            BLLDetailOrder.Instance.SetMaHoaDon(MaHoaDon);
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
                if (SoLuong > 0)
                {
                    string GhiChu = descriptionTextbox.Texts;
                    BLLDetailOrder.Instance.ConfirmDetailOrder(SoLuong, GhiChu);
                    this.Close();
                }
                else
                    throw new Exception("Số lượng phải lớn hơn 0.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
