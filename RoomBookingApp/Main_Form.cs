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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMeetingsForm ManageMF = new ManageMeetingsForm();
            ManageMF.Show();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm ManageEF = new ManageEmployeesForm();
            ManageEF.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm ManageRF = new ManageRoomsForm();
            ManageRF.Show();
        }
    }
}
