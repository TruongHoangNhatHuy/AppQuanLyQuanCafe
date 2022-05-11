using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeShop.View
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            customizeDesigning();
            homeButton_Click(null, null);
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
            this.label1.Text = "Quản Lý Nhân Viên";
            AdForm.EmpInfoForm form = new AdForm.EmpInfoForm();
            form.reload = Reload;
            openChildForm(form);
        }

        private void cusButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Quản Lý Khách Hàng";
            AdForm.EmpInfoForm form = new AdForm.EmpInfoForm();
            form.reload = Reload;
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
            this.label1.Text = "Bàn";
            AdForm.TableForm form = new AdForm.TableForm();
            form.reload = Reload;
            openChildForm(form);
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Kho Hàng";
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
            this.label1.Text = "Hoá Đơn";
            AdForm.InvoiceForm form = new AdForm.InvoiceForm();
            form.reload = Reload;
            openChildForm(form);

        }

        private void revenueButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Doanh Thu";
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Sổ Thu Chi";
        }
        #endregion


        private void homeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Trang Chủ";
            hideSubMenu();
            //code
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Thực đơn";
            hideSubMenu();
            AdForm.MenuForm form = new AdForm.MenuForm();
            form.reload += Reload;
            openChildForm(form);
            //code
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Lịch làm việc";
            hideSubMenu();
            //code
        }

        public void Reload()
        {
            homeButton_Click(homeButton, null);
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
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
