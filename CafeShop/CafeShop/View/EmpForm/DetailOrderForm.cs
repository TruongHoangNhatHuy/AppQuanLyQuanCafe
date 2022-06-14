using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Windows.Forms;
namespace CafeShop.View.EmpForm
{
    public partial class DetailOrderForm : Form
    {
        public delegate void ReloadOrderList();
        public ReloadOrderList ReloadInfo { get; set; }
        string MaMon, MaHoaDon;
        public DetailOrderForm(string MaMon, string MaHoaDon)
        {
            InitializeComponent();
            this.MaMon = MaMon;
            this.MaHoaDon = MaHoaDon;
            GUI();
        }

        public void GUI()
        {
            foodLabel.Text = BLLDetailOrder.Instance.ShowDetail(MaMon);
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
                    totalTextbox.Texts = BLLDetailOrder.Instance.CalculatePrice(MaMon, SoLuong).ToString();
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
                    BLLDetailOrder.Instance.ConfirmDetailOrder(MaHoaDon,MaMon, SoLuong, GhiChu);
                    ReloadInfo?.Invoke();
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
