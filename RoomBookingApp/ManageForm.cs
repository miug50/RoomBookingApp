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

        private void ManageForm_Load(object sender, EventArgs e)
        {

        }

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
    }
}
