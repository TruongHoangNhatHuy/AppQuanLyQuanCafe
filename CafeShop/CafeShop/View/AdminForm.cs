using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using CafeShop.BLL;

namespace CafeShop.View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            customizeDesigning();
            homeButton_Click(this.homeButton, null);
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            logInfoTextbox.Texts = BLLLogin.Instance.GetCurrentIDName();
            jDropDownMenu1.IsMainMenu = true;
            jDropDownMenu1.PrimaryColor = Color.MediumSlateBlue;
            jDropDownMenu1.Items[0].Click += (Sender, E ) => new AdForm.EmpDetailForm(BLLLogin.Instance.currentID,true).ShowDialog();
            jDropDownMenu1.Items[1].Click += (Sender, E) => new ChangePasswordForm(BLLLogin.Instance.currentID).ShowDialog();
            jDropDownMenu1.Items[2].Click += (Sender, E) => logoutButton_Click(Sender,E);
            ClockTimer.Start();
        }
        private void Clocktimer_Tick(object sender, EventArgs e)
        {
            timeButton.Text = DateTime.Now.ToString();
        }
        private void logInfoTextbox_Click(object sender, EventArgs e)
        {
            jDropDownMenu1.Show(logInfoTextbox, 0, logInfoTextbox.Height);
        }
        #region SubMenu
        private void customizeDesigning()
        {
            subPersonPanel.Visible = false;
            subFacilityPanel.Visible = false;
            subStatisticsPanel.Visible = false;
            //
        }
        private void hideSubMenu()
        {
            if (subFacilityPanel.Visible == true)
                subFacilityPanel.Visible = false;
            if (subStatisticsPanel.Visible == true)
                subStatisticsPanel.Visible = false;
            if (subPersonPanel.Visible == true)
                subPersonPanel.Visible = false;

            this.childFormPanel.Controls.Clear();
            //
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

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
        #region PersonalMenu

        private void personalButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(subPersonPanel);
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Quản Lý Nhân Viên";
            AdForm.EmpInfoForm form = new AdForm.EmpInfoForm();
            form.reload += Reload;
            openChildForm(form);
        }

        private void cusButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Quản Lý Khách Hàng";
            //AdForm.EmpInfoForm form = new AdForm.EmpInfoForm();
            AdForm.CustomerInfoForm form = new AdForm.CustomerInfoForm();
            form.reload += Reload;
            openChildForm(form);
        }
        #endregion

        #region Facility Menu
        private void facilityButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(subFacilityPanel);
        }

        private void tableButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Bàn";
            AdForm.TableForm form = new AdForm.TableForm();
            form.reload += Reload;
            openChildForm(form);
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Kho Hàng";
            AdForm.WarehouseForm form  = new AdForm.WarehouseForm();
            openChildForm(form);
        }
        #endregion

        #region Statistics Menu
        private void statisticsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(subStatisticsPanel);
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Hoá Đơn";
            AdForm.InvoiceForm form = new AdForm.InvoiceForm();
            form.reload += Reload;
            openChildForm(form);

        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Doanh Thu";
            AdForm.RevenueForm form = new AdForm.RevenueForm();
            form.reload += Reload;
            openChildForm(form);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Sổ Thu Chi";
        }
        #endregion


        private void homeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Trang Chủ";
            hideSubMenu();
            //code
            AdForm.AdminHomeForm form = new AdForm.AdminHomeForm();
            openChildForm(form);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Thực đơn";
            hideSubMenu();
            AdForm.MenuForm form = new AdForm.MenuForm();
            form.reload += Reload;
            openChildForm(form);
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.funcNameLabel.Text = "Lịch làm việc";
            hideSubMenu();
            //code
        }

        public void Reload()
        {
            homeButton_Click(homeButton, null);
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
    }
}
