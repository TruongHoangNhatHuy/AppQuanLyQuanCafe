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

namespace CafeShop.View.AdForm
{
    public partial class EmpInfoForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public EmpInfoForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }
        private void adButton_Click(object sender, EventArgs e)
        {
            AdForm.EmpDetailForm form = new EmpDetailForm();
            form.ShowDialog();
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
            reload?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BLLEmpInfo.Instance.DeleteAccount(ID);
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BLLEmpInfo.Instance.ResetPassword(ID);
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            AdForm.EmpDetailForm form = new EmpDetailForm(ID);
            form.ShowDialog();
            dataGridView1.DataSource = BLLEmpInfo.Instance.GetAccountList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBModel.Instance.KhachHangs.Where(x => x.HoTenKH.Contains(searchTextbox.Texts)).ToList();
        }
    }
}
