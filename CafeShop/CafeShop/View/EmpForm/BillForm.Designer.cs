namespace CafeShop.View.EmpForm
{
    partial class BillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.surchargeLabel = new System.Windows.Forms.Label();
            this.surchargePercent = new System.Windows.Forms.CheckBox();
            this.discountPercent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ThanhTienTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.discountTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.surchargeTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.tenKHTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.TongTienTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.soTienKhachDuaTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.tienThuaTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.SDTKhachHangTextBox = new CafeShop.View.CustomControl.JNewTextbox();
            this.checkCustomerButton = new CafeShop.View.CustomControl.JButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(56, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền các đơn gọi món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(56, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền khách đưa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(56, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiền thừa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(56, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 72);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thanh toán";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(406, 172);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(89, 25);
            this.discountLabel.TabIndex = 17;
            this.discountLabel.Text = "Giảm giá";
            // 
            // surchargeLabel
            // 
            this.surchargeLabel.AutoSize = true;
            this.surchargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surchargeLabel.Location = new System.Drawing.Point(87, 175);
            this.surchargeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surchargeLabel.Name = "surchargeLabel";
            this.surchargeLabel.Size = new System.Drawing.Size(79, 25);
            this.surchargeLabel.TabIndex = 16;
            this.surchargeLabel.Text = "Phụ thu";
            // 
            // surchargePercent
            // 
            this.surchargePercent.AutoSize = true;
            this.surchargePercent.Location = new System.Drawing.Point(212, 215);
            this.surchargePercent.Name = "surchargePercent";
            this.surchargePercent.Size = new System.Drawing.Size(49, 24);
            this.surchargePercent.TabIndex = 18;
            this.surchargePercent.Text = "%";
            this.surchargePercent.UseVisualStyleBackColor = true;
            this.surchargePercent.CheckedChanged += new System.EventHandler(this.CalculateCharge);
            // 
            // discountPercent
            // 
            this.discountPercent.AutoSize = true;
            this.discountPercent.Location = new System.Drawing.Point(544, 215);
            this.discountPercent.Name = "discountPercent";
            this.discountPercent.Size = new System.Drawing.Size(49, 24);
            this.discountPercent.TabIndex = 18;
            this.discountPercent.Text = "%";
            this.discountPercent.UseVisualStyleBackColor = true;
            this.discountPercent.CheckedChanged += new System.EventHandler(this.CalculateCharge);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(56, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thành tiền";
            // 
            // ThanhTienTextBox
            // 
            this.ThanhTienTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ThanhTienTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ThanhTienTextBox.BorderRadius = 5;
            this.ThanhTienTextBox.BorderSize = 2;
            this.ThanhTienTextBox.Enabled = false;
            this.ThanhTienTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanhTienTextBox.Location = new System.Drawing.Point(347, 274);
            this.ThanhTienTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThanhTienTextBox.Multiline = false;
            this.ThanhTienTextBox.Name = "ThanhTienTextBox";
            this.ThanhTienTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.ThanhTienTextBox.PasswordChar = false;
            this.ThanhTienTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ThanhTienTextBox.PlaceholderText = "";
            this.ThanhTienTextBox.Size = new System.Drawing.Size(272, 48);
            this.ThanhTienTextBox.TabIndex = 20;
            this.ThanhTienTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ThanhTienTextBox.Texts = "";
            this.ThanhTienTextBox.UnderlinedStyle = false;
            // 
            // discountTextbox
            // 
            this.discountTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.discountTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.discountTextbox.BorderRadius = 5;
            this.discountTextbox.BorderSize = 2;
            this.discountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextbox.Location = new System.Drawing.Point(402, 205);
            this.discountTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountTextbox.Multiline = false;
            this.discountTextbox.Name = "discountTextbox";
            this.discountTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.discountTextbox.PasswordChar = false;
            this.discountTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountTextbox.PlaceholderText = "";
            this.discountTextbox.Size = new System.Drawing.Size(134, 48);
            this.discountTextbox.TabIndex = 15;
            this.discountTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.discountTextbox.Texts = "0";
            this.discountTextbox.UnderlinedStyle = false;
            this.discountTextbox._TextChanged += new System.EventHandler(this.CalculateCharge);
            // 
            // surchargeTextbox
            // 
            this.surchargeTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.surchargeTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.surchargeTextbox.BorderRadius = 5;
            this.surchargeTextbox.BorderSize = 2;
            this.surchargeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surchargeTextbox.Location = new System.Drawing.Point(69, 205);
            this.surchargeTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surchargeTextbox.Multiline = false;
            this.surchargeTextbox.Name = "surchargeTextbox";
            this.surchargeTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.surchargeTextbox.PasswordChar = false;
            this.surchargeTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.surchargeTextbox.PlaceholderText = "";
            this.surchargeTextbox.Size = new System.Drawing.Size(134, 48);
            this.surchargeTextbox.TabIndex = 14;
            this.surchargeTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.surchargeTextbox.Texts = "0";
            this.surchargeTextbox.UnderlinedStyle = false;
            this.surchargeTextbox._TextChanged += new System.EventHandler(this.CalculateCharge);
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tenKHTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tenKHTextBox.BorderRadius = 5;
            this.tenKHTextBox.BorderSize = 2;
            this.tenKHTextBox.Enabled = false;
            this.tenKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKHTextBox.Location = new System.Drawing.Point(347, 597);
            this.tenKHTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenKHTextBox.Multiline = false;
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tenKHTextBox.PasswordChar = false;
            this.tenKHTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tenKHTextBox.PlaceholderText = "";
            this.tenKHTextBox.Size = new System.Drawing.Size(272, 48);
            this.tenKHTextBox.TabIndex = 12;
            this.tenKHTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tenKHTextBox.Texts = "";
            this.tenKHTextBox.UnderlinedStyle = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmButton.BorderRadius = 27;
            this.confirmButton.BorderSize = 0;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.Location = new System.Drawing.Point(372, 674);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(200, 58);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 27;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(60, 674);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 58);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TongTienTextBox
            // 
            this.TongTienTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TongTienTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TongTienTextBox.BorderRadius = 5;
            this.TongTienTextBox.BorderSize = 2;
            this.TongTienTextBox.Enabled = false;
            this.TongTienTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTienTextBox.Location = new System.Drawing.Point(347, 109);
            this.TongTienTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TongTienTextBox.Multiline = false;
            this.TongTienTextBox.Name = "TongTienTextBox";
            this.TongTienTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TongTienTextBox.PasswordChar = false;
            this.TongTienTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TongTienTextBox.PlaceholderText = "";
            this.TongTienTextBox.Size = new System.Drawing.Size(272, 48);
            this.TongTienTextBox.TabIndex = 9;
            this.TongTienTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TongTienTextBox.Texts = "";
            this.TongTienTextBox.UnderlinedStyle = false;
            // 
            // soTienKhachDuaTextBox
            // 
            this.soTienKhachDuaTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.soTienKhachDuaTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.soTienKhachDuaTextBox.BorderRadius = 5;
            this.soTienKhachDuaTextBox.BorderSize = 2;
            this.soTienKhachDuaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTienKhachDuaTextBox.Location = new System.Drawing.Point(347, 351);
            this.soTienKhachDuaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soTienKhachDuaTextBox.Multiline = false;
            this.soTienKhachDuaTextBox.Name = "soTienKhachDuaTextBox";
            this.soTienKhachDuaTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.soTienKhachDuaTextBox.PasswordChar = false;
            this.soTienKhachDuaTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.soTienKhachDuaTextBox.PlaceholderText = "";
            this.soTienKhachDuaTextBox.Size = new System.Drawing.Size(272, 48);
            this.soTienKhachDuaTextBox.TabIndex = 8;
            this.soTienKhachDuaTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.soTienKhachDuaTextBox.Texts = "";
            this.soTienKhachDuaTextBox.UnderlinedStyle = false;
            this.soTienKhachDuaTextBox._TextChanged += new System.EventHandler(this.CalculateCharge);
            // 
            // tienThuaTextBox
            // 
            this.tienThuaTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tienThuaTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tienThuaTextBox.BorderRadius = 5;
            this.tienThuaTextBox.BorderSize = 2;
            this.tienThuaTextBox.Enabled = false;
            this.tienThuaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienThuaTextBox.Location = new System.Drawing.Point(347, 440);
            this.tienThuaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tienThuaTextBox.Multiline = false;
            this.tienThuaTextBox.Name = "tienThuaTextBox";
            this.tienThuaTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.tienThuaTextBox.PasswordChar = false;
            this.tienThuaTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tienThuaTextBox.PlaceholderText = "";
            this.tienThuaTextBox.Size = new System.Drawing.Size(272, 48);
            this.tienThuaTextBox.TabIndex = 7;
            this.tienThuaTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tienThuaTextBox.Texts = "";
            this.tienThuaTextBox.UnderlinedStyle = false;
            // 
            // SDTKhachHangTextBox
            // 
            this.SDTKhachHangTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.SDTKhachHangTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.SDTKhachHangTextBox.BorderRadius = 5;
            this.SDTKhachHangTextBox.BorderSize = 2;
            this.SDTKhachHangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDTKhachHangTextBox.Location = new System.Drawing.Point(347, 526);
            this.SDTKhachHangTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SDTKhachHangTextBox.Multiline = false;
            this.SDTKhachHangTextBox.Name = "SDTKhachHangTextBox";
            this.SDTKhachHangTextBox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.SDTKhachHangTextBox.PasswordChar = false;
            this.SDTKhachHangTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SDTKhachHangTextBox.PlaceholderText = "";
            this.SDTKhachHangTextBox.Size = new System.Drawing.Size(272, 48);
            this.SDTKhachHangTextBox.TabIndex = 6;
            this.SDTKhachHangTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.SDTKhachHangTextBox.Texts = "";
            this.SDTKhachHangTextBox.UnderlinedStyle = false;
            // 
            // checkCustomerButton
            // 
            this.checkCustomerButton.BackColor = System.Drawing.Color.LightGreen;
            this.checkCustomerButton.BackgroundColor = System.Drawing.Color.LightGreen;
            this.checkCustomerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.checkCustomerButton.BorderRadius = 27;
            this.checkCustomerButton.BorderSize = 0;
            this.checkCustomerButton.FlatAppearance.BorderSize = 0;
            this.checkCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.checkCustomerButton.Location = new System.Drawing.Point(60, 588);
            this.checkCustomerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkCustomerButton.Name = "checkCustomerButton";
            this.checkCustomerButton.Size = new System.Drawing.Size(162, 58);
            this.checkCustomerButton.TabIndex = 5;
            this.checkCustomerButton.Text = "Kiểm tra";
            this.checkCustomerButton.TextColor = System.Drawing.Color.Black;
            this.checkCustomerButton.UseVisualStyleBackColor = false;
            this.checkCustomerButton.Click += new System.EventHandler(this.checkCustomerButton_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 772);
            this.ControlBox = false;
            this.Controls.Add(this.ThanhTienTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discountPercent);
            this.Controls.Add(this.surchargePercent);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.surchargeLabel);
            this.Controls.Add(this.discountTextbox);
            this.Controls.Add(this.surchargeTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenKHTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.TongTienTextBox);
            this.Controls.Add(this.soTienKhachDuaTextBox);
            this.Controls.Add(this.tienThuaTextBox);
            this.Controls.Add(this.SDTKhachHangTextBox);
            this.Controls.Add(this.checkCustomerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControl.JButton checkCustomerButton;
        private CustomControl.JNewTextbox SDTKhachHangTextBox;
        private CustomControl.JNewTextbox tienThuaTextBox;
        private CustomControl.JNewTextbox soTienKhachDuaTextBox;
        private CustomControl.JNewTextbox TongTienTextBox;
        private CustomControl.JButton cancelButton;
        private CustomControl.JButton confirmButton;
        private CustomControl.JNewTextbox tenKHTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label surchargeLabel;
        private CustomControl.JNewTextbox discountTextbox;
        private CustomControl.JNewTextbox surchargeTextbox;
        private System.Windows.Forms.CheckBox surchargePercent;
        private System.Windows.Forms.CheckBox discountPercent;
        private CustomControl.JNewTextbox ThanhTienTextBox;
        private System.Windows.Forms.Label label6;
    }
}