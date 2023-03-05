using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Deliverable2Application
{
    public partial class ChartTimes : Form
    {
        public ChartTimes()
        {
            InitializeComponent();
        }


        private void fillChart()
        {

            Chart chart = (Chart)this.Controls["chartDays"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Days of the Week";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = "select datename(dw,dateTime) as days, COUNT(datename(dw,dateTime)) as [values]  from offence group by datename(dw,dateTime) ORDER BY CASE  datename(dw,dateTime) WHEN 'Sunday' THEN 1 WHEN 'Monday' THEN 2  WHEN  'Tuesday' THEN 3  WHEN  'Wednesday' THEN 4  WHEN  'Thursday' THEN 5 WHEN 'Friday' THEN 6 WHEN 'Saturday' THEN 7 END ASC ";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartDays.DataSource = ds;
            chartDays.Series["Offences"].XValueMember = "days";
            chartDays.Series["Offences"].YValueMembers = "values";
            chartDays.Titles.Add("Number of Offences Against Days of the Week");



        }

        private void fillChartHours()
        {

            Chart chart = (Chart)this.Controls["chartHours"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Hours of the Day(24hr)";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = " select datename(HH,dateTime) as Hour, COUNT(datename(dw,dateTime)) as offnces  from offence group by datename(HH,dateTime) order by Hour asc ";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartHours.DataSource = ds;
            chartHours.Series["Offences"].XValueMember = "Hour";
            chartHours.Series["Offences"].YValueMembers = "offnces";
            chartHours.Titles.Add("Number of Offences Against Hours of the Day");



        }

        private void ChartTimes_Load(object sender, EventArgs e)
        {
            fillChart();
            fillChartHours();
        }

        private void buttonBar_Click(object sender, EventArgs e)
        {
            chartDays.Series["Offences"].ChartType = SeriesChartType.Bar;
            chartHours.Series["Offences"].ChartType = SeriesChartType.Bar;


        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            chartDays.Series["Offences"].ChartType = SeriesChartType.Area;
            chartHours.Series["Offences"].ChartType = SeriesChartType.Area;

        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            chartDays.Series["Offences"].ChartType = SeriesChartType.Line;
            chartHours.Series["Offences"].ChartType = SeriesChartType.Line;

        }

        private void buttonPie_Click(object sender, EventArgs e)
        {
            chartDays.Series["Offences"].ChartType = SeriesChartType.Pie;
            chartHours.Series["Offences"].ChartType = SeriesChartType.Pie;

        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            Hide();
            SummaryReport summary = new SummaryReport();
            summary.ShowDialog();
            Close();
        }

        private void buttonColumn_Click(object sender, EventArgs e)
        {
            chartDays.Series["Offences"].ChartType = SeriesChartType.Column;
            chartHours.Series["Offences"].ChartType = SeriesChartType.Column;
        }

        private void buttonTimeStats_Click(object sender, EventArgs e)
        {
            Hide();
            ChartStats chart = new ChartStats();
            chart.ShowDialog();
            Close();
        }

        private void buttonAgeColor_Click(object sender, EventArgs e)
        {
            Hide();
            ChartAgeColor chart = new ChartAgeColor();
            chart.ShowDialog();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
