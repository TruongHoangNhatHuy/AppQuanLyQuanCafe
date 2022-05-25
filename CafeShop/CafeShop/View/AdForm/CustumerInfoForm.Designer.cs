namespace CafeShop.View.AdForm
{
    partial class CustomerInfoForm
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
            this.iDKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhKHDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDangKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.updateButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.searchByComboBox = new CafeShop.View.CustomControl.JComboBox();
            this.sortButton = new CafeShop.View.CustomControl.JButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKhachHangDataGridViewTextBoxColumn,
            this.hoTenKHDataGridViewTextBoxColumn,
            this.soDienThoaiKHDataGridViewTextBoxColumn,
            this.gioiTinhKHDataGridViewCheckBoxColumn,
            this.ngaySinhKHDataGridViewTextBoxColumn,
            this.diaChiKHDataGridViewTextBoxColumn,
            this.ngayDangKiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDKhachHangDataGridViewTextBoxColumn
            // 
            this.iDKhachHangDataGridViewTextBoxColumn.DataPropertyName = "IDKhachHang";
            this.iDKhachHangDataGridViewTextBoxColumn.HeaderText = "ID Khách hàng";
            this.iDKhachHangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDKhachHangDataGridViewTextBoxColumn.Name = "iDKhachHangDataGridViewTextBoxColumn";
            this.iDKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKhachHangDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenKHDataGridViewTextBoxColumn
            // 
            this.hoTenKHDataGridViewTextBoxColumn.DataPropertyName = "HoTenKH";
            this.hoTenKHDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenKHDataGridViewTextBoxColumn.Name = "hoTenKHDataGridViewTextBoxColumn";
            this.hoTenKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // soDienThoaiKHDataGridViewTextBoxColumn
            // 
            this.soDienThoaiKHDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoaiKH";
            this.soDienThoaiKHDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soDienThoaiKHDataGridViewTextBoxColumn.Name = "soDienThoaiKHDataGridViewTextBoxColumn";
            this.soDienThoaiKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDienThoaiKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioiTinhKHDataGridViewCheckBoxColumn
            // 
            this.gioiTinhKHDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinhKH";
            this.gioiTinhKHDataGridViewCheckBoxColumn.HeaderText = "Giới tính (Là nam)";
            this.gioiTinhKHDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.gioiTinhKHDataGridViewCheckBoxColumn.Name = "gioiTinhKHDataGridViewCheckBoxColumn";
            this.gioiTinhKHDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gioiTinhKHDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinhKHDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gioiTinhKHDataGridViewCheckBoxColumn.Width = 150;
            // 
            // ngaySinhKHDataGridViewTextBoxColumn
            // 
            this.ngaySinhKHDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhKHDataGridViewTextBoxColumn.Name = "ngaySinhKHDataGridViewTextBoxColumn";
            this.ngaySinhKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiKHDataGridViewTextBoxColumn
            // 
            this.diaChiKHDataGridViewTextBoxColumn.DataPropertyName = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiKHDataGridViewTextBoxColumn.Name = "diaChiKHDataGridViewTextBoxColumn";
            this.diaChiKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiKHDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayDangKiDataGridViewTextBoxColumn
            // 
            this.ngayDangKiDataGridViewTextBoxColumn.DataPropertyName = "NgayDangKi";
            this.ngayDangKiDataGridViewTextBoxColumn.HeaderText = "Ngày đăng kí";
            this.ngayDangKiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayDangKiDataGridViewTextBoxColumn.Name = "ngayDangKiDataGridViewTextBoxColumn";
            this.ngayDangKiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDangKiDataGridViewTextBoxColumn.Width = 150;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(CafeShop.DTO.KhachHang);
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
            this.exitButton.Location = new System.Drawing.Point(16, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(61, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.searchTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderRadius = 10;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTextbox.Location = new System.Drawing.Point(383, 54);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "         Tìm kiếm.......";
            this.searchTextbox.Size = new System.Drawing.Size(633, 39);
            this.searchTextbox.TabIndex = 4;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            this.searchTextbox._TextChanged += new System.EventHandler(this.search);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(1025, 668);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(205, 49);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 30;
            this.updateButton.BorderSize = 0;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(637, 668);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateButton.Size = new System.Drawing.Size(205, 49);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(255, 668);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(205, 49);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchByComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchByComboBox.BorderSize = 1;
            this.searchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.searchByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchByComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.searchByComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.searchByComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.searchByComboBox.Location = new System.Drawing.Point(120, 54);
            this.searchByComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchByComboBox.MinimumSize = new System.Drawing.Size(178, 24);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.searchByComboBox.Size = new System.Drawing.Size(238, 44);
            this.searchByComboBox.TabIndex = 9;
            this.searchByComboBox.Texts = "";
            this.searchByComboBox.OnSelectedIndexChanged += new System.EventHandler(this.search);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sortButton.BorderRadius = 15;
            this.sortButton.BorderSize = 0;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.Color.Black;
            this.sortButton.Location = new System.Drawing.Point(1049, 54);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(151, 39);
            this.sortButton.TabIndex = 10;
            this.sortButton.Text = "Sắp xếp";
            this.sortButton.TextColor = System.Drawing.Color.Black;
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1539, 752);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerInfoForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.JButton deleteButton;
        private CustomControl.JButton updateButton;
        private CustomControl.JButton addButton;
        private CustomControl.JNewTextbox searchTextbox;
        private CustomControl.JButton exitButton;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhKHDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDangKiDataGridViewTextBoxColumn;
        private CustomControl.JComboBox searchByComboBox;
        private CustomControl.JButton sortButton;
    }
}