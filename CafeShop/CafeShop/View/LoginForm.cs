using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DTO;
using CafeShop.BLL;

namespace CafeShop.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = DBContext.Instance.KhuVucs.ToList();
            SetTextDefault();
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

            try
            {
                string account = userTextbox.Texts;
                string password = passwordTextbox.Texts;
                if (account == "")
                    throw new Exception("Thiếu tên tài khoản");
                if (password == "")
                    throw new Exception("Thiếu mật khẩu");
                else if (BLLLogin.Instance.ValidateAccount(account, password))
                {
                    // EmpForm
                    EmployeeForm form = new EmployeeForm();
                    form.FormClosed += (s, args) => this.Show();
                    SetTextDefault();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // AdForm
                    AdminForm form = new AdminForm();
                    form.FormClosed += (s, args) => this.Show();
                    SetTextDefault();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                warningLabel.Text = ex.Message;
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
