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
            label1.Text = "";
            GUI();
        }

        public void GUI()
        {
            dataGridView1.DataSource = BLLWarehouse.Instance.GetAllHangHoa();
            quantityTextbox.Texts = "";
            totalTextbox.Texts = "";
        }

        private void updateMode(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                goodsNameTextbox.Texts = dataGridView1.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
                importRadioButton.Enabled = true;
                updateRadioButton.Enabled = true;
                quantityTextbox.Enabled = true;
                label1.Text = "";
            }
            else
            {
                goodsNameTextbox.Texts = "";
                importRadioButton.Enabled = false;
                updateRadioButton.Enabled = false;
                quantityTextbox.Enabled = false;
                label1.Text = "";
            }
        }

        private void importRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (importRadioButton.Checked)
            {
                quantityLabel.Text = "Số lượng";
                label1.Text = "";
                totalTextbox.Enabled = true;
            }
            else
            {
                quantityLabel.Text = "Số lượng còn lại";
                totalTextbox.Texts = "0";
                label1.Text = "";
                totalTextbox.Enabled = false;
            }
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
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                        return;
                }
                BLLWarehouse.Instance.DeleteGoods(goods);
                GUI();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GoodsForm form = new GoodsForm();
            form.ShowDialog();
            GUI();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                GoodsForm form = new GoodsForm(dataGridView1.SelectedRows[0].Cells["MaHangHoa"].Value.ToString());
                form.ShowDialog();
                GUI();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MaHangHoa = dataGridView1.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
                int ThanhToan = Convert.ToInt32(totalTextbox.Texts);
                int Soluong = Convert.ToInt32(quantityTextbox.Texts);
                if (Soluong <= 0)
                    throw new Exception("Số lượng phải lớn hơn 0");
                if (importRadioButton.Checked)
                {
                    LoHang loHang = new LoHang
                    {
                        MaLoHang = PrimaryKeyGenerator.OrderBillPrimaryKey(),
                        MaHangHoa = MaHangHoa,
                        SoLuongNhap = Soluong,
                        NgayNhapKho = DateTime.Now,
                        TienThanhToan = ThanhToan,
                        IDNhanVien = BLLLogin.Instance.currentID
                    };
                    BLLWarehouse.Instance.ImportGoods(MaHangHoa,loHang);
                }
                else
                {
                    BLLWarehouse.Instance.ExportGoods(MaHangHoa,Soluong);
                }
                label1.Text = "Cập nhật thành công";
                GUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
