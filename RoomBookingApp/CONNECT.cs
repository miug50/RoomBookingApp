using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    class CONNECT
    {
        private readonly MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_RoomBooking_DB");


        public MySqlConnection GetConnection()
        {
            return Connection;
        }

        //create a function to open the connection
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

        }
        //create a function to close the connection
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

        }

    }
}
