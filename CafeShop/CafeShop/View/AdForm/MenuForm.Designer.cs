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
            this.label1 = new System.Windows.Forms.Label();
            this.detailFoodLabel = new System.Windows.Forms.Label();
            this.categoryFoodData = new System.Windows.Forms.DataGridView();
            this.foodData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryFoodPanel = new System.Windows.Forms.Panel();
            this.categoryFoodLabel = new System.Windows.Forms.Label();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.foodPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.categoryCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.priceTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.unitTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.foodNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.foodIDTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.categoryNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.categoryIDTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMucThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMucThucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editCButton = new CafeShop.View.CustomControl.JButton();
            this.addCButton = new CafeShop.View.CustomControl.JButton();
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.deleteCButton = new CafeShop.View.CustomControl.JButton();
            this.jButton7 = new CafeShop.View.CustomControl.JButton();
            this.jNewTextbox1 = new CafeShop.View.CustomControl.JNewTextbox();
            this.deleteFButton = new CafeShop.View.CustomControl.JButton();
            this.editFButton = new CafeShop.View.CustomControl.JButton();
            this.addFButton = new CafeShop.View.CustomControl.JButton();
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.categoryFoodPanel.SuspendLayout();
            this.foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThucDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các hạng mục - Nhóm món";
            // 
            // detailFoodLabel
            // 
            this.detailFoodLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailFoodLabel.AutoSize = true;
            this.detailFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFoodLabel.ForeColor = System.Drawing.Color.Crimson;
            this.detailFoodLabel.Location = new System.Drawing.Point(307, 75);
            this.detailFoodLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.detailFoodLabel.Name = "detailFoodLabel";
            this.detailFoodLabel.Size = new System.Drawing.Size(93, 16);
            this.detailFoodLabel.TabIndex = 2;
            this.detailFoodLabel.Text = "Chi tiết món ăn";
            // 
            // categoryFoodData
            // 
            this.categoryFoodData.AllowUserToAddRows = false;
            this.categoryFoodData.AllowUserToDeleteRows = false;
            this.categoryFoodData.AllowUserToOrderColumns = true;
            this.categoryFoodData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryFoodData.AutoGenerateColumns = false;
            this.categoryFoodData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryFoodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryFoodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc});
            this.categoryFoodData.DataSource = this.danhMucThucDonBindingSource;
            this.categoryFoodData.Location = new System.Drawing.Point(21, 97);
            this.categoryFoodData.Name = "categoryFoodData";
            this.categoryFoodData.ReadOnly = true;
            this.categoryFoodData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryFoodData.Size = new System.Drawing.Size(249, 441);
            this.categoryFoodData.TabIndex = 17;
            this.categoryFoodData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryFoodData_CellDoubleClick);
            // 
            // foodData
            // 
            this.foodData.AllowUserToAddRows = false;
            this.foodData.AllowUserToDeleteRows = false;
            this.foodData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.foodData.AutoGenerateColumns = false;
            this.foodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.DonVi,
            this.DanhMucThucDon});
            this.foodData.DataSource = this.monBindingSource;
            this.foodData.Location = new System.Drawing.Point(276, 97);
            this.foodData.Name = "foodData";
            this.foodData.ReadOnly = true;
            this.foodData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodData.Size = new System.Drawing.Size(535, 441);
            this.foodData.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foodPanel);
            this.groupBox1.Controls.Add(this.categoryFoodPanel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(817, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 456);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
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
            // categoryFoodLabel
            // 
            this.categoryFoodLabel.AutoSize = true;
            this.categoryFoodLabel.Location = new System.Drawing.Point(18, 9);
            this.categoryFoodLabel.Name = "categoryFoodLabel";
            this.categoryFoodLabel.Size = new System.Drawing.Size(116, 20);
            this.categoryFoodLabel.TabIndex = 0;
            this.categoryFoodLabel.Text = "Mã danh mục";
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
            this.foodPanel.Location = new System.Drawing.Point(25, 29);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(291, 374);
            this.foodPanel.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên món";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
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
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmButton.BorderRadius = 30;
            this.confirmButton.BorderSize = 0;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(910, 552);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 40);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryCombobox.BorderSize = 2;
            this.categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.categoryCombobox.ForeColor = System.Drawing.Color.DimGray;
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
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.priceTextbox.Location = new System.Drawing.Point(22, 329);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextbox.Multiline = false;
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.priceTextbox.PasswordChar = false;
            this.priceTextbox.ReadOnly = false;
            this.priceTextbox.Size = new System.Drawing.Size(252, 32);
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
            this.unitTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.unitTextbox.Location = new System.Drawing.Point(22, 256);
            this.unitTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.unitTextbox.Multiline = false;
            this.unitTextbox.Name = "unitTextbox";
            this.unitTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.unitTextbox.PasswordChar = false;
            this.unitTextbox.ReadOnly = false;
            this.unitTextbox.Size = new System.Drawing.Size(252, 32);
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
            this.foodNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.foodNameTextbox.Location = new System.Drawing.Point(19, 104);
            this.foodNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodNameTextbox.Multiline = false;
            this.foodNameTextbox.Name = "foodNameTextbox";
            this.foodNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.foodNameTextbox.PasswordChar = false;
            this.foodNameTextbox.ReadOnly = false;
            this.foodNameTextbox.Size = new System.Drawing.Size(252, 32);
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
            this.foodIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodIDTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.foodIDTextbox.Location = new System.Drawing.Point(22, 34);
            this.foodIDTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodIDTextbox.Multiline = false;
            this.foodIDTextbox.Name = "foodIDTextbox";
            this.foodIDTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.foodIDTextbox.PasswordChar = false;
            this.foodIDTextbox.ReadOnly = true;
            this.foodIDTextbox.Size = new System.Drawing.Size(252, 32);
            this.foodIDTextbox.TabIndex = 6;
            this.foodIDTextbox.Texts = "";
            this.foodIDTextbox.UnderlinedStyle = false;
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.categoryNameTextbox.BorderSize = 2;
            this.categoryNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.categoryNameTextbox.Location = new System.Drawing.Point(22, 113);
            this.categoryNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryNameTextbox.Multiline = false;
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.categoryNameTextbox.PasswordChar = false;
            this.categoryNameTextbox.ReadOnly = false;
            this.categoryNameTextbox.Size = new System.Drawing.Size(252, 32);
            this.categoryNameTextbox.TabIndex = 3;
            this.categoryNameTextbox.Texts = "";
            this.categoryNameTextbox.UnderlinedStyle = false;
            // 
            // categoryIDTextbox
            // 
            this.categoryIDTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.categoryIDTextbox.BorderSize = 2;
            this.categoryIDTextbox.Enabled = false;
            this.categoryIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.categoryIDTextbox.Location = new System.Drawing.Point(22, 33);
            this.categoryIDTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryIDTextbox.Multiline = false;
            this.categoryIDTextbox.Name = "categoryIDTextbox";
            this.categoryIDTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.categoryIDTextbox.PasswordChar = false;
            this.categoryIDTextbox.ReadOnly = true;
            this.categoryIDTextbox.Size = new System.Drawing.Size(252, 32);
            this.categoryIDTextbox.TabIndex = 1;
            this.categoryIDTextbox.Texts = "";
            this.categoryIDTextbox.UnderlinedStyle = false;
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
            // DanhMucThucDon
            // 
            this.DanhMucThucDon.DataPropertyName = "DanhMucThucDon";
            this.DanhMucThucDon.HeaderText = "Tên danh mục";
            this.DanhMucThucDon.Name = "DanhMucThucDon";
            this.DanhMucThucDon.ReadOnly = true;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataSource = typeof(CafeShop.DTO.Mon);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Mã danh mục";
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // danhMucThucDonBindingSource
            // 
            this.danhMucThucDonBindingSource.DataSource = typeof(CafeShop.DTO.DanhMucThucDon);
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
            this.editCButton.Location = new System.Drawing.Point(111, 544);
            this.editCButton.Name = "editCButton";
            this.editCButton.Size = new System.Drawing.Size(68, 29);
            this.editCButton.TabIndex = 5;
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
            this.addCButton.Location = new System.Drawing.Point(202, 544);
            this.addCButton.Name = "addCButton";
            this.addCButton.Size = new System.Drawing.Size(68, 29);
            this.addCButton.TabIndex = 4;
            this.addCButton.Text = "Thêm";
            this.addCButton.TextColor = System.Drawing.Color.Black;
            this.addCButton.UseVisualStyleBackColor = false;
            this.addCButton.Click += new System.EventHandler(this.addCButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(51, 40);
            this.exitButton.TabIndex = 16;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.deleteCButton.Location = new System.Drawing.Point(21, 544);
            this.deleteCButton.Name = "deleteCButton";
            this.deleteCButton.Size = new System.Drawing.Size(68, 29);
            this.deleteCButton.TabIndex = 6;
            this.deleteCButton.Text = "Xoá";
            this.deleteCButton.TextColor = System.Drawing.Color.Black;
            this.deleteCButton.UseVisualStyleBackColor = false;
            // 
            // jButton7
            // 
            this.jButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jButton7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton7.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton7.BorderRadius = 15;
            this.jButton7.BorderSize = 0;
            this.jButton7.FlatAppearance.BorderSize = 0;
            this.jButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton7.ForeColor = System.Drawing.Color.White;
            this.jButton7.Image = global::CafeShop.Properties.Resources.magnifying_glass;
            this.jButton7.Location = new System.Drawing.Point(717, 61);
            this.jButton7.Name = "jButton7";
            this.jButton7.Size = new System.Drawing.Size(62, 32);
            this.jButton7.TabIndex = 11;
            this.jButton7.TextColor = System.Drawing.Color.White;
            this.jButton7.UseVisualStyleBackColor = false;
            // 
            // jNewTextbox1
            // 
            this.jNewTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jNewTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.jNewTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.jNewTextbox1.BorderRadius = 5;
            this.jNewTextbox1.BorderSize = 2;
            this.jNewTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jNewTextbox1.Location = new System.Drawing.Point(490, 61);
            this.jNewTextbox1.Multiline = false;
            this.jNewTextbox1.Name = "jNewTextbox1";
            this.jNewTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.jNewTextbox1.PasswordChar = false;
            this.jNewTextbox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.jNewTextbox1.PlaceholderText = "Tìm kiếm...";
            this.jNewTextbox1.Size = new System.Drawing.Size(196, 32);
            this.jNewTextbox1.TabIndex = 10;
            this.jNewTextbox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.jNewTextbox1.Texts = "";
            this.jNewTextbox1.UnderlinedStyle = false;
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
            this.deleteFButton.Location = new System.Drawing.Point(386, 559);
            this.deleteFButton.Name = "deleteFButton";
            this.deleteFButton.Size = new System.Drawing.Size(94, 29);
            this.deleteFButton.TabIndex = 9;
            this.deleteFButton.Text = "Xoá";
            this.deleteFButton.TextColor = System.Drawing.Color.Black;
            this.deleteFButton.UseVisualStyleBackColor = false;
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
            this.editFButton.Location = new System.Drawing.Point(508, 559);
            this.editFButton.Name = "editFButton";
            this.editFButton.Size = new System.Drawing.Size(94, 29);
            this.editFButton.TabIndex = 8;
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
            this.addFButton.Location = new System.Drawing.Point(632, 559);
            this.addFButton.Name = "addFButton";
            this.addFButton.Size = new System.Drawing.Size(94, 29);
            this.addFButton.TabIndex = 7;
            this.addFButton.Text = "Thêm";
            this.addFButton.TextColor = System.Drawing.Color.Black;
            this.addFButton.UseVisualStyleBackColor = false;
            this.addFButton.Click += new System.EventHandler(this.addFButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.foodData);
            this.Controls.Add(this.categoryFoodData);
            this.Controls.Add(this.editCButton);
            this.Controls.Add(this.addCButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteCButton);
            this.Controls.Add(this.jButton7);
            this.Controls.Add(this.jNewTextbox1);
            this.Controls.Add(this.deleteFButton);
            this.Controls.Add(this.editFButton);
            this.Controls.Add(this.addFButton);
            this.Controls.Add(this.detailFoodLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryFoodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.categoryFoodPanel.ResumeLayout(false);
            this.categoryFoodPanel.PerformLayout();
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThucDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label detailFoodLabel;
        private CustomControl.JButton addCButton;
        private CustomControl.JButton editCButton;
        private CustomControl.JButton deleteCButton;
        private CustomControl.JButton deleteFButton;
        private CustomControl.JButton editFButton;
        private CustomControl.JButton addFButton;
        private CustomControl.JNewTextbox jNewTextbox1;
        private CustomControl.JButton jButton7;
        private CustomControl.JButton exitButton;
        private System.Windows.Forms.DataGridView categoryFoodData;
        private System.Windows.Forms.DataGridView foodData;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControl.JButton confirmButton;
        private System.Windows.Forms.Panel categoryFoodPanel;
        private CustomControl.JTextbox categoryNameTextbox;
        private System.Windows.Forms.Label categoryNameLabel;
        private CustomControl.JTextbox categoryIDTextbox;
        private System.Windows.Forms.Label categoryFoodLabel;
        private System.Windows.Forms.Panel foodPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControl.JComboBox categoryCombobox;
        private CustomControl.JTextbox priceTextbox;
        private CustomControl.JTextbox unitTextbox;
        private CustomControl.JTextbox foodNameTextbox;
        private CustomControl.JTextbox foodIDTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.BindingSource danhMucThucDonBindingSource;
        private System.Windows.Forms.BindingSource monBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMucThucDon;
    }
}