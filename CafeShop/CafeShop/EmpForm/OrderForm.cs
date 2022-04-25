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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            LoadTables();
            LoadCategoryFood();
        }
        private void LoadTables()
        {
            TablesButton table1 = new TablesButton("1", "Trống");
            TablesButton table2 = new TablesButton("2", "Đang phục vụ");
            TablesButton table3 = new TablesButton("3", "Trống");
            TablesButton table4 = new TablesButton("4", "Trống");
            TablesButton table5 = new TablesButton("5", "Đã phục vụ");
            TablesButton table6 = new TablesButton("6", "Trống");
            TablesButton table7 = new TablesButton("7", "Đã phục vụ");
            TablesButton table8 = new TablesButton("8", "Trống");
            areaFlowPanel.Controls.Add(table1);
            areaFlowPanel.Controls.Add(table2);
            areaFlowPanel.Controls.Add(table3);
            areaFlowPanel.Controls.Add(table4);
            areaFlowPanel.Controls.Add(table5);
            areaFlowPanel.Controls.Add(table6);
            areaFlowPanel.Controls.Add(table7);
            areaFlowPanel.Controls.Add(table8);
        }
        private void LoadCategoryFood()
        {
            CustomControl.JButton button1 = new CustomControl.JButton() { Text = "Cafe", Width=100};
            CustomControl.JButton button2 = new CustomControl.JButton() { Text = "Điểm tâm", Width = 100 };
            CustomControl.JButton button3 = new CustomControl.JButton() { Text = "Bánh mặn", Width = 100 };
            CustomControl.JButton button4 = new CustomControl.JButton() { Text = "Nước lọc", Width = 100 };
            CustomControl.JButton button5 = new CustomControl.JButton() { Text = "Nước có ga", Width = 100 };
            CustomControl.JButton button6 = new CustomControl.JButton() { Text = "Trà", Width = 100 };
            CustomControl.JButton button7 = new CustomControl.JButton() { Text = "Bánh ngọt", Width = 100 };
            CustomControl.JButton button8 = new CustomControl.JButton() { Text = "Brunch", Width = 100 };
            categoryFoodPanel.Controls.Add(button1);
            categoryFoodPanel.Controls.Add(button2);
            categoryFoodPanel.Controls.Add(button3);
            categoryFoodPanel.Controls.Add(button4);
            categoryFoodPanel.Controls.Add(button5);
            categoryFoodPanel.Controls.Add(button6);
            categoryFoodPanel.Controls.Add(button7);
            categoryFoodPanel.Controls.Add(button8);
        }
    }
}
