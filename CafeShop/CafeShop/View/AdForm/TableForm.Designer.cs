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
            this.exitButton = new CafeShop.View.CustomControl.JButton();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaCombobox = new System.Windows.Forms.ComboBox();
            this.searchTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.searchButton = new CafeShop.View.CustomControl.JButton();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.buttonPagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoLabel = new System.Windows.Forms.Label();
            this.detailGroupbox = new System.Windows.Forms.GroupBox();
            this.areaNameTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.tableIDLabel = new System.Windows.Forms.Label();
            this.areaIDLabel = new System.Windows.Forms.Label();
            this.areaNameLabel = new System.Windows.Forms.Label();
            this.tableIDTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.areaIDCombobox = new System.Windows.Forms.ComboBox();
            this.jButton1 = new CafeShop.View.CustomControl.JButton();
            this.jButton2 = new CafeShop.View.CustomControl.JButton();
            this.jButton3 = new CafeShop.View.CustomControl.JButton();
            this.jButton4 = new CafeShop.View.CustomControl.JButton();
            this.TopPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.buttonPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.detailGroupbox);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(753, 63);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(385, 532);
            this.detailPanel.TabIndex = 2;
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
            // areaCombobox
            // 
            this.areaCombobox.FormattingEnabled = true;
            this.areaCombobox.Location = new System.Drawing.Point(129, 20);
            this.areaCombobox.Name = "areaCombobox";
            this.areaCombobox.Size = new System.Drawing.Size(145, 21);
            this.areaCombobox.TabIndex = 1;
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
            // 
            // borderPanel
            // 
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderPanel.Location = new System.Drawing.Point(0, 73);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(44, 459);
            this.borderPanel.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(44, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Crimson;
            this.infoLabel.Location = new System.Drawing.Point(33, 33);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(235, 37);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Thông tin chi tiết";
            // 
            // detailGroupbox
            // 
            this.detailGroupbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detailGroupbox.Controls.Add(this.jButton4);
            this.detailGroupbox.Controls.Add(this.infoLabel);
            this.detailGroupbox.Controls.Add(this.jButton3);
            this.detailGroupbox.Controls.Add(this.jButton2);
            this.detailGroupbox.Controls.Add(this.jButton1);
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
            // areaNameTextbox
            // 
            this.areaNameTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.areaNameTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.areaNameTextbox.BorderRadius = 5;
            this.areaNameTextbox.BorderSize = 2;
            this.areaNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaNameTextbox.Location = new System.Drawing.Point(98, 150);
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
            // tableIDLabel
            // 
            this.tableIDLabel.AutoSize = true;
            this.tableIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIDLabel.Location = new System.Drawing.Point(11, 219);
            this.tableIDLabel.Name = "tableIDLabel";
            this.tableIDLabel.Size = new System.Drawing.Size(52, 16);
            this.tableIDLabel.TabIndex = 1;
            this.tableIDLabel.Text = "Mã bàn";
            // 
            // areaIDLabel
            // 
            this.areaIDLabel.AutoSize = true;
            this.areaIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaIDLabel.Location = new System.Drawing.Point(10, 102);
            this.areaIDLabel.Name = "areaIDLabel";
            this.areaIDLabel.Size = new System.Drawing.Size(74, 16);
            this.areaIDLabel.TabIndex = 2;
            this.areaIDLabel.Text = "Mã khu vực";
            // 
            // areaNameLabel
            // 
            this.areaNameLabel.AutoSize = true;
            this.areaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaNameLabel.Location = new System.Drawing.Point(8, 160);
            this.areaNameLabel.Name = "areaNameLabel";
            this.areaNameLabel.Size = new System.Drawing.Size(79, 16);
            this.areaNameLabel.TabIndex = 3;
            this.areaNameLabel.Text = "Tên khu vực";
            // 
            // tableIDTextbox
            // 
            this.tableIDTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tableIDTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tableIDTextbox.BorderRadius = 5;
            this.tableIDTextbox.BorderSize = 2;
            this.tableIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableIDTextbox.Location = new System.Drawing.Point(98, 211);
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
            // areaIDCombobox
            // 
            this.areaIDCombobox.FormattingEnabled = true;
            this.areaIDCombobox.Location = new System.Drawing.Point(100, 100);
            this.areaIDCombobox.Name = "areaIDCombobox";
            this.areaIDCombobox.Size = new System.Drawing.Size(182, 21);
            this.areaIDCombobox.TabIndex = 5;
            // 
            // jButton1
            // 
            this.jButton1.BackColor = System.Drawing.Color.Crimson;
            this.jButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.jButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton1.BorderRadius = 30;
            this.jButton1.BorderSize = 0;
            this.jButton1.FlatAppearance.BorderSize = 0;
            this.jButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton1.ForeColor = System.Drawing.Color.Black;
            this.jButton1.Location = new System.Drawing.Point(20, 261);
            this.jButton1.Name = "jButton1";
            this.jButton1.Size = new System.Drawing.Size(72, 40);
            this.jButton1.TabIndex = 6;
            this.jButton1.Text = "Xoá";
            this.jButton1.TextColor = System.Drawing.Color.Black;
            this.jButton1.UseVisualStyleBackColor = false;
            // 
            // jButton2
            // 
            this.jButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton2.BorderRadius = 30;
            this.jButton2.BorderSize = 0;
            this.jButton2.FlatAppearance.BorderSize = 0;
            this.jButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton2.ForeColor = System.Drawing.Color.Black;
            this.jButton2.Location = new System.Drawing.Point(109, 261);
            this.jButton2.Name = "jButton2";
            this.jButton2.Size = new System.Drawing.Size(72, 40);
            this.jButton2.TabIndex = 7;
            this.jButton2.Text = "Thêm";
            this.jButton2.TextColor = System.Drawing.Color.Black;
            this.jButton2.UseVisualStyleBackColor = false;
            // 
            // jButton3
            // 
            this.jButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.jButton3.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.jButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton3.BorderRadius = 30;
            this.jButton3.BorderSize = 0;
            this.jButton3.FlatAppearance.BorderSize = 0;
            this.jButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton3.ForeColor = System.Drawing.Color.Black;
            this.jButton3.Location = new System.Drawing.Point(199, 261);
            this.jButton3.Name = "jButton3";
            this.jButton3.Size = new System.Drawing.Size(72, 40);
            this.jButton3.TabIndex = 8;
            this.jButton3.Text = "Xác nhận";
            this.jButton3.TextColor = System.Drawing.Color.Black;
            this.jButton3.UseVisualStyleBackColor = false;
            // 
            // jButton4
            // 
            this.jButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton4.BorderRadius = 30;
            this.jButton4.BorderSize = 0;
            this.jButton4.FlatAppearance.BorderSize = 0;
            this.jButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton4.ForeColor = System.Drawing.Color.Black;
            this.jButton4.Location = new System.Drawing.Point(61, 320);
            this.jButton4.Name = "jButton4";
            this.jButton4.Size = new System.Drawing.Size(173, 40);
            this.jButton4.TabIndex = 9;
            this.jButton4.Text = "Thêm khu vực";
            this.jButton4.TextColor = System.Drawing.Color.Black;
            this.jButton4.UseVisualStyleBackColor = false;
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
            this.detailPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.buttonPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private CustomControl.JButton jButton4;
        private CustomControl.JButton jButton3;
        private CustomControl.JButton jButton2;
        private CustomControl.JButton jButton1;
    }
}