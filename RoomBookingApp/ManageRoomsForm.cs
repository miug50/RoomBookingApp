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
    public partial class ManageRoomsForm : Form
    {
        readonly ROOM room = new ROOM();

        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        private void ButtonNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                String name = TextBoxNameRoom.Text;
                int number = Convert.ToInt32(TextBoxCapacityRoom.Text);

                if (room.InsertRoom(name, number))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room inserted successfuly", "Room inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room not inserted", "Room inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClearRoom_Click(object sender, EventArgs e)
        {
            TextBoxIDRoom.Text = "";
            TextBoxNameRoom.Text = "";
            TextBoxCapacityRoom.Text = "";
        }

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = room.GetRooms();
        }

        //loads the selected cell values in to the text boxes
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxIDRoom.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxNameRoom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxCapacityRoom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void ButtonEditRoom_Click(object sender, EventArgs e)
        {
            try { 
                int id = Convert.ToInt32(TextBoxIDRoom.Text);
                String name = TextBoxNameRoom.Text;
                int count = Convert.ToInt32(TextBoxCapacityRoom.Text);

                if(room.EditRooms(id, name, count))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room updated successfuly", "Room update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room not updated", "Room update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemoveRoom_Click(object sender, EventArgs e)
        {
            try { 
                int id = Convert.ToInt32(TextBoxIDRoom.Text);

                if (room.DeleteRooms(id))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("Room Deleted successfuly", "Room Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room not Deleted", "Room Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
