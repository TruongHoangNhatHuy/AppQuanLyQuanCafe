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
            this.components = new System.ComponentModel.Container();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.timeButton = new System.Windows.Forms.Button();
            this.subStatisticsPanel = new System.Windows.Forms.Panel();
            this.revenueButton = new System.Windows.Forms.Button();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
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
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.logInfoTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.zoomButton = new CafeShop.View.CustomControl.JButton();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.funcNameLabel = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.jDropDownMenu1 = new CafeShop.View.CustomControl.DropDownMenu.JDropDownMenu(this.components);
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenuPanel.SuspendLayout();
            this.subStatisticsPanel.SuspendLayout();
            this.subFacilityPanel.SuspendLayout();
            this.subPersonPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.jDropDownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.AutoScroll = true;
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.sideMenuPanel.Controls.Add(this.timeButton);
            this.sideMenuPanel.Controls.Add(this.subStatisticsPanel);
            this.sideMenuPanel.Controls.Add(this.statisticsButton);
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
            // timeButton
            // 
            this.timeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeButton.Location = new System.Drawing.Point(0, 651);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(173, 50);
            this.timeButton.TabIndex = 9;
            this.timeButton.UseVisualStyleBackColor = true;
            // 
            // subStatisticsPanel
            // 
            this.subStatisticsPanel.Controls.Add(this.revenueButton);
            this.subStatisticsPanel.Controls.Add(this.invoiceButton);
            this.subStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subStatisticsPanel.Location = new System.Drawing.Point(0, 518);
            this.subStatisticsPanel.Name = "subStatisticsPanel";
            this.subStatisticsPanel.Size = new System.Drawing.Size(173, 133);
            this.subStatisticsPanel.TabIndex = 8;
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
            this.statisticsButton.Location = new System.Drawing.Point(0, 468);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(173, 50);
            this.statisticsButton.TabIndex = 7;
            this.statisticsButton.Text = "Thống kê";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
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
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(173, 80);
            this.mainPanel.TabIndex = 0;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.titleBarPanel.Controls.Add(this.logInfoTextbox);
            this.titleBarPanel.Controls.Add(this.zoomButton);
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.funcNameLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(190, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1138, 80);
            this.titleBarPanel.TabIndex = 1;
            // 
            // logInfoTextbox
            // 
            this.logInfoTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInfoTextbox.BackColor = System.Drawing.Color.DodgerBlue;
            this.logInfoTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.logInfoTextbox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.logInfoTextbox.BorderSize = 2;
            this.logInfoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInfoTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.logInfoTextbox.Location = new System.Drawing.Point(866, 39);
            this.logInfoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.logInfoTextbox.Multiline = false;
            this.logInfoTextbox.Name = "logInfoTextbox";
            this.logInfoTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.logInfoTextbox.PasswordChar = false;
            this.logInfoTextbox.ReadOnly = true;
            this.logInfoTextbox.Size = new System.Drawing.Size(246, 35);
            this.logInfoTextbox.TabIndex = 3;
            this.logInfoTextbox.Texts = "";
            this.logInfoTextbox.UnderlinedStyle = false;
            this.logInfoTextbox.Click += new System.EventHandler(this.logInfoTextbox_Click);
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
            // funcNameLabel
            // 
            this.funcNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.funcNameLabel.AutoSize = true;
            this.funcNameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcNameLabel.Location = new System.Drawing.Point(36, 16);
            this.funcNameLabel.Name = "funcNameLabel";
            this.funcNameLabel.Size = new System.Drawing.Size(188, 47);
            this.funcNameLabel.TabIndex = 0;
            this.funcNameLabel.Text = "Trang Chủ";
            this.funcNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ClockTimer
            // 
            this.ClockTimer.Tick += new System.EventHandler(this.Clocktimer_Tick);
            // 
            // jDropDownMenu1
            // 
            this.jDropDownMenu1.IsMainMenu = false;
            this.jDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.jDropDownMenu1.MenuItemHeight = 25;
            this.jDropDownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.jDropDownMenu1.Name = "jDropDownMenu1";
            this.jDropDownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.jDropDownMenu1.Size = new System.Drawing.Size(172, 70);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeShop.Properties.Resources.cafe;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.subStatisticsPanel.ResumeLayout(false);
            this.subFacilityPanel.ResumeLayout(false);
            this.subPersonPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.jDropDownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button statisticsButton;
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
        private System.Windows.Forms.Button revenueButton;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Label funcNameLabel;
        private System.Windows.Forms.Panel childFormPanel;
        private CustomControl.JButton zoomButton;
        private CustomControl.JButton minimizeButton;
        private CustomControl.JTextbox logInfoTextbox;
        private CustomControl.DropDownMenu.JDropDownMenu jDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

