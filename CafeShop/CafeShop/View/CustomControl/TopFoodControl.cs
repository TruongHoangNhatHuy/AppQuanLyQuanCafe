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
    public partial class TopFoodControl : UserControl
    {
        public string OrderNumber
        {
            get { return orderNumberLabel.Text; }
            set { orderNumberLabel.Text = value; }
        }
        public string FoodName
        {
            get { return foodNameLabel.Text; }
            set { foodNameLabel.Text = value; }
        }
        public string Count
        {
            get { return countLabel.Text; }
            set { countLabel.Text = value; }
        }
        public TopFoodControl()
        {
            InitializeComponent();
        }
    }
}
