using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CafeShop.View.AdForm
{
    public partial class TableForm : Form
    {
        private List<Ban> TableList;
        public delegate void Reload();
        public Reload reload;
        public TableForm()
        {
            InitializeComponent();            
        }
        #region EventHandler
        private void TableForm_Load(object sender, EventArgs e)
        {
            LoadComboboxItem();            
            ClearInfoTable();
            areaJCombobox.SelectedIndex = 0;
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
        public void Show(string MaKhuVuc, string searchText = "")
        {
            //dataGridView1.DataSource = BLLTable.Instance.SearchTable(MaKhuVuc, searchText);
            TableList = BLLTable.Instance.SearchTable(MaKhuVuc, searchText);
            TotalPage = (TableList.Count / PageSize);
            if (TableList.Count % PageSize > 0)
                TotalPage++;
            CurrentIndex = 1;
            SetPage();
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

        #region EventHandler-DetailInfo
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
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var MaBan = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();
                if (BLLTable.Instance.DeleteTable(MaBan))
                    Show("0");
                else
                    MessageBox.Show("Không thể xoá bàn do bàn đang được mở");
            }
        }
        private void addTableButton_Click(object sender, EventArgs e)
        {
            ClearInfoTable();
            tableNameTextbox.Enabled = areaNameCombobox.Enabled = true;
            tableIDTextbox.Texts = BLLTable.Instance.NewTableKey();
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
            if ((state == ExecuteState.AddTable || state == ExecuteState.Update))
            {
                if (areaNameCombobox.SelectedItem == null && tableNameTextbox.Texts == "")
                {
                    notifycationLabel.Text = "*Thiếu thông tin";
                    return;
                };
                Ban ban = new Ban()
                {
                    MaKhuVuc = (areaNameCombobox.SelectedItem as KhuvucCBItem).ID,
                    TenBan = tableNameTextbox.Texts,
                    MaBan = tableIDTextbox.Texts,
                    TinhTrang = true,
                };
                BLLTable.Instance.Execute(ban);
                Show("0");
            }
            else if (state == ExecuteState.AddArea)
            {
                if(areaIDTextbox.Texts == "")
                {
                    notifycationLabel.Text = "*Thiếu thông tin";
                    return;
                }    
                KhuVuc khuVuc = new KhuVuc()
                {
                    MaKhuVuc = BLLTable.Instance.NewAreaKey(),
                    TenKhuVuc = areaIDTextbox.Texts
                };
                BLLTable.Instance.AddArea(khuVuc);
                LoadComboboxItem();
            }
            ClearInfoTable();
        }
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
        enum ExecuteState
        {
            None,
            AddTable,
            Update,
            AddArea
        }
        #endregion

        #region Pagination
        private const int PageSize = 10;
        private int CurrentIndex = 1;
        private int TotalPage = 0;

        private void SetPage()
        {
            if (TableList != null)
            {
                dataGridView1.DataSource = BLLTable.Instance.GetCurrentRecord(CurrentIndex, PageSize, TableList);
                pageLabel.Text = $" {CurrentIndex}  /  {TotalPage} ";
            }
        }
        
        private void firstPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = 1;
            SetPage();
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 1)
            {
                CurrentIndex--;
                SetPage();
            }               
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < TotalPage)
            {
                CurrentIndex++;
                SetPage();
            }                
        }

        private void lastPageButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = TotalPage;
            SetPage();
        }
        #endregion
    }

}
