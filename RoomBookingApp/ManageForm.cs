using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingApp
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        //When the Manage form is closed the login form is presented. This is if an admin wishes to check changes.
        private void ManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        private void ManageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm ManageEF = new ManageEmployeesForm();
            ManageEF.Show();
        }

        private void ManageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm ManageRF = new ManageRoomsForm();
            ManageRF.Show();
        }

        //when the admin selects this button the last 6 months are saved. This is a manual option. This can be made semi-Automatic by moving this function to the login page as "onload"
        private void LogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEETINGS meeting = new MEETINGS();
            meeting.GetCSVdata();
            MessageBox.Show("Last 6 months saved", "data saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
