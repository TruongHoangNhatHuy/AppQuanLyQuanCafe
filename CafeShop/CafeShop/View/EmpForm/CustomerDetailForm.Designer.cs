namespace CafeShop.View.EmpForm
{
    partial class CustomerDetailForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.genderGroupbox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.subTimeTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.birthdayPicker = new CafeShop.View.CustomControl.JDatetimepicker();
            this.addressTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.nameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.phoneNumberTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.genderGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Tomato;
            this.titleLabel.Location = new System.Drawing.Point(212, 29);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(355, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = " Thông tin chi tiết";
            // 
            // genderGroupbox
            // 
            this.genderGroupbox.Controls.Add(this.femaleRadioButton);
            this.genderGroupbox.Controls.Add(this.maleRadioButton);
            this.genderGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupbox.ForeColor = System.Drawing.Color.Crimson;
            this.genderGroupbox.Location = new System.Drawing.Point(387, 463);
            this.genderGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderGroupbox.Name = "genderGroupbox";
            this.genderGroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderGroupbox.Size = new System.Drawing.Size(336, 81);
            this.genderGroupbox.TabIndex = 7;
            this.genderGroupbox.TabStop = false;
            this.genderGroupbox.Text = "Giới tính";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(170, 41);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(64, 29);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.maleRadioButton.Location = new System.Drawing.Point(26, 39);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(81, 29);
            this.maleRadioButton.TabIndex = 5;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Nam";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDTextbox);
            this.groupBox1.Controls.Add(this.subTimeTextbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(387, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(336, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(31, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(31, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.birthdayPicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addressTextbox);
            this.groupBox2.Controls.Add(this.nameTextbox);
            this.groupBox2.Controls.Add(this.phoneNumberTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(24, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(355, 456);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(25, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên";
            // 
            // IDTextbox
            // 
            this.IDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.IDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTextbox.BorderRadius = 10;
            this.IDTextbox.BorderSize = 2;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(21, 77);
            this.IDTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTextbox.Multiline = false;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.IDTextbox.PasswordChar = false;
            this.IDTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.IDTextbox.PlaceholderText = "";
            this.IDTextbox.Size = new System.Drawing.Size(294, 48);
            this.IDTextbox.TabIndex = 9;
            this.IDTextbox.TabStop = false;
            this.IDTextbox.Texts = "";
            this.IDTextbox.UnderlinedStyle = false;
            // 
            // subTimeTextbox
            // 
            this.subTimeTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.subTimeTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.subTimeTextbox.BorderRadius = 10;
            this.subTimeTextbox.BorderSize = 2;
            this.subTimeTextbox.Enabled = false;
            this.subTimeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTimeTextbox.Location = new System.Drawing.Point(21, 177);
            this.subTimeTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subTimeTextbox.Multiline = false;
            this.subTimeTextbox.Name = "subTimeTextbox";
            this.subTimeTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.subTimeTextbox.PasswordChar = false;
            this.subTimeTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.subTimeTextbox.PlaceholderText = "";
            this.subTimeTextbox.Size = new System.Drawing.Size(294, 48);
            this.subTimeTextbox.TabIndex = 10;
            this.subTimeTextbox.TabStop = false;
            this.subTimeTextbox.Texts = "";
            this.subTimeTextbox.UnderlinedStyle = false;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.birthdayPicker.BorderSize = 0;
            this.birthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.birthdayPicker.Location = new System.Drawing.Point(21, 387);
            this.birthdayPicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(294, 35);
            this.birthdayPicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.birthdayPicker.TabIndex = 4;
            this.birthdayPicker.TextColor = System.Drawing.Color.White;
            // 
            // addressTextbox
            // 
            this.addressTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.addressTextbox.BorderRadius = 10;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addressTextbox.Location = new System.Drawing.Point(21, 283);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.addressTextbox.PlaceholderText = "";
            this.addressTextbox.Size = new System.Drawing.Size(294, 48);
            this.addressTextbox.TabIndex = 3;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextbox.Location = new System.Drawing.Point(21, 77);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.nameTextbox.PlaceholderText = "";
            this.nameTextbox.Size = new System.Drawing.Size(294, 48);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumberTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumberTextbox.BorderRadius = 10;
            this.phoneNumberTextbox.BorderSize = 2;
            this.phoneNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberTextbox.Location = new System.Drawing.Point(21, 177);
            this.phoneNumberTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberTextbox.Multiline = false;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.phoneNumberTextbox.PasswordChar = false;
            this.phoneNumberTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.phoneNumberTextbox.PlaceholderText = "";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(294, 48);
            this.phoneNumberTextbox.TabIndex = 2;
            this.phoneNumberTextbox.Texts = "";
            this.phoneNumberTextbox.UnderlinedStyle = false;
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
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmButton.Location = new System.Drawing.Point(428, 554);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(225, 61);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.cancelButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButton.BorderRadius = 30;
            this.cancelButton.BorderSize = 0;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(107, 554);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(225, 61);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.genderGroupbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmpDetailForm";
            this.genderGroupbox.ResumeLayout(false);
            this.genderGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.JNewTextbox subTimeTextbox;
        private CustomControl.JNewTextbox addressTextbox;
        private CustomControl.JNewTextbox phoneNumberTextbox;
        private System.Windows.Forms.Label titleLabel;
        private CustomControl.JNewTextbox IDTextbox;
        private CustomControl.JButton cancelButton;
        private CustomControl.JButton confirmButton;
        private CustomControl.JNewTextbox nameTextbox;
        private System.Windows.Forms.GroupBox genderGroupbox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControl.JDatetimepicker birthdayPicker;
    }
}