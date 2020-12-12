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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMeetingsForm MMF = new ManageMeetingsForm();
            MMF.Show();
        }

        private void MeetingEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMeetingEmployeesForm MME = new ManageMeetingEmployeesForm();
            MME.Show();
        }

        private void ViewMeetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMeetingsForm vmf = new ViewMeetingsForm();
            vmf.Show();
        }
    }
}
