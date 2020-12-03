using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    class MEETINGS
    {
        readonly CONNECT conn = new CONNECT();

        //Function to get Meetings
        public DataTable GetMeetings()
        {
            MySqlCommand command = new MySqlCommand("SELECT MeetingID, cast(`MeetingStart` as Time) as 'meeting start', cast(`MeetingEnd` as Time) as 'meeting start', MeetingDesc FROM `meetings` where meetingstart > DATE_ADD(NOW(), INTERVAL -1 day)", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        //function to get Rooms
        public DataTable RoomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        //function to insert a new Meeting
        public bool InsertMeeting(int roomid, DateTime start, DateTime finish, string desc)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `Meetings`(`Rooms.RoomID`, `MeetingStart`, `MeetingEnd`, `MeetingDesc`) VALUES (@mri,@mms,@mme,@mmd)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@mri, @mms, @mme, @mmd
            command.Parameters.Add("@mri", MySqlDbType.Int32).Value = roomid;
            command.Parameters.Add("@mms", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@mme", MySqlDbType.DateTime).Value = finish;
            command.Parameters.Add("@mmd", MySqlDbType.VarChar).Value = desc;

            conn.OpenConnection();

            //problems here. its to do with how the dates are stored. look imn to it.

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

        //function to Edit Meetings
        public bool EditMeeting(int MeetingID, int roomid, DateTime start, DateTime finish, string desc)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `Meetings` SET `Rooms.RoomID`= @mri,`MeetingStart`=@mms,`MeetingEnd`=@mme,`MeetingDesc`= @mmd WHERE `MeetingID`= @mid";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //@mid, @mri, @mms, @mme, @mmd
            command.Parameters.Add("@mid", MySqlDbType.Int32).Value = MeetingID;
            command.Parameters.Add("@mri", MySqlDbType.Int32).Value = roomid;
            command.Parameters.Add("@mms", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@mme", MySqlDbType.DateTime).Value = finish;
            command.Parameters.Add("@mmd", MySqlDbType.VarChar).Value = desc;

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

        //create a Function to delete Meetings
        public bool DeleteMeeting(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `Meetings` WHERE `MeetingID` = @mid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            //@mid
            command.Parameters.Add("@mid", MySqlDbType.Int32).Value = id;
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
        public DataTable GetMeetingsFromID(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String getQuery = "SELECT MeetingID, `Rooms.RoomID`, `MeetingStart`, `MeetingEnd`, `MeetingDesc` FROM meetings as m left join meetingemployees as me on m.MeetingID = me.`meetings.MeetingID` left join employees as e on me.`employees.EmployeeID` = e.EmployeeID where e.EmployeeID = @eid ";
            command.CommandText = getQuery;
            command.Connection = conn.GetConnection();

            //@eid
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //SQL Used
            //SELECT MeetingID, `Rooms.RoomID`, `MeetingStart`, `MeetingEnd`, `MeetingDesc` FROM meetings as m
            //left join meetingemployees as me
            //    on m.MeetingID = me.`meetings.MeetingID`
            // left join employees as e
            //    on me.`employees.EmployeeID` = e.EmployeeID
            //where e.EmployeeID = 1;
           
                adapter.SelectCommand = command;
                adapter.Fill(table);
            
                return table;   

        }

    }

}
