using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirTeamProject
{
    public partial class JobForm : Form
    {
        iDB2Connection iDB2Connection;
        iDB2DataAdapter iDB2DataAdapter;
        DataSet iDataSet;

        public JobForm()
        {
            InitializeComponent();
        }

        private void listJobs()
        {
            string sQL;

            try
            {
                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu");
                iDB2Connection.Open();
                sQL = "SELECT * FROM FLIGHT2025.JOBTYPE"; // is this the right one? i don't know
                iDB2DataAdapter = new iDB2DataAdapter(sQL, iDB2Connection);
                iDataSet = new DataSet();
                iDB2DataAdapter.Fill(iDataSet);
                jobsListBox.Items.Clear();
                // i had a very scientific method to figure out how many columns there were, known as "mess around and see what breaks"
                foreach (DataRow row in iDataSet.Tables[0].Rows)
                    jobsListBox.Items.Add(row[0] + "  " + row[1] + "  " + row[2] + "  " + row[3] + "  " + row[4]);
                iDB2Connection.Close();
            }
            catch (Exception ex) // something has went wrong
            {
                jobsListBox.Items.Add(ex.Message);
            }
        }

        private void addZipCode()
        {
            zipCodeListBox.Items.Clear();


            // before we even try anything, do the bare minimum of checking that the fields aren't empty
            if (cityTextBox.Text.Length <= 0 || stateTextBox.Text.Length <= 0 || zipCodeTextBox.Text.Length <= 0)
            {
                zipCodeListBox.Items.Add("Could not add zip code, as one or more inputs were empty.");
                return;
            }

            string sQL;
            try
            {

                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu");
                iDB2Connection.Open();
                sQL = "INSERT INTO FLIGHT2025.ZIPCODE VALUES(@ZIP, @CITY, @STATE)";
                iDB2Command command = new iDB2Command(sQL, iDB2Connection);
                command.DeriveParameters();
                command.Parameters["@ZIP"].Value = zipCodeTextBox.Text;
                command.Parameters["@CITY"].Value = cityTextBox.Text;
                command.Parameters["@STATE"].Value = stateTextBox.Text;
                command.ExecuteNonQuery();
                iDB2Connection.Close();
                zipCodeListBox.Items.Add("Zip code added successfully.");
            }
            catch (Exception ex)
            {
                zipCodeListBox.Items.Add("Could not add zip code, as an exception was thrown: " + ex.Message);
            }
        }

        // this could probably be optimized (since the code is practically copied verbatim from flightform) but i doubt he will care
        private void listJobsButton_Click(object sender, EventArgs e)
        {
            listJobs();
        }

        private void addZipCodeButton_Click(object sender, EventArgs e)
        {
            addZipCode();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listJobs();
        }

        private void addZipCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addZipCode();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
