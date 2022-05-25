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
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string MaHangHoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                GoodsInfoForm form = new GoodsInfoForm(MaHangHoa);
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
    }
}
