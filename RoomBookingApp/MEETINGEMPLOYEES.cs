using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    public class MEETINGEMPLOYEES
    {
        readonly CONNECT conn = new CONNECT();

        public bool InsertMeetingEmployee( int Employee,int Meeting)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                string insertQuery = "INSERT INTO `MeetingEmployees`(`employees.EmployeeID`, `meetings.MeetingID`) VALUES (@mei,@mmi)";
                command.CommandText = insertQuery;
                command.Connection = conn.GetConnection();

                //@mei,@mmi
                command.Parameters.Add("@mmi", MySqlDbType.Int32).Value = Meeting;
                command.Parameters.Add("@mei", MySqlDbType.Int32).Value = Employee;

                conn.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    conn.CloseConnection();
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        public DataTable GetMeetingEmployees()
        {
            try
            {
                //when getting the meeting employee data the SQL statment only selects values from today
                MySqlCommand command = new MySqlCommand("SELECT a.* FROM `MeetingEmployees` as a, Meetings as b where a.`meetings.MeetingID` =b.MeetingID and b.meetingstart > DATE_ADD(NOW(), INTERVAL -1 day)", conn.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteMeetingEmployee(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                string removeQuery = "DELETE FROM `MeetingEmployees` WHERE `MeetingEmployeeID` = @meid";
                command.CommandText = removeQuery;
                command.Connection = conn.GetConnection();

                //@meid
                command.Parameters.Add("@meid", MySqlDbType.Int32).Value = id;
                conn.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    conn.CloseConnection();
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
