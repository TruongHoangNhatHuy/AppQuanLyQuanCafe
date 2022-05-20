using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CafeShop.View.AdForm
{
    public partial class TableForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public TableForm()
        {
            InitializeComponent();
            
        }
        private void TableForm_Load(object sender, EventArgs e)
        {
            LoadComboboxItem();
            ClearInfoTable();
        }
        public void LoadComboboxItem()
        {
            areaJCombobox.Items.Clear();
            areaNameCombobox.Items.Clear();
            
            areaJCombobox.Items.Add(new KhuvucCBItem { ID = "0", Name = "Tất cả" });
            areaJCombobox.Items.AddRange(BLLTable.Instance.GetKhuvucCBItem().ToArray());
            areaNameCombobox.Items.AddRange(BLLTable.Instance.GetKhuvucCBItem().ToArray());
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            reload?.Invoke();
            this.Close();

        }
        #region DataGridView
        public void Show(string MaKhuVuc, string searchText = "")
        {
            dataGridView1.DataSource = BLLTable.Instance.SearchTable(MaKhuVuc, searchText);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaJCombobox.SelectedItem as KhuvucCBItem).ID;
            string searchText = searchTextbox.Texts;
            Show(MaKhuVuc, searchText);
        }

        private void areaJCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaJCombobox.SelectedItem as KhuvucCBItem).ID;
            Show(MaKhuVuc);
        }
        #endregion

        #region DetailInfo
        ExecuteState state;
        private void ClearInfoTable()
        {
            areaNameCombobox.SelectedItem = null;
            areaIDTextbox.Texts = "";
            tableIDTextbox.Texts = "";
            tableNameTextbox.Texts = "";
            areaNameCombobox.Enabled = areaIDTextbox.Enabled = tableNameTextbox.Enabled = false;
            notifycationLabel.Text = "";
            state = ExecuteState.None;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> delList = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    delList.Add(row.Cells["MaBan"].Value.ToString());
                BLLTable.Instance.DeleteTable(delList);
                Show("0");
            }
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            ClearInfoTable();
            tableNameTextbox.Enabled = areaNameCombobox.Enabled = true;
            state = ExecuteState.AddTable;
            notifycationLabel.Text = "*Bạn đã chọn thêm một bàn mới";
        }
        private void addAreaButton_Click(object sender, EventArgs e)
        {
            ClearInfoTable();
            state = ExecuteState.AddArea;
            areaIDTextbox.Enabled = true;
            notifycationLabel.Text = "*Bạn đã chọn thêm một khu vực mới";
        }
        private void areaNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (areaNameCombobox.SelectedItem != null)
                areaIDTextbox.Texts = (areaNameCombobox.SelectedItem as KhuvucCBItem).Name;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if ((state == ExecuteState.AddTable || state == ExecuteState.Update) && areaNameCombobox.SelectedItem != null)
            {
                Ban ban = new Ban()
                {
                    MaKhuVuc = (areaNameCombobox.SelectedItem as KhuvucCBItem).ID,
                    TenBan = tableNameTextbox.Texts,
                    MaBan = (state == ExecuteState.Update) ? tableIDTextbox.Texts : "B000000022",
                    TinhTrang = false,
                    KhuVuc = BLLTable.Instance.GetKhuVucByMaKhuVuc((areaNameCombobox.SelectedItem as KhuvucCBItem).ID)
                };
                BLLTable.Instance.Execute(ban);
                Show("0");
            }
            else if (state == ExecuteState.AddArea)
            {
                KhuVuc khuVuc = new KhuVuc()
                {
                    MaKhuVuc = "KV00000013",
                    TenKhuVuc = areaIDTextbox.Texts,
                    SoLuongBan = 0
                };
                BLLTable.Instance.AddArea(khuVuc);
                LoadComboboxItem();
            }
            ClearInfoTable();
        }
        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ClearInfoTable();
                areaNameCombobox.Enabled = tableNameTextbox.Enabled = true;
                state = ExecuteState.Update;
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                areaIDTextbox.Texts = row.Cells["MaKhuVuc"].Value.ToString();
                tableIDTextbox.Texts = row.Cells["MaBan"].Value.ToString();
                tableNameTextbox.Texts = row.Cells["TenBan"].Value.ToString();
                foreach (KhuvucCBItem item in areaNameCombobox.Items)
                    if (item.ID.Equals(row.Cells["MaKhuVuc"].Value.ToString()))
                    {
                        areaNameCombobox.SelectedItem = item;
                        break;
                    }
            }
        }
       
    }
    enum ExecuteState
    {
        None,
        AddTable,
        Update,
        AddArea
    }
}
