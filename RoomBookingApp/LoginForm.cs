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
            SQLstatusCheck();
        }

        readonly CONNECT conn = new CONNECT();

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            //this if statment shows if their is a valid sql connection. This is displayed via a checkbox(CheckBoxLoginForm)
            SQLstatusCheck();

            //this query attempts to get the username and passwrod from the user inputs
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username` =@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            //binds the user inputs to parameters
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            //trys to conect to the database. if the database is not active. Catch and display error message. 
            try {
                adapter.Fill(table);

                //if a row is found then show the managment form else display the appropriate error. 
                if (table.Rows.Count > 0)
                {
                    // show the main from
                    this.Hide();
                    ManageForm mForm = new ManageForm();
                    mForm.Show();
                }
                else
                {
                    //if the user and the password exists 
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
                        MessageBox.Show("This username or password Dosen't Exisit", "wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxPassword.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Text = "";
                TextBoxPassword.Text = "";
            }
        }
        private bool IsServerConnected()
        {
            try
            {
                conn.OpenConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            // show the main from for guests. No login required
            this.Hide();
            Main_Form mForm = new Main_Form();
            mForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckBoxLoginForm_Click(object sender, EventArgs e)
        {
            //similar to before this code checks the status of the mysql connection when the login button is selected. 
            SQLstatusCheck();
        }

        public void SQLstatusCheck()
        {
            //this code is used more that once. 
            if (IsServerConnected() == true)
            {
                checkBoxLoginForm.CheckState = CheckState.Checked;
                checkBoxLoginForm.ForeColor = Color.FromArgb(0, 128, 0);
            }
            else
            {
                checkBoxLoginForm.CheckState = CheckState.Unchecked;
                checkBoxLoginForm.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }
    }
}
