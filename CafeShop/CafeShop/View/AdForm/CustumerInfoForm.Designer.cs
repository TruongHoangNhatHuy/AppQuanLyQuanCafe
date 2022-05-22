namespace CafeShop.View.AdForm
{
    partial class CustomerInfoForm
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
            this.searchButton = new CafeShop.View.CustomControl.JButton();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.updateButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortButton = new CafeShop.View.CustomControl.JButton();
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 538);
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
            this.searchButton.Location = new System.Drawing.Point(120, 59);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 39);
            this.searchButton.TabIndex = 5;
            this.searchButton.TextColor = System.Drawing.Color.Black;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.searchTextbox.Location = new System.Drawing.Point(304, 59);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DimGray;
            this.searchTextbox.PlaceholderText = "         Tìm kiếm.......";
            this.searchTextbox.Size = new System.Drawing.Size(633, 39);
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
            this.addButton.Location = new System.Drawing.Point(1025, 668);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(205, 49);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.adButton_Click);
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
            this.updateButton.Location = new System.Drawing.Point(637, 668);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateButton.Size = new System.Drawing.Size(205, 49);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(255, 668);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(205, 49);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(1001, 68);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(208, 24);
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
            this.sortButton.Location = new System.Drawing.Point(1257, 59);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(151, 39);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Sắp xếp";
            this.sortButton.TextColor = System.Drawing.Color.Black;
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(16, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(61, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1539, 752);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerInfoForm";
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
    }
}