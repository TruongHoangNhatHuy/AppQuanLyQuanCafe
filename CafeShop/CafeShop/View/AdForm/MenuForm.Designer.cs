namespace CafeShop.View.AdForm
{
    partial class MenuForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.categoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.categoryFoodData = new System.Windows.Forms.DataGridView();
            this.maDanhMucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.danhMucThucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteCButton = new CafeShop.View.CustomControl.JButton();
            this.editCButton = new CafeShop.View.CustomControl.JButton();
            this.addCButton = new CafeShop.View.CustomControl.JButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ShowAllButton = new CafeShop.View.CustomControl.JButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteFButton = new CafeShop.View.CustomControl.JButton();
            this.editFButton = new CafeShop.View.CustomControl.JButton();
            this.addFButton = new CafeShop.View.CustomControl.JButton();
            this.foodData = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectionCombobox = new System.Windows.Forms.ComboBox();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.detailFoodLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.foodPanel = new System.Windows.Forms.Panel();
            this.categoryCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.priceTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.unitTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.foodNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.foodIDTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryFoodPanel = new System.Windows.Forms.Panel();
            this.categoryNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryIDTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.categoryFoodLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThucDonBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.foodPanel.SuspendLayout();
            this.categoryFoodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1154, 55);
            this.topPanel.TabIndex = 21;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.exitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.BorderRadius = 30;
            this.exitButton.BorderSize = 0;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::CafeShop.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(15, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 40);
            this.exitButton.TabIndex = 16;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 7;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.mainPanel.Controls.Add(this.categoryPanel, 1, 0);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1, 3, 0);
            this.mainPanel.Controls.Add(this.panel2, 5, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 55);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.mainPanel.Size = new System.Drawing.Size(1154, 556);
            this.mainPanel.TabIndex = 22;
            // 
            // categoryPanel
            // 
            this.categoryPanel.ColumnCount = 1;
            this.categoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.categoryPanel.Controls.Add(this.categoryFoodData, 0, 1);
            this.categoryPanel.Controls.Add(this.panel3, 0, 2);
            this.categoryPanel.Controls.Add(this.panel5, 0, 0);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPanel.Location = new System.Drawing.Point(23, 3);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.RowCount = 3;
            this.categoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.categoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.categoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.categoryPanel.Size = new System.Drawing.Size(259, 550);
            this.categoryPanel.TabIndex = 0;
            // 
            // categoryFoodData
            // 
            this.categoryFoodData.AllowUserToAddRows = false;
            this.categoryFoodData.AllowUserToDeleteRows = false;
            this.categoryFoodData.AllowUserToResizeColumns = false;
            this.categoryFoodData.AllowUserToResizeRows = false;
            this.categoryFoodData.AutoGenerateColumns = false;
            this.categoryFoodData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryFoodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryFoodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDanhMucDataGridViewTextBoxColumn,
            this.TenDanhMuc,
            this.visibleDataGridViewCheckBoxColumn});
            this.categoryFoodData.DataSource = this.danhMucThucDonBindingSource;
            this.categoryFoodData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryFoodData.Location = new System.Drawing.Point(3, 43);
            this.categoryFoodData.MultiSelect = false;
            this.categoryFoodData.Name = "categoryFoodData";
            this.categoryFoodData.ReadOnly = true;
            this.categoryFoodData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryFoodData.Size = new System.Drawing.Size(253, 444);
            this.categoryFoodData.TabIndex = 2;
            this.categoryFoodData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryFoodData_CellClick);
            // 
            // maDanhMucDataGridViewTextBoxColumn
            // 
            this.maDanhMucDataGridViewTextBoxColumn.DataPropertyName = "MaDanhMuc";
            this.maDanhMucDataGridViewTextBoxColumn.HeaderText = "Mã danh mục";
            this.maDanhMucDataGridViewTextBoxColumn.Name = "maDanhMucDataGridViewTextBoxColumn";
            this.maDanhMucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // visibleDataGridViewCheckBoxColumn
            // 
            this.visibleDataGridViewCheckBoxColumn.DataPropertyName = "Visible";
            this.visibleDataGridViewCheckBoxColumn.HeaderText = "Hiển thị";
            this.visibleDataGridViewCheckBoxColumn.Name = "visibleDataGridViewCheckBoxColumn";
            this.visibleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // danhMucThucDonBindingSource
            // 
            this.danhMucThucDonBindingSource.DataSource = typeof(CafeShop.DTO.DanhMucThucDon);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteCButton);
            this.panel3.Controls.Add(this.editCButton);
            this.panel3.Controls.Add(this.addCButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 54);
            this.panel3.TabIndex = 3;
            // 
            // deleteCButton
            // 
            this.deleteCButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteCButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteCButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteCButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteCButton.BorderRadius = 19;
            this.deleteCButton.BorderSize = 0;
            this.deleteCButton.FlatAppearance.BorderSize = 0;
            this.deleteCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCButton.ForeColor = System.Drawing.Color.Black;
            this.deleteCButton.Location = new System.Drawing.Point(13, 13);
            this.deleteCButton.Name = "deleteCButton";
            this.deleteCButton.Size = new System.Drawing.Size(68, 29);
            this.deleteCButton.TabIndex = 9;
            this.deleteCButton.Text = "Ẩn";
            this.deleteCButton.TextColor = System.Drawing.Color.Black;
            this.deleteCButton.UseVisualStyleBackColor = false;
            this.deleteCButton.Click += new System.EventHandler(this.deleteCButton_Click);
            // 
            // editCButton
            // 
            this.editCButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editCButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editCButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editCButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editCButton.BorderRadius = 19;
            this.editCButton.BorderSize = 0;
            this.editCButton.FlatAppearance.BorderSize = 0;
            this.editCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCButton.ForeColor = System.Drawing.Color.Black;
            this.editCButton.Location = new System.Drawing.Point(92, 13);
            this.editCButton.Name = "editCButton";
            this.editCButton.Size = new System.Drawing.Size(68, 29);
            this.editCButton.TabIndex = 8;
            this.editCButton.Text = "Sửa";
            this.editCButton.TextColor = System.Drawing.Color.Black;
            this.editCButton.UseVisualStyleBackColor = false;
            this.editCButton.Click += new System.EventHandler(this.editCButton_Click);
            // 
            // addCButton
            // 
            this.addCButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addCButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addCButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addCButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addCButton.BorderRadius = 19;
            this.addCButton.BorderSize = 0;
            this.addCButton.FlatAppearance.BorderSize = 0;
            this.addCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCButton.ForeColor = System.Drawing.Color.Black;
            this.addCButton.Location = new System.Drawing.Point(172, 13);
            this.addCButton.Name = "addCButton";
            this.addCButton.Size = new System.Drawing.Size(68, 29);
            this.addCButton.TabIndex = 7;
            this.addCButton.Text = "Thêm";
            this.addCButton.TextColor = System.Drawing.Color.Black;
            this.addCButton.UseVisualStyleBackColor = false;
            this.addCButton.Click += new System.EventHandler(this.addCButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ShowAllButton);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 34);
            this.panel5.TabIndex = 4;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ShowAllButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ShowAllButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ShowAllButton.BorderRadius = 28;
            this.ShowAllButton.BorderSize = 0;
            this.ShowAllButton.FlatAppearance.BorderSize = 0;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.ForeColor = System.Drawing.Color.Black;
            this.ShowAllButton.Location = new System.Drawing.Point(174, 3);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(70, 28);
            this.ShowAllButton.TabIndex = 2;
            this.ShowAllButton.Text = "Tất cả";
            this.ShowAllButton.TextColor = System.Drawing.Color.Black;
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.foodData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(308, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 550);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteFButton);
            this.panel4.Controls.Add(this.editFButton);
            this.panel4.Controls.Add(this.addFButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 493);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 54);
            this.panel4.TabIndex = 4;
            // 
            // deleteFButton
            // 
            this.deleteFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteFButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteFButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteFButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteFButton.BorderRadius = 19;
            this.deleteFButton.BorderSize = 0;
            this.deleteFButton.FlatAppearance.BorderSize = 0;
            this.deleteFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFButton.ForeColor = System.Drawing.Color.Black;
            this.deleteFButton.Location = new System.Drawing.Point(50, 13);
            this.deleteFButton.Name = "deleteFButton";
            this.deleteFButton.Size = new System.Drawing.Size(94, 29);
            this.deleteFButton.TabIndex = 12;
            this.deleteFButton.Text = "Ẩn";
            this.deleteFButton.TextColor = System.Drawing.Color.Black;
            this.deleteFButton.UseVisualStyleBackColor = false;
            this.deleteFButton.Click += new System.EventHandler(this.deleteFButton_Click);
            // 
            // editFButton
            // 
            this.editFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editFButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editFButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editFButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editFButton.BorderRadius = 19;
            this.editFButton.BorderSize = 0;
            this.editFButton.FlatAppearance.BorderSize = 0;
            this.editFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFButton.ForeColor = System.Drawing.Color.Black;
            this.editFButton.Location = new System.Drawing.Point(185, 13);
            this.editFButton.Name = "editFButton";
            this.editFButton.Size = new System.Drawing.Size(94, 29);
            this.editFButton.TabIndex = 11;
            this.editFButton.Text = "Sửa";
            this.editFButton.TextColor = System.Drawing.Color.Black;
            this.editFButton.UseVisualStyleBackColor = false;
            this.editFButton.Click += new System.EventHandler(this.editFButton_Click);
            // 
            // addFButton
            // 
            this.addFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addFButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addFButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addFButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addFButton.BorderRadius = 19;
            this.addFButton.BorderSize = 0;
            this.addFButton.FlatAppearance.BorderSize = 0;
            this.addFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFButton.ForeColor = System.Drawing.Color.Black;
            this.addFButton.Location = new System.Drawing.Point(320, 13);
            this.addFButton.Name = "addFButton";
            this.addFButton.Size = new System.Drawing.Size(94, 29);
            this.addFButton.TabIndex = 10;
            this.addFButton.Text = "Thêm";
            this.addFButton.TextColor = System.Drawing.Color.Black;
            this.addFButton.UseVisualStyleBackColor = false;
            this.addFButton.Click += new System.EventHandler(this.addFButton_Click);
            // 
            // foodData
            // 
            this.foodData.AllowUserToAddRows = false;
            this.foodData.AllowUserToDeleteRows = false;
            this.foodData.AllowUserToResizeColumns = false;
            this.foodData.AllowUserToResizeRows = false;
            this.foodData.AutoGenerateColumns = false;
            this.foodData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.DonVi,
            this.Visible});
            this.foodData.DataSource = this.monBindingSource;
            this.foodData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodData.Location = new System.Drawing.Point(3, 43);
            this.foodData.MultiSelect = false;
            this.foodData.Name = "foodData";
            this.foodData.ReadOnly = true;
            this.foodData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodData.Size = new System.Drawing.Size(465, 444);
            this.foodData.TabIndex = 2;
            this.foodData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodData_CellClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // Visible
            // 
            this.Visible.DataPropertyName = "Visible";
            this.Visible.HeaderText = "Hiển thị";
            this.Visible.Name = "Visible";
            this.Visible.ReadOnly = true;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataSource = typeof(CafeShop.DTO.Mon);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectionCombobox);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Controls.Add(this.detailFoodLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 34);
            this.panel1.TabIndex = 3;
            // 
            // selectionCombobox
            // 
            this.selectionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionCombobox.FormattingEnabled = true;
            this.selectionCombobox.Items.AddRange(new object[] {
            "Tất cả",
            "Visible",
            "Hidden"});
            this.selectionCombobox.Location = new System.Drawing.Point(134, 6);
            this.selectionCombobox.Name = "selectionCombobox";
            this.selectionCombobox.Size = new System.Drawing.Size(121, 21);
            this.selectionCombobox.TabIndex = 12;
            this.selectionCombobox.SelectedIndexChanged += new System.EventHandler(this.selectionCombobox_SelectedIndexChanged);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderRadius = 5;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(269, 1);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "Tìm kiếm...";
            this.searchTextbox.Size = new System.Drawing.Size(196, 32);
            this.searchTextbox.TabIndex = 11;
            this.searchTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            this.searchTextbox._TextChanged += new System.EventHandler(this.searchTextbox__TextChanged);
            // 
            // detailFoodLabel
            // 
            this.detailFoodLabel.AutoSize = true;
            this.detailFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFoodLabel.ForeColor = System.Drawing.Color.Crimson;
            this.detailFoodLabel.Location = new System.Drawing.Point(3, 7);
            this.detailFoodLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.detailFoodLabel.Name = "detailFoodLabel";
            this.detailFoodLabel.Size = new System.Drawing.Size(93, 16);
            this.detailFoodLabel.TabIndex = 3;
            this.detailFoodLabel.Text = "Chi tiết món ăn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(805, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 550);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.buttonPanel);
            this.groupBox1.Controls.Add(this.foodPanel);
            this.groupBox1.Controls.Add(this.categoryFoodPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 550);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.exceptionLabel);
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.confirmButton);
            this.buttonPanel.Location = new System.Drawing.Point(25, 429);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(271, 94);
            this.buttonPanel.TabIndex = 4;
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionLabel.Location = new System.Drawing.Point(14, 6);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(130, 20);
            this.exceptionLabel.TabIndex = 5;
            this.exceptionLabel.Text = "exceptionLabel";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 30;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(14, 46);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confirmButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmButton.BorderRadius = 30;
            this.confirmButton.BorderSize = 0;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(154, 46);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 40);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // foodPanel
            // 
            this.foodPanel.Controls.Add(this.categoryCombobox);
            this.foodPanel.Controls.Add(this.priceTextbox);
            this.foodPanel.Controls.Add(this.unitTextbox);
            this.foodPanel.Controls.Add(this.foodNameTextbox);
            this.foodPanel.Controls.Add(this.foodIDTextbox);
            this.foodPanel.Controls.Add(this.label6);
            this.foodPanel.Controls.Add(this.label5);
            this.foodPanel.Controls.Add(this.label4);
            this.foodPanel.Controls.Add(this.label3);
            this.foodPanel.Controls.Add(this.label2);
            this.foodPanel.Location = new System.Drawing.Point(25, 25);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(291, 380);
            this.foodPanel.TabIndex = 2;
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryCombobox.BorderSize = 2;
            this.categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombobox.ForeColor = System.Drawing.Color.Black;
            this.categoryCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.categoryCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.categoryCombobox.Location = new System.Drawing.Point(22, 177);
            this.categoryCombobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCombobox.Size = new System.Drawing.Size(252, 36);
            this.categoryCombobox.TabIndex = 10;
            this.categoryCombobox.Texts = "";
            // 
            // priceTextbox
            // 
            this.priceTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.priceTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.priceTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.priceTextbox.BorderSize = 2;
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.ForeColor = System.Drawing.Color.Black;
            this.priceTextbox.Location = new System.Drawing.Point(22, 329);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextbox.Multiline = false;
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.priceTextbox.PasswordChar = false;
            this.priceTextbox.ReadOnly = false;
            this.priceTextbox.Size = new System.Drawing.Size(252, 31);
            this.priceTextbox.TabIndex = 9;
            this.priceTextbox.Texts = "";
            this.priceTextbox.UnderlinedStyle = false;
            // 
            // unitTextbox
            // 
            this.unitTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.unitTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.unitTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.unitTextbox.BorderSize = 2;
            this.unitTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextbox.ForeColor = System.Drawing.Color.Black;
            this.unitTextbox.Location = new System.Drawing.Point(22, 256);
            this.unitTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.unitTextbox.Multiline = false;
            this.unitTextbox.Name = "unitTextbox";
            this.unitTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.unitTextbox.PasswordChar = false;
            this.unitTextbox.ReadOnly = false;
            this.unitTextbox.Size = new System.Drawing.Size(252, 31);
            this.unitTextbox.TabIndex = 8;
            this.unitTextbox.Texts = "";
            this.unitTextbox.UnderlinedStyle = false;
            // 
            // foodNameTextbox
            // 
            this.foodNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.foodNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.foodNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.foodNameTextbox.BorderSize = 2;
            this.foodNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameTextbox.ForeColor = System.Drawing.Color.Black;
            this.foodNameTextbox.Location = new System.Drawing.Point(19, 104);
            this.foodNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodNameTextbox.Multiline = false;
            this.foodNameTextbox.Name = "foodNameTextbox";
            this.foodNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.foodNameTextbox.PasswordChar = false;
            this.foodNameTextbox.ReadOnly = false;
            this.foodNameTextbox.Size = new System.Drawing.Size(252, 31);
            this.foodNameTextbox.TabIndex = 7;
            this.foodNameTextbox.Texts = "";
            this.foodNameTextbox.UnderlinedStyle = false;
            // 
            // foodIDTextbox
            // 
            this.foodIDTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.foodIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.foodIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.foodIDTextbox.BorderSize = 2;
            this.foodIDTextbox.Enabled = false;
            this.foodIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodIDTextbox.ForeColor = System.Drawing.Color.Black;
            this.foodIDTextbox.Location = new System.Drawing.Point(22, 34);
            this.foodIDTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodIDTextbox.Multiline = false;
            this.foodIDTextbox.Name = "foodIDTextbox";
            this.foodIDTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.foodIDTextbox.PasswordChar = false;
            this.foodIDTextbox.ReadOnly = true;
            this.foodIDTextbox.Size = new System.Drawing.Size(252, 31);
            this.foodIDTextbox.TabIndex = 6;
            this.foodIDTextbox.Texts = "";
            this.foodIDTextbox.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã món";
            // 
            // categoryFoodPanel
            // 
            this.categoryFoodPanel.Controls.Add(this.categoryNameTextbox);
            this.categoryFoodPanel.Controls.Add(this.categoryNameLabel);
            this.categoryFoodPanel.Controls.Add(this.categoryIDTextbox);
            this.categoryFoodPanel.Controls.Add(this.categoryFoodLabel);
            this.categoryFoodPanel.Location = new System.Drawing.Point(28, 26);
            this.categoryFoodPanel.Name = "categoryFoodPanel";
            this.categoryFoodPanel.Size = new System.Drawing.Size(291, 159);
            this.categoryFoodPanel.TabIndex = 1;
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.categoryNameTextbox.BorderSize = 2;
            this.categoryNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextbox.ForeColor = System.Drawing.Color.Black;
            this.categoryNameTextbox.Location = new System.Drawing.Point(22, 113);
            this.categoryNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryNameTextbox.Multiline = false;
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.categoryNameTextbox.PasswordChar = false;
            this.categoryNameTextbox.ReadOnly = false;
            this.categoryNameTextbox.Size = new System.Drawing.Size(252, 31);
            this.categoryNameTextbox.TabIndex = 3;
            this.categoryNameTextbox.Texts = "";
            this.categoryNameTextbox.UnderlinedStyle = false;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(18, 80);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(122, 20);
            this.categoryNameLabel.TabIndex = 2;
            this.categoryNameLabel.Text = "Tên danh mục";
            // 
            // categoryIDTextbox
            // 
            this.categoryIDTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.categoryIDTextbox.BorderSize = 2;
            this.categoryIDTextbox.Enabled = false;
            this.categoryIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDTextbox.ForeColor = System.Drawing.Color.Black;
            this.categoryIDTextbox.Location = new System.Drawing.Point(22, 33);
            this.categoryIDTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryIDTextbox.Multiline = false;
            this.categoryIDTextbox.Name = "categoryIDTextbox";
            this.categoryIDTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.categoryIDTextbox.PasswordChar = false;
            this.categoryIDTextbox.ReadOnly = true;
            this.categoryIDTextbox.Size = new System.Drawing.Size(252, 31);
            this.categoryIDTextbox.TabIndex = 1;
            this.categoryIDTextbox.Texts = "";
            this.categoryIDTextbox.UnderlinedStyle = false;
            // 
            // categoryFoodLabel
            // 
            this.categoryFoodLabel.AutoSize = true;
            this.categoryFoodLabel.Location = new System.Drawing.Point(18, 9);
            this.categoryFoodLabel.Name = "categoryFoodLabel";
            this.categoryFoodLabel.Size = new System.Drawing.Size(116, 20);
            this.categoryFoodLabel.TabIndex = 0;
            this.categoryFoodLabel.Text = "Mã danh mục";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "NewMenuForm";
            this.Load += new System.EventHandler(this.NewMenuForm_Load);
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThucDonBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            this.categoryFoodPanel.ResumeLayout(false);
            this.categoryFoodPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private CustomControl.JButton exitButton;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel categoryPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView foodData;
        private System.Windows.Forms.DataGridView categoryFoodData;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.JNewTextbox searchTextbox;
        private System.Windows.Forms.Label detailFoodLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel foodPanel;
        private CustomControl.JComboBox categoryCombobox;
        private CustomControl.JTextbox priceTextbox;
        private CustomControl.JTextbox unitTextbox;
        private CustomControl.JTextbox foodNameTextbox;
        private CustomControl.JTextbox foodIDTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel categoryFoodPanel;
        private CustomControl.JTextbox categoryNameTextbox;
        private System.Windows.Forms.Label categoryNameLabel;
        private CustomControl.JTextbox categoryIDTextbox;
        private System.Windows.Forms.Label categoryFoodLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CustomControl.JButton confirmButton;
        private CustomControl.JButton deleteCButton;
        private CustomControl.JButton editCButton;
        private CustomControl.JButton addCButton;
        private CustomControl.JButton deleteFButton;
        private CustomControl.JButton editFButton;
        private CustomControl.JButton addFButton;
        private System.Windows.Forms.ComboBox selectionCombobox;
        private System.Windows.Forms.BindingSource danhMucThucDonBindingSource;
        private System.Windows.Forms.BindingSource monBindingSource;
        private System.Windows.Forms.Panel panel5;
        private CustomControl.JButton ShowAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDanhMucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visible;
        private System.Windows.Forms.Panel buttonPanel;
        private CustomControl.JButton cancelButton;
        private System.Windows.Forms.Label exceptionLabel;
    }
}