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
    public partial class ViewMeetingsForm : Form
    {
        public ViewMeetingsForm()
        {
            InitializeComponent();
        }

        readonly MEETINGS meeting = new MEETINGS();

        private void ViewMeetingsForm_Load(object sender, EventArgs e)
        {
            EMPLOYEE emp = new EMPLOYEE();

            comboBox1.DataSource = emp.GetEmployee();
            comboBox1.DisplayMember = "EmployeeEmail";
            comboBox1.ValueMember = "EmployeeID";
            int i = Convert.ToInt32(comboBox1.SelectedValue);
            dataGridViewViewMeetings.DataSource = meeting.GetMeetingsFromID(i);
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBox1.SelectedValue);
            dataGridViewViewMeetings.DataSource = meeting.GetMeetingsFromID(i);
        }
    }
}
