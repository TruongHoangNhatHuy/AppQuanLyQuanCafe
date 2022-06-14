using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CafeShop.BLL;
namespace CafeShop.View.AdForm
{
    public partial class RevenueForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public RevenueForm()
        {
            InitializeComponent();
        }
        #region EventHandler
        private void RevenueForm_Load(object sender, EventArgs e)
        {
            statisticsTypeCombobox.Items.AddRange(new string[] { "Theo ngày trong tháng", "Theo tháng", "Theo năm" });
            statisticsTypeCombobox.SelectedIndex = 0;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            DateTime from = fromDatetimepicker.Value, to = toDatetimepicker.Value;
            if (from.Date > to.Date)
            {
                MessageBox.Show("Out of range");
                return;
            }
            int fromYear = from.Year, toYear = to.Year;
            if (statisticsTypeCombobox.SelectedItem == null)
                return;
            string statisticsType = statisticsTypeCombobox.SelectedItem.ToString();
            if (statisticsType.Equals("Theo năm"))
            {
                LoadRevenueChartByYear(fromYear, toYear);
                LoadBillChartByYear(fromYear, toYear);
                LoadCustomerChart(from, to, BLLRevenue.StatisticsType.ByYear);
            }
            else if (statisticsType.Equals("Theo tháng"))
            {
                LoadRevenueByMonth(from, to);
                LoadBillChartByMonth(from, to);
                LoadCustomerChart(from, to, BLLRevenue.StatisticsType.ByMonth);
            }
            else if (statisticsType.Equals("Theo ngày trong tháng"))
            {
                LoadRevenueByDate(from);
                LoadBillCountByDate(from);
                LoadCustomerChart(from, to, BLLRevenue.StatisticsType.ByDate);
            }
        }

        private void statisticsTypeCombobox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = statisticsTypeCombobox.SelectedIndex;
            if (selection == 0)
            {
                toGroupbox.Visible = false;
            }
            else if (selection == 1)
            {
                toGroupbox.Visible = true;
            }
            else if (selection == 2)
            {
                toGroupbox.Visible = true;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }
        #endregion

        #region LoadChartData
        private void LoadRevenueChartByYear(int from = 2020, int to = 2022)
        {
            revenueChart.Series.Clear();            
            Series series = new Series("Revenue");
            var data = BLLRevenue.Instance.GetRevenueByYear(from, to);
            for (int i = 0; i < (to - from + 1); i++)
            {
                series.Points.AddXY(i + from, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            revenueChart.Series.Add(series);
            revenueLabel.Text = BLLRevenue.Instance.GetRevenue(data).ToString();
        }
        private void LoadRevenueByMonth(DateTime from, DateTime to)
        {
            revenueChart.Series.Clear();
            Series series = new Series();
            var data = BLLRevenue.Instance.GetRevenueByMonth(from, to);
            int monthCount = (to.Year - from.Year) * 12 + to.Month - from.Month + 1;
            for (int i = 0; i < monthCount; i++)
            {
                DateTime time = from.AddMonths(i);
                string month = time.Month.ToString() + "/" + time.Year.ToString();
                series.Points.AddXY(month, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            revenueChart.Series.Add(series);
            revenueLabel.Text = BLLRevenue.Instance.GetRevenue(data).ToString();
        }
        private void LoadRevenueByDate(DateTime from)
        {
            revenueChart.Series.Clear();
            Series series = new Series();
            var data = BLLRevenue.Instance.GetRevenueByDate(from);
            int daysInMonth = DateTime.DaysInMonth(from.Year, from.Month);
            for (int i = 0; i < daysInMonth; i++)
            {
                string date = (i + 1).ToString() + "/" + from.Month.ToString();
                series.Points.AddXY(date, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            revenueChart.Series.Add(series);
            revenueLabel.Text = BLLRevenue.Instance.GetRevenue(data).ToString();
        }
        private void LoadBillChartByYear(int from = 2020, int to = 2022)
        {
            billChart.Series.Clear();
            Series series = new Series("Bill");
            var data = BLLRevenue.Instance.GetBillCountByYear(from, to);
            for (int i = 0; i < (to - from + 1); i++)
            {
                series.Points.AddXY(i + from, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            billChart.Series.Add(series);
            billCountLabel.Text = BLLRevenue.Instance.GetBillCount(data).ToString();
        }
        private void LoadBillChartByMonth(DateTime from, DateTime to)
        {
            billChart.Series.Clear();
            Series series = new Series("Bill");
            var data = BLLRevenue.Instance.GetBillCountByMonth(from, to);
            int monthCount = (to.Year - from.Year) * 12 + to.Month - from.Month + 1;
            for (int i = 0; i < monthCount; i++)
            {
                DateTime time = from.AddMonths(i);
                string month = time.Month.ToString() + "/" + time.Year.ToString();
                series.Points.AddXY(month, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            billChart.Series.Add(series);
            billCountLabel.Text = BLLRevenue.Instance.GetBillCount(data).ToString();
        }   
        private void LoadBillCountByDate(DateTime from)
        {
            billChart.Series.Clear();
            Series series = new Series("Bill");
            var data = BLLRevenue.Instance.GetBillCountDate(from);
            int daysInMonth = DateTime.DaysInMonth(from.Year, from.Month);
            for (int i = 0; i < daysInMonth; i++)
            {
                string date = (i + 1).ToString() + "/" + from.Month.ToString();
                series.Points.AddXY(date, data[i]);
                series.Points[i].Label = data[i].ToString();
            }
            billChart.Series.Add(series);
            billCountLabel.Text = BLLRevenue.Instance.GetBillCount(data).ToString();
        }
        private void LoadCustomerChart(DateTime from, DateTime to, BLLRevenue.StatisticsType type)
        {
            customerChart.Series.Clear();
            Series series = new Series("Customer");
            var data = BLLRevenue.Instance.GetCustomerRevenue(from, to, type);
            series.ChartType = SeriesChartType.Doughnut;
            series.Points.AddXY("Khách vãng lai", data[0]);
            series.Points.AddXY("Thành viên", data[1]);
            series.Label = "#PERCENT";
            series.LegendText = "#VALX";
            series.Palette = ChartColorPalette.SeaGreen;
            customerChart.Series.Add(series);
            customerCountLabel.Text = BLLRevenue.Instance.GetCustomerCount(from, to, type).ToString();
        }
        #endregion
        
    }
}
