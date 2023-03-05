using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Deliverable2Application
{
    
    public partial class Offenders : Form
    {
        public Offenders()
        {
            InitializeComponent();
        }

        //Declaring variables to store data into after executing the selectQuery()
        string firstName, lastName, offenceDescription, allegedSpeed, dateTime, RegistrationNumber, offenderID;
        string titleSpacing = "{0, -12}{1, -12}{2, -23}{3, -20}{4, -20}{5, 0}";
        string dataSpacing = "{0, -12}{1, -12}{2, -23}{3, -15}{4, -32}{5, 0}";

        private void buttonOverDueInfringemnts_Click(object sender, EventArgs e)
        {
            //{6, -25}
            offenderListBox.Items.Clear();
            string titleSpacingOver = "{0, -10}{1, -15}{2, -15}{3, -18}{4, -15}{5, -23}{6, 0}";
            string dataSpacingOver = "{0, -10}{1, -15}{2, -15}{3, -18}{4, -10}{5, -26}{6, 0}";
            string amount, issueDate, phone;

            string query = "select ofnder.offenderId, fname, lname, [description],  amount,issueDate, phone, noticeNumber from infringementNotice inf join offence ofnce on inf.offenceID = ofnce.offenceId join offender ofnder on ofnder.offenderId = ofnce.offenceId where DATEDIFF(DAY, issueDate, GETDATE()) > 28 and status like 'Unpaid'";

            SQL.selectQuery(query);

            try
            {
                //if there is data present
                if (SQL.read.HasRows)
                {
                    //adding titles to the top of the listbox  
                    offenderListBox.Items.Add(String.Format(titleSpacingOver, "ID", "First Name", "Last Name", "Description", "Amount", "Issue Date", "Phone", "Notice Number"));

                    //added lines to emphasise the difference between headers and data
                    offenderListBox.Items.Add("---       ----------     ---------      -----------       ------    ----------------------    ------------");
                    //reading the data
                    while (SQL.read.Read())
                    {
                        //storing the data columns into the assigned variables
                        offenderID = SQL.read[0].ToString();
                        firstName = SQL.read[1].ToString();
                        lastName = SQL.read[2].ToString();
                        offenceDescription = SQL.read[3].ToString();
                        amount = SQL.read[4].ToString();
                        issueDate = SQL.read[5].ToString();
                        phone = SQL.read[6].ToString();



                        //adding the variables into the listbox with formatting to be displayed to the user
                        offenderListBox.Items.Add(String.Format(dataSpacingOver, offenderID, firstName, lastName, offenceDescription, amount, issueDate, phone));

                    }
                }
                else
                {
                    // infroms when there is no data found in the sql database
                    offenderListBox.Items.Add("No offender information found.");
                }
            }
            catch
            {
                // simple message to indicate exception
                MessageBox.Show("Error quering the database.");

            }

        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            Hide();
            SummaryReport summary = new SummaryReport();
            summary.ShowDialog();
            Close();
        }

        private void buttonUnpaidInfringements_Click(object sender, EventArgs e)
        {
            offenderListBox.Items.Clear();
            string titleSpacingInf = "{0, -10}{1, -15}{2, -15}{3, -15}{4, -12}{5, -26}{6, 0}";
            string dataSpacingInf = "{0, -10}{1, -15}{2, -15}{3, -15}{4, -12}{5, -27}{6, 0}";
            string amount, issueDate, noticeNumber;

            string query = "select ofnder.offenderId, fname, lname, [description], amount, issueDate, noticeNumber  from infringementNotice inf join offender ofnder on inf.offenceID = ofnder.offenderId join offence ofnce on ofnce.offenceId = inf.offenceID where status like 'Unpaid'";

            SQL.selectQuery(query);

            try
            {
                //if there is data present
                if (SQL.read.HasRows)
                {
                    //adding titles to the top of the listbox  
                    offenderListBox.Items.Add(String.Format(titleSpacingInf, "ID", "First Name", "Last Name", "Description", "Amount", "Issue Date", "Notice Number"));

                    //added lines to emphasise the difference between headers and data
                    offenderListBox.Items.Add("---       ----------     -----------    ------------   -------     ----------------------    -------------");
                    //reading the data
                    while (SQL.read.Read())
                    {
                        //storing the data columns into the assigned variables
                        offenderID = SQL.read[0].ToString();
                        firstName = SQL.read[1].ToString();
                        lastName = SQL.read[2].ToString();
                        offenceDescription = SQL.read[3].ToString();
                        amount = SQL.read[4].ToString();
                        issueDate = SQL.read[5].ToString();
                        noticeNumber = SQL.read[6].ToString();

                        //adding the variables into the listbox with formatting to be displayed to the user
                        offenderListBox.Items.Add(String.Format(dataSpacingInf, offenderID, firstName, lastName, offenceDescription, amount, issueDate, noticeNumber));

                    }
                }
                else
                {
                    // infroms when there is no data found in the sql database
                    offenderListBox.Items.Add("No offender information found.");
                }
            }
            catch
            {
                // simple message to indicate exception
                MessageBox.Show("Error quering the database.");

            }
        }

        /// <summary>
        /// Displays the information from an SQL database in a listbox when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            offenderListBox.Items.Clear();


            //Spacing for the headers and data so that the output is formated appropriately 
           

            //Made titles in application so did not need to rename attributes with 'as'
            // query to get the names of the offenders from offenders table along with other useful information from the offence table
            string query = "select fname, lname, [description], speedAlleged, [dateTime], registrationNumber  from offender, offence where offender.offenderId = offence.offenceId ";

            //Query the database with this method
            SQL.selectQuery(query);

            //try catch used for error handling 
            try
            {
                //if there is data present
                if (SQL.read.HasRows)
                {
                    //adding titles to the top of the listbox  
                    offenderListBox.Items.Add(String.Format(titleSpacing, "Firstname", "Lastname", "Offence Description", "Alleged Speed", "Date&Time", "Registration Number"));

                    //added lines to emphasise the difference between headers and data
                    offenderListBox.Items.Add("---------  ----------  ---------------------  --------------- ----------------------  ---------------------");
                    //reading the data
                    while (SQL.read.Read())
                    {
                        //storing the data columns into the assigned variables
                        firstName = SQL.read[0].ToString();
                        lastName = SQL.read[1].ToString();
                        offenceDescription = SQL.read[2].ToString();
                        allegedSpeed = SQL.read[3].ToString();
                        dateTime = SQL.read[4].ToString();
                        RegistrationNumber = SQL.read[5].ToString();

                        //adding the variables into the listbox with formatting to be displayed to the user
                        offenderListBox.Items.Add(String.Format(dataSpacing, firstName, lastName, offenceDescription, allegedSpeed, dateTime, RegistrationNumber));

                    }
                }
                else
                {
                    // infroms when there is no data found in the sql database
                    offenderListBox.Items.Add("No offender information found.");
                }
            }
            catch
            {
                // simple message to indicate exception
                MessageBox.Show("Error quering the database.");

            }
        }

        /// <summary>
        /// Button to exit the application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddUpOffence_Click(object sender, EventArgs e)
        {
            Hide();
            AddUpdateOffence addUpdateOffence = new AddUpdateOffence();
            addUpdateOffence.ShowDialog();
            Close();
        }

        private void buttonInfringement_Click(object sender, EventArgs e)
        {
            Hide();
            InfringementNotice infringement = new InfringementNotice();
            infringement.ShowDialog();
            Close();
        }

        private void buttonFilterInfringement_Click(object sender, EventArgs e)
        {
            string titleSpacingFilter = "{0, -5}{1, -13}{2, -13}{3, -23}{4, -20}{5, -18}{6, 0}";
            string dataSpacingFilter = "{0, -5}{1, -13}{2, -13}{3, -25}{4, -12}{5, -27}{6, 0}";

            offenderListBox.Items.Clear();

            string query = "select fname, lname, [description], speedAlleged, [dateTime], registrationNumber, offend.offenderId from offence ofnce join offender offend on ofnce.offenderId = offend.offenderId where offend.offenderId in (select offenderId from offender where offenderId not in (select offenceID from infringementNotice))";
          
            SQL.selectQuery(query);

            try
            {
                //if there is data present
                if (SQL.read.HasRows)
                {
                    //adding titles to the top of the listbox  
                    offenderListBox.Items.Add(String.Format(titleSpacingFilter, "ID", "Firstname", "Lastname", "Offence Description", "Alleged Speed", "Date&Time", "Registration"));

                    //added lines to emphasise the difference between headers and data
                    offenderListBox.Items.Add("---  ---------    ---------    --------------------   ------------- ----------------------  ------------");
                    //reading the data
                    while (SQL.read.Read())
                    {
                        //storing the data columns into the assigned variables
                        firstName = SQL.read[0].ToString();
                        lastName = SQL.read[1].ToString();
                        offenceDescription = SQL.read[2].ToString();
                        allegedSpeed = SQL.read[3].ToString();
                        dateTime = SQL.read[4].ToString();
                        RegistrationNumber = SQL.read[5].ToString();
                        offenderID = SQL.read[6].ToString();


                        //adding the variables into the listbox with formatting to be displayed to the user
                        offenderListBox.Items.Add(String.Format(dataSpacingFilter, offenderID, firstName, lastName, offenceDescription, allegedSpeed, dateTime, RegistrationNumber));

                    }
                }
                else
                {
                    // infroms when there is no data found in the sql database
                    offenderListBox.Items.Add("No offender information found.");
                }
            }
            catch
            {
                // simple message to indicate exception
                MessageBox.Show("Error quering the database.");

            }

        }
    }
}

