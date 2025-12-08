// File: PixisAirMain.cs
// Developer: Team5 - pithchert1, RooneyA3, waupoosa1
// Written: 12/08/25

// This assignment will access data on the IBM i.  Each team will create a C# application that accesses various tables in the PixisAir Database.

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
    public partial class PixisAirMain : Form
    {
        public PixisAirMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Exit application via the menu strip.
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e) // Exit application via the exit button.
        {
            Application.Exit();
        }

        private void flightFormToolStripMenuItem_Click(object sender, EventArgs e) // Show the flight form via the menu strip
        {
            FlightForm flightForm = new FlightForm();
            flightForm.Show();
        }

        private void flightFormButton_Click(object sender, EventArgs e) // Show the flight form via the menu strip.
        {
            FlightForm flightForm = new FlightForm();
            flightForm.Show();
        }

        private void employeeFormButton_Click(object sender, EventArgs e) //show the employee form via button
        {
            new EmployeeForm().Show();                  
        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e) //show the employee form via menu strip 
        {
            new EmployeeForm().Show();
        }
    }
}
