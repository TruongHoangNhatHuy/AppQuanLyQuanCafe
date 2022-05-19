namespace CafeShop.View
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.subStatisticsPanel = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.revenueButton = new System.Windows.Forms.Button();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.subFacilityPanel = new System.Windows.Forms.Panel();
            this.warehouseButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.facilityButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.subPersonPanel = new System.Windows.Forms.Panel();
            this.cusButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.personalButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.AdNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.zoomButton = new CafeShop.View.CustomControl.JButton();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.label1 = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.subStatisticsPanel.SuspendLayout();
            this.subFacilityPanel.SuspendLayout();
            this.subPersonPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.sideMenuPanel.Controls.Add(this.logoutButton);
            this.sideMenuPanel.Controls.Add(this.subStatisticsPanel);
            this.sideMenuPanel.Controls.Add(this.statisticsButton);
            this.sideMenuPanel.Controls.Add(this.scheduleButton);
            this.sideMenuPanel.Controls.Add(this.subFacilityPanel);
            this.sideMenuPanel.Controls.Add(this.facilityButton);
            this.sideMenuPanel.Controls.Add(this.menuButton);
            this.sideMenuPanel.Controls.Add(this.subPersonPanel);
            this.sideMenuPanel.Controls.Add(this.personalButton);
            this.sideMenuPanel.Controls.Add(this.homeButton);
            this.sideMenuPanel.Controls.Add(this.mainPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(190, 675);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = global::CafeShop.Properties.Resources.log_out;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 701);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(173, 50);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Thoát";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // subStatisticsPanel
            // 
            this.subStatisticsPanel.Controls.Add(this.changeButton);
            this.subStatisticsPanel.Controls.Add(this.revenueButton);
            this.subStatisticsPanel.Controls.Add(this.invoiceButton);
            this.subStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subStatisticsPanel.Location = new System.Drawing.Point(0, 568);
            this.subStatisticsPanel.Name = "subStatisticsPanel";
            this.subStatisticsPanel.Size = new System.Drawing.Size(173, 133);
            this.subStatisticsPanel.TabIndex = 8;
            // 
            // changeButton
            // 
            this.changeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeButton.FlatAppearance.BorderSize = 0;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Image = global::CafeShop.Properties.Resources.book_multiple;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeButton.Location = new System.Drawing.Point(0, 90);
            this.changeButton.Name = "changeButton";
            this.changeButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.changeButton.Size = new System.Drawing.Size(173, 45);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Sổ thu chi";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // revenueButton
            // 
            this.revenueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.revenueButton.FlatAppearance.BorderSize = 0;
            this.revenueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueButton.Image = global::CafeShop.Properties.Resources.cash_multiple;
            this.revenueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenueButton.Location = new System.Drawing.Point(0, 45);
            this.revenueButton.Name = "revenueButton";
            this.revenueButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.revenueButton.Size = new System.Drawing.Size(173, 45);
            this.revenueButton.TabIndex = 1;
            this.revenueButton.Text = "Doanh thu";
            this.revenueButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revenueButton.UseVisualStyleBackColor = true;
            this.revenueButton.Click += new System.EventHandler(this.revenueButton_Click);
            // 
            // invoiceButton
            // 
            this.invoiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.invoiceButton.FlatAppearance.BorderSize = 0;
            this.invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceButton.Image = global::CafeShop.Properties.Resources.receipt_outline;
            this.invoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invoiceButton.Location = new System.Drawing.Point(0, 0);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.invoiceButton.Size = new System.Drawing.Size(173, 45);
            this.invoiceButton.TabIndex = 0;
            this.invoiceButton.Text = "Hoá đơn";
            this.invoiceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoiceButton.UseVisualStyleBackColor = true;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Image = global::CafeShop.Properties.Resources.statistics;
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(0, 518);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(173, 50);
            this.statisticsButton.TabIndex = 7;
            this.statisticsButton.Text = "Thống kê";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.scheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleButton.Location = new System.Drawing.Point(0, 468);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(173, 50);
            this.scheduleButton.TabIndex = 6;
            this.scheduleButton.Text = "Lịch làm việc";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // subFacilityPanel
            // 
            this.subFacilityPanel.Controls.Add(this.warehouseButton);
            this.subFacilityPanel.Controls.Add(this.tableButton);
            this.subFacilityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subFacilityPanel.Location = new System.Drawing.Point(0, 374);
            this.subFacilityPanel.Name = "subFacilityPanel";
            this.subFacilityPanel.Size = new System.Drawing.Size(173, 94);
            this.subFacilityPanel.TabIndex = 5;
            // 
            // warehouseButton
            // 
            this.warehouseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseButton.Image = global::CafeShop.Properties.Resources.warehouse;
            this.warehouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.warehouseButton.Location = new System.Drawing.Point(0, 45);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.warehouseButton.Size = new System.Drawing.Size(173, 45);
            this.warehouseButton.TabIndex = 1;
            this.warehouseButton.Text = "Kho hàng";
            this.warehouseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButton.FlatAppearance.BorderSize = 0;
            this.tableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableButton.Image = global::CafeShop.Properties.Resources.table_chair;
            this.tableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableButton.Location = new System.Drawing.Point(0, 0);
            this.tableButton.Name = "tableButton";
            this.tableButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.tableButton.Size = new System.Drawing.Size(173, 45);
            this.tableButton.TabIndex = 0;
            this.tableButton.Text = "Bàn";
            this.tableButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // facilityButton
            // 
            this.facilityButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.facilityButton.FlatAppearance.BorderSize = 0;
            this.facilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityButton.Image = global::CafeShop.Properties.Resources.hammer_wrench;
            this.facilityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facilityButton.Location = new System.Drawing.Point(0, 324);
            this.facilityButton.Name = "facilityButton";
            this.facilityButton.Size = new System.Drawing.Size(173, 50);
            this.facilityButton.TabIndex = 4;
            this.facilityButton.Text = "Cơ sở vật chất";
            this.facilityButton.UseVisualStyleBackColor = true;
            this.facilityButton.Click += new System.EventHandler(this.facilityButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Image = global::CafeShop.Properties.Resources.food_outline;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(0, 274);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(173, 50);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Thực đơn";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // subPersonPanel
            // 
            this.subPersonPanel.Controls.Add(this.cusButton);
            this.subPersonPanel.Controls.Add(this.empButton);
            this.subPersonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPersonPanel.Location = new System.Drawing.Point(0, 180);
            this.subPersonPanel.Name = "subPersonPanel";
            this.subPersonPanel.Size = new System.Drawing.Size(173, 94);
            this.subPersonPanel.TabIndex = 2;
            // 
            // cusButton
            // 
            this.cusButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusButton.FlatAppearance.BorderSize = 0;
            this.cusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusButton.Image = global::CafeShop.Properties.Resources.customer;
            this.cusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cusButton.Location = new System.Drawing.Point(0, 45);
            this.cusButton.Name = "cusButton";
            this.cusButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cusButton.Size = new System.Drawing.Size(173, 45);
            this.cusButton.TabIndex = 1;
            this.cusButton.Text = "Khách hàng";
            this.cusButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cusButton.UseVisualStyleBackColor = true;
            this.cusButton.Click += new System.EventHandler(this.cusButton_Click);
            // 
            // empButton
            // 
            this.empButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.empButton.FlatAppearance.BorderSize = 0;
            this.empButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empButton.Image = global::CafeShop.Properties.Resources.EmployeeIcon;
            this.empButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.empButton.Location = new System.Drawing.Point(0, 0);
            this.empButton.Name = "empButton";
            this.empButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.empButton.Size = new System.Drawing.Size(173, 45);
            this.empButton.TabIndex = 0;
            this.empButton.Text = "Nhân viên";
            this.empButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empButton.UseVisualStyleBackColor = true;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // personalButton
            // 
            this.personalButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalButton.FlatAppearance.BorderSize = 0;
            this.personalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalButton.Image = global::CafeShop.Properties.Resources.card_account_details_outline;
            this.personalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalButton.Location = new System.Drawing.Point(0, 130);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(173, 50);
            this.personalButton.TabIndex = 1;
            this.personalButton.Text = "Nhân sự";
            this.personalButton.UseVisualStyleBackColor = true;
            this.personalButton.Click += new System.EventHandler(this.personalButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = global::CafeShop.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 80);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(173, 50);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Trang chủ";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.AdNameLabel);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(173, 80);
            this.mainPanel.TabIndex = 0;
            // 
            // AdNameLabel
            // 
            this.AdNameLabel.AutoSize = true;
            this.AdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdNameLabel.Location = new System.Drawing.Point(3, 27);
            this.AdNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdNameLabel.Name = "AdNameLabel";
            this.AdNameLabel.Size = new System.Drawing.Size(136, 20);
            this.AdNameLabel.TabIndex = 0;
            this.AdNameLabel.Text = "Tên chủ cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủ cửa hàng";
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.titleBarPanel.Controls.Add(this.zoomButton);
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.label1);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(190, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1138, 80);
            this.titleBarPanel.TabIndex = 1;
            // 
            // zoomButton
            // 
            this.zoomButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zoomButton.BackColor = System.Drawing.Color.Transparent;
            this.zoomButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.zoomButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.zoomButton.BorderRadius = 0;
            this.zoomButton.BorderSize = 0;
            this.zoomButton.FlatAppearance.BorderSize = 0;
            this.zoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomButton.ForeColor = System.Drawing.Color.Black;
            this.zoomButton.Image = global::CafeShop.Properties.Resources.full_screen;
            this.zoomButton.Location = new System.Drawing.Point(1090, 3);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(44, 29);
            this.zoomButton.TabIndex = 2;
            this.zoomButton.TextColor = System.Drawing.Color.Black;
            this.zoomButton.UseVisualStyleBackColor = false;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            this.zoomButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.zoomButton.MouseHover += new System.EventHandler(this.button_MouseEnter);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.BorderSize = 0;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = global::CafeShop.Properties.Resources.minimize_sign;
            this.minimizeButton.Location = new System.Drawing.Point(1041, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(44, 29);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextColor = System.Drawing.Color.Black;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang Chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(190, 80);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.childFormPanel.Size = new System.Drawing.Size(1138, 595);
            this.childFormPanel.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1328, 675);
            this.ControlBox = false;
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideMenuPanel.ResumeLayout(false);
            this.subStatisticsPanel.ResumeLayout(false);
            this.subFacilityPanel.ResumeLayout(false);
            this.subPersonPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Panel subFacilityPanel;
        private System.Windows.Forms.Button warehouseButton;
        private System.Windows.Forms.Button tableButton;
        private System.Windows.Forms.Button facilityButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel subPersonPanel;
        private System.Windows.Forms.Button cusButton;
        private System.Windows.Forms.Button empButton;
        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Panel subStatisticsPanel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button revenueButton;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel childFormPanel;
        private CustomControl.JButton zoomButton;
        private CustomControl.JButton minimizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdNameLabel;
    }
}

