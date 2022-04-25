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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
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
            this.label1.Text = "Trang Chủ";

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.label1.Text = "Đặt món";
            openChildForm(new EmpForm.OrderForm());
        }
    }
}
