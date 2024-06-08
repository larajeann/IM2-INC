using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace req
{
    public partial class Form7 : Form
    {
        readonly string cs = "server=localhost;userid=root;password=;database=req";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public bool edit = false;
        int idno;
        Form f1, f2, f3, f4, f6, f7;
        public Form7(bool edit, int idno)
        {
            InitializeComponent();
            this.edit = edit;
            this.idno = idno;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = "server=localhost;userid=root;password=;database=req";
                conn = new MySqlConnection(cs);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBoxButtons b = MessageBoxButtons.OK;
                MessageBox.Show($"Connection error: {ex}", "Error", b, MessageBoxIcon.Error);
            }
            LoadData();
            conn.Close();
        }


        private void LoadData()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
            string query = "SELECT * FROM student WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Form1.uname);

            reader = cmd.ExecuteReader();
            reader.Read();


            studIDtextbox.Text = reader.GetString(0);
            name_txt.Text = reader.GetString(1);
            update.Text = reader.GetString(11);

          
           
        }


       
        private void edit_btn_Click(object sender, EventArgs e)
        {
           
            string studID = studIDtextbox.Text;
            string studName = name_txt.Text;
          
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            if (main_panel.Controls.Contains(f6) || main_panel.Controls.Contains(f7))
            {
                main_panel.Controls.Remove(f7);
                main_panel.Controls.Remove(f6);
                f6?.Close();
                f6?.Close();
                f6 = null;
                f7 = null;
            }

        }

        private void surname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (!main_panel.Controls.Contains(f6))
            {
                f6 = new Form4();
                f7?.Close();
                f6.TopLevel = false;
                main_panel.Controls.Add(f6);
                f6.BringToFront();
                f6.Dock = DockStyle.Fill;
                f6.Show();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void course_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gwa_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void male_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void course_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
