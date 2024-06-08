using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using req;

namespace req
{



    public partial class Form1 : Form
    {

        readonly string cs = @"server=localhost;userid=root;password=;database=req";
        MySqlConnection conn = null;
        MySqlDataReader read = null;
        MySqlCommand cmd = null;
        public static string uname;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            string query = "SELECT * FROM user";
            cmd = new MySqlCommand(query, conn);
            read = cmd.ExecuteReader();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            req regForm = new req();
            regForm.Show();
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            try
            {
                conn.Open();

                string query = "SELECT * FROM user WHERE username=@username AND password=@password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    string role = read["role"].ToString();

                    if (role == "Admin")
                    {
                        MessageBox.Show("You logged in as an Admin.", "Login Successful");
                        this.Hide();
                        Form2 secondForm = new Form2();
                        secondForm.Show();
                    }
                    else if (role == "Student")
                    {
                        MessageBox.Show("You logged in as a Student.", "Login Successful");
                        uname = usernameTextbox.Text;
                        this.Hide();
                        Form6 sixthForm = new Form6();
                        sixthForm.Show();

                       
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed");
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxButtons b = MessageBoxButtons.OK;
                MessageBox.Show($"Error: {ex}", "Error", b, MessageBoxIcon.Error);
            }
            finally
            {
                if (read != null) read.Close();
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
