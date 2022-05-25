using CafeShop.BLL;
using System;
using System.Windows.Forms;
using CafeShop.DTO;
namespace CafeShop.View.AdForm
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void importRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (importRadioButton.Checked)
                totalTextbox.Enabled = true;
            else
                totalTextbox.Enabled = false;
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaHangHoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                GoodsInfoForm form = new GoodsInfoForm(MaHangHoa);
                form.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaHangHoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var goods = BLLWarehouse.Instance.GetHangHoaByMa(MaHangHoa);
                if (goods.SoLuong > 0)
                    MessageBox.Show("Cảnh báo"); //////
                else
                    BLLWarehouse.Instance.DeleteGoods(goods);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GoodsForm form = new GoodsForm();
            form.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(importRadioButton.Checked)
            {
                
            }    
            else
            {

            }    
        }
    }
}
