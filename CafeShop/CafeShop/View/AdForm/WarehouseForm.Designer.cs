namespace CafeShop.View.AdForm
{
    partial class WarehouseForm
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
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.goodsNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.quantityTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.importRadioButton = new System.Windows.Forms.RadioButton();
            this.updateButton = new CafeShop.View.CustomControl.JButton();
            this.showInfoButton = new CafeShop.View.CustomControl.JButton();
            this.editButton = new CafeShop.View.CustomControl.JButton();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.MaHangHoa,
            this.TenHangHoa,
            this.SoLuong,
            this.DonVi});
            this.dataGridView1.DataSource = this.hangHoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(829, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateMode);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            this.MaHangHoa.HeaderText = "Mã hàng hóa";
            this.MaHangHoa.MinimumWidth = 6;
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Tên hàng hóa";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(CafeShop.DTO.HangHoa);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalTextbox);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.goodsNameLabel);
            this.groupBox1.Controls.Add(this.goodsNameTextbox);
            this.groupBox1.Controls.Add(this.quantityTextbox);
            this.groupBox1.Controls.Add(this.updateRadioButton);
            this.groupBox1.Controls.Add(this.importRadioButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1098, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(561, 725);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiệu chỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(91, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // totalTextbox
            // 
            this.totalTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.totalTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.totalTextbox.BorderSize = 2;
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.totalTextbox.Location = new System.Drawing.Point(96, 471);
            this.totalTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.totalTextbox.Multiline = false;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.totalTextbox.PasswordChar = false;
            this.totalTextbox.ReadOnly = false;
            this.totalTextbox.Size = new System.Drawing.Size(405, 48);
            this.totalTextbox.TabIndex = 11;
            this.totalTextbox.Texts = "";
            this.totalTextbox.UnderlinedStyle = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalLabel.Location = new System.Drawing.Point(91, 435);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(193, 29);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Tiền thanh toán";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Crimson;
            this.quantityLabel.Location = new System.Drawing.Point(91, 271);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(117, 29);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Số lượng";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.goodsNameLabel.Location = new System.Drawing.Point(91, 125);
            this.goodsNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(173, 29);
            this.goodsNameLabel.TabIndex = 8;
            this.goodsNameLabel.Text = "Tên hàng hoá";
            // 
            // goodsNameTextbox
            // 
            this.goodsNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.goodsNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodsNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodsNameTextbox.BorderSize = 2;
            this.goodsNameTextbox.Enabled = false;
            this.goodsNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.goodsNameTextbox.Location = new System.Drawing.Point(98, 162);
            this.goodsNameTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.goodsNameTextbox.Multiline = false;
            this.goodsNameTextbox.Name = "goodsNameTextbox";
            this.goodsNameTextbox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.goodsNameTextbox.PasswordChar = false;
            this.goodsNameTextbox.ReadOnly = false;
            this.goodsNameTextbox.Size = new System.Drawing.Size(404, 48);
            this.goodsNameTextbox.TabIndex = 6;
            this.goodsNameTextbox.Texts = "";
            this.goodsNameTextbox.UnderlinedStyle = false;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextbox.BorderSize = 2;
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextbox.Location = new System.Drawing.Point(98, 309);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quantityTextbox.Multiline = false;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.quantityTextbox.PasswordChar = false;
            this.quantityTextbox.ReadOnly = false;
            this.quantityTextbox.Size = new System.Drawing.Size(404, 48);
            this.quantityTextbox.TabIndex = 5;
            this.quantityTextbox.Texts = "";
            this.quantityTextbox.UnderlinedStyle = false;
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(330, 51);
            this.updateRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(181, 41);
            this.updateRadioButton.TabIndex = 4;
            this.updateRadioButton.Text = "Cập nhật";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            // 
            // importRadioButton
            // 
            this.importRadioButton.AutoSize = true;
            this.importRadioButton.Checked = true;
            this.importRadioButton.Location = new System.Drawing.Point(98, 51);
            this.importRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importRadioButton.Name = "importRadioButton";
            this.importRadioButton.Size = new System.Drawing.Size(210, 41);
            this.importRadioButton.TabIndex = 3;
            this.importRadioButton.TabStop = true;
            this.importRadioButton.Text = "Nhập hàng";
            this.importRadioButton.UseVisualStyleBackColor = true;
            this.importRadioButton.CheckedChanged += new System.EventHandler(this.importRadioButton_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 30;
            this.updateButton.BorderSize = 0;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(189, 639);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(225, 61);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.Color.Black;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.showInfoButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.showInfoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.showInfoButton.BorderRadius = 30;
            this.showInfoButton.BorderSize = 0;
            this.showInfoButton.FlatAppearance.BorderSize = 0;
            this.showInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoButton.ForeColor = System.Drawing.Color.Black;
            this.showInfoButton.Location = new System.Drawing.Point(566, 749);
            this.showInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(225, 61);
            this.showInfoButton.TabIndex = 6;
            this.showInfoButton.Text = "Thông tin";
            this.showInfoButton.TextColor = System.Drawing.Color.Black;
            this.showInfoButton.UseVisualStyleBackColor = false;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 30;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(180, 820);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(225, 61);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Sửa";
            this.editButton.TextColor = System.Drawing.Color.Black;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(180, 749);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(225, 61);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.Color.Black;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(566, 820);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 61);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.Color.Black;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(78, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin hàng hoá";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1731, 940);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WarehouseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.JButton deleteButton;
        private CustomControl.JButton updateButton;
        private CustomControl.JButton addButton;
        private CustomControl.JButton editButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControl.JTextbox quantityTextbox;
        private CustomControl.JTextbox goodsNameTextbox;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton importRadioButton;
        private CustomControl.JButton showInfoButton;
        private CustomControl.JTextbox totalTextbox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.Label label1;
    }
}