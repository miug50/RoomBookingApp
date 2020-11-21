using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingApp
{
    public partial class ManageEmployeesForm : Form
    {
        EMPLOYEE Employee = new EMPLOYEE();

        public ManageEmployeesForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClearEmp_Click(object sender, EventArgs e)
        {
            textBoxIDEmp.Text = "";
            textBoxFnameEmp.Text = "";
            textBoxLnameEmp.Text = "";
            textBoxEmailEmp.Text = "";
        }

        private void buttonNewEmployee_Click(object sender, EventArgs e)
        {

            String Fname = textBoxFnameEmp.Text;
            String Lname = textBoxLnameEmp.Text;
            String Email = textBoxEmailEmp.Text;

            if(Fname.Trim().Equals("") || Lname.Trim().Equals("") || Email.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - First & Last Name + Email", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = Employee.insertEmployee(Fname, Lname, Email);

                if (insertClient)
                {
                    dataGridView1.DataSource = Employee.GetEmployee();
                    MessageBox.Show("new Employee Inserted Successfuly", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("ERROR - new Employee Not Inserted ", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Employee.GetEmployee();
        }


        private void buttonEditEmp_Click(object sender, EventArgs e)
        {
            int id;
            String Fname = textBoxFnameEmp.Text;
            String Lname = textBoxLnameEmp.Text;
            String Email = textBoxEmailEmp.Text;

            try
            {
                id = Convert.ToInt32(textBoxIDEmp.Text);

                if (Fname.Trim().Equals("") || Lname.Trim().Equals("") || Email.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields - First & Last Name + Email. Try and select an Employee first", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean EditClient = Employee.EditEmployee(id, Fname, Lname, Email);

                    if (EditClient)
                    {
                        dataGridView1.DataSource = Employee.GetEmployee();
                        MessageBox.Show("Employee Updated Successfuly", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ERROR - Employee Not Updated ", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        //display the selected Employee data from the datagridview to the textboxes. 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDEmp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFnameEmp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLnameEmp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxEmailEmp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonRemoveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIDEmp.Text);

                if (Employee.DeleteEmployee(id))
                {
                    dataGridView1.DataSource = Employee.GetEmployee();
                    MessageBox.Show("Employee Deleted Successfuly", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clears fields after deletion 
                    buttonClearEmp.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Employeeent Not Updated ", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxEmailEmp_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
