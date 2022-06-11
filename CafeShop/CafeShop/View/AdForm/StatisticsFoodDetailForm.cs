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
using CafeShop.DTO;
namespace CafeShop.View.AdForm
{
    public partial class StatisticsFoodDetailForm : Form
    {
        public StatisticsFoodDetailForm()
        {
            InitializeComponent();
            
        }
        private void StatisticsFoodDetailForm_Load(object sender, EventArgs e)
        {
            LoadStatisticsFood();
        }
        private bool direction = false;
        public void LoadStatisticsFood()
        {
            var result = BLLAdminHome.Instance.GetAllFoodStatistics(DateTime.Now);
            if (direction)
                result.Reverse();
            flowLayoutPanel.Controls.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                CustomControl.TopFoodControl line = new CustomControl.TopFoodControl()
                {
                    OrderNumber = (i + 1).ToString(),
                    FoodName = BLLAdminHome.Instance.GetTenMonByMaMon(result[i].FoodID),
                    Count = result[i].Count.ToString()
                };
                flowLayoutPanel.Controls.Add(line);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            direction = !direction;
            LoadStatisticsFood();
        }

        
    }
}
