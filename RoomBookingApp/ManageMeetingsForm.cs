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

        public ManageMeetingsForm()
        {
            InitializeComponent();
        }

        readonly MEETINGS Meeting = new MEETINGS();
        
        private void ManageMeetingsForm_Load(object sender, EventArgs e)
        {
            //loads the Meeting data in to the data grid view 
            dataGridView1.DataSource = Meeting.GetMeetings();  

            //loads the roomtypes in to the room comboBox
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
                    MessageBox.Show("The date/time must be > current date/time", "Invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (end < start)
                {
                    MessageBox.Show("The meeting must start be before the End of the meeting", "Invalid Date/time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(desc == null || desc == string.Empty)
                    {
                       MessageBox.Show("Description can't be empty", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Meeting.InsertMeeting(rid, start, end, desc))
                        {
                            //updates the datagridview to show changes
                            dataGridView1.DataSource = Meeting.GetMeetings();
                            MessageBox.Show("New Meeting Inserted Successfuly", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Meeting Not Inserted", "Add Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void ButtonRemoveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxMeeting.Text);

                if (Meeting.DeleteMeeting(id))
                {
                    dataGridView1.DataSource = Meeting.GetMeetings();
                    MessageBox.Show("Meeting Deleted Successfuly", "Delete Meeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clears fields after deletion 
                    buttonClearMeeting.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Meeting Not Updated ", "Delete Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Meeting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMeeting.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
