using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
namespace CafeShop.View
{
    public partial class ChangePasswordForm : Form
    {
        private string CurrentID;
        public ChangePasswordForm(string CurrentID)
        {
            InitializeComponent();
            this.CurrentID = CurrentID;
        }
        #region EventHandler
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string oldPass = oldPassTextbox.Texts;
            string newPass = newPassTextbox.Texts;
            string retypePass = retypePassTextbox.Texts;
            if (oldPass == "" || newPass == "" || retypePass == "")
            {
                //MessageBox.Show("Nhập thiếu dữ liệu");
                this.warningLabel.Text = "Nhập thiếu dữ liệu";
                return;
            }
            else if(newPass != retypePass)
            {
                //MessageBox.Show("Nhập khẩu không khớp");
                this.warningLabel.Text = "Mật khẩu mới không khớp";
                return;
            }
            else if(!BLLChangePassword.Instance.CheckPassword(CurrentID,oldPass))
            {
                //MessageBox.Show("Mật khẩu cũ nhập vào không đúng");
                this.warningLabel.Text = "Mật khẩu cũ nhập vào không đúng";
                return;
            }
            else if(BLLChangePassword.Instance.CheckPassword(CurrentID, oldPass))
            {
                if(BLLChangePassword.Instance.ChangePassword(CurrentID,newPass))
                {
                    MessageBox.Show("Đã đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    warningLabel.Text = "Có lỗi khi đổi mật khẩu";
                    return;
                }    
            }    
        }
        private void retypePassTextbox__TextChanged(object sender, EventArgs e)
        {
            if (newPassTextbox.Texts != retypePassTextbox.Texts)
                warningLabel.Text = "Mật khẩu nhập vào không khớp";
            else
                warningLabel.Text = "";
        }
        #endregion
    }
}
