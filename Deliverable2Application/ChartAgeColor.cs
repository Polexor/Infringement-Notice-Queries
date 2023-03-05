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
    public partial class ChartAgeColor : Form
    {
        public ChartAgeColor()
        {
            InitializeComponent();
        }
        private void fillChart()
        {

            Chart chart = (Chart)this.Controls["chartAge"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Ages of Offenders";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = " select DATEDIFF(YEAR, dateOfBirth, GETDATE()) as [Age], COUNT(dateTime) as [Offences Committed] from offender ofnder join offence ofnce on ofnce.offenderId = ofnder.offenderId group by DATEDIFF(YEAR, dateOfBirth, GETDATE())";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartAge.DataSource = ds;
            chartAge.Series["Offences"].XValueMember = "Age";
            chartAge.Series["Offences"].YValueMembers = "Offences Committed";
            chartAge.Titles.Add("Number of Offences Against Driver Age");



        }

        private void fillChartColor()
        {

            Chart chart = (Chart)this.Controls["chartAge"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Color of Vehicles";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = " select colour as [Color of the car], COUNT(colour) as [Number of Offences] from vehicle veh join offence ofnce on ofnce.registrationNumber = veh.registrationNumber group by colour";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartColor.DataSource = ds;
            chartColor.Series["Offences"].XValueMember = "Color of the car";
            chartColor.Series["Offences"].YValueMembers = "Number of Offences";
            chartColor.Titles.Add("Number of Offences Against Car Color");



        }


        private void ChartAgeColor_Load(object sender, EventArgs e)
        {
            fillChart();
            fillChartColor();
        }

        private void buttonBar_Click(object sender, EventArgs e)
        {
            chartAge.Series["Offences"].ChartType = SeriesChartType.Bar;
            chartColor.Series["Offences"].ChartType = SeriesChartType.Bar;
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            chartAge.Series["Offences"].ChartType = SeriesChartType.Area;
            chartColor.Series["Offences"].ChartType = SeriesChartType.Area;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            chartAge.Series["Offences"].ChartType = SeriesChartType.Line;
            chartColor.Series["Offences"].ChartType = SeriesChartType.Line;
        }

        private void buttonPie_Click(object sender, EventArgs e)
        {
            chartAge.Series["Offences"].ChartType = SeriesChartType.Pie;
            chartColor.Series["Offences"].ChartType = SeriesChartType.Pie;
        }

        private void buttonColumn_Click(object sender, EventArgs e)
        {
            chartAge.Series["Offences"].ChartType = SeriesChartType.Column;
            chartColor.Series["Offences"].ChartType = SeriesChartType.Column;

        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            Hide();
            SummaryReport summary = new SummaryReport();
            summary.ShowDialog();
            Close();
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            Hide();
            ChartStats chart = new ChartStats();
            chart.ShowDialog();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgeColor_Click(object sender, EventArgs e)
        {
            Hide();
            ChartTimes chart = new ChartTimes();
            chart.ShowDialog();
            Close();
        }
    }
}
