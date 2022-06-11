namespace CafeShop.View.EmpForm
{
    partial class OrderForm
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
            this.areaPanel = new System.Windows.Forms.Panel();
            this.areaFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.areaJCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.orderDetailsDataPanel = new System.Windows.Forms.Panel();
            this.orderListDataGridView = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGoiMonViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsPanel = new System.Windows.Forms.Panel();
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stateButton = new CafeShop.View.CustomControl.JButton();
            this.orderButton = new CafeShop.View.CustomControl.JButton();
            this.tableInfoTable = new System.Windows.Forms.Panel();
            this.timeInfoLabel = new System.Windows.Forms.Label();
            this.statusTable = new System.Windows.Forms.Label();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.statusTableLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timeArriveLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.categoryFoodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.foodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.areaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.orderDetailsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonViewBindingSource)).BeginInit();
            this.orderDetailsPanel.SuspendLayout();
            this.buttonPanel1.SuspendLayout();
            this.tableInfoTable.SuspendLayout();
            this.itemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaPanel
            // 
            this.areaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaPanel.Controls.Add(this.areaFlowPanel);
            this.areaPanel.Controls.Add(this.panel5);
            this.areaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.areaPanel.Location = new System.Drawing.Point(0, 0);
            this.areaPanel.Name = "areaPanel";
            this.areaPanel.Size = new System.Drawing.Size(329, 611);
            this.areaPanel.TabIndex = 0;
            // 
            // areaFlowPanel
            // 
            this.areaFlowPanel.AutoScroll = true;
            this.areaFlowPanel.BackColor = System.Drawing.Color.Wheat;
            this.areaFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.areaFlowPanel.Location = new System.Drawing.Point(0, 62);
            this.areaFlowPanel.Name = "areaFlowPanel";
            this.areaFlowPanel.Size = new System.Drawing.Size(327, 547);
            this.areaFlowPanel.TabIndex = 1;
            this.areaFlowPanel.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.areaJCombobox);
            this.panel5.Controls.Add(this.areaLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 62);
            this.panel5.TabIndex = 0;
            // 
            // areaJCombobox
            // 
            this.areaJCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.areaJCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.areaJCombobox.BorderSize = 2;
            this.areaJCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.areaJCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaJCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.areaJCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.areaJCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.areaJCombobox.ListTextColor = System.Drawing.Color.Black;
            this.areaJCombobox.Location = new System.Drawing.Point(108, 26);
            this.areaJCombobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.areaJCombobox.Name = "areaJCombobox";
            this.areaJCombobox.Padding = new System.Windows.Forms.Padding(2);
            this.areaJCombobox.Size = new System.Drawing.Size(200, 30);
            this.areaJCombobox.TabIndex = 2;
            this.areaJCombobox.Texts = "";
            this.areaJCombobox.OnSelectedIndexChanged += new System.EventHandler(this.areaJCombobox_OnSelectedIndexChanged);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(12, 31);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(72, 20);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Khu vực";
            // 
            // detailPanel
            // 
            this.detailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPanel.Controls.Add(this.orderDetailsDataPanel);
            this.detailPanel.Controls.Add(this.orderDetailsPanel);
            this.detailPanel.Controls.Add(this.panel1);
            this.detailPanel.Controls.Add(this.buttonPanel1);
            this.detailPanel.Controls.Add(this.tableInfoTable);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailPanel.Location = new System.Drawing.Point(329, 0);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(313, 611);
            this.detailPanel.TabIndex = 1;
            // 
            // orderDetailsDataPanel
            // 
            this.orderDetailsDataPanel.Controls.Add(this.orderListDataGridView);
            this.orderDetailsDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsDataPanel.Location = new System.Drawing.Point(0, 351);
            this.orderDetailsDataPanel.Name = "orderDetailsDataPanel";
            this.orderDetailsDataPanel.Size = new System.Drawing.Size(311, 258);
            this.orderDetailsDataPanel.TabIndex = 4;
            // 
            // orderListDataGridView
            // 
            this.orderListDataGridView.AllowUserToAddRows = false;
            this.orderListDataGridView.AllowUserToDeleteRows = false;
            this.orderListDataGridView.AllowUserToResizeColumns = false;
            this.orderListDataGridView.AllowUserToResizeRows = false;
            this.orderListDataGridView.AutoGenerateColumns = false;
            this.orderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn});
            this.orderListDataGridView.DataSource = this.donGoiMonViewBindingSource;
            this.orderListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderListDataGridView.Name = "orderListDataGridView";
            this.orderListDataGridView.Size = new System.Drawing.Size(311, 258);
            this.orderListDataGridView.TabIndex = 0;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TenMon.DefaultCellStyle = dataGridViewCellStyle1;
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // thoiGianTuKhiGoiDataGridViewTextBoxColumn
            // 
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianTuKhiGoi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.HeaderText = "Thời gian từ khi gọi";
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.Name = "thoiGianTuKhiGoiDataGridViewTextBoxColumn";
            // 
            // donGoiMonViewBindingSource
            // 
            this.donGoiMonViewBindingSource.DataSource = typeof(CafeShop.DTO.DonGoiMonView);
            // 
            // orderDetailsPanel
            // 
            this.orderDetailsPanel.Controls.Add(this.orderDetailsLabel);
            this.orderDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetailsPanel.Location = new System.Drawing.Point(0, 308);
            this.orderDetailsPanel.Name = "orderDetailsPanel";
            this.orderDetailsPanel.Size = new System.Drawing.Size(311, 43);
            this.orderDetailsPanel.TabIndex = 3;
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.orderDetailsLabel.Location = new System.Drawing.Point(80, 11);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(158, 24);
            this.orderDetailsLabel.TabIndex = 0;
            this.orderDetailsLabel.Text = "Các món đã gọi";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 16);
            this.panel1.TabIndex = 2;
            // 
            // buttonPanel1
            // 
            this.buttonPanel1.ColumnCount = 5;
            this.buttonPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.buttonPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.buttonPanel1.Controls.Add(this.stateButton, 1, 0);
            this.buttonPanel1.Controls.Add(this.orderButton, 3, 0);
            this.buttonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel1.Location = new System.Drawing.Point(0, 242);
            this.buttonPanel1.Name = "buttonPanel1";
            this.buttonPanel1.RowCount = 1;
            this.buttonPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonPanel1.Size = new System.Drawing.Size(311, 50);
            this.buttonPanel1.TabIndex = 1;
            // 
            // stateButton
            // 
            this.stateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.stateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.stateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.stateButton.BorderRadius = 30;
            this.stateButton.BorderSize = 0;
            this.stateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateButton.FlatAppearance.BorderSize = 0;
            this.stateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateButton.ForeColor = System.Drawing.Color.White;
            this.stateButton.Location = new System.Drawing.Point(23, 3);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(124, 44);
            this.stateButton.TabIndex = 0;
            this.stateButton.Text = "Mở bàn";
            this.stateButton.TextColor = System.Drawing.Color.White;
            this.stateButton.UseVisualStyleBackColor = false;
            this.stateButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Crimson;
            this.orderButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.orderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.orderButton.BorderRadius = 30;
            this.orderButton.BorderSize = 0;
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(163, 3);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(124, 44);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Gọi Món";
            this.orderButton.TextColor = System.Drawing.Color.White;
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // tableInfoTable
            // 
            this.tableInfoTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableInfoTable.Controls.Add(this.timeInfoLabel);
            this.tableInfoTable.Controls.Add(this.statusTable);
            this.tableInfoTable.Controls.Add(this.timeOutLabel);
            this.tableInfoTable.Controls.Add(this.label1);
            this.tableInfoTable.Controls.Add(this.tableNameLabel);
            this.tableInfoTable.Controls.Add(this.statusTableLabel);
            this.tableInfoTable.Controls.Add(this.statusLabel);
            this.tableInfoTable.Controls.Add(this.timeArriveLabel);
            this.tableInfoTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableInfoTable.Location = new System.Drawing.Point(0, 0);
            this.tableInfoTable.Name = "tableInfoTable";
            this.tableInfoTable.Size = new System.Drawing.Size(311, 242);
            this.tableInfoTable.TabIndex = 0;
            // 
            // timeInfoLabel
            // 
            this.timeInfoLabel.AutoSize = true;
            this.timeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInfoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.timeInfoLabel.Location = new System.Drawing.Point(110, 61);
            this.timeInfoLabel.Name = "timeInfoLabel";
            this.timeInfoLabel.Size = new System.Drawing.Size(40, 18);
            this.timeInfoLabel.TabIndex = 7;
            this.timeInfoLabel.Text = "time";
            // 
            // statusTable
            // 
            this.statusTable.AutoSize = true;
            this.statusTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTable.ForeColor = System.Drawing.Color.Crimson;
            this.statusTable.Location = new System.Drawing.Point(146, 96);
            this.statusTable.Name = "statusTable";
            this.statusTable.Size = new System.Drawing.Size(93, 18);
            this.statusTable.TabIndex = 6;
            this.statusTable.Text = "Tình trạng: ";
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timeOutLabel.Location = new System.Drawing.Point(66, 202);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(179, 20);
            this.timeOutLabel.TabIndex = 5;
            this.timeOutLabel.Text = "25/04/2022 07:34 PM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời điểm phục vụ gần nhất";
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableNameLabel.Location = new System.Drawing.Point(76, 17);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(151, 20);
            this.tableNameLabel.TabIndex = 3;
            this.tableNameLabel.Text = "Bàn số 1 - Tầng 1";
            // 
            // statusTableLabel
            // 
            this.statusTableLabel.AutoSize = true;
            this.statusTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTableLabel.Location = new System.Drawing.Point(19, 130);
            this.statusTableLabel.Name = "statusTableLabel";
            this.statusTableLabel.Size = new System.Drawing.Size(58, 18);
            this.statusTableLabel.TabIndex = 2;
            this.statusTableLabel.Text = "Khách: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(19, 96);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 18);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Tình trạng: ";
            // 
            // timeArriveLabel
            // 
            this.timeArriveLabel.AutoSize = true;
            this.timeArriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeArriveLabel.Location = new System.Drawing.Point(19, 62);
            this.timeArriveLabel.Name = "timeArriveLabel";
            this.timeArriveLabel.Size = new System.Drawing.Size(68, 18);
            this.timeArriveLabel.TabIndex = 0;
            this.timeArriveLabel.Text = "Giờ đến: ";
            // 
            // itemPanel
            // 
            this.itemPanel.Controls.Add(this.categoryFoodPanel);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemPanel.Location = new System.Drawing.Point(642, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(118, 611);
            this.itemPanel.TabIndex = 2;
            // 
            // categoryFoodPanel
            // 
            this.categoryFoodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryFoodPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.categoryFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.categoryFoodPanel.Name = "categoryFoodPanel";
            this.categoryFoodPanel.Size = new System.Drawing.Size(118, 611);
            this.categoryFoodPanel.TabIndex = 0;
            this.categoryFoodPanel.Visible = false;
            // 
            // foodPanel
            // 
            this.foodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.foodPanel.Location = new System.Drawing.Point(760, 0);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(394, 611);
            this.foodPanel.TabIndex = 3;
            this.foodPanel.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.Controls.Add(this.foodPanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.areaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.areaPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.orderDetailsDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonViewBindingSource)).EndInit();
            this.orderDetailsPanel.ResumeLayout(false);
            this.orderDetailsPanel.PerformLayout();
            this.buttonPanel1.ResumeLayout(false);
            this.tableInfoTable.ResumeLayout(false);
            this.tableInfoTable.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel areaPanel;
        private System.Windows.Forms.FlowLayoutPanel areaFlowPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.TableLayoutPanel buttonPanel1;
        private CustomControl.JButton stateButton;
        private CustomControl.JButton orderButton;
        private System.Windows.Forms.Panel tableInfoTable;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timeArriveLabel;
        private System.Windows.Forms.FlowLayoutPanel categoryFoodPanel;
        private System.Windows.Forms.FlowLayoutPanel foodPanel;
        private System.Windows.Forms.Label statusTable;
        private System.Windows.Forms.Label timeInfoLabel;
        private System.Windows.Forms.Label statusTableLabel;
        private CustomControl.JComboBox areaJCombobox;
        private System.Windows.Forms.Panel orderDetailsPanel;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel orderDetailsDataPanel;
        private System.Windows.Forms.DataGridView orderListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianTuKhiGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource donGoiMonViewBindingSource;
    }
}