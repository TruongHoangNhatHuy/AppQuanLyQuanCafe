namespace CafeShop
{
    partial class EmployeeForm
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.sideMenuPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.sideMenuPanel.Controls.Add(this.scheduleButton);
            this.sideMenuPanel.Controls.Add(this.orderButton);
            this.sideMenuPanel.Controls.Add(this.homeButton);
            this.sideMenuPanel.Controls.Add(this.mainPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(210, 691);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(210, 70);
            this.mainPanel.TabIndex = 1;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.titleBarPanel.Controls.Add(this.label1);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(210, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1134, 70);
            this.titleBarPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang Chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(210, 70);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Padding = new System.Windows.Forms.Padding(10);
            this.childFormPanel.Size = new System.Drawing.Size(1134, 621);
            this.childFormPanel.TabIndex = 3;
            // 
            // scheduleButton
            // 
            this.scheduleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.scheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduleButton.Location = new System.Drawing.Point(0, 170);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(210, 50);
            this.scheduleButton.TabIndex = 7;
            this.scheduleButton.Text = "Lịch làm việc";
            this.scheduleButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Image = global::CafeShop.Properties.Resources.order;
            this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.Location = new System.Drawing.Point(0, 120);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(210, 50);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Đặt món";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = global::CafeShop.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 70);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(210, 50);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Trang chủ";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 691);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.sideMenuPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button scheduleButton;
    }
}