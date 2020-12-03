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
            try
            {
                int ct = Convert.ToInt32(comboBoxRoomMeeting.SelectedIndex);
                ct++;
                int rid = ct;
                DateTime start = dateTimePickerMeetingStart.Value;
                DateTime end = dateTimePickerMeetingEnd.Value;
                string desc = textBoxMeetingDesc.Text;

                if (start < DateTime.Now)
                {
                    MessageBox.Show("the date/time must be > current date/time", "invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (end < start)
                {
                    MessageBox.Show("the meeting end must be before the meeting start", "invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Meeting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ButtonClearMeeting_Click(object sender, EventArgs e)
        {
            textBoxIDMeeting.Text = "";
            comboBoxRoomMeeting.SelectedIndex = 0;
            textBoxMeetingDesc.Text = "";
            dateTimePickerMeetingStart.Value = DateTime.Now;
            dateTimePickerMeetingEnd.Value = DateTime.Now;
        }

        private void DateTimePickerMeetingStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEditMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = Convert.ToInt32(textBoxIDMeeting.Text);
                int ct = Convert.ToInt32(comboBoxRoomMeeting.SelectedValue);
                ct++;
                DateTime start = dateTimePickerMeetingStart.Value;
                int rid = ct; 
                DateTime end = dateTimePickerMeetingEnd.Value;
                string desc = textBoxMeetingDesc.Text;

                if (start < DateTime.Now) 
                {
                    MessageBox.Show("the date/time must be > current date/time", "invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (end < start)
                {
                    MessageBox.Show("the meeting end must be before the meeting start", "invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Meeting.EditMeeting(mid, rid, start, end, desc))
                    {
                        dataGridView1.DataSource = Meeting.GetMeetings();
                        MessageBox.Show("new Meeting Inserted Successfuly", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Meeting Not Inserted", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Meeting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDMeeting.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int cr = (int)dataGridView1.CurrentRow.Cells[1].Value;
            cr--;
            comboBoxRoomMeeting.SelectedIndex = cr;
            dateTimePickerMeetingStart.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            dateTimePickerMeetingEnd.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            textBoxMeetingDesc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void ButtonRemoveMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                int MeetingID = Convert.ToInt32(textBoxIDMeeting.Text);

                if (Meeting.DeleteMeeting(MeetingID))
                {
                    dataGridView1.DataSource = Meeting.GetMeetings();
                    MessageBox.Show("Meeting Deleted Successfuly", "Delete Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clears fields after deletion 
                    buttonClearMeeting.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Meeting Not Deleted ", "Delete Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Meeting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
