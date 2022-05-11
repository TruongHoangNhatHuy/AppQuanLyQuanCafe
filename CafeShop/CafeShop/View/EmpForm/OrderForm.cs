using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop.View.EmpForm
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
            areaFlowPanel.AutoScroll = true;
            //areaFlowPanel.WrapContents = false;
            
            TablesButton table1 = new TablesButton("1", "Trống");
            TablesButton table2 = new TablesButton("2", "Đang phục vụ");
            TablesButton table3 = new TablesButton("3", "Trống");
            TablesButton table4 = new TablesButton("4", "Trống");
            TablesButton table5 = new TablesButton("5", "Đã phục vụ");
            TablesButton table6 = new TablesButton("6", "Trống");
            TablesButton table7 = new TablesButton("7", "Đã phục vụ");
            TablesButton table8 = new TablesButton("8", "Trống");
            TablesButton table9 = new TablesButton("9", "Trống");
            TablesButton table10 = new TablesButton("10", "Đang phục vụ");
            TablesButton table11 = new TablesButton("11", "Trống");
            TablesButton table12 = new TablesButton("12", "Trống");
            TablesButton table13 = new TablesButton("13", "Đã phục vụ");
            TablesButton table14 = new TablesButton("14", "Trống");
            TablesButton table15 = new TablesButton("15", "Đã phục vụ");
            TablesButton table16 = new TablesButton("16", "Trống");
            TablesButton table17 = new TablesButton("17", "Trống");
            TablesButton table18 = new TablesButton("18", "Đang phục vụ");
            TablesButton table19 = new TablesButton("19", "Trống");
            TablesButton table20 = new TablesButton("20", "Trống");
            TablesButton table21 = new TablesButton("21", "Đã phục vụ");
            TablesButton table22 = new TablesButton("22", "Trống");
            TablesButton table23 = new TablesButton("23", "Đã phục vụ");
            TablesButton table24 = new TablesButton("24", "Trống");
            TablesButton table25 = new TablesButton("25", "Trống");
            TablesButton table26 = new TablesButton("26", "Đang phục vụ");
            TablesButton table27 = new TablesButton("27", "Trống");
            TablesButton table28 = new TablesButton("28", "Trống");
            TablesButton table29 = new TablesButton("29", "Đã phục vụ");
            TablesButton table30 = new TablesButton("30", "Trống");
            TablesButton table31 = new TablesButton("31", "Đã phục vụ");
            TablesButton table32 = new TablesButton("32", "Trống");
            areaFlowPanel.Controls.Add(table1);
            areaFlowPanel.Controls.Add(table2);
            areaFlowPanel.Controls.Add(table3);
            areaFlowPanel.Controls.Add(table4);
            areaFlowPanel.Controls.Add(table5);
            areaFlowPanel.Controls.Add(table6);
            areaFlowPanel.Controls.Add(table7);
            areaFlowPanel.Controls.Add(table8);
            areaFlowPanel.Controls.Add(table9);
            areaFlowPanel.Controls.Add(table10);
            areaFlowPanel.Controls.Add(table11);
            areaFlowPanel.Controls.Add(table12);
            areaFlowPanel.Controls.Add(table13);
            areaFlowPanel.Controls.Add(table14);
            areaFlowPanel.Controls.Add(table15);
            areaFlowPanel.Controls.Add(table16);
            areaFlowPanel.Controls.Add(table17);
            areaFlowPanel.Controls.Add(table18);
            areaFlowPanel.Controls.Add(table19);
            areaFlowPanel.Controls.Add(table20);
            areaFlowPanel.Controls.Add(table21);
            areaFlowPanel.Controls.Add(table22);
            areaFlowPanel.Controls.Add(table23);
            areaFlowPanel.Controls.Add(table24);
            areaFlowPanel.Controls.Add(table25);
            areaFlowPanel.Controls.Add(table26);
            areaFlowPanel.Controls.Add(table27);
            areaFlowPanel.Controls.Add(table28);
            areaFlowPanel.Controls.Add(table29);
            areaFlowPanel.Controls.Add(table30);
            areaFlowPanel.Controls.Add(table31);
            areaFlowPanel.Controls.Add(table32);
            for (int i = 33; i < 60; i++)
            {
                TablesButton table = new TablesButton($"{i}", "Trống");
                areaFlowPanel.Controls.Add(table);
            }
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
        public void ShowDetailFood(object sender, EventArgs e)
        {
             
        }
    }
}
