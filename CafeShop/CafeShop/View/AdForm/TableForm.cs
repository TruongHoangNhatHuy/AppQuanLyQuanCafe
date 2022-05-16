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
    public partial class TableForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public TableForm()
        {
            InitializeComponent();
            areaCombobox.Items.Add(new KhuvucCBItem { ID = "0", Name = "Tất cả" });
            areaCombobox.Items.AddRange(BLLTable.Instance.GetKhuvucCBItem().ToArray());
        }
        public void Show(string MaKhuVuc, string searchText = "")
        {
            dataGridView1.DataSource = BLLTable.Instance.SearchTable(MaKhuVuc, searchText);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            reload?.Invoke();
            this.Close();
            
        }

        private void areaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaCombobox.SelectedItem as KhuvucCBItem).ID;
            Show(MaKhuVuc);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaCombobox.SelectedItem as KhuvucCBItem).ID;
            string searchText = searchTextbox.Texts;
            Show(MaKhuVuc, searchText);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                List<string> delList = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    delList.Add(row.Cells["MaBan"].Value.ToString());
                BLLTable.Instance.DeleteTable(delList);
            }    
        }
    }
}
