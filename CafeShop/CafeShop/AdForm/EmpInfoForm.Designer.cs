namespace CafeShop.AdForm
{
    partial class EmpInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new CafeShop.CustomControl.JButton();
            this.searchTextbox = new CafeShop.CustomControl.JNewTextbox();
            this.addButton = new CafeShop.CustomControl.JButton();
            this.updateButton = new CafeShop.CustomControl.JButton();
            this.deleteButton = new CafeShop.CustomControl.JButton();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new CafeShop.CustomControl.JButton();
            this.exitButton = new CafeShop.CustomControl.JButton();
            this.resetPasswordButton = new CafeShop.CustomControl.JButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 15;
            this.searchButton.BorderSize = 0;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Image = global::CafeShop.Properties.Resources.magnifying_glass;
            this.searchButton.Location = new System.Drawing.Point(90, 48);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 32);
            this.searchButton.TabIndex = 5;
            this.searchButton.TextColor = System.Drawing.Color.Black;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.BackColor = System.Drawing.Color.AliceBlue;
            this.searchTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderRadius = 10;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTextbox.Location = new System.Drawing.Point(228, 48);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "         Tìm kiếm.......";
            this.searchTextbox.Size = new System.Drawing.Size(439, 32);
            this.searchTextbox.TabIndex = 4;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(751, 489);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.jButton3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 30;
            this.updateButton.BorderSize = 0;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.Location = new System.Drawing.Point(547, 489);
            this.updateButton.Name = "updateButton";
            this.updateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateButton.Size = new System.Drawing.Size(154, 40);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(173, 489);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(751, 55);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortComboBox.TabIndex = 6;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.sortButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sortButton.BorderRadius = 15;
            this.sortButton.BorderSize = 0;
            this.sortButton.FlatAppearance.BorderSize = 0;
            this.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.Color.Black;
            this.sortButton.Location = new System.Drawing.Point(907, 48);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(113, 32);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sắp xếp";
            this.sortButton.TextColor = System.Drawing.Color.Black;
            this.sortButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.exitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.BorderRadius = 30;
            this.exitButton.BorderSize = 0;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::CafeShop.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(12, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(46, 40);
            this.exitButton.TabIndex = 8;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetPasswordButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.resetPasswordButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.resetPasswordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetPasswordButton.BorderRadius = 30;
            this.resetPasswordButton.BorderSize = 0;
            this.resetPasswordButton.FlatAppearance.BorderSize = 0;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetPasswordButton.Location = new System.Drawing.Point(355, 489);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(154, 40);
            this.resetPasswordButton.TabIndex = 9;
            this.resetPasswordButton.Text = "Reset mật khẩu";
            this.resetPasswordButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            // 
            // EmpInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 557);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpInfoForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControl.JButton deleteButton;
        private CustomControl.JButton updateButton;
        private CustomControl.JButton addButton;
        private CustomControl.JNewTextbox searchTextbox;
        private CustomControl.JButton searchButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private CustomControl.JButton sortButton;
        private CustomControl.JButton exitButton;
        private CustomControl.JButton resetPasswordButton;
    }
}