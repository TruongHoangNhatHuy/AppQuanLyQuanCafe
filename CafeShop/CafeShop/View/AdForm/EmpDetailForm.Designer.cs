namespace CafeShop.View.AdForm
{
    partial class EmpDetailForm
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
            this.roleLabel = new System.Windows.Forms.Label();
            this.genderGroupbox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayPicker = new CafeShop.View.CustomControl.JDatetimepicker();
            this.nameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addressTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.phoneNumberTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roleCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.IDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.titleLabel.Location = new System.Drawing.Point(141, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(232, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = " Thông tin chi tiết";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roleLabel.Location = new System.Drawing.Point(8, 169);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(56, 17);
            this.roleLabel.TabIndex = 99;
            this.roleLabel.Text = "Vai trò";
            // 
            // genderGroupbox
            // 
            this.genderGroupbox.Controls.Add(this.femaleRadioButton);
            this.genderGroupbox.Controls.Add(this.maleRadioButton);
            this.genderGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupbox.ForeColor = System.Drawing.Color.Crimson;
            this.genderGroupbox.Location = new System.Drawing.Point(260, 292);
            this.genderGroupbox.Name = "genderGroupbox";
            this.genderGroupbox.Size = new System.Drawing.Size(224, 61);
            this.genderGroupbox.TabIndex = 8;
            this.genderGroupbox.TabStop = false;
            this.genderGroupbox.Text = "Giới tính";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(113, 30);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(44, 20);
            this.femaleRadioButton.TabIndex = 10;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.maleRadioButton.Location = new System.Drawing.Point(17, 30);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(57, 20);
            this.maleRadioButton.TabIndex = 9;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Nam";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.birthdayPicker);
            this.groupBox1.Controls.Add(this.nameTextbox);
            this.groupBox1.Controls.Add(this.addressTextbox);
            this.groupBox1.Controls.Add(this.phoneNumberTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(232, 299);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày sinh";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.birthdayPicker.BorderSize = 0;
            this.birthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.birthdayPicker.Location = new System.Drawing.Point(17, 257);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birthdayPicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(197, 35);
            this.birthdayPicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.birthdayPicker.TabIndex = 7;
            this.birthdayPicker.TextColor = System.Drawing.Color.White;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextbox.Location = new System.Drawing.Point(17, 52);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.nameTextbox.PlaceholderText = "";
            this.nameTextbox.Size = new System.Drawing.Size(196, 32);
            this.nameTextbox.TabIndex = 3;
            this.nameTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
            // 
            // addressTextbox
            // 
            this.addressTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.addressTextbox.BorderRadius = 10;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addressTextbox.Location = new System.Drawing.Point(17, 121);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.addressTextbox.PlaceholderText = "";
            this.addressTextbox.Size = new System.Drawing.Size(196, 32);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumberTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumberTextbox.BorderRadius = 10;
            this.phoneNumberTextbox.BorderSize = 2;
            this.phoneNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberTextbox.Location = new System.Drawing.Point(17, 191);
            this.phoneNumberTextbox.Multiline = false;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumberTextbox.PasswordChar = false;
            this.phoneNumberTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.phoneNumberTextbox.PlaceholderText = "";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(196, 32);
            this.phoneNumberTextbox.TabIndex = 6;
            this.phoneNumberTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.phoneNumberTextbox.Texts = "";
            this.phoneNumberTextbox.UnderlinedStyle = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roleCombobox);
            this.groupBox2.Controls.Add(this.IDTextbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.accountTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.roleLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(259, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(225, 231);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // roleCombobox
            // 
            this.roleCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roleCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roleCombobox.BorderSize = 1;
            this.roleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.roleCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roleCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.roleCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.roleCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.roleCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.roleCombobox.Location = new System.Drawing.Point(10, 193);
            this.roleCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roleCombobox.MinimumSize = new System.Drawing.Size(133, 20);
            this.roleCombobox.Name = "roleCombobox";
            this.roleCombobox.Padding = new System.Windows.Forms.Padding(1);
            this.roleCombobox.Size = new System.Drawing.Size(197, 34);
            this.roleCombobox.TabIndex = 102;
            this.roleCombobox.Texts = "";
            // 
            // IDTextbox
            // 
            this.IDTextbox.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.IDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTextbox.BorderRadius = 10;
            this.IDTextbox.BorderSize = 2;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IDTextbox.Location = new System.Drawing.Point(10, 52);
            this.IDTextbox.Multiline = false;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.IDTextbox.PasswordChar = false;
            this.IDTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.IDTextbox.PlaceholderText = "";
            this.IDTextbox.Size = new System.Drawing.Size(196, 32);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.TabStop = false;
            this.IDTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.IDTextbox.Texts = "";
            this.IDTextbox.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên đăng nhập";
            // 
            // accountTextbox
            // 
            this.accountTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.accountTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.accountTextbox.BorderRadius = 10;
            this.accountTextbox.BorderSize = 2;
            this.accountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accountTextbox.Location = new System.Drawing.Point(10, 121);
            this.accountTextbox.Multiline = false;
            this.accountTextbox.Name = "accountTextbox";
            this.accountTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.accountTextbox.PasswordChar = false;
            this.accountTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.accountTextbox.PlaceholderText = "";
            this.accountTextbox.Size = new System.Drawing.Size(196, 32);
            this.accountTextbox.TabIndex = 2;
            this.accountTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountTextbox.Texts = "";
            this.accountTextbox.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
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
            this.confirmButton.Location = new System.Drawing.Point(258, 360);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 40);
            this.confirmButton.TabIndex = 12;
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
            this.cancelButton.Location = new System.Drawing.Point(59, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 40);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EmpDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.genderGroupbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpDetailForm";
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

        private CustomControl.JNewTextbox accountTextbox;
        private CustomControl.JNewTextbox addressTextbox;
        private CustomControl.JNewTextbox phoneNumberTextbox;
        private System.Windows.Forms.Label titleLabel;
        private CustomControl.JNewTextbox IDTextbox;
        private CustomControl.JButton cancelButton;
        private CustomControl.JButton confirmButton;
        private CustomControl.JNewTextbox nameTextbox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.GroupBox genderGroupbox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControl.JDatetimepicker birthdayPicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControl.JComboBox roleCombobox;
    }
}