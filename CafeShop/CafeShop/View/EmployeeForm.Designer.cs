﻿namespace CafeShop.View
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
            this.warehouseButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.orderListButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.zoomButton = new CafeShop.View.CustomControl.JButton();
            this.label1 = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.sideMenuPanel.Controls.Add(this.warehouseButton);
            this.sideMenuPanel.Controls.Add(this.logoutButton);
            this.sideMenuPanel.Controls.Add(this.orderListButton);
            this.sideMenuPanel.Controls.Add(this.orderButton);
            this.sideMenuPanel.Controls.Add(this.mainPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(253, 831);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // warehouseButton
            // 
            this.warehouseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.warehouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warehouseButton.Location = new System.Drawing.Point(0, 222);
            this.warehouseButton.Margin = new System.Windows.Forms.Padding(4);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(253, 62);
            this.warehouseButton.TabIndex = 11;
            this.warehouseButton.Text = "Kho hàng";
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = global::CafeShop.Properties.Resources.log_out;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 769);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(253, 62);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Thoát";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // orderListButton
            // 
            this.orderListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderListButton.FlatAppearance.BorderSize = 0;
            this.orderListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListButton.Image = global::CafeShop.Properties.Resources.calendar_blank_multiple;
            this.orderListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderListButton.Location = new System.Drawing.Point(0, 160);
            this.orderListButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderListButton.Name = "orderListButton";
            this.orderListButton.Size = new System.Drawing.Size(253, 62);
            this.orderListButton.TabIndex = 7;
            this.orderListButton.Text = "Đơn gọi món";
            this.orderListButton.UseVisualStyleBackColor = true;
            this.orderListButton.Click += new System.EventHandler(this.orderListButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Image = global::CafeShop.Properties.Resources.order;
            this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderButton.Location = new System.Drawing.Point(0, 98);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(253, 62);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Đặt món";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.EmpNameLabel);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(253, 98);
            this.mainPanel.TabIndex = 1;
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmpNameLabel.Location = new System.Drawing.Point(4, 28);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(140, 25);
            this.EmpNameLabel.TabIndex = 0;
            this.EmpNameLabel.Text = "Tên Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên";
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
            this.titleBarPanel.Controls.Add(this.minimizeButton);
            this.titleBarPanel.Controls.Add(this.zoomButton);
            this.titleBarPanel.Controls.Add(this.label1);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(253, 0);
            this.titleBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(1518, 98);
            this.titleBarPanel.TabIndex = 2;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.BorderSize = 0;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Image = global::CafeShop.Properties.Resources.minimize_sign;
            this.minimizeButton.Location = new System.Drawing.Point(1377, 5);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(59, 36);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.TextColor = System.Drawing.Color.Black;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.button_MouseEnter);
            // 
            // zoomButton
            // 
            this.zoomButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zoomButton.BackColor = System.Drawing.Color.Transparent;
            this.zoomButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.zoomButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.zoomButton.BorderRadius = 0;
            this.zoomButton.BorderSize = 0;
            this.zoomButton.FlatAppearance.BorderSize = 0;
            this.zoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomButton.ForeColor = System.Drawing.Color.Black;
            this.zoomButton.Image = global::CafeShop.Properties.Resources.full_screen;
            this.zoomButton.Location = new System.Drawing.Point(1444, 4);
            this.zoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(59, 36);
            this.zoomButton.TabIndex = 3;
            this.zoomButton.TextColor = System.Drawing.Color.Black;
            this.zoomButton.UseVisualStyleBackColor = false;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            this.zoomButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.zoomButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang Chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(253, 98);
            this.childFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.childFormPanel.Size = new System.Drawing.Size(1518, 733);
            this.childFormPanel.TabIndex = 3;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 831);
            this.ControlBox = false;
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sideMenuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button orderListButton;
        private System.Windows.Forms.Button logoutButton;
        private CustomControl.JButton zoomButton;
        private CustomControl.JButton minimizeButton;
        private System.Windows.Forms.Button warehouseButton;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label label2;
    }
}