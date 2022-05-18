using CafeShop.BLL;
using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace CafeShop.View.EmpForm
{
    public partial class OrderForm : Form
    {
        private List<FlowLayoutPanel> panelList = new List<FlowLayoutPanel>();
        private TablesButton currentTableButton;
        private Ban currentTable;

        public OrderForm()
        {
            InitializeComponent();
            
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            areaComboBox.Items.Add(new KhuvucCBItem { ID = "0", Name = "Tất cả" });
            areaComboBox.Items.AddRange(BLLOrder.Instance.GetKhuvucCBItem().ToArray());
            LoadTableFromDB();
            LoadCategoryFood();
            HidePanel();
        }
        #region Create dynamic Components
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
                foodNameLabel.Dock = DockStyle.Left;
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
                foodDetailPanel.Controls.Add(foodNameLabel);
                foodDetailPanel.Controls.Add(foodPriceLabel);
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
            DetailOrderForm form = new DetailOrderForm(MaMon);
            form.ShowDialog();
        }

        private void HidePanel()
        {
            tableInfoTable.Visible = buttonPanel1.Visible = buttonPanel2.Visible =
            foodPanel.Visible = categoryFoodPanel.Visible = false;
        }
        private void ShowPanel()
        {
            tableInfoTable.Visible = buttonPanel1.Visible = buttonPanel2.Visible = true;
        }
        private void ShowInfoTable(object sender, EventArgs e)
        {
            HidePanel();
            CustomControl.JButton button = sender as CustomControl.JButton;
            TablesButton tablesButton = button.Parent as TablesButton;
            this.currentTableButton = tablesButton;
            this.currentTable = BLLOrder.Instance.GetBanByMaBan(tablesButton.MaBan);
            SetInfoTable();
            ShowPanel();

        }
        public void SetInfoTable()
        {
            orderButton.Enabled = currentTableButton.Status.Equals("Bận");
            tableNameLabel.Text = this.currentTable.TenBan;
            statusTable.Text = this.currentTable.TinhTrang ? "Còn trống" : "Bận";
        }

        public void LoadTableByLocation(string MaKhuVuc)
        {
            if (MaKhuVuc.Equals("0"))
                panelList.ForEach(panel => panel.Visible = true);
            else if (MaKhuVuc != null)
                panelList.ForEach(panel => panel.Visible = panel.Name.Equals(MaKhuVuc));

        }
        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKhuVuc = (areaComboBox.SelectedItem as KhuvucCBItem).ID;
            LoadTableByLocation(MaKhuVuc);
        }

        private void ChangeStateTable()
        {
            if (currentTableButton.Status.Equals("Còn trống"))
                currentTableButton.Status = "Bận";
            else
                currentTableButton.Status = "Còn trống";
            currentTableButton.GUI();
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            categoryFoodPanel.Visible = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (currentTableButton.Status.Equals("Còn trống"))
            {
                orderButton.Enabled = true;
                ChangeStateTable();
                SetInfoTable();
            }

        }
        #endregion

        
    }
}
