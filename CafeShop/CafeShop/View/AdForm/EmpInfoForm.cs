using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.View.AdForm
{
    public partial class EmpInfoForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public EmpInfoForm()
        {
            InitializeComponent();
        }

        private void jButton3_Click(object sender, EventArgs e)
        {
            AdForm.EmpDetailForm form = new EmpDetailForm();
            form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
            reload?.Invoke();
        }
    }
}
