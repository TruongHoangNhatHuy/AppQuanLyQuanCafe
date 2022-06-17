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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            logInfoTextbox.Texts = BLLLogin.Instance.GetCurrentIDName();
            jDropDownMenu1.IsMainMenu = true;
            jDropDownMenu1.PrimaryColor = Color.MediumSlateBlue;
            jDropDownMenu1.Items[0].Click += (Sender, E) => new AdForm.EmpDetailForm(BLLLogin.Instance.currentID, true).ShowDialog();
            jDropDownMenu1.Items[1].Click += (Sender, E) => new ChangePasswordForm(BLLLogin.Instance.currentID).ShowDialog();
            jDropDownMenu1.Items[2].Click += (Sender, E) => logoutButton_Click(Sender, E);
            Clock_Timer.Start();
        }
        private void Clock_Timer_Tick(object sender, EventArgs e)
        {
            timeButton.Text = DateTime.Now.ToString();
        }
        private void logInfoTextbox_Click(object sender, EventArgs e)
        {
            jDropDownMenu1.Show(logInfoTextbox, 0, logInfoTextbox.Height);
        }
        #region ChangColorButton
        private Button currentButton = null;
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = sender as Button;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                childFormPanel.Controls.Clear();
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = sideMenuPanel.BackColor;
            }
        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Trang Chủ";
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Đặt món";
            openChildForm(new EmpForm.OrderForm());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            BLLLogin.Instance.ResetCurrentID();
            this.Close();
        }

        #region ControlBar
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
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
        #endregion

        private void orderListButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Đơn gọi món";
            openChildForm(new EmpForm.OrderListForm());
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Kho hàng";
            openChildForm(new EmpForm.WarehouseForm());
        }       
    }
}
