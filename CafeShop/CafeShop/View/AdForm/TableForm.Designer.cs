namespace CafeShop.View.AdForm
{
    partial class TableForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.areaCombobox = new System.Windows.Forms.ComboBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.detailGroupbox = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.areaIDCombobox = new System.Windows.Forms.ComboBox();
            this.areaNameLabel = new System.Windows.Forms.Label();
            this.areaIDLabel = new System.Windows.Forms.Label();
            this.tableIDLabel = new System.Windows.Forms.Label();
            this.addAreaButton = new CafeShop.View.CustomControl.JButton();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.addButton = new CafeShop.View.CustomControl.JButton();
            this.deleteButton = new CafeShop.View.CustomControl.JButton();
            this.tableIDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.areaNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.searchButton = new CafeShop.View.CustomControl.JButton();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.tableNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.TopPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.buttonPagePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.detailGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.exitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1138, 63);
            this.TopPanel.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataGridView1);
            this.dataPanel.Controls.Add(this.buttonPagePanel);
            this.dataPanel.Controls.Add(this.borderPanel);
            this.dataPanel.Controls.Add(this.controlPanel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanel.Location = new System.Drawing.Point(0, 63);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(753, 532);
            this.dataPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(44, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonPagePanel
            // 
            this.buttonPagePanel.Controls.Add(this.button1);
            this.buttonPagePanel.Controls.Add(this.button2);
            this.buttonPagePanel.Controls.Add(this.button3);
            this.buttonPagePanel.Controls.Add(this.button4);
            this.buttonPagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPagePanel.Location = new System.Drawing.Point(44, 499);
            this.buttonPagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPagePanel.Name = "buttonPagePanel";
            this.buttonPagePanel.Size = new System.Drawing.Size(709, 33);
            this.buttonPagePanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<Trang đầu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "<Trang trước";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(226, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Trang sau >";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(339, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Trang cuối >>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // borderPanel
            // 
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanel.Location = new System.Drawing.Point(0, 73);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(44, 459);
            this.borderPanel.TabIndex = 2;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.searchButton);
            this.controlPanel.Controls.Add(this.searchTextbox);
            this.controlPanel.Controls.Add(this.areaCombobox);
            this.controlPanel.Controls.Add(this.areaLabel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(753, 73);
            this.controlPanel.TabIndex = 0;
            // 
            // areaCombobox
            // 
            this.areaCombobox.FormattingEnabled = true;
            this.areaCombobox.Location = new System.Drawing.Point(129, 20);
            this.areaCombobox.Name = "areaCombobox";
            this.areaCombobox.Size = new System.Drawing.Size(145, 21);
            this.areaCombobox.TabIndex = 1;
            this.areaCombobox.SelectedIndexChanged += new System.EventHandler(this.areaCombobox_SelectedIndexChanged);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(22, 20);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(86, 24);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Khu vực";
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.detailGroupbox);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(753, 63);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(385, 532);
            this.detailPanel.TabIndex = 2;
            // 
            // detailGroupbox
            // 
            this.detailGroupbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detailGroupbox.Controls.Add(this.tableNameTextbox);
            this.detailGroupbox.Controls.Add(this.tableNameLabel);
            this.detailGroupbox.Controls.Add(this.addAreaButton);
            this.detailGroupbox.Controls.Add(this.infoLabel);
            this.detailGroupbox.Controls.Add(this.confirmButton);
            this.detailGroupbox.Controls.Add(this.addButton);
            this.detailGroupbox.Controls.Add(this.deleteButton);
            this.detailGroupbox.Controls.Add(this.areaIDCombobox);
            this.detailGroupbox.Controls.Add(this.tableIDTextbox);
            this.detailGroupbox.Controls.Add(this.areaNameLabel);
            this.detailGroupbox.Controls.Add(this.areaIDLabel);
            this.detailGroupbox.Controls.Add(this.tableIDLabel);
            this.detailGroupbox.Controls.Add(this.areaNameTextbox);
            this.detailGroupbox.Location = new System.Drawing.Point(53, 73);
            this.detailGroupbox.Name = "detailGroupbox";
            this.detailGroupbox.Size = new System.Drawing.Size(300, 426);
            this.detailGroupbox.TabIndex = 1;
            this.detailGroupbox.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.infoLabel.Location = new System.Drawing.Point(33, 15);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(235, 37);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Thông tin chi tiết";
            // 
            // areaIDCombobox
            // 
            this.areaIDCombobox.FormattingEnabled = true;
            this.areaIDCombobox.Location = new System.Drawing.Point(100, 81);
            this.areaIDCombobox.Name = "areaIDCombobox";
            this.areaIDCombobox.Size = new System.Drawing.Size(182, 21);
            this.areaIDCombobox.TabIndex = 5;
            // 
            // areaNameLabel
            // 
            this.areaNameLabel.AutoSize = true;
            this.areaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaNameLabel.Location = new System.Drawing.Point(6, 134);
            this.areaNameLabel.Name = "areaNameLabel";
            this.areaNameLabel.Size = new System.Drawing.Size(79, 16);
            this.areaNameLabel.TabIndex = 3;
            this.areaNameLabel.Text = "Tên khu vực";
            // 
            // areaIDLabel
            // 
            this.areaIDLabel.AutoSize = true;
            this.areaIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaIDLabel.Location = new System.Drawing.Point(10, 86);
            this.areaIDLabel.Name = "areaIDLabel";
            this.areaIDLabel.Size = new System.Drawing.Size(74, 16);
            this.areaIDLabel.TabIndex = 2;
            this.areaIDLabel.Text = "Mã khu vực";
            // 
            // tableIDLabel
            // 
            this.tableIDLabel.AutoSize = true;
            this.tableIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIDLabel.Location = new System.Drawing.Point(11, 185);
            this.tableIDLabel.Name = "tableIDLabel";
            this.tableIDLabel.Size = new System.Drawing.Size(52, 16);
            this.tableIDLabel.TabIndex = 1;
            this.tableIDLabel.Text = "Mã bàn";
            // 
            // addAreaButton
            // 
            this.addAreaButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addAreaButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addAreaButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addAreaButton.BorderRadius = 30;
            this.addAreaButton.BorderSize = 0;
            this.addAreaButton.FlatAppearance.BorderSize = 0;
            this.addAreaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAreaButton.ForeColor = System.Drawing.Color.Black;
            this.addAreaButton.Location = new System.Drawing.Point(61, 365);
            this.addAreaButton.Name = "addAreaButton";
            this.addAreaButton.Size = new System.Drawing.Size(173, 40);
            this.addAreaButton.TabIndex = 9;
            this.addAreaButton.Text = "Thêm khu vực";
            this.addAreaButton.TextColor = System.Drawing.Color.Black;
            this.addAreaButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmButton.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmButton.BorderRadius = 30;
            this.confirmButton.BorderSize = 0;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.Location = new System.Drawing.Point(199, 306);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(72, 40);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.TextColor = System.Drawing.Color.Black;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.addButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addButton.BorderRadius = 30;
            this.addButton.BorderSize = 0;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(109, 306);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Thêm";
            this.addButton.TextColor = System.Drawing.Color.Black;
            this.addButton.UseVisualStyleBackColor = false;
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
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(20, 306);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 40);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextColor = System.Drawing.Color.Black;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // tableIDTextbox
            // 
            this.tableIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tableIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tableIDTextbox.BorderRadius = 5;
            this.tableIDTextbox.BorderSize = 2;
            this.tableIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIDTextbox.Location = new System.Drawing.Point(98, 178);
            this.tableIDTextbox.Multiline = false;
            this.tableIDTextbox.Name = "tableIDTextbox";
            this.tableIDTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tableIDTextbox.PasswordChar = false;
            this.tableIDTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tableIDTextbox.PlaceholderText = "";
            this.tableIDTextbox.Size = new System.Drawing.Size(183, 32);
            this.tableIDTextbox.TabIndex = 4;
            this.tableIDTextbox.Texts = "";
            this.tableIDTextbox.UnderlinedStyle = false;
            // 
            // areaNameTextbox
            // 
            this.areaNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.areaNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.areaNameTextbox.BorderRadius = 5;
            this.areaNameTextbox.BorderSize = 2;
            this.areaNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaNameTextbox.Location = new System.Drawing.Point(100, 127);
            this.areaNameTextbox.Multiline = false;
            this.areaNameTextbox.Name = "areaNameTextbox";
            this.areaNameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.areaNameTextbox.PasswordChar = false;
            this.areaNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.areaNameTextbox.PlaceholderText = "";
            this.areaNameTextbox.Size = new System.Drawing.Size(183, 32);
            this.areaNameTextbox.TabIndex = 0;
            this.areaNameTextbox.Texts = "";
            this.areaNameTextbox.UnderlinedStyle = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 30;
            this.searchButton.BorderSize = 0;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::CafeShop.Properties.Resources.magnifying_glass;
            this.searchButton.Location = new System.Drawing.Point(672, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(63, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.TextColor = System.Drawing.Color.White;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchTextbox.BorderRadius = 5;
            this.searchTextbox.BorderSize = 2;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(370, 12);
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchTextbox.PasswordChar = false;
            this.searchTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchTextbox.PlaceholderText = "    Tìm kiếm";
            this.searchTextbox.Size = new System.Drawing.Size(283, 35);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.Texts = "";
            this.searchTextbox.UnderlinedStyle = false;
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
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(55, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.TextColor = System.Drawing.Color.White;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.Location = new System.Drawing.Point(11, 236);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(57, 16);
            this.tableNameLabel.TabIndex = 10;
            this.tableNameLabel.Text = "Tên bàn";
            // 
            // tableNameTextbox
            // 
            this.tableNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tableNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tableNameTextbox.BorderRadius = 5;
            this.tableNameTextbox.BorderSize = 2;
            this.tableNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameTextbox.Location = new System.Drawing.Point(98, 228);
            this.tableNameTextbox.Multiline = false;
            this.tableNameTextbox.Name = "tableNameTextbox";
            this.tableNameTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tableNameTextbox.PasswordChar = false;
            this.tableNameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tableNameTextbox.PlaceholderText = "";
            this.tableNameTextbox.Size = new System.Drawing.Size(183, 32);
            this.tableNameTextbox.TabIndex = 11;
            this.tableNameTextbox.Texts = "";
            this.tableNameTextbox.UnderlinedStyle = false;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 595);
            this.ControlBox = false;
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "TableForm";
            this.TopPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.buttonPagePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.detailGroupbox.ResumeLayout(false);
            this.detailGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private CustomControl.JButton exitButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Panel controlPanel;
        private CustomControl.JButton searchButton;
        private CustomControl.JNewTextbox searchTextbox;
        private System.Windows.Forms.ComboBox areaCombobox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel buttonPagePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox detailGroupbox;
        private System.Windows.Forms.ComboBox areaIDCombobox;
        private CustomControl.JNewTextbox tableIDTextbox;
        private System.Windows.Forms.Label areaNameLabel;
        private System.Windows.Forms.Label areaIDLabel;
        private System.Windows.Forms.Label tableIDLabel;
        private CustomControl.JNewTextbox areaNameTextbox;
        private System.Windows.Forms.Label infoLabel;
        private CustomControl.JButton addAreaButton;
        private CustomControl.JButton confirmButton;
        private CustomControl.JButton addButton;
        private CustomControl.JButton deleteButton;
        private CustomControl.JNewTextbox tableNameTextbox;
        private System.Windows.Forms.Label tableNameLabel;
    }
}