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
    public partial class ManageMeetingsForm : Form
    {
        readonly MEETINGS Meeting = new MEETINGS();

        public ManageMeetingsForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageMeetingsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Meeting.GetMeetings();
            comboBoxRoomMeeting.DataSource = Meeting.RoomTypeList();
            comboBoxRoomMeeting.DisplayMember = "RoomName";
            comboBoxRoomMeeting.ValueMember = "RoomID";
        }

        private void ButtonNewMeeting_Click(object sender, EventArgs e)
        {
            int ct = Convert.ToInt32(comboBoxRoomMeeting.SelectedIndex);
            ct++;
            int rid = ct;
            DateTime start = dateTimePickerMeetingStart.Value;
            string end = dateTimePickerMeetingEnd.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string desc = textBoxMeetingDesc.Text;

            if (Meeting.InsertMeeting(rid, start, end, desc))
            {
                dataGridView1.DataSource = Meeting.GetMeetings();
                MessageBox.Show("new Meeting Inserted Successfuly", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   
                MessageBox.Show("Meeting Not Inserted", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClearMeeting_Click(object sender, EventArgs e)
        {
            textBoxIDMeeting.Text = "";
            comboBoxRoomMeeting.SelectedIndex = 0;
            textBoxMeetingDesc.Text = "";
        }

        private void DateTimePickerMeetingStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
