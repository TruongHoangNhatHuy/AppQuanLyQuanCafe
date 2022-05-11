namespace CafeShop.EmpForm
{
    partial class DetailOrderForm
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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.descriptionTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.totalTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.surchargeTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.discountTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.surchargeLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.cancelButton = new CafeShop.CustomControl.JButton();
            this.acceptButton = new CafeShop.CustomControl.JButton();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món, đơn giá";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(21, 80);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(80, 20);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Số lượng";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextbox.BorderRadius = 5;
            this.quantityTextbox.BorderSize = 2;
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.Location = new System.Drawing.Point(128, 78);
            this.quantityTextbox.Multiline = false;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTextbox.PasswordChar = false;
            this.quantityTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantityTextbox.PlaceholderText = "";
            this.quantityTextbox.Size = new System.Drawing.Size(196, 32);
            this.quantityTextbox.TabIndex = 1;
            this.quantityTextbox.Texts = "";
            this.quantityTextbox.UnderlinedStyle = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descriptionTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.descriptionTextbox.BorderRadius = 5;
            this.descriptionTextbox.BorderSize = 2;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(128, 144);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.descriptionTextbox.PasswordChar = false;
            this.descriptionTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.descriptionTextbox.PlaceholderText = "";
            this.descriptionTextbox.Size = new System.Drawing.Size(196, 32);
            this.descriptionTextbox.TabIndex = 2;
            this.descriptionTextbox.Texts = "";
            this.descriptionTextbox.UnderlinedStyle = false;
            // 
            // totalTextbox
            // 
            this.totalTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.totalTextbox.BorderRadius = 5;
            this.totalTextbox.BorderSize = 2;
            this.totalTextbox.Enabled = false;
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.Location = new System.Drawing.Point(128, 214);
            this.totalTextbox.Multiline = false;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.totalTextbox.PasswordChar = false;
            this.totalTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.totalTextbox.PlaceholderText = "";
            this.totalTextbox.Size = new System.Drawing.Size(196, 32);
            this.totalTextbox.TabIndex = 3;
            this.totalTextbox.Texts = "";
            this.totalTextbox.UnderlinedStyle = false;
            // 
            // surchargeTextbox
            // 
            this.surchargeTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.surchargeTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.surchargeTextbox.BorderRadius = 5;
            this.surchargeTextbox.BorderSize = 2;
            this.surchargeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surchargeTextbox.Location = new System.Drawing.Point(52, 278);
            this.surchargeTextbox.Multiline = false;
            this.surchargeTextbox.Name = "surchargeTextbox";
            this.surchargeTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.surchargeTextbox.PasswordChar = false;
            this.surchargeTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.surchargeTextbox.PlaceholderText = "";
            this.surchargeTextbox.Size = new System.Drawing.Size(89, 32);
            this.surchargeTextbox.TabIndex = 4;
            this.surchargeTextbox.Texts = "";
            this.surchargeTextbox.UnderlinedStyle = false;
            // 
            // discountTextbox
            // 
            this.discountTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.discountTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.discountTextbox.BorderRadius = 5;
            this.discountTextbox.BorderSize = 2;
            this.discountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextbox.Location = new System.Drawing.Point(218, 278);
            this.discountTextbox.Multiline = false;
            this.discountTextbox.Name = "discountTextbox";
            this.discountTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.discountTextbox.PasswordChar = false;
            this.discountTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.discountTextbox.PlaceholderText = "";
            this.discountTextbox.Size = new System.Drawing.Size(89, 32);
            this.discountTextbox.TabIndex = 5;
            this.discountTextbox.Texts = "";
            this.discountTextbox.UnderlinedStyle = false;
            // 
            // surchargeLabel
            // 
            this.surchargeLabel.AutoSize = true;
            this.surchargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surchargeLabel.Location = new System.Drawing.Point(64, 259);
            this.surchargeLabel.Name = "surchargeLabel";
            this.surchargeLabel.Size = new System.Drawing.Size(73, 16);
            this.surchargeLabel.TabIndex = 6;
            this.surchargeLabel.Text = "Phụ thu (%)";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(219, 258);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(84, 16);
            this.discountLabel.TabIndex = 7;
            this.discountLabel.Text = "Giảm giá (%)";
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
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(28, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 40);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.acceptButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.acceptButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.acceptButton.BorderRadius = 30;
            this.acceptButton.BorderSize = 0;
            this.acceptButton.FlatAppearance.BorderSize = 0;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.Black;
            this.acceptButton.Location = new System.Drawing.Point(191, 356);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(116, 40);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Xác nhận";
            this.acceptButton.TextColor = System.Drawing.Color.Black;
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(25, 153);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 20);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Ghi chú";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(24, 226);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(72, 20);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Giá tiền";
            // 
            // DetailOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 418);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.surchargeLabel);
            this.Controls.Add(this.discountTextbox);
            this.Controls.Add(this.surchargeTextbox);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.label1);
            this.Name = "DetailOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantityLabel;
        private CustomControl.JNewTextbox quantityTextbox;
        private CustomControl.JNewTextbox descriptionTextbox;
        private CustomControl.JNewTextbox totalTextbox;
        private CustomControl.JNewTextbox surchargeTextbox;
        private CustomControl.JNewTextbox discountTextbox;
        private System.Windows.Forms.Label surchargeLabel;
        private System.Windows.Forms.Label discountLabel;
        private CustomControl.JButton cancelButton;
        private CustomControl.JButton acceptButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}