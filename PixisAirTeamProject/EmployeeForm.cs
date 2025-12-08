using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;



namespace PixisAirTeamProject
{
    public partial class EmployeeForm : Form
    {
        iDB2Connection conn;
        DataSet ds;
        iDB2DataAdapter adapt;



        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void ListEmpsButton_Click(object sender, EventArgs e)
        {
            string database;

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu"); //connect to the IBM server 
                conn.Open();
                database = "SELECT * FROM FLIGHT2025.EMPPF"; //selection from empspf file
                adapt = new iDB2DataAdapter(database, conn);
                ds = new DataSet();
                adapt.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ShowEmpsListBox.Items.Add(row[0].ToString().PadRight(0) + " " + row[1].ToString().PadRight(2) + " " + row[2].ToString().PadRight(4) + " " + row[3].ToString().PadRight(6) + " " + row[5].ToString().PadRight(8) + " " +
                        row[6].ToString().PadRight(10) + " " + row[7].ToString().PadRight(12) + " " + row[8].ToString().PadRight(14) + " " + row[9].ToString().PadRight(16) + " " + row[10].ToString().PadRight(18) + " " + row[12].ToString().PadRight(20) + " " + row[13].ToString().PadRight(22) + " " +
                        row[14].ToString().PadRight(24));


                }


            }
            catch (Exception ex) // try catch block set to give error message if CONN dosent load
            {

                ShowEmpsListBox.Items.Add(ex.Message); //error message

            }
            finally
            {

                conn.Close(); //closes app
            }
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            string database;

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu"); //connect to the IBM server 
                conn.Open();
                database = "INSERT INTO FLIGHT2025.EMPPF VALUES(@RCDNBR, @EMPNO, @LASTNAME, @FIRSTNAME, @TITLE, @HOMEPHONE, @ADDR1, @ADDR2, + @ZIP, + @DEPT, + @WORKPHONE, + @BIRTHDATE, + @HIREDATE, @SALARY, + @REGIONID";
                iDB2Command comm = new iDB2Command(database, conn);
                comm.DeriveParameters();
                comm.Parameters["@RCDNBR"].Value = RecNumTextBox.Text;
                comm.Parameters["@EMPNO"].Value = EMPNumTextBox.Text;
                comm.Parameters["@LASTNAME"].Value = LastNameTextBox.Text;
                comm.Parameters["@FIRSTNAME"].Value = FirstNameTextBox.Text;
                comm.Parameters["@TITLE"].Value = TitleTextBox.Text;
                comm.Parameters["@HOMEPHONE"].Value = HomePhoneTextBox.Text;
                comm.Parameters["@ADDR1"].Value = AddressTexBox.Text;
                comm.Parameters["@ADDR2"].Value = Address2TextBox.Text;
                comm.Parameters["@ZIP"].Value = ZIPTextBox.Text;
                comm.Parameters["@DEPT"].Value = DEPTTextBox.Text;
                comm.Parameters["@WORKPHONE"].Value = WorkPhoneTextBox.Text;
                comm.Parameters["@BIRTHDATER"].Value =BDTextBox.Text;
                comm.Parameters["@HIREDATE"].Value = HDTextBox.Text;
                comm.Parameters["@SALARY"].Value = SalaryTextBox.Text;
                comm.Parameters["@REGIONID"].Value = REGIDTextBox.Text;
                comm.ExecuteNonQuery();
                conn.Close();



            }
            catch(Exception ex) 
            {
                ShowEmpsListBox.Items.Add(ex.Message); //error message
            }

        }
    }
}
