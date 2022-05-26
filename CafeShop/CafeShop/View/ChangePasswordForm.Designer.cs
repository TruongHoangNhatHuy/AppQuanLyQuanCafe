namespace CafeShop.View
{
    partial class ChangePasswordForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.cancelButton = new CafeShop.View.CustomControl.JButton();
            this.confirmButton = new CafeShop.View.CustomControl.JButton();
            this.retypePassTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.newPassTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.oldPassTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.controlBarPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBarPanel
            // 
            this.controlBarPanel.Controls.Add(this.minimizeButton);
            this.controlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.controlBarPanel.Name = "controlBarPanel";
            this.controlBarPanel.Size = new System.Drawing.Size(431, 31);
            this.controlBarPanel.TabIndex = 10;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 31);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(431, 63);
            this.titlePanel.TabIndex = 11;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(105, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(200, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Đổi mật khẩu";
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.ForeColor = System.Drawing.Color.Crimson;
            this.oldPassLabel.Location = new System.Drawing.Point(75, 128);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(117, 24);
            this.oldPassLabel.TabIndex = 15;
            this.oldPassLabel.Text = "Mật khẩu cũ:";
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.ForeColor = System.Drawing.Color.Crimson;
            this.newPassLabel.Location = new System.Drawing.Point(75, 213);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(127, 24);
            this.newPassLabel.TabIndex = 16;
            this.newPassLabel.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(75, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập lại mật khẩu mới";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warningLabel.Location = new System.Drawing.Point(72, 378);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 18);
            this.warningLabel.TabIndex = 20;
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
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(52, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 40);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Huỷ";
            this.cancelButton.TextColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmButton.BorderRadius = 30;
            this.confirmButton.BorderSize = 0;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.Location = new System.Drawing.Point(221, 409);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 40);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Lưu thay đổi";
            this.confirmButton.TextColor = System.Drawing.SystemColors.ControlText;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // retypePassTextbox
            // 
            this.retypePassTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.retypePassTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.retypePassTextbox.BorderRadius = 5;
            this.retypePassTextbox.BorderSize = 2;
            this.retypePassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePassTextbox.Location = new System.Drawing.Point(75, 328);
            this.retypePassTextbox.Multiline = false;
            this.retypePassTextbox.Name = "retypePassTextbox";
            this.retypePassTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.retypePassTextbox.PasswordChar = true;
            this.retypePassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.retypePassTextbox.PlaceholderText = "";
            this.retypePassTextbox.Size = new System.Drawing.Size(280, 32);
            this.retypePassTextbox.TabIndex = 14;
            this.retypePassTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.retypePassTextbox.Texts = "";
            this.retypePassTextbox.UnderlinedStyle = false;
            this.retypePassTextbox._TextChanged += new System.EventHandler(this.retypePassTextbox__TextChanged);
            // 
            // newPassTextbox
            // 
            this.newPassTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.newPassTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.newPassTextbox.BorderRadius = 5;
            this.newPassTextbox.BorderSize = 2;
            this.newPassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTextbox.Location = new System.Drawing.Point(75, 240);
            this.newPassTextbox.Multiline = false;
            this.newPassTextbox.Name = "newPassTextbox";
            this.newPassTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.newPassTextbox.PasswordChar = true;
            this.newPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.newPassTextbox.PlaceholderText = "";
            this.newPassTextbox.Size = new System.Drawing.Size(280, 32);
            this.newPassTextbox.TabIndex = 13;
            this.newPassTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.newPassTextbox.Texts = "";
            this.newPassTextbox.UnderlinedStyle = false;
            // 
            // oldPassTextbox
            // 
            this.oldPassTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.oldPassTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.oldPassTextbox.BorderRadius = 5;
            this.oldPassTextbox.BorderSize = 2;
            this.oldPassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassTextbox.Location = new System.Drawing.Point(75, 155);
            this.oldPassTextbox.Multiline = false;
            this.oldPassTextbox.Name = "oldPassTextbox";
            this.oldPassTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.oldPassTextbox.PasswordChar = true;
            this.oldPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.oldPassTextbox.PlaceholderText = "";
            this.oldPassTextbox.Size = new System.Drawing.Size(280, 32);
            this.oldPassTextbox.TabIndex = 12;
            this.oldPassTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.oldPassTextbox.Texts = "";
            this.oldPassTextbox.UnderlinedStyle = false;
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
            this.minimizeButton.Location = new System.Drawing.Point(377, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(54, 31);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextColor = System.Drawing.Color.White;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 474);
            this.ControlBox = false;
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.retypePassTextbox);
            this.Controls.Add(this.newPassTextbox);
            this.Controls.Add(this.oldPassTextbox);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.controlBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.controlBarPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel controlBarPanel;
        private CustomControl.JButton minimizeButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private CustomControl.JNewTextbox oldPassTextbox;
        private CustomControl.JNewTextbox newPassTextbox;
        private CustomControl.JNewTextbox retypePassTextbox;
        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label label1;
        private CustomControl.JButton confirmButton;
        private CustomControl.JButton cancelButton;
        private System.Windows.Forms.Label warningLabel;
    }
}