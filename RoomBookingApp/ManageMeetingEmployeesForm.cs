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
        
        readonly MEETINGEMPLOYEES ME = new MEETINGEMPLOYEES();

        private void ManageMeetingEmployeesForm_Load(object sender, EventArgs e)
        {
            
            EMPLOYEE emp = new EMPLOYEE();
            MEETINGS meet = new MEETINGS();

            //loads the datagrid views with data
            dataGridViewManageEmployees.DataSource = ME.GetMeetingEmployees();
            dataGridViewMeetingEmployeeLst.DataSource = emp.GetEmployee();

            //loads the combo boxes with data
            comboBoxMeetings.DataSource = meet.GetMeetings();
            comboBoxMeetings.DisplayMember = "MeetingDesc";
            comboBoxMeetings.ValueMember = "MeetingID";
        }

        private void ButtonClearMeetingEMP_Click(object sender, EventArgs e)
        {
            TextBoxIDMeetingEmployees.Text = "";
            comboBoxMeetings.SelectedIndex = 0;            
        }

        private void ButtonNewMeetingEMP_Click(object sender, EventArgs e)
        {
            ROOM room = new ROOM();
            
            try
            {
                int MID = Convert.ToInt32(comboBoxMeetings.SelectedValue);
                int empID = 0;
                int cap = room.RoomCap(MID);
                int c = 0;

                //this loop checks throgh all the rows for any checked employees. this checked employees are added to the selected meeting one by one. 
                for (int i = 0; i < dataGridViewMeetingEmployeeLst.RowCount; i++)
                {
                    if (Convert.ToBoolean(dataGridViewMeetingEmployeeLst.Rows[i].Cells["chk"].Value) == true)
                    {
                        c++;
                        empID = Convert.ToInt32(dataGridViewMeetingEmployeeLst.Rows[i].Cells[1].Value);
                        if (c <= cap)
                        {
                            if (ME.InsertMeetingEmployee(empID, MID))
                            {
                                dataGridViewManageEmployees.DataSource = ME.GetMeetingEmployees();
                                MessageBox.Show("new Meeting Employees Inserted Successfuly", "Add Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Meeting Employee was Not Inserted", "Add Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else 
                        {
                            //if the room capacity for the meeting selected room is exeaded then the loop is broken and the user is alerted.
                            MessageBox.Show("Room Capacity was exceeded for selected meeting - Meeting Room Capacity = " + cap.ToString(), "Add Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Meeting Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewManageEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxIDMeetingEmployees.Text = dataGridViewManageEmployees.CurrentRow.Cells[0].Value.ToString();
            comboBoxMeetings.SelectedValue = (int)dataGridViewManageEmployees.CurrentRow.Cells[2].Value;
        }

        private void ButtonRemoveMeetingEMP_Click(object sender, EventArgs e)
        {
            try
            {
                int MeetingEmployeeID = Convert.ToInt32(TextBoxIDMeetingEmployees.Text);

                if (ME.DeleteMeetingEmployee(MeetingEmployeeID))
                {
                    dataGridViewManageEmployees.DataSource = ME.GetMeetingEmployees();
                    MessageBox.Show("Meeting Employee Deleted Successfuly", "Delete Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clears fields after deletion 
                    buttonClearMeetingEMP.PerformClick();
                }
                else
                {
                    MessageBox.Show("Meeting Employee Not Deleted ", "Delete Meeting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Meeting Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
