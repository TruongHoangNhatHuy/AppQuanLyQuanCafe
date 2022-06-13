namespace CafeShop.View.EmpForm
{
    partial class OrderListForm
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
            this.maDonGoiMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGoiMonViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reloadTimer = new System.Windows.Forms.Timer(this.components);
            this.reloadButton = new CafeShop.View.CustomControl.JButton();
            this.cancelFoodButton = new CafeShop.View.CustomControl.JButton();
            this.performButton = new CafeShop.View.CustomControl.JButton();
            this.searchButton = new CafeShop.View.CustomControl.JButton();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.jButton2 = new CafeShop.View.CustomControl.JButton();
            this.donGoiMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonGoiMonDataGridViewTextBoxColumn,
            this.TenBan,
            this.tenMonDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn,
            this.TinhTrang});
            this.dataGridView1.DataSource = this.donGoiMonViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 519);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maDonGoiMonDataGridViewTextBoxColumn
            // 
            this.maDonGoiMonDataGridViewTextBoxColumn.DataPropertyName = "MaDonGoiMon";
            this.maDonGoiMonDataGridViewTextBoxColumn.HeaderText = "MaDonGoiMon";
            this.maDonGoiMonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maDonGoiMonDataGridViewTextBoxColumn.Name = "maDonGoiMonDataGridViewTextBoxColumn";
            this.maDonGoiMonDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDonGoiMonDataGridViewTextBoxColumn.Visible = false;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 8;
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianTuKhiGoiDataGridViewTextBoxColumn
            // 
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianTuKhiGoi";
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.HeaderText = "Thời gian từ khi gọi món (phút)";
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.Name = "thoiGianTuKhiGoiDataGridViewTextBoxColumn";
            this.thoiGianTuKhiGoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // donGoiMonViewBindingSource
            // 
            this.donGoiMonViewBindingSource.DataSource = typeof(CafeShop.DTO.DonGoiMonView);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // reloadTimer
            // 
            this.reloadTimer.Interval = 20000;
            this.reloadTimer.Tick += new System.EventHandler(this.reloadTimer_Tick);
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Crimson;
            this.reloadButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.reloadButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reloadButton.BorderRadius = 30;
            this.reloadButton.BorderSize = 0;
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Image = global::CafeShop.Properties.Resources.exit;
            this.reloadButton.Location = new System.Drawing.Point(24, 12);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(55, 40);
            this.reloadButton.TabIndex = 16;
            this.reloadButton.TextColor = System.Drawing.Color.White;
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // cancelFoodButton
            // 
            this.cancelFoodButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelFoodButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelFoodButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.cancelFoodButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelFoodButton.BorderRadius = 20;
            this.cancelFoodButton.BorderSize = 0;
            this.cancelFoodButton.Enabled = false;
            this.cancelFoodButton.FlatAppearance.BorderSize = 0;
            this.cancelFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelFoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelFoodButton.ForeColor = System.Drawing.Color.Black;
            this.cancelFoodButton.Location = new System.Drawing.Point(916, 208);
            this.cancelFoodButton.Name = "cancelFoodButton";
            this.cancelFoodButton.Size = new System.Drawing.Size(101, 51);
            this.cancelFoodButton.TabIndex = 15;
            this.cancelFoodButton.Text = "Huỷ món";
            this.cancelFoodButton.TextColor = System.Drawing.Color.Black;
            this.cancelFoodButton.UseVisualStyleBackColor = false;
            this.cancelFoodButton.Click += new System.EventHandler(this.cancelFoodButton_Click);
            // 
            // performButton
            // 
            this.performButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.performButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.performButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.performButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.performButton.BorderRadius = 20;
            this.performButton.BorderSize = 0;
            this.performButton.FlatAppearance.BorderSize = 0;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performButton.ForeColor = System.Drawing.Color.Black;
            this.performButton.Location = new System.Drawing.Point(916, 125);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(101, 51);
            this.performButton.TabIndex = 14;
            this.performButton.Text = "Thực hiện";
            this.performButton.TextColor = System.Drawing.Color.Black;
            this.performButton.UseVisualStyleBackColor = false;
            this.performButton.Click += new System.EventHandler(this.performButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 15;
            this.searchButton.BorderSize = 0;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Image = global::CafeShop.Properties.Resources.magnifying_glass;
            this.searchButton.Location = new System.Drawing.Point(916, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 32);
            this.searchButton.TabIndex = 13;
            this.searchButton.TextColor = System.Drawing.Color.Black;
            this.searchButton.UseVisualStyleBackColor = false;
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
            this.searchTextbox.Location = new System.Drawing.Point(515, 69);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "         Tìm kiếm.......";
            this.searchTextbox.Size = new System.Drawing.Size(386, 32);
            this.searchTextbox.TabIndex = 12;
            this.searchTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            // 
            // jButton2
            // 
            this.jButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton2.BorderRadius = 15;
            this.jButton2.BorderSize = 0;
            this.jButton2.FlatAppearance.BorderSize = 0;
            this.jButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton2.ForeColor = System.Drawing.Color.Black;
            this.jButton2.Location = new System.Drawing.Point(46, 69);
            this.jButton2.Name = "jButton2";
            this.jButton2.Size = new System.Drawing.Size(95, 32);
            this.jButton2.TabIndex = 10;
            this.jButton2.Text = "Sắp xếp";
            this.jButton2.TextColor = System.Drawing.Color.Black;
            this.jButton2.UseVisualStyleBackColor = false;
            // 
            // donGoiMonBindingSource
            // 
            this.donGoiMonBindingSource.DataSource = typeof(CafeShop.DTO.DonGoiMon);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 595);
            this.ControlBox = false;
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.cancelFoodButton);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.jButton2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGoiMonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource donGoiMonBindingSource;
        private System.Windows.Forms.BindingSource donGoiMonViewBindingSource;
        private CustomControl.JButton jButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomControl.JNewTextbox searchTextbox;
        private CustomControl.JButton searchButton;
        private CustomControl.JButton performButton;
        private CustomControl.JButton cancelFoodButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonGoiMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianTuKhiGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private CustomControl.JButton reloadButton;
        private System.Windows.Forms.Timer reloadTimer;
    }
}