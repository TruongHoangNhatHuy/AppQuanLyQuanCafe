namespace CafeShop.View
{
    partial class EmployeeForm
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
            this.warehouseButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.orderListButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.jButton2 = new CafeShop.View.CustomControl.JButton();
            this.jButton1 = new CafeShop.View.CustomControl.JButton();
            this.logInfoTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.zoomButton = new CafeShop.View.CustomControl.JButton();
            this.funcNameLabel = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.Clock_Timer = new System.Windows.Forms.Timer(this.components);
            this.jDropDownMenu1 = new CafeShop.View.CustomControl.DropDownMenu.JDropDownMenu(this.components);
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.jDropDownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.sideMenuPanel.Controls.Add(this.warehouseButton);
            this.sideMenuPanel.Controls.Add(this.timeButton);
            this.sideMenuPanel.Controls.Add(this.orderListButton);
            this.sideMenuPanel.Controls.Add(this.orderButton);
            this.sideMenuPanel.Controls.Add(this.mainPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(190, 675);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // warehouseButton
            // 
            this.warehouseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.warehouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseButton.Location = new System.Drawing.Point(0, 180);
            this.warehouseButton.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(190, 62);
            this.warehouseButton.TabIndex = 11;
            this.warehouseButton.Text = "Kho hàng";
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // timeButton
            // 
            this.timeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeButton.Location = new System.Drawing.Point(0, 625);
            this.timeButton.Margin = new System.Windows.Forms.Padding(4);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(190, 50);
            this.timeButton.TabIndex = 10;
            this.timeButton.UseVisualStyleBackColor = true;
            // 
            // orderListButton
            // 
            this.orderListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderListButton.FlatAppearance.BorderSize = 0;
            this.orderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.orderListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderListButton.Location = new System.Drawing.Point(0, 130);
            this.orderListButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderListButton.Name = "orderListButton";
            this.orderListButton.Size = new System.Drawing.Size(190, 50);
            this.orderListButton.TabIndex = 7;
            this.orderListButton.Text = "Đơn gọi món";
            this.orderListButton.UseVisualStyleBackColor = true;
            this.orderListButton.Click += new System.EventHandler(this.orderListButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Image = global::CafeShop.Properties.Resources.order;
            this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.Location = new System.Drawing.Point(0, 80);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(190, 50);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Đặt món";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(190, 80);
            this.mainPanel.TabIndex = 1;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.titleBarPanel.Controls.Add(this.jButton2);
            this.titleBarPanel.Controls.Add(this.jButton1);
            this.titleBarPanel.Controls.Add(this.logInfoTextbox);
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.zoomButton);
            this.titleBarPanel.Controls.Add(this.funcNameLabel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(190, 0);
            this.titleBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1138, 80);
            this.titleBarPanel.TabIndex = 2;
            // 
            // jButton2
            // 
            this.jButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.jButton2.BackColor = System.Drawing.Color.Transparent;
            this.jButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.jButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton2.BorderRadius = 0;
            this.jButton2.BorderSize = 0;
            this.jButton2.FlatAppearance.BorderSize = 0;
            this.jButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton2.ForeColor = System.Drawing.Color.Black;
            this.jButton2.Image = global::CafeShop.Properties.Resources.minimize_sign;
            this.jButton2.Location = new System.Drawing.Point(1041, 4);
            this.jButton2.Name = "jButton2";
            this.jButton2.Size = new System.Drawing.Size(44, 29);
            this.jButton2.TabIndex = 7;
            this.jButton2.TextColor = System.Drawing.Color.Black;
            this.jButton2.UseVisualStyleBackColor = false;
            // 
            // jButton1
            // 
            this.jButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.jButton1.BackColor = System.Drawing.Color.Transparent;
            this.jButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.jButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton1.BorderRadius = 0;
            this.jButton1.BorderSize = 0;
            this.jButton1.FlatAppearance.BorderSize = 0;
            this.jButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton1.ForeColor = System.Drawing.Color.Black;
            this.jButton1.Image = global::CafeShop.Properties.Resources.full_screen;
            this.jButton1.Location = new System.Drawing.Point(1091, 4);
            this.jButton1.Name = "jButton1";
            this.jButton1.Size = new System.Drawing.Size(44, 29);
            this.jButton1.TabIndex = 6;
            this.jButton1.TextColor = System.Drawing.Color.Black;
            this.jButton1.UseVisualStyleBackColor = false;
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
            this.logInfoTextbox.Location = new System.Drawing.Point(879, 38);
            this.logInfoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.logInfoTextbox.Multiline = false;
            this.logInfoTextbox.Name = "logInfoTextbox";
            this.logInfoTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.logInfoTextbox.PasswordChar = false;
            this.logInfoTextbox.ReadOnly = true;
            this.logInfoTextbox.Size = new System.Drawing.Size(246, 35);
            this.logInfoTextbox.TabIndex = 5;
            this.logInfoTextbox.Texts = "";
            this.logInfoTextbox.UnderlinedStyle = false;
            this.logInfoTextbox.Click += new System.EventHandler(this.logInfoTextbox_Click);
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
            this.minimizeButton.Location = new System.Drawing.Point(1377, 5);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(44, 29);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TextColor = System.Drawing.Color.Black;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.button_MouseEnter);
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
            this.zoomButton.Location = new System.Drawing.Point(1444, 4);
            this.zoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(44, 29);
            this.zoomButton.TabIndex = 3;
            this.zoomButton.TextColor = System.Drawing.Color.Black;
            this.zoomButton.UseVisualStyleBackColor = false;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            this.zoomButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.zoomButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
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
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.childFormPanel.Size = new System.Drawing.Size(1138, 595);
            this.childFormPanel.TabIndex = 3;
            // 
            // Clock_Timer
            // 
            this.Clock_Timer.Interval = 1000;
            this.Clock_Timer.Tick += new System.EventHandler(this.Clock_Timer_Tick);
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
            this.pictureBox1.Location = new System.Drawing.Point(55, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 675);
            this.ControlBox = false;
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.jDropDownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label funcNameLabel;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button orderListButton;
        private System.Windows.Forms.Button timeButton;
        private CustomControl.JButton zoomButton;
        private CustomControl.JButton minimizeButton;
        private System.Windows.Forms.Button warehouseButton;
        private CustomControl.JTextbox logInfoTextbox;
        private CustomControl.DropDownMenu.JDropDownMenu jDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Timer Clock_Timer;
        private CustomControl.JButton jButton1;
        private CustomControl.JButton jButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}