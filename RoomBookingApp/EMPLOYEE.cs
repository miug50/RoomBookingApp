using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomBookingApp
{
    class EMPLOYEE
    {
        readonly CONNECT conn = new CONNECT();

        public bool InsertEmployee(String Fname, String Lname, String Email)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `employees`(`EmployeeFname`, `EmployeeLname`, `EmployeeEmail`) VALUES (@fnm,@lnm,@eml)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            //@fnm,@lnm,@eml
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = Fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = Lname;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = Email;

            conn.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                return true;


            }
            else
            {
                conn.CloseConnection();
                return false;
            }

        }

        public DataTable GetEmployee()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employees`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table); 


            return table;
        }

        //function to Edit Employees
        public bool EditEmployee(int id, String Fname, String Lname, String Email)
        {
            MySqlCommand command = new MySqlCommand();
            string editQuery = "UPDATE `employees` SET `EmployeeFname`= @fnm,`EmployeeLname`=@lnm,`EmployeeEmail`=@eml WHERE `EmployeeID`= @eid";
            command.CommandText = editQuery;
            command.Connection = conn.GetConnection();

            //@eid,@fnm,@lnm,@eml
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = Fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = Lname;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = Email;

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

        //create a Function to delete Employees
        public bool DeleteEmployee(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `employees` WHERE `EmployeeID` = @eid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            //@eid
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = id;
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
