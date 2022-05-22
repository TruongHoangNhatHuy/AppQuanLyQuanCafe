namespace CafeShop.View.AdForm
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
            this.birthdayTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.nameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.IDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.phoneNumberTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addressTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.subTimeTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.genderGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Tomato;
            this.titleLabel.Location = new System.Drawing.Point(188, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(293, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = " Thông tin chi tiết";
            // 
            // genderGroupbox
            // 
            this.genderGroupbox.Controls.Add(this.femaleRadioButton);
            this.genderGroupbox.Controls.Add(this.maleRadioButton);
            this.genderGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupbox.ForeColor = System.Drawing.Color.Crimson;
            this.genderGroupbox.Location = new System.Drawing.Point(381, 245);
            this.genderGroupbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderGroupbox.Name = "genderGroupbox";
            this.genderGroupbox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderGroupbox.Size = new System.Drawing.Size(267, 65);
            this.genderGroupbox.TabIndex = 7;
            this.genderGroupbox.TabStop = false;
            this.genderGroupbox.Text = "Giới tính";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.femaleRadioButton.Location = new System.Drawing.Point(151, 33);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(53, 24);
            this.femaleRadioButton.TabIndex = 9;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Nữ";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.maleRadioButton.Location = new System.Drawing.Point(23, 31);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(68, 24);
            this.maleRadioButton.TabIndex = 8;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Nam";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.birthdayTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.birthdayTextbox.BorderRadius = 10;
            this.birthdayTextbox.BorderSize = 2;
            this.birthdayTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTextbox.Location = new System.Drawing.Point(33, 241);
            this.birthdayTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdayTextbox.Multiline = false;
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.birthdayTextbox.PasswordChar = false;
            this.birthdayTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.birthdayTextbox.PlaceholderText = "    Ngày sinh";
            this.birthdayTextbox.Size = new System.Drawing.Size(261, 39);
            this.birthdayTextbox.TabIndex = 3;
            this.birthdayTextbox.Texts = "";
            this.birthdayTextbox.UnderlinedStyle = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(33, 164);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.nameTextbox.PlaceholderText = "    Họ và tên";
            this.nameTextbox.Size = new System.Drawing.Size(261, 39);
            this.nameTextbox.TabIndex = 2;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
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
            this.confirmButton.Location = new System.Drawing.Point(380, 443);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(200, 49);
            this.confirmButton.TabIndex = 11;
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
            this.cancelButton.Location = new System.Drawing.Point(95, 443);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 49);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IDTextbox
            // 
            this.IDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.IDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.IDTextbox.BorderRadius = 10;
            this.IDTextbox.BorderSize = 2;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(33, 97);
            this.IDTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTextbox.Multiline = false;
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.IDTextbox.PasswordChar = false;
            this.IDTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.IDTextbox.PlaceholderText = "";
            this.IDTextbox.Size = new System.Drawing.Size(261, 39);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.Texts = "";
            this.IDTextbox.UnderlinedStyle = false;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumberTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumberTextbox.BorderRadius = 10;
            this.phoneNumberTextbox.BorderSize = 2;
            this.phoneNumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextbox.Location = new System.Drawing.Point(380, 164);
            this.phoneNumberTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumberTextbox.Multiline = false;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.phoneNumberTextbox.PasswordChar = false;
            this.phoneNumberTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.phoneNumberTextbox.PlaceholderText = "";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(261, 39);
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
            this.addressTextbox.Location = new System.Drawing.Point(381, 97);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.addressTextbox.PlaceholderText = "    Địa chỉ";
            this.addressTextbox.Size = new System.Drawing.Size(261, 39);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // subTimeTextbox
            // 
            this.subTimeTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.subTimeTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.subTimeTextbox.BorderRadius = 10;
            this.subTimeTextbox.BorderSize = 2;
            this.subTimeTextbox.Enabled = false;
            this.subTimeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTimeTextbox.Location = new System.Drawing.Point(33, 318);
            this.subTimeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subTimeTextbox.Multiline = false;
            this.subTimeTextbox.Name = "subTimeTextbox";
            this.subTimeTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.subTimeTextbox.PasswordChar = false;
            this.subTimeTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.subTimeTextbox.PlaceholderText = "";
            this.subTimeTextbox.Size = new System.Drawing.Size(261, 39);
            this.subTimeTextbox.TabIndex = 4;
            this.subTimeTextbox.Texts = "";
            this.subTimeTextbox.UnderlinedStyle = false;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 554);
            this.Controls.Add(this.genderGroupbox);
            this.Controls.Add(this.birthdayTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.subTimeTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmpDetailForm";
            this.genderGroupbox.ResumeLayout(false);
            this.genderGroupbox.PerformLayout();
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
        private CustomControl.JNewTextbox birthdayTextbox;
        private System.Windows.Forms.GroupBox genderGroupbox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
    }
}