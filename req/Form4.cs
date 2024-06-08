using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace req
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        readonly string cs = "server=localhost;userid=root;password=;database=req";
        MySqlConnection conn = null;
        MySqlDataReader read = null;
        MySqlCommand cmd = null;
        Form f2, f5, f4;
        int idno;

        public void refreshData()
        {
            conn.Open();
            stud_table.Rows.Clear();
            string query = "SELECT * FROM student WHERE status = 'Accepted'";
            cmd = new MySqlCommand(query, conn);
            read = cmd.ExecuteReader();

            while (read.Read())
            {

                stud_table.Rows.Add(read[0], read[1], read[2], read[3], read[9], read[4], read[5], read[6]);
            }
            stud_table.Refresh();
            //stud_table.CurrentCell.Selected = false;
           // stud_table.CurrentRow.Selected = false;
            conn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshData();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            f4?.Close();
            showForm5(false);
        }

        private void showForm5(bool edit)
        {
            if (!main_panel.Controls.Contains(f5))
            {
                f5 = new Form3(edit, idno);
                f5.TopLevel = false;
                main_panel.Controls.Add(f5);
                f5.BringToFront();
                f5.Dock = DockStyle.Fill;
                f5.Show();
            }
           
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons b = MessageBoxButtons.OK;
            if (stud_table.SelectedRows.Count <= 0 && stud_table.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Did not Select.", "Warning", b, MessageBoxIcon.Warning);
                return;
            }
            b = MessageBoxButtons.YesNo;
            if (MessageBox.Show($"You are about to remove student with ID No. {idno}", "Warning", b, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            string reject = $"UPDATE student SET status = 'Removed' WHERE student_id = {idno}";
            conn.Open();
            cmd = new MySqlCommand(reject, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshData();
            MessageBox.Show("Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /* string q = $"DELETE FROM scholars WHERE student_id = {idno}";
             conn.Open();
             cmd = new MySqlCommand(q, conn);
             cmd.ExecuteNonQuery();
             conn.Close();
             refreshData();
             MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }

        private void stud_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stud_table.CurrentRow != null)
            {
                var cellValue = stud_table.CurrentRow.Cells[0].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    idno = id;
                }
                else
                {
                    MessageBox.Show("INVALID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Did not Select.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons b = MessageBoxButtons.OK;
            if (stud_table.SelectedRows.Count <= 0 && stud_table.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Did not Select.", "Warning", b, MessageBoxIcon.Warning);
                return;
            }
            showForm5(true);
            
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stud_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

