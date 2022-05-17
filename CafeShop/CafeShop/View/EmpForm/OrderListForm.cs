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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLLOrderList.Instance.GetOrderListSortByTime();
        }

        private void performButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaDonGoiMon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                BLLOrderList.Instance.StateChange(MaDonGoiMon);
                dataGridView1.DataSource = BLLOrderList.Instance.GetOrderListSortByTime();
            }
        }
    }
}
