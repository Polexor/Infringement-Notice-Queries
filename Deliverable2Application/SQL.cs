using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Deliverable2Application
{
    //Name: Shifaz Ali
    class SQL
    {
        //generates the connection to the database that is specified     
        public static SqlConnection con = new SqlConnection(@"Data Source=SHIF-DESKTOP\SQLEXPRESS;Database=DELIVERABLE_3;Integrated Security=True; MultipleActiveResultSets=true");
        //Executes an sql command
        public static SqlCommand cmd = new SqlCommand();
        //Reads data from database
        public static SqlDataReader read;




        /// <summary>
        /// Generates an SQL query based on the input
        /// query e.g. "SELECT * FROM staff"
        /// </summary>
        /// <param name="query">Your select query statement</param>
        public static void selectQuery(string query)
        {
            //Try catch for handling exceptions
            try
            {
                //Closes the connection
                con.Close();
                //make the connection the database specified in con
                cmd.Connection = con;
                //open the connection to the DELIVERIABLE_2 database
                con.Open();
                //gets the query from the method
                cmd.CommandText = query;
                //sends command to the data reader
                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                return;
            }
        }

        /// <summary>
        /// This excecutres the query, used mainly for 
        /// insert/delete/update statements etc. where we don't need
        /// to read from what we are doing.
        /// </summary>
        /// <param name="query"></param>
        public static void executeQuery(string query)
        {
            //try catch to catch any unforseen errors gracefully
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// Prints out the ID  based on the query givin into a combo box
        /// </summary>
        /// <param name="comboBox">A control to be used to write existing names to</param>
        /// <param name="query">An SQL query to generate from</param>
        public static void editComboBoxItems(ComboBox comboBox, string query)
        {
            bool clear = true;

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write brah
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (comboBox.Text == SQL.read[0].ToString())
                    {
                        clear = false;
                    }
                }
            }

            //gets data from database
            SQL.selectQuery(query);
            //if nothing in the comboBox then we need to clear it
            if (clear)
            {
                comboBox.Text = "";
                comboBox.Items.Clear();

            }

            // this will print whatever is in the database to the combobox
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBox.Items.Add(SQL.read[0].ToString());
                }
            }
        }



        public static void editListBoxItems(ListBox listBox, string query)
        {
            bool clear = true;

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write brah
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (listBox.Text == SQL.read[0].ToString())
                    {
                        clear = false;
                    }
                }
            }

            //gets data from database
            SQL.selectQuery(query);
            //if nothing in the comboBox then we need to clear it
            if (clear)
            {
                listBox.Text = "";
                listBox.Items.Clear();

            }

            // this will print whatever is in the database to the combobox
            if (SQL.read.HasRows)
            {
                string titleSpacing = "{0, -9}{1, -15}{2, -23}";
                string dataSpacing = "{0, -9}{1, -15}{2, -23}";
                listBox.Items.Add(String.Format(titleSpacing, "ID", "First Name", "Last Name"));

                while (SQL.read.Read())
                {
                    
                    string offenderId, fname, lname;

                    offenderId = SQL.read[0].ToString();
                    fname = SQL.read[1].ToString();
                    lname = SQL.read[2].ToString();
                    listBox.Items.Add(String.Format(dataSpacing, offenderId, fname, lname));

                }
            }
        }
    }
}
