// File: PixisAirMain.cs
// Developer: Team5 - waupoosa1
// Written: 12/08/25

// This assignment will access data on the IBM i.  Each team will create a C# application that accesses various tables in the PixisAir Database.

using IBM.Data.DB2.iSeries; // Using statement for the IBM DB2 for i namespace. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirTeamProject
{
    public partial class FlightForm : Form
    {
        iDB2Connection iDB2Connection; // A connection to an IBM DB2 for i for database operations.
        iDB2DataAdapter iDB2DataAdapter; // A connection used to fill a DataSet and update an IBM DB2 for i data source.
        DataSet iDataSet; // An in-memory cache of data.

        public FlightForm()
        {
            InitializeComponent();
        }

        private void displayAirplanesButton_Click(object sender, EventArgs e) // A button event handler that loads airplane records into the airplane listBox. 
        {
            string sQL; // Initializes a string to store the SQL statement.
            try // Tries to load the airplanes.
            {
                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu"); // Initializes a connectionString.
                iDB2Connection.Open(); // Opens a connection to the data source.
                sQL = "SELECT * FROM FLIGHT2025.AIRPLANE"; // An SQL statement that selects the airplane table.
                iDB2DataAdapter = new iDB2DataAdapter(sQL, iDB2Connection); // Initializes a iDB2DataAdapter using the SQL statement and connection object.
                iDataSet = new DataSet(); // Initializes a DataSet.
                iDB2DataAdapter.Fill(iDataSet); // Adds rows to the DataSet via the iDB2DataAdapter.
                airplanesListBox.Items.Clear(); // Clears the list box before the rows are added.
                foreach (DataRow row in iDataSet.Tables[0].Rows) // Adds rows of airplanes from the DataSet to the llistBox.
                    airplanesListBox.Items.Add(row[0] + "  " + row[1] + "  " + row[2] + "  " + row[3] + "  " + row[4] + "  " + row[5] + "  " + row[6] + "  " + row[7] + "  " + row[8] + "  " + row[9] + "  " + row[10] + "  " + row[11] + "  " + row[12]);
                iDB2Connection.Close(); // Closes the connection to the data source.
            }
            catch (Exception ex) // Catches errors that occur during the application execution.
            {
                airplanesListBox.Items.Add(ex.Message); // Displays the error message explaining the exception in the airplane listBox.
            }
        }

        private void addAirplaneButton_Click(object sender, EventArgs e) // A button event handler that adds an airplane record to the airplane table.
        {
            string sQL; // Initializes a string to store the SQL statement.
            try // Tries to add the airplane.
            {
                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu"); // Initializes a connectionString.
                iDB2Connection.Open(); // Opens a connection to the data source.
                sQL = "INSERT INTO FLIGHT2025.AIRPLANE VALUES(@PLANENO, @MAXDIST, @FCLASS, @CCLASS, @PAVAIL, @MAINTMILES, @PLANEMODEL, @PMAKE, @APARCD, @APACTDT, @APIACTDT, @STATUS, @DATEMAINT)"; // An SQL statement that inserts the airplane values into the airplane table.
                iDB2Command command = new iDB2Command(sQL, iDB2Connection); // Intializes the iDB2Command and sets the commandText property to the passed-in value.
                command.DeriveParameters(); // Populates the command with the parameter descriptions.
                command.Parameters["@PLANENO"].Value = planeNumberTextBox.Text; // Sets the parameter values.
                command.Parameters["@MAXDIST"].Value = maxDistanceTextBox.Text;
                command.Parameters["@FCLASS"].Value = firstClassTextBox.Text;
                command.Parameters["@CCLASS"].Value = coachClassTextBox.Text;
                command.Parameters["@PAVAIL"].Value = planeAvailableTextBox.Text;
                command.Parameters["@MAINTMILES"].Value = maintenanceMilesTextBox.Text;
                command.Parameters["@PLANEMODEL"].Value = planeModelTextBox.Text;
                command.Parameters["@PMAKE"].Value = planeMakeTextBox.Text;
                command.Parameters["@APARCD"].Value = aPARCDTextBox.Text;
                command.Parameters["@APACTDT"].Value = aPACTDTTextBox.Text;
                command.Parameters["@APIACTDT"].Value = aPIACTDTTextBox.Text;
                command.Parameters["@STATUS"].Value = statusTextBox.Text;
                command.Parameters["@DATEMAINT"].Value = maintenanceDateTextBox.Text;
                command.ExecuteNonQuery(); // Excecutes the command.
                iDB2Connection.Close(); // Closes the connection to the data source.
            }
            catch (Exception ex) // Catches errors that occur during the application execution.
            {
                airplanesListBox.Items.Add(ex.Message); // Displays the error message explaining the exception in the airplane listBox.
            }
        }

        private void FlightForm_Load(object sender, EventArgs e) // A form load event handler that loads employee number records into the employee number listBox.
        {
            string sQL; // Initializes a string to store the SQL statement.
            try // Tries to load the employee numbers.
            {
                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu"); // Initializes a connectionString.
                iDB2Connection.Open(); // Opens a connection to the data source.
                sQL = "SELECT * FROM FLIGHT2025.EMPPF"; // An SQL statement that selects the employee table.
                iDB2DataAdapter = new iDB2DataAdapter(sQL, iDB2Connection); // Initializes a iDB2DataAdapter using the SQL statement and connection object.
                iDataSet = new DataSet(); // Initializes a DataSet.
                iDB2DataAdapter.Fill(iDataSet); // Adds rows to the DataSet via the iDB2DataAdapter.
                employeeNumberListBox.Items.Clear(); // Clears the list box before the rows are added.
                foreach (DataRow row in iDataSet.Tables[0].Rows) // Adds rows of employee numbers from the DataSet to the llistBox.
                    employeeNumberListBox.Items.Add(row[0]);
                iDB2Connection.Close(); // Closes the connection to the data source.
            }
            catch (Exception ex) // Catches errors that occur during the application execution.
            {
                employeeNumberListBox.Items.Add(ex.Message); // Displays the error message explaining the exception in the employee number listBox.
            }
        }

        private void displayEmployeeStateButton_Click(object sender, EventArgs e) // A button event handler that displays the state in which the selected employee number is located.
        {
            int selectedValue; // Initializes an interger to store the selected employee number.
            string sQL; // Initializes a string to store the SQL statement.
            int zipResult; // Initializes an interger to store the zip code.
            try // Tries to display the state in which the selected employee number is located.
            {
                selectedValue = int.Parse(employeeNumberListBox.Text); // Parses and stores an integer from the employee number selected in the listBox.
                iDB2Connection = new iDB2Connection("DataSource=deathstar.gtc.edu"); // Initializes a connectionString.
                iDB2Connection.Open(); // Opens a connection to the data source.
                sQL = "SELECT ZIP FROM FLIGHT2025.EMPPF WHERE EMPNO = @selectedValue"; // An SQL statement that selects the zip code from the employee table record of the selected employee number. 
                iDB2Command command = new iDB2Command(sQL, iDB2Connection); // Intializes the iDB2Command and sets the commandText property to the passed-in value.
                command.Parameters.AddWithValue("@selectedValue", selectedValue); // Adds the parameter to the collection.
                object result = command.ExecuteScalar(); // Excecutes the commmand and returns the first column of the first row in the result set.
                zipResult = Convert.ToInt32(result); // Converts the result to a 32-bit signed interger and stores it.
                sQL = "SELECT STATE FROM FLIGHT2025.ZIPPF WHERE ZIP = @zipResult"; // An SQL statement that selects the state from the zip code table record of the selected employee number's zip code.
                iDB2Command command2 = new iDB2Command(sQL, iDB2Connection); // Intializes the iDB2Command and sets the commandText property to the passed-in value.
                command2.Parameters.AddWithValue("@zipResult", zipResult); // Adds the parameter to the collection.
                object result2 = command2.ExecuteScalar(); // Excecutes the commmand and returns the first column of the first row in the result set.
                if (result2 != null && result2 != DBNull.Value) // If the result is not null.
                    employeeStateTextBox.Text = result2.ToString(); // Return the result as a string and sets the text value of the employee state textBox.
                iDB2Connection.Close(); // Closes the connection to the data source.
            }
            catch (Exception ex) // Catches errors that occur during the application execution.
            {
                employeeStateTextBox.Text = ex.Message; // Displays the error message explaining the exception in the employee state textBox.
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Close form and return to main form via the menu strip.
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e) // Close form and return to the main form via the exit button.
        {
            this.Close();
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jobFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
