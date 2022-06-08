namespace CafeShop.View.AdForm
{
    partial class EmpInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauLamViecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVaiTroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetPasswordButton = new CafeShop.View.CustomControl.JButton();
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.sortButton = new CafeShop.View.CustomControl.JButton();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.updateButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.searchByComboBox = new CafeShop.View.CustomControl.JComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanViewBindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tenTaiKhoanDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.ngayBatDauLamViecDataGridViewTextBoxColumn,
            this.tenVaiTroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taiKhoanViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(938, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTaiKhoanDataGridViewTextBoxColumn
            // 
            this.tenTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TenTaiKhoan";
            this.tenTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTaiKhoanDataGridViewTextBoxColumn.Name = "tenTaiKhoanDataGridViewTextBoxColumn";
            this.tenTaiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayBatDauLamViecDataGridViewTextBoxColumn
            // 
            this.ngayBatDauLamViecDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDauLamViec";
            this.ngayBatDauLamViecDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu làm việc";
            this.ngayBatDauLamViecDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayBatDauLamViecDataGridViewTextBoxColumn.Name = "ngayBatDauLamViecDataGridViewTextBoxColumn";
            this.ngayBatDauLamViecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenVaiTroDataGridViewTextBoxColumn
            // 
            this.tenVaiTroDataGridViewTextBoxColumn.DataPropertyName = "TenVaiTro";
            this.tenVaiTroDataGridViewTextBoxColumn.HeaderText = "Vai trò";
            this.tenVaiTroDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenVaiTroDataGridViewTextBoxColumn.Name = "tenVaiTroDataGridViewTextBoxColumn";
            this.tenVaiTroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taiKhoanViewBindingSource
            // 
            this.taiKhoanViewBindingSource.DataSource = typeof(CafeShop.DTO.TaiKhoanView);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.resetPasswordButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.resetPasswordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetPasswordButton.BorderRadius = 30;
            this.resetPasswordButton.BorderSize = 0;
            this.resetPasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetPasswordButton.FlatAppearance.BorderSize = 0;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetPasswordButton.Location = new System.Drawing.Point(268, 4);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(158, 41);
            this.resetPasswordButton.TabIndex = 9;
            this.resetPasswordButton.Text = "Reset mật khẩu";
            this.resetPasswordButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(39, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(46, 40);
            this.exitButton.TabIndex = 8;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sortButton.BorderRadius = 15;
            this.sortButton.BorderSize = 0;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.Color.Black;
            this.sortButton.Location = new System.Drawing.Point(876, 14);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(113, 32);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sắp xếp";
            this.sortButton.TextColor = System.Drawing.Color.Black;
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.searchTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderRadius = 10;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTextbox.Location = new System.Drawing.Point(374, 14);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "         Tìm kiếm.......";
            this.searchTextbox.Size = new System.Drawing.Size(475, 32);
            this.searchTextbox.TabIndex = 4;
            this.searchTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            this.searchTextbox._TextChanged += new System.EventHandler(this.search);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(756, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 41);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 30;
            this.updateButton.BorderSize = 0;
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(512, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateButton.Size = new System.Drawing.Size(158, 41);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(24, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(158, 41);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchByComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchByComboBox.BorderSize = 1;
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.searchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.searchByComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.searchByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.Location = new System.Drawing.Point(51, 15);
            this.searchByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchByComboBox.MinimumSize = new System.Drawing.Size(134, 20);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.searchByComboBox.Size = new System.Drawing.Size(178, 32);
            this.searchByComboBox.TabIndex = 10;
            this.searchByComboBox.Texts = "";
            this.searchByComboBox.OnSelectedIndexChanged += new System.EventHandler(this.search);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1040, 52);
            this.topPanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchByComboBox);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Controls.Add(this.sortButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 52);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 9;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.resetPasswordButton, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.updateButton, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.addButton, 7, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(938, 49);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 104);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(51, 507);
            this.leftPanel.TabIndex = 14;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(989, 104);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(51, 507);
            this.rightPanel.TabIndex = 15;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(51, 596);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(938, 15);
            this.bottomPanel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(51, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 49);
            this.panel2.TabIndex = 17;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataGridView1);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(51, 104);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(938, 443);
            this.dataPanel.TabIndex = 18;
            // 
            // EmpInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1040, 611);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpInfoForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanViewBindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.JButton deleteButton;
        private CustomControl.JButton updateButton;
        private CustomControl.JButton addButton;
        private CustomControl.JNewTextbox searchTextbox;
        private CustomControl.JButton sortButton;
        private CustomControl.JButton exitButton;
        private CustomControl.JButton resetPasswordButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauLamViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVaiTroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taiKhoanViewBindingSource;
        private CustomControl.JComboBox searchByComboBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dataPanel;
    }
}