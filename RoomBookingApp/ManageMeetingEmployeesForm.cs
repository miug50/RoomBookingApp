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
    public partial class ManageMeetingEmployeesForm : Form
    {

        public ManageMeetingEmployeesForm()
        {
            InitializeComponent();
        }

        private void ManageMeetingEmployeesForm_Load(object sender, EventArgs e)
        {
            MEETINGEMPLOYEES ME = new MEETINGEMPLOYEES();
            EMPLOYEE emp = new EMPLOYEE();
            MEETINGS meet = new MEETINGS();
            dataGridViewManageEmployees.DataSource = ME.GetMeetingEmployees();
            comboBoxMeetings.DataSource = meet.GetMeetings();
            comboBoxMeetings.DisplayMember = "MeetingDesc";
            comboBoxMeetings.ValueMember = "MeetingID";

            dataGridViewMeetingEmployeeLst.DataSource = emp.GetEmployee();
        }

        private void buttonClearMeetingEMP_Click(object sender, EventArgs e)
        {
            TextBoxIDMeetingEmployees.Text = "";
            comboBoxMeetings.SelectedIndex = 0;
            
        }

        private void buttonEditMeetingEMP_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewMeetingEMP_Click(object sender, EventArgs e)
        {
            MEETINGEMPLOYEES MeetingE = new MEETINGEMPLOYEES();
                try
                {
                int MID = Convert.ToInt32(comboBoxMeetings.SelectedValue);
                int empID = 0;

                for (int i = 0; i < dataGridViewMeetingEmployeeLst.RowCount; i++)
                {
                    if (Convert.ToBoolean(dataGridViewMeetingEmployeeLst.Rows[i].Cells["chk"].Value) == true)
                    {
                        empID = Convert.ToInt32(dataGridViewMeetingEmployeeLst.Rows[i].Cells[1].Value);
                    
                        if (MeetingE.InsertMeetingEmployee(empID, MID))
                        {
                            dataGridViewManageEmployees.DataSource = MeetingE.GetMeetingEmployees();
                            MessageBox.Show("new Meeting Employee Inserted Successfuly", "Add Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Meeting Employee was Not Inserted", "Add Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    }
                
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Meeting Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewManageEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxIDMeetingEmployees.Text = dataGridViewManageEmployees.CurrentRow.Cells[0].Value.ToString();
            comboBoxMeetings.SelectedValue = (int)dataGridViewManageEmployees.CurrentRow.Cells[2].Value;
        }

        private void buttonRemoveMeetingEMP_Click(object sender, EventArgs e)
        {
            try
            {
                MEETINGEMPLOYEES MeetingE = new MEETINGEMPLOYEES();
                int MeetingEmployeeID = Convert.ToInt32(TextBoxIDMeetingEmployees.Text);

                if (MeetingE.deleteMeetingEmployee(MeetingEmployeeID))
                {
                    dataGridViewManageEmployees.DataSource = MeetingE.GetMeetingEmployees();
                    MessageBox.Show("Meeting Employee Deleted Successfuly", "Delete Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clears fields after deletion 
                    buttonClearMeetingEMP.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Meeting Employee Not Deleted ", "Delete Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Meeting Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void labelEmployeeID_Click(object sender, EventArgs e)
        {

        }
    }
}
