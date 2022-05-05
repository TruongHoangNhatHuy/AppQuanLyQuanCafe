using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        #region EventHandler
        private void button_MouseEnter(object sender, EventArgs e)
        {
            CustomControl.JButton button = sender as CustomControl.JButton;
            button.BorderSize = 2;
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            CustomControl.JButton button = sender as CustomControl.JButton;
            button.BorderSize = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool passwordState = false;
        private void passwordButton_Click(object sender, EventArgs e)
        {
            if(passwordTextbox.PasswordChar)
                passwordTextbox.PasswordChar = false;
            else
                passwordTextbox.PasswordChar = true;
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            SetTextDefault();
            passwordTextbox.PasswordChar = false;
            passwordState = false;
        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            if(!passwordState)
            {
                passwordState = true;
                passwordTextbox.PasswordChar=true;
            }    
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTextbox.Texts.Equals("admin") && passwordTextbox.Texts.Equals("admin"))
            {
                AdminForm form = new AdminForm();
                form.FormClosed += (s, args) =>this.Show();
                SetTextDefault();
                form.Show();
                this.Hide();
            }
            else if( userTextbox.Texts.Equals("user") && passwordTextbox.Texts.Equals("user"))
            {
                EmployeeForm form = new EmployeeForm();
                form.FormClosed += (s, args) => this.Show();
                SetTextDefault();
                form.Show();
                this.Hide(); 
            }
            else
            {
                warningLabel.Text = "*Tên đăng nhập hoặc mật khẩu không đúng*";
            }
        }
        public void SetTextDefault()
        {
            userTextbox.Texts = "";
            passwordTextbox.Texts = "";
            warningLabel.Text = "";
        }
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton.PerformClick();
        }
        #endregion
    }
}
