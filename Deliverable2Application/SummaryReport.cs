using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliverable2Application
{
    public partial class SummaryReport : Form
    {
        public SummaryReport()
        {
            InitializeComponent();
            listBoxSummaryReport.Items.Clear();

            string queryInfFee = "select COUNT(offenderId) as [Number of Recorded Offences] from offence";

            string querySpeedInfSum = "select SUM(amount) as [Sum of Infringement Fees] from infringementNotice";

            string querySpeedAvgExceed = "select AVG(speedAlleged - speedLimit) as [Speed Limit Exceeded by] from offence ofnce join [location] loc on ofnce.locationX = loc.locationX ";

            string queryDayOffenceCount = "select datename(dw,dateTime), COUNT(datename(dw,dateTime))  from offence group by datename(dw,dateTime) order by COUNT(datename(dw,dateTime)) desc ";

            string queryValue;
            try
            {
                SQL.selectQuery(queryInfFee);
                if (SQL.read.HasRows)
                {
                    listBoxSummaryReport.Items.Add("Number of Recorded Offences:");

                    //reading the data
                    while (SQL.read.Read())
                    {
                        queryValue = SQL.read[0].ToString();
                        listBoxSummaryReport.Items.Add(queryValue);

                    }

                }

                SQL.selectQuery(querySpeedInfSum);
                if (SQL.read.HasRows)
                {
                    listBoxSummaryReport.Items.Add("--------------------------------------");
                    listBoxSummaryReport.Items.Add("Sum of Infringement Fees:");

                    while (SQL.read.Read())
                    {

                        queryValue = SQL.read[0].ToString();
                        listBoxSummaryReport.Items.Add("$ " + queryValue);
                    }

                }

                SQL.selectQuery(querySpeedAvgExceed);
                if (SQL.read.HasRows)
                {
                    listBoxSummaryReport.Items.Add("--------------------------------------");
                    listBoxSummaryReport.Items.Add("Average Speed Limit Exceeded by:");

                    while (SQL.read.Read())
                    {

                        queryValue = SQL.read[0].ToString();
                        listBoxSummaryReport.Items.Add(queryValue + " km/h");
                    }

                }

                SQL.selectQuery(queryDayOffenceCount);
                if (SQL.read.HasRows)
                {
                    string dayName, dayCount;
                    string titleSpacing = "{0, -12}{1, -12}";
                    string dataSpacing = "{0, -12}{1, -12}";

                    listBoxSummaryReport.Items.Add("--------------------------------------");
                    listBoxSummaryReport.Items.Add("Days Most Offences Occured:");
                    listBoxSummaryReport.Items.Add("");

                    listBoxSummaryReport.Items.Add(String.Format(titleSpacing, "Day", "Offence Count"));
                    listBoxSummaryReport.Items.Add("---------   -------------");

                    while (SQL.read.Read())
                    {

                        dayName = SQL.read[0].ToString();
                        dayCount = SQL.read[1].ToString();

                        listBoxSummaryReport.Items.Add(String.Format(dataSpacing, dayName, dayCount));
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error generating summary report");
                return;
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBrowseOffences_Click(object sender, EventArgs e)
        {
            Hide();
            Offenders offenders = new Offenders();
            offenders.ShowDialog();
            Close();
        }

        private void buttonInfNotice_Click(object sender, EventArgs e)
        {
            Hide();
            InfringementNotice infringement = new InfringementNotice();
            infringement.ShowDialog();
            Close();
        }

        private void buttonAddUpOff_Click(object sender, EventArgs e)
        {
            Hide();
            AddUpdateOffence add = new AddUpdateOffence();
            add.ShowDialog();
            Close();
        }

        private void buttonChartStats_Click(object sender, EventArgs e)
        {
            Hide();
            ChartStats stats = new ChartStats();
            stats.ShowDialog();
            Hide();
        }
    }
}
