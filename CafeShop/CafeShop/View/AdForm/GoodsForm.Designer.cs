namespace CafeShop.View.AdForm
{
    partial class GoodsForm
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
            this.controlBarPanel = new System.Windows.Forms.Panel();
            this.goodsIDLabel = new System.Windows.Forms.Label();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.foodNameCombobox = new CafeShop.View.CustomControl.JComboBox();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.acceptButton = new CafeShop.View.CustomControl.JButton();
            this.unitTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.goodsNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.goodsIDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.controlBarPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBarPanel
            // 
            this.controlBarPanel.Controls.Add(this.minimizeButton);
            this.controlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.controlBarPanel.Name = "controlBarPanel";
            this.controlBarPanel.Size = new System.Drawing.Size(375, 31);
            this.controlBarPanel.TabIndex = 9;
            // 
            // goodsIDLabel
            // 
            this.goodsIDLabel.AutoSize = true;
            this.goodsIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsIDLabel.ForeColor = System.Drawing.Color.Crimson;
            this.goodsIDLabel.Location = new System.Drawing.Point(38, 56);
            this.goodsIDLabel.Name = "goodsIDLabel";
            this.goodsIDLabel.Size = new System.Drawing.Size(113, 20);
            this.goodsIDLabel.TabIndex = 11;
            this.goodsIDLabel.Text = "Mã hàng hoá";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.goodsNameLabel.Location = new System.Drawing.Point(38, 126);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(119, 20);
            this.goodsNameLabel.TabIndex = 12;
            this.goodsNameLabel.Text = "Tên hàng hoá";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.ForeColor = System.Drawing.Color.Crimson;
            this.unitLabel.Location = new System.Drawing.Point(38, 199);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(59, 20);
            this.unitLabel.TabIndex = 13;
            this.unitLabel.Text = "Đơn vị";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.Crimson;
            this.categoryLabel.Location = new System.Drawing.Point(13, 92);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(94, 20);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Nhóm món";
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.foodNameLabel.Location = new System.Drawing.Point(13, 165);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(78, 20);
            this.foodNameLabel.TabIndex = 15;
            this.foodNameLabel.Text = "Tên món";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoryLabel);
            this.groupBox1.Controls.Add(this.foodNameLabel);
            this.groupBox1.Controls.Add(this.categoryCombobox);
            this.groupBox1.Controls.Add(this.foodNameCombobox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 259);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(314, 241);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liên kết món (Tùy chọn)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chỉ liên kết khi hàng hóa \r\nlà 1 món trong menu.";
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryCombobox.BorderSize = 2;
            this.categoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.categoryCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.categoryCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.categoryCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.categoryCombobox.Location = new System.Drawing.Point(17, 115);
            this.categoryCombobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCombobox.Size = new System.Drawing.Size(279, 39);
            this.categoryCombobox.TabIndex = 3;
            this.categoryCombobox.Texts = "";
            this.categoryCombobox.OnSelectedIndexChanged += new System.EventHandler(this.categoryCombobox_OnSelectedIndexChanged);
            // 
            // foodNameCombobox
            // 
            this.foodNameCombobox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.foodNameCombobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.foodNameCombobox.BorderSize = 2;
            this.foodNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.foodNameCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameCombobox.ForeColor = System.Drawing.Color.DimGray;
            this.foodNameCombobox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.foodNameCombobox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.foodNameCombobox.ListTextColor = System.Drawing.Color.DimGray;
            this.foodNameCombobox.Location = new System.Drawing.Point(17, 188);
            this.foodNameCombobox.MinimumSize = new System.Drawing.Size(200, 30);
            this.foodNameCombobox.Name = "foodNameCombobox";
            this.foodNameCombobox.Padding = new System.Windows.Forms.Padding(2);
            this.foodNameCombobox.Size = new System.Drawing.Size(279, 39);
            this.foodNameCombobox.TabIndex = 4;
            this.foodNameCombobox.Texts = "";
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
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(39, 505);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 40);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.minimizeButton.Location = new System.Drawing.Point(321, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(54, 31);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextColor = System.Drawing.Color.White;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
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
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.Black;
            this.acceptButton.Location = new System.Drawing.Point(200, 505);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(121, 40);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Xác nhận";
            this.acceptButton.TextColor = System.Drawing.Color.Black;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // unitTextbox
            // 
            this.unitTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.unitTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.unitTextbox.BorderRadius = 0;
            this.unitTextbox.BorderSize = 2;
            this.unitTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTextbox.Location = new System.Drawing.Point(39, 222);
            this.unitTextbox.Multiline = false;
            this.unitTextbox.Name = "unitTextbox";
            this.unitTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.unitTextbox.PasswordChar = false;
            this.unitTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.unitTextbox.PlaceholderText = "";
            this.unitTextbox.Size = new System.Drawing.Size(282, 35);
            this.unitTextbox.TabIndex = 2;
            this.unitTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.unitTextbox.Texts = "";
            this.unitTextbox.UnderlinedStyle = false;
            // 
            // goodsNameTextbox
            // 
            this.goodsNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodsNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodsNameTextbox.BorderRadius = 0;
            this.goodsNameTextbox.BorderSize = 2;
            this.goodsNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextbox.Location = new System.Drawing.Point(39, 149);
            this.goodsNameTextbox.Multiline = false;
            this.goodsNameTextbox.Name = "goodsNameTextbox";
            this.goodsNameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.goodsNameTextbox.PasswordChar = false;
            this.goodsNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.goodsNameTextbox.PlaceholderText = "";
            this.goodsNameTextbox.Size = new System.Drawing.Size(282, 35);
            this.goodsNameTextbox.TabIndex = 1;
            this.goodsNameTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.goodsNameTextbox.Texts = "";
            this.goodsNameTextbox.UnderlinedStyle = false;
            // 
            // goodsIDTextbox
            // 
            this.goodsIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodsIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodsIDTextbox.BorderRadius = 0;
            this.goodsIDTextbox.BorderSize = 2;
            this.goodsIDTextbox.Enabled = false;
            this.goodsIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsIDTextbox.Location = new System.Drawing.Point(39, 79);
            this.goodsIDTextbox.Multiline = false;
            this.goodsIDTextbox.Name = "goodsIDTextbox";
            this.goodsIDTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.goodsIDTextbox.PasswordChar = false;
            this.goodsIDTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.goodsIDTextbox.PlaceholderText = "";
            this.goodsIDTextbox.Size = new System.Drawing.Size(282, 33);
            this.goodsIDTextbox.TabIndex = 0;
            this.goodsIDTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.goodsIDTextbox.Texts = "";
            this.goodsIDTextbox.UnderlinedStyle = false;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 570);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.goodsNameLabel);
            this.Controls.Add(this.goodsIDLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.controlBarPanel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.unitTextbox);
            this.Controls.Add(this.goodsNameTextbox);
            this.Controls.Add(this.goodsIDTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.controlBarPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.JNewTextbox goodsIDTextbox;
        private CustomControl.JNewTextbox goodsNameTextbox;
        private CustomControl.JNewTextbox unitTextbox;
        private CustomControl.JComboBox categoryCombobox;
        private CustomControl.JComboBox foodNameCombobox;
        private CustomControl.JButton acceptButton;
        private System.Windows.Forms.Panel controlBarPanel;
        private CustomControl.JButton minimizeButton;
        private CustomControl.JButton cancelButton;
        private System.Windows.Forms.Label goodsIDLabel;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}