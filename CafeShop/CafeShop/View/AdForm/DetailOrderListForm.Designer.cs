namespace CafeShop.View.AdForm
{
    partial class DetailOrderListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billIDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlBarPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianGoiMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGoiMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.employeeNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.customerNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.timeTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.billIDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.closeButton = new CafeShop.View.CustomControl.JButton();
            this.controlBarPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billIDLabel
            // 
            this.billIDLabel.AutoSize = true;
            this.billIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIDLabel.Location = new System.Drawing.Point(30, 15);
            this.billIDLabel.Name = "billIDLabel";
            this.billIDLabel.Size = new System.Drawing.Size(103, 20);
            this.billIDLabel.TabIndex = 0;
            this.billIDLabel.Text = "Mã hoá đơn";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(255, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(325, 50);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Chi Tiết Hoá Đơn";
            // 
            // controlBarPanel
            // 
            this.controlBarPanel.Controls.Add(this.minimizeButton);
            this.controlBarPanel.Controls.Add(this.closeButton);
            this.controlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.controlBarPanel.Name = "controlBarPanel";
            this.controlBarPanel.Size = new System.Drawing.Size(824, 31);
            this.controlBarPanel.TabIndex = 2;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 31);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(824, 79);
            this.titlePanel.TabIndex = 3;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.employeeNameTextbox);
            this.infoPanel.Controls.Add(this.customerNameTextbox);
            this.infoPanel.Controls.Add(this.timeTextbox);
            this.infoPanel.Controls.Add(this.billIDTextbox);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.billIDLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 110);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(824, 98);
            this.infoPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.totalTextbox);
            this.bottomPanel.Controls.Add(this.totalLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 482);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(824, 70);
            this.bottomPanel.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalLabel.Location = new System.Drawing.Point(465, 27);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(84, 20);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Tổng tiền";
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 208);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(49, 274);
            this.leftPanel.TabIndex = 6;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(770, 208);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(54, 274);
            this.rightPanel.TabIndex = 7;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataGridView1);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(49, 208);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(721, 274);
            this.dataPanel.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.thoiGianGoiMonDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donGoiMonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // monDataGridViewTextBoxColumn
            // 
            this.monDataGridViewTextBoxColumn.DataPropertyName = "Mon";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.monDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.monDataGridViewTextBoxColumn.Name = "monDataGridViewTextBoxColumn";
            this.monDataGridViewTextBoxColumn.ReadOnly = true;
            this.monDataGridViewTextBoxColumn.Width = 130;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuongDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 80;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ghiChuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 150;
            // 
            // thoiGianGoiMonDataGridViewTextBoxColumn
            // 
            this.thoiGianGoiMonDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianGoiMon";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.thoiGianGoiMonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.thoiGianGoiMonDataGridViewTextBoxColumn.HeaderText = "Thời gian gọi món";
            this.thoiGianGoiMonDataGridViewTextBoxColumn.Name = "thoiGianGoiMonDataGridViewTextBoxColumn";
            this.thoiGianGoiMonDataGridViewTextBoxColumn.ReadOnly = true;
            this.thoiGianGoiMonDataGridViewTextBoxColumn.Width = 140;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.giaTienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            this.giaTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // donGoiMonBindingSource
            // 
            this.donGoiMonBindingSource.DataSource = typeof(CafeShop.DTO.DonGoiMon);
            // 
            // totalTextbox
            // 
            this.totalTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.totalTextbox.BorderRadius = 5;
            this.totalTextbox.BorderSize = 2;
            this.totalTextbox.Enabled = false;
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.Location = new System.Drawing.Point(574, 21);
            this.totalTextbox.Multiline = false;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.totalTextbox.PasswordChar = false;
            this.totalTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.totalTextbox.PlaceholderText = "";
            this.totalTextbox.Size = new System.Drawing.Size(196, 32);
            this.totalTextbox.TabIndex = 1;
            this.totalTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTextbox.Texts = "";
            this.totalTextbox.UnderlinedStyle = false;
            // 
            // employeeNameTextbox
            // 
            this.employeeNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.employeeNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.employeeNameTextbox.BorderRadius = 5;
            this.employeeNameTextbox.BorderSize = 2;
            this.employeeNameTextbox.Enabled = false;
            this.employeeNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.employeeNameTextbox.Location = new System.Drawing.Point(560, 47);
            this.employeeNameTextbox.Multiline = false;
            this.employeeNameTextbox.Name = "employeeNameTextbox";
            this.employeeNameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.employeeNameTextbox.PasswordChar = false;
            this.employeeNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.employeeNameTextbox.PlaceholderText = "";
            this.employeeNameTextbox.Size = new System.Drawing.Size(210, 33);
            this.employeeNameTextbox.TabIndex = 7;
            this.employeeNameTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.employeeNameTextbox.Texts = "";
            this.employeeNameTextbox.UnderlinedStyle = false;
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customerNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customerNameTextbox.BorderRadius = 5;
            this.customerNameTextbox.BorderSize = 2;
            this.customerNameTextbox.Enabled = false;
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.customerNameTextbox.Location = new System.Drawing.Point(560, 8);
            this.customerNameTextbox.Multiline = false;
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customerNameTextbox.PasswordChar = false;
            this.customerNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customerNameTextbox.PlaceholderText = "";
            this.customerNameTextbox.Size = new System.Drawing.Size(210, 33);
            this.customerNameTextbox.TabIndex = 6;
            this.customerNameTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerNameTextbox.Texts = "";
            this.customerNameTextbox.UnderlinedStyle = false;
            // 
            // timeTextbox
            // 
            this.timeTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.timeTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.timeTextbox.BorderRadius = 5;
            this.timeTextbox.BorderSize = 2;
            this.timeTextbox.Enabled = false;
            this.timeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.timeTextbox.Location = new System.Drawing.Point(148, 47);
            this.timeTextbox.Multiline = false;
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.timeTextbox.PasswordChar = false;
            this.timeTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.timeTextbox.PlaceholderText = "";
            this.timeTextbox.Size = new System.Drawing.Size(210, 33);
            this.timeTextbox.TabIndex = 5;
            this.timeTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.timeTextbox.Texts = "";
            this.timeTextbox.UnderlinedStyle = false;
            // 
            // billIDTextbox
            // 
            this.billIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.billIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.billIDTextbox.BorderRadius = 5;
            this.billIDTextbox.BorderSize = 2;
            this.billIDTextbox.Enabled = false;
            this.billIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIDTextbox.ForeColor = System.Drawing.Color.Crimson;
            this.billIDTextbox.Location = new System.Drawing.Point(148, 8);
            this.billIDTextbox.Multiline = false;
            this.billIDTextbox.Name = "billIDTextbox";
            this.billIDTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.billIDTextbox.PasswordChar = false;
            this.billIDTextbox.PlaceholderColor = System.Drawing.Color.Black;
            this.billIDTextbox.PlaceholderText = "";
            this.billIDTextbox.Size = new System.Drawing.Size(210, 33);
            this.billIDTextbox.TabIndex = 4;
            this.billIDTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.billIDTextbox.Texts = "";
            this.billIDTextbox.UnderlinedStyle = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.BorderSize = 0;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = global::CafeShop.Properties.Resources.minimize_sign;
            this.minimizeButton.Location = new System.Drawing.Point(716, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(54, 31);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextColor = System.Drawing.Color.White;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeButton.BorderRadius = 0;
            this.closeButton.BorderSize = 0;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = global::CafeShop.Properties.Resources.closelogin;
            this.closeButton.Location = new System.Drawing.Point(770, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(54, 31);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextColor = System.Drawing.Color.White;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // DetailOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(824, 552);
            this.ControlBox = false;
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.controlBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailOrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.controlBarPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label billIDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlBarPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel infoPanel;
        private CustomControl.JNewTextbox employeeNameTextbox;
        private CustomControl.JNewTextbox customerNameTextbox;
        private CustomControl.JNewTextbox timeTextbox;
        private CustomControl.JNewTextbox billIDTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.JButton minimizeButton;
        private CustomControl.JButton closeButton;
        private System.Windows.Forms.BindingSource donGoiMonBindingSource;
        private CustomControl.JNewTextbox totalTextbox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn monDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianGoiMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
    }
}