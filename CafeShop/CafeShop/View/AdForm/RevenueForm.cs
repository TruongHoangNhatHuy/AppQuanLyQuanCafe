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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
            statisticsTypeCombobox.Items.AddRange(new string[] { "Theo ngày trong tháng", "Theo tháng", "Theo năm" });           
            //LoadRevenueChartByYear();
        }

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

        }
        private void LoadCustomerChart(DateTime from, DateTime to, int type = 0)
        {
            customerChart.Series.Clear();
            Series series = new Series("Customer");
            dynamic data;
            if (type == 0)
                data = BLLRevenue.Instance.GetCustumerCountByYear(from.Year, to.Year);
            else if (type == 1)
                data = BLLRevenue.Instance.GetCustumerCountByDate(from, to);
            else
                data = BLLRevenue.Instance.GetCustumerCountByMonth(from);
            series.ChartType = SeriesChartType.Doughnut;
            series.Points.AddXY("Khách vãng lai", data[0]);
            series.Points.AddXY("Thành viên", data[1]);
            series.Label = "#PERCENT";
            series.LegendText = "#VALX";
            series.Palette = ChartColorPalette.SeaGreen;
            customerChart.Series.Add(series);
        }
        #endregion
        private void confirmButton_Click(object sender, EventArgs e)
        {
            DateTime from = fromDatetimepicker.Value, to = toDatetimepicker.Value;
            if(from > to)
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
                LoadCustomerChart(from, to, 0);
            }
            else if(statisticsType.Equals("Theo tháng"))
            {
                LoadRevenueByMonth(from, to);
                LoadBillChartByMonth(from, to);
                LoadCustomerChart(from, to, 1);
            }    
            else if (statisticsType.Equals("Theo ngày trong tháng"))
            {
                LoadRevenueByDate(from);
                LoadBillCountByDate(from);
                LoadCustomerChart(from, to, 2);
            }
            var bill = BLLInvoice.Instance.GetHoaDonByTime(from, to);
            billCountLabel.Text = BLLInvoice.Instance.GetBillCount(bill);
            customerCountLabel.Text = BLLInvoice.Instance.GetCustomerCount(bill);
            revenueLabel.Text = BLLInvoice.Instance.GetRevenue(bill);
        }
    }
}
