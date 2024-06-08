using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using req;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace req
{
    public partial class req : Form
    {

        readonly string cs = @"server=localhost;userid=root;password=;database=req";
        MySqlConnection conn = null;
        MySqlDataReader read = null;
        MySqlCommand cmd = null;
       


        public req()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

            }
            catch (MySqlException ex)
            {
                MessageBoxButtons b = MessageBoxButtons.OK;
                MessageBox.Show($"Connection error: {ex}", "Error", b, MessageBoxIcon.Error);
            }
            //LoadData();
            conn.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            string role = comboBox1.Text;
          

            if ( usernameTextbox.Text == string.Empty
                    || passwordTextbox.Text == string.Empty || comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Please input all the required input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
           
            string checkUsernameQuery = $"SELECT COUNT(*) FROM user WHERE username = '{username}'";
            int existingUsernameCount;
           
            using (MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, conn))
            {
                conn.Open();
                existingUsernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());
            }

            if (existingUsernameCount > 0)
            {
                MessageBox.Show("Username already exists. Please use a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.Close();
            string qStudent = $"INSERT INTO student (username) " +
                                          $"VALUES ('{username}')";
           
            string qUser = $"INSERT INTO user (username, password, role) " +
                           $"VALUES ('{username}', '{password}', '{role}')";
            conn.Open();
            // Insert into user table
            MySqlCommand commandUser = new MySqlCommand(qUser, conn);
            commandUser.ExecuteNonQuery();
            MySqlCommand commandStudent = new MySqlCommand(qStudent, conn);
              commandStudent.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("The record has been added", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
         
            usernameTextbox.Clear();
            passwordTextbox.Clear();
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 firstForm = new Form1();
            firstForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}