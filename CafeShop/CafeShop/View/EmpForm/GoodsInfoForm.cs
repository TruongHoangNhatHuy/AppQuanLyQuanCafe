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
namespace CafeShop.View.EmpForm
{
    public partial class GoodsInfoForm : Form
    {
        public GoodsInfoForm(string MaHangHoa = "")
        {
            InitializeComponent();
            HangHoa goods = BLLWarehouse.Instance.GetHangHoaByMa(MaHangHoa);
            if (goods != null)
                InitGUI(goods);
        }
        private void InitGUI(HangHoa goods)
        {
            goodsNameTextbox.Texts = goods.TenHangHoa;
            quantityTextbox.Texts = goods.SoLuong.ToString();
            dataGridView1.DataSource = goods.LoHangs.ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
