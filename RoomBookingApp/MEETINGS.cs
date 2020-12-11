using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    public class MEETINGS
    {
        readonly CONNECT conn = new CONNECT();

        //Function to get Meetings
        public DataTable GetMeetings()
        {
            try
            {
                //when getting the Meeting data the SQL statment only selects values from today
                MySqlCommand command = new MySqlCommand("SELECT MeetingID, cast(`MeetingStart` as Time) as 'meeting start', cast(`MeetingEnd` as Time) as 'meeting End', MeetingDesc FROM `meetings` where meetingstart > DATE_ADD(NOW(), INTERVAL -1 day)", conn.GetConnection());
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

        //function to get all Rooms
        public DataTable RoomTypeList()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.GetConnection());
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

        //function to insert a new Meeting
        public bool InsertMeeting(int roomid, DateTime start, DateTime finish, string desc)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        //function to Edit Meetings
        public bool EditMeeting(int MeetingID, int roomid, DateTime start, DateTime finish, string desc)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        //create a Function to delete Meetings
        public bool DeleteMeeting(int id)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetMeetingsFromID(int id)
        {
            try
            {
                if (id < 0)
                {
                    return null;
                }
                //this SQL has a few left joins to bring data from the three relevent tables in this case where the meeting id equals the passed value. Meetings,MeetingEmployees ,Employees. This data for today only.
                MySqlCommand command = new MySqlCommand();
                String getQuery = "SELECT MeetingID, `Rooms.RoomID`, `MeetingStart`, `MeetingEnd`, `MeetingDesc` FROM meetings as m left join meetingemployees as me on m.MeetingID = me.`meetings.MeetingID` left join employees as e on me.`employees.EmployeeID` = e.EmployeeID where e.EmployeeID = @eid and `MeetingStart` > DATE_ADD(NOW(), INTERVAL -1 day) ";
                command.CommandText = getQuery;
                command.Connection = conn.GetConnection();

                //@eid
                command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;

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

        public void GetCSVdata()
        {
            try
            {
                //similar to the sql statment above this query brings togither values required for the log. This data is relevent to the last six months only.
                conn.OpenConnection();
                String getQuery = "SELECT m.`MeetingID`,m.`MeetingStart`,m.`MeetingDesc`,r.`RoomName`, count(me.`employees.EmployeeID`)  FROM `meetings` as m left join rooms as r on m.`Rooms.RoomID` = r.RoomID left join meetingemployees as me on m.MeetingID = me.`meetings.MeetingID` where `MeetingStart` > DATE_ADD(NOW(), INTERVAL -6 month) group by `MeetingID`";

                using (var cmd = new MySqlCommand(getQuery, conn.GetConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            //this first section writes a new CSV file called Meetingreport as the boolean is set to false. This will overide the preveous copy with the coloum names as seen below
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Meetingreport.csv", false))
                            {
                                file.WriteLine("id" + "," + "Meeeing Start" + "," + "Description" + "," + "Room Name" + "," + "Meeting Count");
                            }
                            //Whilst the reader is reading through all the values the lines are added to the CSV file as the boolean is set to true. this alows the file to be writen to this way while removing any data older that Six months
                            while (reader.Read())
                            {
                                var ID = reader.GetString(0);
                                var Start = reader.GetString(1);
                                var desc = reader.GetString(2);
                                var Rname = reader.GetString(3);
                                var count = reader.GetString(4);

                                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Meetingreport.csv", true))
                                {
                                    file.WriteLine(ID + "," + Start + "," + desc + "," + Rname + "," + count);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ApplicationException("Something went Wrong: ", ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("check SQL connection...", ex);
            }
        }
    }
}
