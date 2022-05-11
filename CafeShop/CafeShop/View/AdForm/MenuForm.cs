using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.AdForm
{
    public partial class MenuForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            reload?.Invoke();
        }
    }
}
