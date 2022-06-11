using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.View.CustomControl
{
    public partial class TablesButton : UserControl
    {
        public string ID { get; set; }
        public string Status { get; set; }
        public string MaBan { get; set; }

        public event EventHandler _Click;
        public TablesButton()
        {
            InitializeComponent();
        }
        public TablesButton(string MaBan, bool Status)
        {
            InitializeComponent();
            this.MaBan = MaBan;
            this.ID = Convert.ToInt32(MaBan.Substring(1)).ToString();
            this.Status = Status ? "Còn trống" : "Bận";     
            GUI();
        }
        public void GUI()
        {
            TableButton.Text = ID;
            if (Status.Equals("Bận"))
            {
                TableButton.ForeColor = Color.Black;
                TableButton.BorderSize = 2;
                TableButton.BorderColor = Color.Black;
                TableButton.BackColor = Color.Crimson;
            }
            else if (Status.Equals("Còn trống"))
            {
                TableButton.ForeColor = Color.Black;
                TableButton.BorderSize = 2;
                TableButton.BorderColor = Color.Green;
                TableButton.BackColor = Color.LightGreen;
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if (_Click != null)
                _Click.Invoke(sender, e);
            this.OnClick(e);
        }
    }
}
