using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    class MEETINGEMPLOYEES
    {
        readonly CONNECT conn = new CONNECT();

        public bool InsertMeetingEmployee( int Employee,int Meeting)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `MeetingEmployees`(`employees.EmployeeID`, `meetings.MeetingID`) VALUES (@mei,@mmi)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@mei,@mmi
            command.Parameters.Add("@mmi", MySqlDbType.VarChar).Value = Meeting;
            command.Parameters.Add("@mei", MySqlDbType.VarChar).Value = Employee;

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

        public DataTable GetMeetingEmployees()
        {
            MySqlCommand command = new MySqlCommand("SELECT a.* FROM `MeetingEmployees` as a, Meetings as b where a.`meetings.MeetingID` =b.MeetingID and b.meetingstart > DATE_ADD(NOW(), INTERVAL -1 day)", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        public bool deleteMeetingEmployee(int id)
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

    }
}
