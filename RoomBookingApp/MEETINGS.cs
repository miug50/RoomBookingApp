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
            MySqlCommand command = new MySqlCommand("SELECT * FROM `meetings`", conn.GetConnection());
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
        public bool InsertMeeting(int roomid, DateTime start, String finish, string desc)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `Meetings`(`Rooms.RoomID`, `MeetingStart`, `MeetingEnd`, `MeetingDesc`) VALUES ([@mri],[@mms],[@mme],[@mmd])";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@mri, @mms, @mme, @mmd
            command.Parameters.Add("@mri", MySqlDbType.Int32).Value = roomid;
            command.Parameters.Add("@mms", MySqlDbType.DateTime).Value = start;
            command.Parameters.Add("@mme", MySqlDbType.String).Value = finish;
            command.Parameters.Add("@mmd", MySqlDbType.String).Value = desc;

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
  
    }

}
