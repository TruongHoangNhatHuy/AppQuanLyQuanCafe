using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CafeShop.View.CustomControl;
namespace CafeShop.View.EmpForm
{
    public partial class OrderForm : Form
    {
        private static List<FlowLayoutPanel> panelList = new List<FlowLayoutPanel>();
        private TablesButton currentTableButton;
        private Ban currentTable;

        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            areaJCombobox.Items.Add(new KhuvucCBItem { ID = "0", Name = "Tất cả" });
            areaJCombobox.Items.AddRange(BLLOrder.Instance.GetKhuvucCBItem().ToArray());
            areaJCombobox.SelectedIndex = 0;
            LoadTableFromDB();
            LoadCategoryFood();
            HidePanel();
        }
        #region CreateDynamicComponents
        private void LoadCategoryFood()
        {
            foreach (var danhmuc in BLLOrder.Instance.GetDanhMucThucDon())
            {
                CustomControl.JButton button = new CustomControl.JButton()
                {
                    Text = danhmuc.TenDanhMuc,
                    Name = danhmuc.MaDanhMuc,
                    Width = 100,
                    ForeColor = Color.Black,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
                };
                button.Click += new EventHandler(ShowDetailFood);
                categoryFoodPanel.Controls.Add(button);
            }
        }
        public void ShowDetailFood(object sender, EventArgs e)
        {
            foodPanel.Controls.Clear();
            foodPanel.Visible = true;
            CustomControl.JButton button = sender as CustomControl.JButton;
            string MaDanhMuc = button.Name;
            foreach (var mon in BLLOrder.Instance.GetMonByMaDanhMuc(MaDanhMuc))
            {
                Label foodNameLabel = new Label();
                Label foodPriceLabel = new Label();
                Panel foodDetailPanel = new Panel();
                //
                //foodNameLabel
                //
                foodNameLabel.Text = mon.TenMon;
                foodNameLabel.Name = mon.MaMon;
                foodNameLabel.ForeColor = Color.Crimson;
                foodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                foodNameLabel.Dock = DockStyle.Fill;
                foodNameLabel.Click += new EventHandler(openDetailOrderForm);
                //
                //fooodPriceLabel
                //
                foodPriceLabel.Text = mon.DonGia.ToString();
                foodPriceLabel.ForeColor = Color.Black;
                foodPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                foodPriceLabel.Dock = DockStyle.Right;
                //
                //foodPanel
                //
                foodDetailPanel.Name = mon.MaMon;
                foodDetailPanel.Width = foodPanel.Width - 5;
                foodDetailPanel.BackColor = SystemColors.ControlLight;
                foodDetailPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
                foodDetailPanel.BorderStyle = BorderStyle.FixedSingle;
                foodDetailPanel.Controls.Add(foodPriceLabel);
                foodDetailPanel.Controls.Add(foodNameLabel);
                foodDetailPanel.Height = 40;
                foodDetailPanel.BringToFront();
                foodDetailPanel.Click += new EventHandler(openDetailOrderForm);
                foodPanel.Padding = new System.Windows.Forms.Padding(3);
                foodPanel.Controls.Add(foodDetailPanel);
            }
        }
        public void LoadTableFromDB()
        {
            foreach (KhuVuc khuvuc in BLLOrder.Instance.GetAllKhuvuc())
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
        #endregion

        #region EventHandler
        private void openDetailOrderForm(object sender, EventArgs e)
        {
            string MaMon = "";
            if (sender is Label)
                sender = (sender as Label).Parent;
            MaMon = (sender as Panel).Name;
            //string MaHoaDon = BLLOrder.Instance.CreateNewBill(currentTable.MaBan).MaHoaDon;
            string MaHoaDon = BLLOrder.Instance.GetHoaDonByMaBan(currentTable.MaBan).MaHoaDon;
            DetailOrderForm form = new DetailOrderForm(MaMon, MaHoaDon);
            form.ReloadInfo += new DetailOrderForm.ReloadOrderList(LoadOrderList);
            form.ShowDialog();
            SetInfoTable(currentTable.MaBan);
        }

        private void HidePanel()
        {
            tableInfoTable.Visible = buttonPanel1.Visible = orderDetailsDataPanel.Visible =
            orderDetailsPanel.Visible = foodPanel.Visible = categoryFoodPanel.Visible = false;
        }
        private void ShowPanel()
        {
            tableInfoTable.Visible = buttonPanel1.Visible = orderDetailsDataPanel.Visible =
            orderDetailsPanel.Visible = true;
        }
        private void ShowInfoTable(object sender, EventArgs e)
        {
            HidePanel();
            CustomControl.JButton button = sender as CustomControl.JButton;
            TablesButton tablesButton = button.Parent as TablesButton;
            this.currentTableButton = tablesButton;
            this.currentTable = BLLOrder.Instance.GetBanByMaBan(tablesButton.MaBan);
            SetInfoTable(tablesButton.MaBan);            
            ShowPanel();
            LoadOrderList();

        }
        public void SetInfoTable(string MaBan)
        {
            orderButton.Enabled = currentTableButton.Status.Equals("Bận");
            tableNameLabel.Text = this.currentTable.TenBan;
            statusTable.Text = this.currentTable.TinhTrang ? "Còn trống" : "Bận";
            //if (statusTable.Text == "Bận")
            //    timeInfoLabel.Text = BLLOrder.Instance.GetHoaDonByMaBan(MaBan).ThoiGianThanhToan.ToString();
            //else
            //    timeInfoLabel.Text = "";
            if (statusTable.Text == "Còn trống")
            {
                timeInfoLabel.Text = "";
                stateButton.Text = "Mở bàn";
            }
            else
            {
                timeInfoLabel.Text = BLLOrder.Instance.GetHoaDonByMaBan(MaBan).ThoiGianThanhToan.ToString();
                if (BLLOrder.Instance.GetDonGoiMonViewsByMaBan(currentTable.MaBan).Count == 0)
                    stateButton.Text = "Đóng bàn";
                else
                    stateButton.Text = "Thanh toán";
            }
        }
        public void LoadOrderList()
        {
            var list = BLLOrder.Instance.GetDonGoiMonViewsByMaBan(currentTable.MaBan);
            if (list == null || list.Count == 0)
            {
                orderDetailsPanel.Visible = orderDetailsDataPanel.Visible = false;
                orderListDataGridView.DataSource = null;
            }
            else
            {
                list.Reverse();
                orderListDataGridView.DataSource = list;
                ShowPanel();
            }
            //orderListDataGridView.DataSource = BLLOrder.Instance.GetDonGoiMonViewsByMaBan(currentTable.MaBan);
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
        }
        private void ChangeStateTable()
        {
            if (currentTableButton.Status.Equals("Còn trống"))
                currentTableButton.Status = "Bận";
            else
                currentTableButton.Status = "Còn trống";
            BLLOrder.Instance.SaveTableState(currentTable.MaBan);
            currentTableButton.GUI();
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            categoryFoodPanel.Visible = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (currentTableButton.Status.Equals("Còn trống"))
                OpenTable();
            else
                if (BLLOrder.Instance.GetDonGoiMonViewsByMaBan(currentTable.MaBan).Count == 0)
                CloseTable();
            else
                chargeBill();
        }
        private void OpenTable()
        {
            orderButton.Enabled = true;
            ChangeStateTable();
            BLLOrder.Instance.CreateNewBill(currentTable.MaBan);
            SetInfoTable(currentTable.MaBan);
        }
        private void chargeBill()
        {
            BillForm form = new BillForm(currentTable.MaBan);
            form.ReloadTable += new BillForm.ReloadTableDelegate(ChangeStateTable);
            form.ReloadInfo += new BillForm.ReloadTableInfoDelegate(SetInfoTable);
            form.ShowDialog();
        }
        private void CloseTable()
        {
            BLLOrder.Instance.DeleteEmptyBill(currentTable.MaBan);
            ChangeStateTable();
            SetInfoTable(currentTable.MaBan);
        }

        #endregion



    }
}
