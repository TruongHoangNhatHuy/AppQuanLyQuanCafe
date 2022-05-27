namespace CafeShop.View.EmpForm
{
    partial class GoodsInfoForm
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
            this.MaLoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.detaiLabel = new System.Windows.Forms.Label();
            this.goodsNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.quantityTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.controlBarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.closeButton = new CafeShop.View.CustomControl.JButton();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).BeginInit();
            this.controlBarPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoHang,
            this.SoLuongNhap,
            this.NgayNhapKho,
            this.TienThanhToan,
            this.TaiKhoan});
            this.dataGridView1.DataSource = this.loHangBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(35, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(831, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaLoHang
            // 
            this.MaLoHang.DataPropertyName = "MaLoHang";
            this.MaLoHang.HeaderText = "Mã lô hàng";
            this.MaLoHang.MinimumWidth = 6;
            this.MaLoHang.Name = "MaLoHang";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.DataPropertyName = "NgayNhapKho";
            this.NgayNhapKho.HeaderText = "Ngày nhập kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            // 
            // TienThanhToan
            // 
            this.TienThanhToan.DataPropertyName = "TienThanhToan";
            this.TienThanhToan.HeaderText = "Thanh toán";
            this.TienThanhToan.MinimumWidth = 6;
            this.TienThanhToan.Name = "TienThanhToan";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            // 
            // loHangBindingSource
            // 
            this.loHangBindingSource.DataSource = typeof(CafeShop.DTO.LoHang);
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.goodsNameLabel.Location = new System.Drawing.Point(46, 134);
            this.goodsNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(146, 25);
            this.goodsNameLabel.TabIndex = 1;
            this.goodsNameLabel.Text = "Tên hàng hoá";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Crimson;
            this.quantityLabel.Location = new System.Drawing.Point(463, 134);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(174, 25);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Số lượng hiện tại";
            // 
            // detaiLabel
            // 
            this.detaiLabel.AutoSize = true;
            this.detaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaiLabel.ForeColor = System.Drawing.Color.Crimson;
            this.detaiLabel.Location = new System.Drawing.Point(30, 238);
            this.detaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detaiLabel.Name = "detaiLabel";
            this.detaiLabel.Size = new System.Drawing.Size(174, 25);
            this.detaiLabel.TabIndex = 3;
            this.detaiLabel.Text = "Lô hàng đã nhập";
            // 
            // goodsNameTextbox
            // 
            this.goodsNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodsNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodsNameTextbox.BorderRadius = 5;
            this.goodsNameTextbox.BorderSize = 2;
            this.goodsNameTextbox.Enabled = false;
            this.goodsNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextbox.Location = new System.Drawing.Point(51, 163);
            this.goodsNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.goodsNameTextbox.Multiline = false;
            this.goodsNameTextbox.Name = "goodsNameTextbox";
            this.goodsNameTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.goodsNameTextbox.PasswordChar = false;
            this.goodsNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.goodsNameTextbox.PlaceholderText = "";
            this.goodsNameTextbox.Size = new System.Drawing.Size(365, 39);
            this.goodsNameTextbox.TabIndex = 5;
            this.goodsNameTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.goodsNameTextbox.Texts = "";
            this.goodsNameTextbox.UnderlinedStyle = false;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextbox.BorderRadius = 5;
            this.quantityTextbox.BorderSize = 2;
            this.quantityTextbox.Enabled = false;
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.Location = new System.Drawing.Point(468, 163);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextbox.Multiline = false;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.quantityTextbox.PasswordChar = false;
            this.quantityTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantityTextbox.PlaceholderText = "";
            this.quantityTextbox.Size = new System.Drawing.Size(365, 39);
            this.quantityTextbox.TabIndex = 7;
            this.quantityTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextbox.Texts = "";
            this.quantityTextbox.UnderlinedStyle = false;
            // 
            // controlBarPanel
            // 
            this.controlBarPanel.Controls.Add(this.minimizeButton);
            this.controlBarPanel.Controls.Add(this.closeButton);
            this.controlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.controlBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlBarPanel.Name = "controlBarPanel";
            this.controlBarPanel.Size = new System.Drawing.Size(925, 38);
            this.controlBarPanel.TabIndex = 8;
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
            this.minimizeButton.Location = new System.Drawing.Point(781, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(72, 38);
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
            this.closeButton.Location = new System.Drawing.Point(853, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 38);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextColor = System.Drawing.Color.White;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 38);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(925, 79);
            this.titlePanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(253, 12);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(436, 63);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Chi Tiết Hàng Hoá";
            // 
            // GoodsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 676);
            this.ControlBox = false;
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.controlBarPanel);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.goodsNameTextbox);
            this.Controls.Add(this.detaiLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.goodsNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).EndInit();
            this.controlBarPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label detaiLabel;
        private CustomControl.JNewTextbox goodsNameTextbox;
        private CustomControl.JNewTextbox quantityTextbox;
        private System.Windows.Forms.Panel controlBarPanel;
        private CustomControl.JButton minimizeButton;
        private CustomControl.JButton closeButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.BindingSource loHangBindingSource;
    }
}