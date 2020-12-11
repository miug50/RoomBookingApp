using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace RoomBookingApp
{
    public class ROOM
    {
        readonly CONNECT conn = new CONNECT();

        public bool InsertRoom(String RoomName, int RoomCapacity)
        {
            try {
                //soft limit of 100 for the max posible room capacity. 
                if(RoomCapacity < 0 || RoomCapacity > 100)
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand();
                string insertQuery = "INSERT INTO `rooms`(`RoomName`, `RoomCapacity`) VALUES (@rrn,@rrc)";
                command.CommandText = insertQuery;
                command.Connection = conn.GetConnection();

                //@rrn,@rrc
                command.Parameters.Add("@rrn", MySqlDbType.VarChar).Value = RoomName;
                command.Parameters.Add("@rrc", MySqlDbType.Int32).Value = RoomCapacity;

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

        //function to get the rooms
        public DataTable GetRooms()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `Rooms`", conn.GetConnection());
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

        //function to Edit Rooms
        public bool EditRooms(int id, String RoomName, int RoomCapacity)
        {
            try 
            { 
                //soft limit of 100 for the max posible room capacity. 
                if (RoomCapacity < 0 || RoomCapacity > 100)
                {
                    return false;
                }

                MySqlCommand command = new MySqlCommand();
                string editQuery = "UPDATE `Rooms` SET `RoomName`= @rrn,`RoomCapacity`=@rrc WHERE `RoomID`= @rid";
                command.CommandText = editQuery;
                command.Connection = conn.GetConnection();

                //@rrn,@rrc,@rid
                command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@rrn", MySqlDbType.VarChar).Value = RoomName;
                command.Parameters.Add("@rrc", MySqlDbType.Int32).Value = RoomCapacity;

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

        //function to Delete Selected Employees
        public bool DeleteRooms(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                string removeQuery = "DELETE FROM `Rooms` WHERE `RoomID` = @rid";
                command.CommandText = removeQuery;
                command.Connection = conn.GetConnection();

                //@rid
                command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
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

        //function to returb the room capacity of a selected meeting
        public int RoomCap(int id)
        {
            try
            {
                if (id < 0 || id > 100)
                {
                    return 0;
                }
                MySqlCommand command = new MySqlCommand();
                string insertQuery = "SELECT RoomCapacity FROM rooms as r left join meetings as m on r.RoomID =  m.`Rooms.RoomID` where m.MeetingID = @mid";
                command.CommandText = insertQuery;
                command.Parameters.Add("@mid", MySqlDbType.Int32).Value = id;
                command.Connection = conn.GetConnection();
                conn.OpenConnection();
                var Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    int res = Convert.ToInt32(Reader[0]);
                    conn.CloseConnection();
                    return res;
                }
                conn.CloseConnection();
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        } 
    }
}
