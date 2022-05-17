﻿namespace CafeShop.View.AdForm
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
            this.phoneNumberTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addressTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.accountTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.nameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.birthdayTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.roleCombobox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.genderGroupbox = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumberTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumberTextbox.BorderRadius = 10;
            this.phoneNumberTextbox.BorderSize = 2;
            this.phoneNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextbox.Location = new System.Drawing.Point(285, 133);
            this.phoneNumberTextbox.Multiline = false;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumberTextbox.PasswordChar = false;
            this.phoneNumberTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.phoneNumberTextbox.PlaceholderText = "    Số điện thoại";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(196, 32);
            this.phoneNumberTextbox.TabIndex = 6;
            this.phoneNumberTextbox.Texts = "";
            this.phoneNumberTextbox.UnderlinedStyle = false;
            // 
            // addressTextbox
            // 
            this.addressTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.addressTextbox.BorderRadius = 10;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.Location = new System.Drawing.Point(286, 79);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.addressTextbox.PlaceholderText = "    Địa chỉ";
            this.addressTextbox.Size = new System.Drawing.Size(196, 32);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // accountTextbox
            // 
            this.accountTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.accountTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.accountTextbox.BorderRadius = 10;
            this.accountTextbox.BorderSize = 2;
            this.accountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextbox.Location = new System.Drawing.Point(25, 133);
            this.accountTextbox.Multiline = false;
            this.accountTextbox.Name = "accountTextbox";
            this.accountTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.accountTextbox.PasswordChar = false;
            this.accountTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.accountTextbox.PlaceholderText = "    Tên tài khoản";
            this.accountTextbox.Size = new System.Drawing.Size(196, 32);
            this.accountTextbox.TabIndex = 2;
            this.accountTextbox.Texts = "";
            this.accountTextbox.UnderlinedStyle = false;
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
            // IDTextbox
            // 
            this.IDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.IDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTextbox.BorderRadius = 10;
            this.IDTextbox.BorderSize = 2;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(25, 79);
            this.IDTextbox.Multiline = false;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.IDTextbox.PasswordChar = false;
            this.IDTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.IDTextbox.PlaceholderText = "    Mã nhân viên";
            this.IDTextbox.Size = new System.Drawing.Size(196, 32);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.Texts = "";
            this.IDTextbox.UnderlinedStyle = false;
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
            // 
            // nameTextbox
            // 
            this.nameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(25, 189);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.nameTextbox.PlaceholderText = "    Họ và tên";
            this.nameTextbox.Size = new System.Drawing.Size(196, 32);
            this.nameTextbox.TabIndex = 3;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.birthdayTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.birthdayTextbox.BorderRadius = 10;
            this.birthdayTextbox.BorderSize = 2;
            this.birthdayTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTextbox.Location = new System.Drawing.Point(25, 252);
            this.birthdayTextbox.Multiline = false;
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.birthdayTextbox.PasswordChar = false;
            this.birthdayTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.birthdayTextbox.PlaceholderText = "    Ngày sinh";
            this.birthdayTextbox.Size = new System.Drawing.Size(196, 32);
            this.birthdayTextbox.TabIndex = 4;
            this.birthdayTextbox.Texts = "";
            this.birthdayTextbox.UnderlinedStyle = false;
            // 
            // roleCombobox
            // 
            this.roleCombobox.FormattingEnabled = true;
            this.roleCombobox.Location = new System.Drawing.Point(373, 199);
            this.roleCombobox.Name = "roleCombobox";
            this.roleCombobox.Size = new System.Drawing.Size(108, 21);
            this.roleCombobox.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.roleLabel.Location = new System.Drawing.Point(295, 201);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(62, 20);
            this.roleLabel.TabIndex = 99;
            this.roleLabel.Text = "Vai trò";
            // 
            // genderGroupbox
            // 
            this.genderGroupbox.Controls.Add(this.femaleRadioButton);
            this.genderGroupbox.Controls.Add(this.maleRadioButton);
            this.genderGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupbox.ForeColor = System.Drawing.Color.Crimson;
            this.genderGroupbox.Location = new System.Drawing.Point(299, 243);
            this.genderGroupbox.Name = "genderGroupbox";
            this.genderGroupbox.Size = new System.Drawing.Size(200, 53);
            this.genderGroupbox.TabIndex = 8;
            this.genderGroupbox.TabStop = false;
            this.genderGroupbox.Text = "Giới tính";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(113, 27);
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
            this.maleRadioButton.Location = new System.Drawing.Point(17, 27);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(57, 20);
            this.maleRadioButton.TabIndex = 9;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Nam";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmpDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.genderGroupbox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.roleCombobox);
            this.Controls.Add(this.birthdayTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.accountTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmpDetailForm";
            this.genderGroupbox.ResumeLayout(false);
            this.genderGroupbox.PerformLayout();
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
        private CustomControl.JNewTextbox birthdayTextbox;
        private System.Windows.Forms.ComboBox roleCombobox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.GroupBox genderGroupbox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
    }
}