namespace CafeShop.View.EmpForm
{
    partial class OrderForm
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
            this.areaPanel = new System.Windows.Forms.Panel();
            this.areaFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.jButton4 = new CafeShop.View.CustomControl.JButton();
            this.jButton3 = new CafeShop.View.CustomControl.JButton();
            this.jButton2 = new CafeShop.View.CustomControl.JButton();
            this.jButton1 = new CafeShop.View.CustomControl.JButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openButton = new CafeShop.View.CustomControl.JButton();
            this.orderButton = new CafeShop.View.CustomControl.JButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.statusTableLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timeArriveLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.categoryFoodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.foodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusTable = new System.Windows.Forms.Label();
            this.areaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.itemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaPanel
            // 
            this.areaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaPanel.Controls.Add(this.areaFlowPanel);
            this.areaPanel.Controls.Add(this.panel5);
            this.areaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.areaPanel.Location = new System.Drawing.Point(0, 0);
            this.areaPanel.Name = "areaPanel";
            this.areaPanel.Size = new System.Drawing.Size(329, 611);
            this.areaPanel.TabIndex = 0;
            // 
            // areaFlowPanel
            // 
            this.areaFlowPanel.BackColor = System.Drawing.Color.Wheat;
            this.areaFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.areaFlowPanel.Location = new System.Drawing.Point(0, 62);
            this.areaFlowPanel.Name = "areaFlowPanel";
            this.areaFlowPanel.Size = new System.Drawing.Size(327, 547);
            this.areaFlowPanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.areaComboBox);
            this.panel5.Controls.Add(this.areaLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 62);
            this.panel5.TabIndex = 0;
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(127, 32);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(121, 21);
            this.areaComboBox.TabIndex = 1;
            this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBox_SelectedIndexChanged);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(12, 31);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(72, 20);
            this.areaLabel.TabIndex = 0;
            this.areaLabel.Text = "Khu vực";
            // 
            // detailPanel
            // 
            this.detailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPanel.Controls.Add(this.tableLayoutPanel2);
            this.detailPanel.Controls.Add(this.tableLayoutPanel1);
            this.detailPanel.Controls.Add(this.panel1);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.detailPanel.Location = new System.Drawing.Point(329, 0);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(313, 611);
            this.detailPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.jButton4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.jButton3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.jButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.jButton1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 292);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 47);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.jButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton4.ForeColor = System.Drawing.Color.White;
            this.jButton4.Location = new System.Drawing.Point(234, 3);
            this.jButton4.Name = "jButton4";
            this.jButton4.Size = new System.Drawing.Size(71, 40);
            this.jButton4.TabIndex = 3;
            this.jButton4.Text = "Thanh toán";
            this.jButton4.TextColor = System.Drawing.Color.White;
            this.jButton4.UseVisualStyleBackColor = false;
            // 
            // jButton3
            // 
            this.jButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton3.BorderRadius = 30;
            this.jButton3.BorderSize = 0;
            this.jButton3.FlatAppearance.BorderSize = 0;
            this.jButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton3.ForeColor = System.Drawing.Color.White;
            this.jButton3.Location = new System.Drawing.Point(157, 3);
            this.jButton3.Name = "jButton3";
            this.jButton3.Size = new System.Drawing.Size(71, 40);
            this.jButton3.TabIndex = 2;
            this.jButton3.Text = "Ghép bàn";
            this.jButton3.TextColor = System.Drawing.Color.White;
            this.jButton3.UseVisualStyleBackColor = false;
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
            this.jButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton2.ForeColor = System.Drawing.Color.White;
            this.jButton2.Location = new System.Drawing.Point(80, 3);
            this.jButton2.Name = "jButton2";
            this.jButton2.Size = new System.Drawing.Size(71, 40);
            this.jButton2.TabIndex = 1;
            this.jButton2.Text = "Chuyển bàn";
            this.jButton2.TextColor = System.Drawing.Color.White;
            this.jButton2.UseVisualStyleBackColor = false;
            // 
            // jButton1
            // 
            this.jButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.jButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.jButton1.BorderRadius = 30;
            this.jButton1.BorderSize = 0;
            this.jButton1.FlatAppearance.BorderSize = 0;
            this.jButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButton1.ForeColor = System.Drawing.Color.White;
            this.jButton1.Location = new System.Drawing.Point(3, 3);
            this.jButton1.Name = "jButton1";
            this.jButton1.Size = new System.Drawing.Size(71, 40);
            this.jButton1.TabIndex = 0;
            this.jButton1.Text = "Đặt chỗ";
            this.jButton1.TextColor = System.Drawing.Color.White;
            this.jButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.openButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 242);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.openButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.openButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.openButton.BorderRadius = 30;
            this.openButton.BorderSize = 0;
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(23, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(124, 44);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Mở bàn";
            this.openButton.TextColor = System.Drawing.Color.White;
            this.openButton.UseVisualStyleBackColor = false;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Crimson;
            this.orderButton.BackgroundColor = System.Drawing.Color.Crimson;
            this.orderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.orderButton.BorderRadius = 30;
            this.orderButton.BorderSize = 0;
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(163, 3);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(124, 44);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Gọi Món";
            this.orderButton.TextColor = System.Drawing.Color.White;
            this.orderButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statusTable);
            this.panel1.Controls.Add(this.timeOutLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableNameLabel);
            this.panel1.Controls.Add(this.statusTableLabel);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.timeArriveLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 242);
            this.panel1.TabIndex = 0;
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timeOutLabel.Location = new System.Drawing.Point(66, 202);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(179, 20);
            this.timeOutLabel.TabIndex = 5;
            this.timeOutLabel.Text = "25/04/2022 07:34 PM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời điểm phục vụ gần nhất";
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableNameLabel.Location = new System.Drawing.Point(76, 17);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(151, 20);
            this.tableNameLabel.TabIndex = 3;
            this.tableNameLabel.Text = "Bàn số 1 - Tầng 1";
            // 
            // statusTableLabel
            // 
            this.statusTableLabel.AutoSize = true;
            this.statusTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTableLabel.Location = new System.Drawing.Point(19, 130);
            this.statusTableLabel.Name = "statusTableLabel";
            this.statusTableLabel.Size = new System.Drawing.Size(58, 18);
            this.statusTableLabel.TabIndex = 2;
            this.statusTableLabel.Text = "Khách: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(19, 96);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(81, 18);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Tình trạng: ";
            // 
            // timeArriveLabel
            // 
            this.timeArriveLabel.AutoSize = true;
            this.timeArriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeArriveLabel.Location = new System.Drawing.Point(19, 62);
            this.timeArriveLabel.Name = "timeArriveLabel";
            this.timeArriveLabel.Size = new System.Drawing.Size(68, 18);
            this.timeArriveLabel.TabIndex = 0;
            this.timeArriveLabel.Text = "Giờ đến: ";
            // 
            // itemPanel
            // 
            this.itemPanel.Controls.Add(this.categoryFoodPanel);
            this.itemPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemPanel.Location = new System.Drawing.Point(642, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(118, 611);
            this.itemPanel.TabIndex = 2;
            // 
            // categoryFoodPanel
            // 
            this.categoryFoodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryFoodPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.categoryFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.categoryFoodPanel.Name = "categoryFoodPanel";
            this.categoryFoodPanel.Size = new System.Drawing.Size(118, 611);
            this.categoryFoodPanel.TabIndex = 0;
            // 
            // foodPanel
            // 
            this.foodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.foodPanel.Location = new System.Drawing.Point(760, 0);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(394, 611);
            this.foodPanel.TabIndex = 3;
            // 
            // statusTable
            // 
            this.statusTable.AutoSize = true;
            this.statusTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTable.ForeColor = System.Drawing.Color.Crimson;
            this.statusTable.Location = new System.Drawing.Point(146, 96);
            this.statusTable.Name = "statusTable";
            this.statusTable.Size = new System.Drawing.Size(93, 18);
            this.statusTable.TabIndex = 6;
            this.statusTable.Text = "Tình trạng: ";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.Controls.Add(this.foodPanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.areaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.areaPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.itemPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel areaPanel;
        private System.Windows.Forms.FlowLayoutPanel areaFlowPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControl.JButton jButton4;
        private CustomControl.JButton jButton3;
        private CustomControl.JButton jButton2;
        private CustomControl.JButton jButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControl.JButton openButton;
        private CustomControl.JButton orderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.Label statusTableLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timeArriveLabel;
        private System.Windows.Forms.FlowLayoutPanel categoryFoodPanel;
        private System.Windows.Forms.FlowLayoutPanel foodPanel;
        private System.Windows.Forms.Label statusTable;
    }
}