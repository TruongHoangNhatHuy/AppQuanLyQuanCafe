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
    public partial class GoodsForm : Form
    {
        public GoodsForm(string MaHangHoa = "")
        {
            InitializeComponent();
            var goods = BLLWarehouse.Instance.GetHangHoaByMa(MaHangHoa);
            categoryCombobox.Items.AddRange(BLLOrder.Instance.GetDanhMucThucDon().ToArray());
            if (goods != null)
                InitGUI(goods);

        }

        private void InitGUI(HangHoa goods)
        {
            goodsIDTextbox.Texts = goods.MaHangHoa;
            goodsNameLabel.Text = goods.TenHangHoa;
            unitTextbox.Texts = goods.DonVi;
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //check condition first
            HangHoa goods = new HangHoa()
            {
                MaHangHoa = "1234567890",
                TenHangHoa = goodsIDTextbox.Texts,
                DonVi = unitTextbox.Texts,
                SoLuong = 0,
                MaMon = (foodNameCombobox.SelectedItem as Mon).MaMon                
            };
            BLLWarehouse.Instance.AddGoods(goods);
            this.Close();
        }

        private void categoryCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foodNameCombobox.Items.Clear();
            foodNameCombobox.Texts = "";
            foodNameCombobox.SelectedItem = null;
            string MaDanhMuc = (categoryCombobox.SelectedItem as DanhMucThucDon).MaDanhMuc;
            foodNameCombobox.Items.AddRange(BLLOrder.Instance.GetMonByMaDanhMuc(MaDanhMuc).ToArray());
        }
    }
}
