using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.EmpForm
{
    public partial class TablesButton : UserControl
    {
        public string ID { get; set; }
        public string Status { get; set; }
        public TablesButton()
        {
            InitializeComponent();
        }
        public TablesButton(string ID, string Status)
        {
            InitializeComponent();
            this.ID = ID;
            this.Status = Status;
            GUI();
        }
        private void GUI()
        {
            TableButton.Text = ID;
            if(Status.Equals("Trống"))
            {
                TableButton.ForeColor = Color.Black;
                TableButton.BorderSize = 2;
                TableButton.BorderColor = Color.Black;
                TableButton.BackColor = Color.White;
            }
            else if(Status.Equals("Đang phục vụ"))
            {
                TableButton.ForeColor = Color.Black;
                TableButton.BorderSize = 2;
                TableButton.BorderColor = Color.Red;
                TableButton.BackColor = Color.PaleVioletRed;
            }
            else if (Status.Equals("Đã phục vụ"))
            {
                TableButton.ForeColor = Color.Black;
                TableButton.BorderSize = 2;
                TableButton.BorderColor = Color.Green;
                TableButton.BackColor = Color.LightGreen;
            }
        }
    }
}
