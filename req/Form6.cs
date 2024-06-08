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
using Mysqlx.Crud;

namespace req
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        readonly string cs = "server=localhost;userid=root;password=;database=req";
        MySqlConnection conn;
        MySqlDataReader reader = null;
        MySqlCommand cmd = null;
        Form f2, f3, f4, f5, f6, f7;
        int idno;
        

        
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
               // conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Connection error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           LoadData();
        //conn.Close();
        }
        private void LoadData()
        {
            //conn = new MySqlConnection(cs);
            //conn.Open();
            string query = "SELECT * FROM student WHERE username = '"+Form1.uname+"'";
            cmd = new MySqlCommand(query, conn);
            

            reader = cmd.ExecuteReader();
            reader.Read();
                
            if (reader.GetString(0
                ) != "")
            {
                studIDtextbox.Text = reader.GetString(0);
                name_txt.Text = reader.GetString(1);
                mobile_txt.Text = reader.GetString(4);
                bday_date.Value = reader.GetDateTime(5);
                address_txt.Text = reader.GetString(6);
                type_combo.SelectedItem = reader.GetString(3);
                gwa_txtbox.Text = reader.GetString(9);
                income_txtbox.Text = reader.GetInt32(10).ToString();

                if (reader.GetString(2) == "Male")
                {
                    male_radio.Checked = true;
                };
                if (reader.GetString(2) == "Female")
                {
                    female_radio.Checked = true;
                };
            }
                
                reader.Close();
        
        }

            private void iconButton1_Click(object sender, EventArgs e)
        {
            label3.Text = "HOME";
            if ( main_panel.Controls.Contains(f7))
            {
                main_panel.Controls.Remove(f7);
                f7?.Close();
              
            }
            //conn = new MySqlConnection(cs);
            //conn.Open();
            //cmd = new MySqlCommand($"SELECT * FROM student WHERE student_id = {idno}", conn);
            //reader = cmd.ExecuteReader();

           

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
            conn = new MySqlConnection(cs);
            conn.Open();
            string query = "SELECT * FROM student WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Form1.uname);

            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.GetString(0) != "")
            {
                f6?.Close();
                showForm7(false);
               
            }
            else
            {
                MessageBoxButtons b = MessageBoxButtons.OK;
                MessageBox.Show("Not Yet Applied!", "Empty Form!", b, MessageBoxIcon.Warning);
            }



        }

            private void showForm7(bool edit)
        {

            if (!main_panel.Controls.Contains(f7))
            {
                f7 = new Form7(edit, idno);
                f7.TopLevel = false;
                main_panel.Controls.Add(f7);
                f7.BringToFront();
                f7.Dock = DockStyle.Fill;
                f7.Show();
            }
            label3.Text = edit ? "EDIT" : "SCHOLARSHIP";
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
          

        }

        private void stud_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           
            showForm7(true);
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stud_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            studIDtextbox.Clear();
            name_txt.Clear();
             mobile_txt.Clear();
            address_txt.Clear();
            Convert.ToDateTime(bday_date.Text).ToString("yyyy-MM-dd");
             gwa_txtbox.Clear();
            type_combo = null;
            male_radio.Checked = false;
            income_txtbox.Clear();
        }

        private void iconButton1_BackColorChanged(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Teal;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            
            //msg na applied
            MessageBoxButtons b = MessageBoxButtons.OK;
            string incomeString = income_txtbox.Text;
            // Check if required fields are not empty
            if (string.IsNullOrEmpty(studIDtextbox.Text) || string.IsNullOrEmpty(name_txt.Text) || string.IsNullOrEmpty(mobile_txt.Text) || string.IsNullOrEmpty(address_txt.Text)
                || string.IsNullOrEmpty(bday_date.Text) || string.IsNullOrEmpty(type_combo.Text) || string.IsNullOrEmpty(incomeString) || string.IsNullOrEmpty(gwa_txtbox.Text)|| type_combo==null)
            {
                MessageBox.Show("Must Complete the Form!", "Warning", b, MessageBoxIcon.Warning);
                return;
            }

            string course = type_combo.SelectedItem.ToString();
            string studID = studIDtextbox.Text;
            string studName = name_txt.Text;
            string mobile = mobile_txt.Text;
            string address = address_txt.Text;
            string bday = Convert.ToDateTime(bday_date.Text).ToString("yyyy-MM-dd");
            string gwa = gwa_txtbox.Text;
            string type = type_combo.SelectedText;
            string gender = male_radio.Checked ? "Male" : "Female";
            string money = income_txtbox.Text;

         
            
            reader.Close();
            cmd = new MySqlCommand($"SELECT * FROM student WHERE student_id = '{studID}'", conn);
            reader = cmd.ExecuteReader();
            
          

            if (reader.HasRows == false)
            {

                string update = "UPDATE  student  SET student_id = '" + studID + "', studentName = '" + studName + "', sex = '" + gender + "', income = '" + money + "',  course_code = '" + course + "', gwa = '" + gwa + "', mobile_number = '" + mobile + "',  date_birth = '" + bday + "', address = '" + address + "' WHERE username = '" + Form1.uname + "'";
                try
                {
                    reader.Close();
                    //conn.Open();
                    cmd.CommandText = update;
                    cmd.ExecuteNonQuery();
                    //conn.Close();

                    string message = "Successfully Applied!";
                    MessageBox.Show(message, "Success", b, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Error: {ex.Message}", "Error", b, MessageBoxIcon.Error);
                    //conn.Close();
                }
            }
            else
            {
                string message = "Stud_ID already addded";
                MessageBox.Show(message, "Failed", b, MessageBoxIcon.Information);
            }
          
            
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
            
        }
    }
}

