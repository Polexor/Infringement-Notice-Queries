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
    public partial class InfringementNotice : Form
    {
        public InfringementNotice()
        {
            InitializeComponent();
            //change to show just the ids of offenders with inf notices
            string idName = "select offenderId, fname, lname from offender o join infringementNotice i on o.offenderId = i.offenceID";
            SQL.editListBoxItems(listBoxSelectOffender, idName);
            Console.WriteLine(idName);


        }

        private void buttonShowNotice_Click(object sender, EventArgs e)
        {


            ClearListBoxes();



            string inputOffenderid, fname, lname, streetAddress, cityAddress, regionAddress, dateOfBirth, licenseNumber, noticeNumber, icn, issueDate, offenceDateTime, vehicleMake, VehicleRegNum, offLocation, offRoad, offRegion, description, amount, issueDateDueFee, speedLimit, speedAlleged;


            inputOffenderid = textBoxEnterOID.Text.Trim();


            string query = "select ofnder.offenderId, fname, lname, streetAddress, cityAddress, regionAddress, dateOfBirth, licenseNumber, noticeNumber, icn, ofnce.dateTime, ofnce.[dateTime], veh.make, veh.registrationNumber, loc.location, loc.road, loc.region,[description], amount, inf.issueDate, speedLimit, speedAlleged from offence ofnce join offender ofnder on ofnce.offenderId = ofnder.offenderId join infringementNotice inf on inf.offenceID = ofnder.offenderId join [location] loc on loc.locationX = ofnce.locationX join vehicle veh on veh.registrationNumber = ofnce.registrationNumber where ofnder.offenderId = " + inputOffenderid;



            SQL.selectQuery(query);

            try
            {

                if (SQL.read.HasRows)
                {


                    while (SQL.read.Read())
                    {   //Name

                        fname = SQL.read[1].ToString();
                        lname = SQL.read[2].ToString();

                        //Address section

                        streetAddress = SQL.read[3].ToString();
                        cityAddress = SQL.read[4].ToString();
                        regionAddress = SQL.read[5].ToString();

                        //Licence details
                        dateOfBirth = SQL.read[6].ToString();
                        licenseNumber = SQL.read[7].ToString();
                        noticeNumber = SQL.read[8].ToString();
                        icn = SQL.read[9].ToString();

                        //Alleged infringement details section
                        issueDate = SQL.read[10].ToString();
                        offenceDateTime = SQL.read[11].ToString();
                        vehicleMake = SQL.read[12].ToString();
                        VehicleRegNum = SQL.read[13].ToString();

                        //Location of offence
                        offLocation = SQL.read[14].ToString();
                        offRoad = SQL.read[15].ToString();
                        offRegion = SQL.read[16].ToString();

                        //Fine and offence information
                        description = SQL.read[17].ToString();
                        amount = SQL.read[18].ToString();
                        issueDateDueFee = SQL.read[19].ToString();

                        //Details of speeding offence section (dont forget exceeded by)
                        speedLimit = SQL.read[20].ToString();
                        speedAlleged = SQL.read[21].ToString();

                        string dataSpacingNames = "{0, -8}{1, -4}";
                        listBoxIname.Items.Add(String.Format(dataSpacingNames, fname, lname));

                        string dataSpacingAddresses = "{0, 0}{1, 10}";
                        listBoxIaddress.Items.Add(String.Format(dataSpacingAddresses, streetAddress, cityAddress));
                        listBoxIaddressRegion.Items.Add(regionAddress);

                        listBoxIdob.Items.Add(dateOfBirth);
                        listBoxIdriversLicence.Items.Add(licenseNumber);
                        listBoxINoticeNum.Items.Add(noticeNumber);
                        listBoxIicn.Items.Add(icn);

                        listBoxIdate.Items.Add(String.Format(issueDate, offenceDateTime));
                        listBoxIvehMake.Items.Add(vehicleMake);
                        listBoxIregNum.Items.Add(VehicleRegNum);

                        string dataSpacingLocation = "{0, 0}{1, 14}";
                        listBoxIlocation.Items.Add(String.Format(dataSpacingLocation, offLocation, offRoad));
                        listBoxIlocation.Items.Add(offRegion);

                        listBoxIdescription.Items.Add(description);
                        listBoxIfine.Items.Add("$ " + amount);
                        listBoxIdueDate.Items.Add(issueDateDueFee);

                        listBoxIspeedLim.Items.Add(speedLimit + " km/h");
                        listBoxIspeedAllgd.Items.Add(speedAlleged + " km/h");

                        int exceededSpeed = int.Parse(speedAlleged) - int.Parse(speedLimit);
                        listBoxIexceededBy.Items.Add(exceededSpeed + " km/h");




                    }
                }
                else
                {
                    MessageBox.Show("No infringement notices found");
                }


            }
            catch
            {
                MessageBox.Show("Please enter an Offender ID");
                return;
            }
        }

        private void ClearListBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is ListBox && control != null)
                    {
                        if (control.Name != "listBoxSelectOffender")
                        {
                            (control as ListBox).Items.Clear();
                        }
                    }
                    func(control.Controls);
                }

            };
            func(Controls);
        }

        private void InfringementNotice_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBrowOffenders_Click(object sender, EventArgs e)
        {
            Hide();
            Offenders offenders = new Offenders();
            offenders.ShowDialog();
            Close();
        }

        private void buttonAddupOffence_Click(object sender, EventArgs e)
        {
            Hide();
            AddUpdateOffence addUpdateOffence = new AddUpdateOffence();
            addUpdateOffence.ShowDialog();
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
