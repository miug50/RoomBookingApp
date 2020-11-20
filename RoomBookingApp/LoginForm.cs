using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RoomBookingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username` =@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //if the user and the password exists 
            if (table.Rows.Count > 0)
            {
                // show the main from
                this.Hide();
                Main_Form mForm = new Main_Form();
                mForm.Show();
            }
            else
            {
                if (TextBoxUsername.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TextBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("this username or password Dosen't Exisit", "wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
