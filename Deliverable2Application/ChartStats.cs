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
    public partial class ChartStats : Form
    {
        public ChartStats()
        {
            InitializeComponent();

        }


        private void fillChart()
        {

            Chart chart = (Chart)this.Controls["chartGraph"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Number of Lanes";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = "select roadLane, COUNT(roadLane) as [Number of offences] from offence ofnce join location loc on ofnce.locationX = loc.locationX group by roadLane";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartGraph.DataSource = ds;
            chartGraph.Series["Offences"].XValueMember = "roadLane";
            chartGraph.Series["Offences"].YValueMembers = "Number of offences";
            chartGraph.Titles.Add("Number of Offences Against Number of Lanes");
            
               
            
        }

        private void fillChartSpeed()
        {
            Chart chart = (Chart)this.Controls["chartGraphSpeed"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Speed Limits";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";



            DataSet ds = new DataSet();
                string query = "select speedLimit, COUNT(speedLimit) as [Number of offences at speedlimit] from offence ofnce join location loc on ofnce.locationX = loc.locationX group by speedLimit"; 
                SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
                adapt.Fill(ds);

                chartGraphSpeed.DataSource = ds;
                chartGraphSpeed.Series["Offences"].XValueMember = "speedLimit";
                chartGraphSpeed.Series["Offences"].YValueMembers = "Number of offences at speedlimit";
                chartGraphSpeed.Titles.Add("Number of Offences Against SpeedLimit");


            
        }

        private void fillChartLightCon()
        {

            Chart chart = (Chart)this.Controls["chartLightCon"];
            chart.ChartAreas["ChartArea1"].AxisX.Title = "Light Conditions";
            chart.ChartAreas["ChartArea1"].AxisY.Title = "Number of Offences";

            DataSet ds = new DataSet();
            string query = " select lightConditions, COUNT(lightConditions) as [Number of offences at lightConditions] from offence ofnce join location loc on ofnce.locationX = loc.locationX group by lightConditions";
            SqlDataAdapter adapt = new SqlDataAdapter(query, SQL.con);
            adapt.Fill(ds);

            chartLightCon.DataSource = ds;
            chartLightCon.Series["Offences"].XValueMember = "lightConditions";
            chartLightCon.Series["Offences"].YValueMembers = "Number of offences at lightConditions";
            chartLightCon.Titles.Add("Number of Offences Against Number of Lanes");



        }



        private void buttonBar_Click(object sender, EventArgs e)
        {
            chartGraph.Series["Offences"].ChartType = SeriesChartType.Bar;
            chartGraphSpeed.Series["Offences"].ChartType = SeriesChartType.Bar;
            chartLightCon.Series["Offences"].ChartType = SeriesChartType.Bar;


        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            chartGraph.Series["Offences"].ChartType = SeriesChartType.Area;
            chartGraphSpeed.Series["Offences"].ChartType = SeriesChartType.Area;
            chartLightCon.Series["Offences"].ChartType = SeriesChartType.Area;

        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            chartGraph.Series["Offences"].ChartType = SeriesChartType.Line;
            chartGraphSpeed.Series["Offences"].ChartType = SeriesChartType.Line;
            chartLightCon.Series["Offences"].ChartType = SeriesChartType.Line;

        }

        private void buttonPie_Click(object sender, EventArgs e)
        {
            chartGraph.Series["Offences"].ChartType = SeriesChartType.Pie;
            chartGraphSpeed.Series["Offences"].ChartType = SeriesChartType.Pie;
            chartLightCon.Series["Offences"].ChartType = SeriesChartType.Pie;

        }
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            chartGraph.Series["Offences"].ChartType = SeriesChartType.Column;
            chartGraphSpeed.Series["Offences"].ChartType = SeriesChartType.Column;
            chartLightCon.Series["Offences"].ChartType = SeriesChartType.Column;
        }

        private void ChartStats_Load(object sender, EventArgs e)
        {
            fillChart();
            fillChartSpeed();
            fillChartLightCon();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            Hide();
            SummaryReport summary = new SummaryReport();
            summary.ShowDialog();
            Close();
        }

        private void buttonTimeStats_Click(object sender, EventArgs e)
        {
            Hide();
            ChartTimes chart = new ChartTimes();
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
    }
}
