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
using CafeShop.View.EmpForm;
namespace CafeShop.View.AdForm
{
    public partial class AdminHomeForm : Form
    {
        private static List<FlowLayoutPanel> panelList = new List<FlowLayoutPanel>();
        private TablesButton currentTableButton;
        private Ban currentTable;
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            areaJCombobox.Items.Add(new KhuvucCBItem { ID = "0", Name = "Tất cả" });
            areaJCombobox.Items.AddRange(BLLAdminHome.Instance.GetKhuvucCBItem().ToArray());
            areaJCombobox.SelectedIndex = 0;
            tableInfoTable.Visible = false;
            LoadTopFood();
            LoadTableFromDB();
            StatisticsInDay();
        }
        public void StatisticsInDay()
        {
            billCountLabel.Text = BLLAdminHome.Instance.GetBillCount(DateTime.Now);
            customerCountLabel.Text = BLLAdminHome.Instance.GetCustomerCount(DateTime.Now);
            revenueLabel.Text = BLLAdminHome.Instance.GetRevenue(DateTime.Now);
        }
        public void LoadTopFood()
        {
            var result = BLLAdminHome.Instance.GetFoodStatistics(DateTime.Now);
            for (int i = 0; i < result.Count; i++)
            {
                CustomControl.TopFoodControl line = new CustomControl.TopFoodControl()
                {
                    OrderNumber = (i + 1).ToString(),
                    FoodName = result[i].FoodName,
                    Count = result[i].Count.ToString()
                };
                topFoodLayoutPanel.Controls.Add(line);
            }
        }
        public void LoadTableFromDB()
        {
            foreach (KhuVuc khuvuc in BLLAdminHome.Instance.GetAllKhuvuc())
            {
                Label label = new Label();
                FlowLayoutPanel tablePanel = new FlowLayoutPanel();
                FlowLayoutPanel mainPanel = new FlowLayoutPanel();

                label.Text = khuvuc.TenKhuVuc;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = Color.Crimson;

                tablePanel.FlowDirection = FlowDirection.LeftToRight;
                tablePanel.BackColor = SystemColors.ActiveBorder;
                tablePanel.AutoSize = true;
                foreach (var ban in khuvuc.Bans)
                {
                    TablesButton table = new TablesButton(ban.MaBan, ban.TinhTrang);
                    table._Click += new EventHandler(ShowInfoTable);
                    tablePanel.Controls.Add(table);
                }

                mainPanel.Name = khuvuc.MaKhuVuc;
                mainPanel.FlowDirection = FlowDirection.TopDown;
                mainPanel.AutoSize = true;
                mainPanel.Controls.Add(label);
                mainPanel.Controls.Add(tablePanel);

                areaFlowPanel.Controls.Add(mainPanel);
                panelList.Add(mainPanel);
            }
        }
        private void HidePanel()
        {
            tableInfoTable.Visible = false;
        }
        private void ShowPanel()
        {
            tableInfoTable.Visible = true;
        }
        private void ShowInfoTable(object sender, EventArgs e)
        {
            HidePanel();
            CustomControl.JButton button = sender as CustomControl.JButton;
            TablesButton tablesButton = button.Parent as TablesButton;
            this.currentTableButton = tablesButton;
            this.currentTable = BLLAdminHome.Instance.GetBanByMaBan(tablesButton.MaBan);
            SetInfoTable(tablesButton.MaBan);
            ShowPanel();

        }
        public void SetInfoTable(string MaBan)
        {
            tableNameLabel.Text = this.currentTable.TenBan;
            statusTable.Text = this.currentTable.TinhTrang ? "Còn trống" : "Bận";
            if (statusTable.Text == "Còn trống")
                timeInfoLabel.Text = "";
            else
                timeInfoLabel.Text = BLLAdminHome.Instance.GetHoaDonByMaBan(MaBan).ThoiGianThanhToan.ToString();
        }
        public void LoadTableByLocation(string MaKhuVuc)
        {
            if (MaKhuVuc.Equals("0"))
                panelList.ForEach(panel => panel.Visible = true);
            else if (MaKhuVuc != null)
                panelList.ForEach(panel => panel.Visible = panel.Name.Equals(MaKhuVuc));
        }
        private void areaJCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaJCombobox.SelectedItem as KhuvucCBItem).ID;
            LoadTableByLocation(MaKhuVuc);
            tableInfoTable.Visible = false;
        }
    }
}
