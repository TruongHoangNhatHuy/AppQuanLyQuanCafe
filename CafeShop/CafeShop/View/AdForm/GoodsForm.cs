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
            categoryCombobox.Items.AddRange(BLLOrder.Instance.GetDanhMucThucDon().ToArray());
            GUI(MaHangHoa);
        }

        private void GUI(string MaHangHoa)
        {  
            if (MaHangHoa != "")
            {
                HangHoa goods = BLLWarehouse.Instance.GetHangHoaByMa(MaHangHoa);
                goodsIDTextbox.Texts = goods.MaHangHoa;
                goodsNameLabel.Text = goods.TenHangHoa;
                unitTextbox.Texts = goods.DonVi;
                //lien ket mon
            }
            else
            {
                goodsIDTextbox.Texts = BLLWarehouse.Instance.NewGoodsID();
            }
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
                MaHangHoa = goodsIDTextbox.Texts,
                TenHangHoa = goodsNameTextbox.Texts,
                DonVi = unitTextbox.Texts,
                SoLuong = 0,
                MaMon = (foodNameCombobox.SelectedItem as Mon).MaMon                
            };
            BLLWarehouse.Instance.ExecuteDB(goods);
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
