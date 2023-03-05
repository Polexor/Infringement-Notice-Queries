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
    public partial class AddUpdateOffence : Form
    {
        public AddUpdateOffence()
        {
            InitializeComponent();

            try
            {
                //show all the column names, pick which ones to update
                string colToChange = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'offence'";

                string colToChange2 = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'offence'";

                SQL.editComboBoxItems(comboBoxSet, colToChange);
                SQL.editComboBoxItems(comboBoxWhere, colToChange2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Queries are blank" + ex);
            }



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Can leave offenceID and desc null Note:
            string offenceID, description, speedAlleged, dateTime, ICN, locationX, locationY, rainConditions, lightConditions, windConditions, registrationNumber, offenderID;

          
            try
            {
                offenceID = textBoxOffenceID.Text.Trim();
                description = textBoxDesc.Text.Trim();
                speedAlleged = textBoxAllegedSpd.Text.Trim();
                dateTime = textBoxDateTime.Text.Trim();
                ICN = textBoxICN.Text.Trim();
                locationX = textBoxLocX.Text.Trim();
                locationY = textBoxLocY.Text.Trim();
                rainConditions = textBoxRainCon.Text.Trim();
                lightConditions = textBoxLightCon.Text.Trim();
                windConditions = textBoxWindCon.Text.Trim();
                registrationNumber = textBoxRegNum.Text.Trim();
                offenderID = textBoxOffenderID.Text.Trim();

            }
            catch
            {
                MessageBox.Show("Please make sure text is in the correct format");
                return;
            }

            
            try
            {

                SQL.executeQuery("INSERT INTO offence values ('" + offenceID + "','" + description + "','" + speedAlleged + "','" + dateTime + "','" + ICN + "','" + locationX + "','" + locationY + "','" + rainConditions + "','" + lightConditions + "','" + windConditions + "','" + registrationNumber + "','" + offenderID + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding offence unsuccessful. Check insert statement/ values entered/ if offence already in the database");
                return;
            }
            MessageBox.Show("Offence added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void ErrorTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox && control is null)
                        MessageBox.Show("Please enter values in the boxes");
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string comboSetColumn = "";
            string comboWhereColumn = "";

            string setTextValue = "";
            string whereTextValue = "";

            //Check that the combo boxes hold data first
            if (comboBoxSet.SelectedItem == null
                || comboBoxWhere.SelectedItem == null)
            {
                //One of the boxes do not have a selected item
                MessageBox.Show("Please make sure that you select the columns you want to update");
                return;
            }

            try
            {
                //For the comboBoxes
                comboSetColumn = comboBoxSet.SelectedItem.ToString();
                comboWhereColumn = comboBoxWhere.SelectedItem.ToString();

                //For the textboxes
                setTextValue = textBoxSetCombo.Text.Trim();
                whereTextValue = textBoxWhereCombo.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Update attempt unsuccessful.");
                return;
            }


            try
            {
                //the values which are string need '' before entered
                SQL.executeQuery("UPDATE offence SET " + comboSetColumn + " = " + setTextValue + " where " + comboWhereColumn + " = " + whereTextValue);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Update attempt unsuccessful.");
                return;
            }

            MessageBox.Show("Successfully updated");

        }

        private void buttonBrowseOffenders_Click(object sender, EventArgs e)
        {
            Hide();
            Offenders offenders = new Offenders();
            offenders.ShowDialog();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInfringement_Click(object sender, EventArgs e)
        {
            Hide();
            InfringementNotice infringement = new InfringementNotice();
            infringement.ShowDialog();
            Close();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            Hide();
            SummaryReport summary = new SummaryReport();
            summary.ShowDialog();
            Close();
        }
    }
}
