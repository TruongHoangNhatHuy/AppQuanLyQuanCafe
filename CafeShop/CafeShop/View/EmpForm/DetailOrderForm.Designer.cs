namespace CafeShop.View.EmpForm
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.acceptButton = new CafeShop.View.CustomControl.JButton();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.totalTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.descriptionTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.quantityTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.ForeColor = System.Drawing.Color.Crimson;
            this.foodLabel.Location = new System.Drawing.Point(20, 22);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(257, 33);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Tên món, đơn giá";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(32, 123);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(117, 29);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Số lượng";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(38, 312);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(101, 29);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Ghi chú";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(32, 222);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(103, 29);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Giá tiền";
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
            this.acceptButton.Location = new System.Drawing.Point(300, 455);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(174, 62);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Xác nhận";
            this.acceptButton.TextColor = System.Drawing.Color.Black;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
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
            this.cancelButton.Location = new System.Drawing.Point(56, 455);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(174, 62);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // totalTextbox
            // 
            this.totalTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.totalTextbox.BorderRadius = 5;
            this.totalTextbox.BorderSize = 2;
            this.totalTextbox.Enabled = false;
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.Location = new System.Drawing.Point(192, 203);
            this.totalTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalTextbox.Multiline = false;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.totalTextbox.PasswordChar = false;
            this.totalTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.totalTextbox.PlaceholderText = "";
            this.totalTextbox.Size = new System.Drawing.Size(294, 48);
            this.totalTextbox.TabIndex = 3;
            this.totalTextbox.Texts = "";
            this.totalTextbox.UnderlinedStyle = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descriptionTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.descriptionTextbox.BorderRadius = 5;
            this.descriptionTextbox.BorderSize = 2;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextbox.Location = new System.Drawing.Point(192, 298);
            this.descriptionTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.descriptionTextbox.PasswordChar = false;
            this.descriptionTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.descriptionTextbox.PlaceholderText = "Chú thích";
            this.descriptionTextbox.Size = new System.Drawing.Size(294, 120);
            this.descriptionTextbox.TabIndex = 2;
            this.descriptionTextbox.Texts = "";
            this.descriptionTextbox.UnderlinedStyle = false;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextbox.BorderRadius = 5;
            this.quantityTextbox.BorderSize = 2;
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.Location = new System.Drawing.Point(192, 120);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityTextbox.Multiline = false;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.quantityTextbox.PasswordChar = false;
            this.quantityTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantityTextbox.PlaceholderText = "";
            this.quantityTextbox.Size = new System.Drawing.Size(294, 48);
            this.quantityTextbox.TabIndex = 1;
            this.quantityTextbox.Texts = "";
            this.quantityTextbox.UnderlinedStyle = false;
            this.quantityTextbox._TextChanged += new System.EventHandler(this.quantityTextbox__TextChanged);
            // 
            // DetailOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 550);
            this.ControlBox = false;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.foodLabel);
            this.Name = "DetailOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label quantityLabel;
        private CustomControl.JNewTextbox quantityTextbox;
        private CustomControl.JNewTextbox descriptionTextbox;
        private CustomControl.JNewTextbox totalTextbox;
        private CustomControl.JButton cancelButton;
        private CustomControl.JButton acceptButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}