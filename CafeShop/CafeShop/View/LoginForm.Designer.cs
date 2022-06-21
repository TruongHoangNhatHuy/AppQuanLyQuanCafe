
namespace CafeShop.View
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new CafeShop.View.CustomControl.JButton();
            this.closeButton = new CafeShop.View.CustomControl.JButton();
            this.loginButton = new CafeShop.View.CustomControl.JButton();
            this.passwordButton = new CafeShop.View.CustomControl.JButton();
            this.passwordTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            this.userButton = new CafeShop.View.CustomControl.JButton();
            this.userTextbox = new CafeShop.View.CustomControl.JNewTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeShop.Properties.Resources.cafe;
            this.pictureBox1.Location = new System.Drawing.Point(133, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warningLabel.Location = new System.Drawing.Point(100, 376);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(97, 24);
            this.warningLabel.TabIndex = 8;
            this.warningLabel.Text = "     label  ";
            // 
            // minimizeButton
            // 
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
            this.minimizeButton.Location = new System.Drawing.Point(289, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(44, 29);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TextColor = System.Drawing.Color.Black;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeButton.BorderRadius = 0;
            this.closeButton.BorderSize = 0;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Image = global::CafeShop.Properties.Resources.closelogin;
            this.closeButton.Location = new System.Drawing.Point(340, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.TextColor = System.Drawing.Color.Black;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginButton.BorderRadius = 30;
            this.loginButton.BorderSize = 0;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(57, 417);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(276, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.TextColor = System.Drawing.Color.Black;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.passwordButton.BorderRadius = 30;
            this.passwordButton.BorderSize = 0;
            this.passwordButton.FlatAppearance.BorderSize = 0;
            this.passwordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordButton.ForeColor = System.Drawing.Color.White;
            this.passwordButton.Image = global::CafeShop.Properties.Resources.padlock;
            this.passwordButton.Location = new System.Drawing.Point(57, 305);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(43, 40);
            this.passwordButton.TabIndex = 6;
            this.passwordButton.TextColor = System.Drawing.Color.White;
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextbox.BorderRadius = 5;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(113, 298);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTextbox.PasswordChar = false;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.PlaceholderText = "Mật khẩu";
            this.passwordTextbox.Size = new System.Drawing.Size(235, 47);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = true;
            this.passwordTextbox.Click += new System.EventHandler(this.passwordTextbox_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.userButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.userButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.userButton.BorderRadius = 30;
            this.userButton.BorderSize = 0;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Image = global::CafeShop.Properties.Resources.EmployeeIcon;
            this.userButton.Location = new System.Drawing.Point(57, 215);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(43, 40);
            this.userButton.TabIndex = 5;
            this.userButton.TextColor = System.Drawing.Color.White;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // userTextbox
            // 
            this.userTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userTextbox.BorderRadius = 5;
            this.userTextbox.BorderSize = 2;
            this.userTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.Location = new System.Drawing.Point(113, 208);
            this.userTextbox.Multiline = false;
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userTextbox.PasswordChar = false;
            this.userTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userTextbox.PlaceholderText = "Tài khoản";
            this.userTextbox.Size = new System.Drawing.Size(235, 47);
            this.userTextbox.TabIndex = 2;
            this.userTextbox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.userTextbox.Texts = "";
            this.userTextbox.UnderlinedStyle = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(387, 478);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.userTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControl.JNewTextbox userTextbox;
        private CustomControl.JButton userButton;
        private CustomControl.JNewTextbox passwordTextbox;
        private CustomControl.JButton passwordButton;
        private CustomControl.JButton loginButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControl.JButton closeButton;
        private CustomControl.JButton minimizeButton;
        private System.Windows.Forms.Label warningLabel;
    }
}