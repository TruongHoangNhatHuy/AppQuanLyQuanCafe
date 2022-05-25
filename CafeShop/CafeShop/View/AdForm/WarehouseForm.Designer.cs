namespace CafeShop.View.AdForm
{
    partial class WarehouseForm
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsNameLabel = new System.Windows.Forms.Label();
            this.goodsNameTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.quantityTextbox = new CafeShop.View.CustomControl.JTextbox();
            this.exportRadioButton = new System.Windows.Forms.RadioButton();
            this.importRadioButton = new System.Windows.Forms.RadioButton();
            this.updateButton = new CafeShop.View.CustomControl.JButton();
            this.showInfoButton = new CafeShop.View.CustomControl.JButton();
            this.editButton = new CafeShop.View.CustomControl.JButton();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(43, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng hoá";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng hoá";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn vị";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goodsNameLabel);
            this.groupBox1.Controls.Add(this.goodsNameTextbox);
            this.groupBox1.Controls.Add(this.quantityTextbox);
            this.groupBox1.Controls.Add(this.exportRadioButton);
            this.groupBox1.Controls.Add(this.importRadioButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(732, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 471);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập xuất form";
            // 
            // totalTextbox
            // 
            this.totalTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.totalTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.totalTextbox.BorderSize = 2;
            this.totalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.totalTextbox.Location = new System.Drawing.Point(64, 331);
            this.totalTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextbox.Multiline = false;
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.totalTextbox.PasswordChar = false;
            this.totalTextbox.Size = new System.Drawing.Size(270, 32);
            this.totalTextbox.TabIndex = 11;
            this.totalTextbox.Texts = "";
            this.totalTextbox.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(61, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiền thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(61, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng";
            // 
            // goodsNameLabel
            // 
            this.goodsNameLabel.AutoSize = true;
            this.goodsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.goodsNameLabel.Location = new System.Drawing.Point(61, 106);
            this.goodsNameLabel.Name = "goodsNameLabel";
            this.goodsNameLabel.Size = new System.Drawing.Size(119, 20);
            this.goodsNameLabel.TabIndex = 8;
            this.goodsNameLabel.Text = "Tên hàng hoá";
            // 
            // goodsNameTextbox
            // 
            this.goodsNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.goodsNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.goodsNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.goodsNameTextbox.BorderSize = 2;
            this.goodsNameTextbox.Enabled = false;
            this.goodsNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsNameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.goodsNameTextbox.Location = new System.Drawing.Point(65, 130);
            this.goodsNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.goodsNameTextbox.Multiline = false;
            this.goodsNameTextbox.Name = "goodsNameTextbox";
            this.goodsNameTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.goodsNameTextbox.PasswordChar = false;
            this.goodsNameTextbox.Size = new System.Drawing.Size(269, 32);
            this.goodsNameTextbox.TabIndex = 6;
            this.goodsNameTextbox.Texts = "";
            this.goodsNameTextbox.UnderlinedStyle = false;
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quantityTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quantityTextbox.BorderSize = 2;
            this.quantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.quantityTextbox.Location = new System.Drawing.Point(65, 225);
            this.quantityTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextbox.Multiline = false;
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Padding = new System.Windows.Forms.Padding(7);
            this.quantityTextbox.PasswordChar = false;
            this.quantityTextbox.Size = new System.Drawing.Size(269, 32);
            this.quantityTextbox.TabIndex = 5;
            this.quantityTextbox.Texts = "";
            this.quantityTextbox.UnderlinedStyle = false;
            // 
            // exportRadioButton
            // 
            this.exportRadioButton.AutoSize = true;
            this.exportRadioButton.Location = new System.Drawing.Point(245, 33);
            this.exportRadioButton.Name = "exportRadioButton";
            this.exportRadioButton.Size = new System.Drawing.Size(78, 29);
            this.exportRadioButton.TabIndex = 4;
            this.exportRadioButton.Text = "Xuất";
            this.exportRadioButton.UseVisualStyleBackColor = true;
            // 
            // importRadioButton
            // 
            this.importRadioButton.AutoSize = true;
            this.importRadioButton.Checked = true;
            this.importRadioButton.Location = new System.Drawing.Point(65, 33);
            this.importRadioButton.Name = "importRadioButton";
            this.importRadioButton.Size = new System.Drawing.Size(85, 29);
            this.importRadioButton.TabIndex = 3;
            this.importRadioButton.TabStop = true;
            this.importRadioButton.Text = "Nhập";
            this.importRadioButton.UseVisualStyleBackColor = true;
            this.importRadioButton.CheckedChanged += new System.EventHandler(this.importRadioButton_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateButton.BorderRadius = 30;
            this.updateButton.BorderSize = 0;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(126, 415);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 40);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Cập nhật";
            this.updateButton.TextColor = System.Drawing.Color.Black;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.showInfoButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.showInfoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.showInfoButton.BorderRadius = 30;
            this.showInfoButton.BorderSize = 0;
            this.showInfoButton.FlatAppearance.BorderSize = 0;
            this.showInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoButton.ForeColor = System.Drawing.Color.Black;
            this.showInfoButton.Location = new System.Drawing.Point(377, 487);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(150, 40);
            this.showInfoButton.TabIndex = 6;
            this.showInfoButton.Text = "Thông tin";
            this.showInfoButton.TextColor = System.Drawing.Color.Black;
            this.showInfoButton.UseVisualStyleBackColor = false;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 30;
            this.editButton.BorderSize = 0;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(118, 483);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 40);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Sửa";
            this.editButton.TextColor = System.Drawing.Color.Black;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(377, 533);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.Color.Black;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 30;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(118, 533);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 40);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.Color.Black;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(52, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin hàng hoá";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CustomControl.JButton deleteButton;
        private CustomControl.JButton updateButton;
        private CustomControl.JButton addButton;
        private CustomControl.JButton editButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControl.JTextbox quantityTextbox;
        private CustomControl.JTextbox goodsNameTextbox;
        private System.Windows.Forms.RadioButton exportRadioButton;
        private System.Windows.Forms.RadioButton importRadioButton;
        private CustomControl.JButton showInfoButton;
        private CustomControl.JTextbox totalTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goodsNameLabel;
        private System.Windows.Forms.Label label3;
    }
}