using MySql.Data.MySqlClient;
using System;
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
    public partial class Form5 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public bool edit = false;
        int idno;
        Form f1, f2, f3, f4,f5;
        public Form5(bool edit, int idno)
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
            
            if (edit)
            {
                cmd = new MySqlCommand($"SELECT * FROM student WHERE student_id = {idno}", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                studIDtextbox.Text = reader.GetString(0);
                name_txt.Text = reader.GetString(1);
                mobile_txt.Text = reader.GetString(4);
                bday_date.Value = reader.GetDateTime(5);
                address_txt.Text = reader.GetString(6);
                type_combo.SelectedIndex = -1;
                gwa_txtbox.Text = reader.GetString(9);
                reader.Close();
            }
          
        }

        private void reset()
        {
            studIDtextbox.Clear();
            name_txt.Clear();
            mobile_txt.Clear();
            address_txt.Clear();
            bday_date.ResetText();
            male_radio.Checked = false;
            type_combo.SelectedIndex = -1;
            gwa_txtbox.Clear();
            type_combo.SelectedIndex = -1;

        }
        public void refreshData()
        {
            conn.Open();


        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons b = MessageBoxButtons.OK;
            string incomeString = income_txtbox.Text;
            // Check if required fields are not empty
            if (string.IsNullOrEmpty(studIDtextbox.Text) || string.IsNullOrEmpty(name_txt.Text) || string.IsNullOrEmpty(mobile_txt.Text) || string.IsNullOrEmpty(address_txt.Text)
                || string.IsNullOrEmpty(bday_date.Text) || string.IsNullOrEmpty(type_combo.Text) || string.IsNullOrEmpty(gwa_txtbox.Text) || string.IsNullOrEmpty(incomeString))
            {
                MessageBox.Show("Must Complete the Form!", "Warning", b, MessageBoxIcon.Warning);
                return;
            }

            string income = income_txtbox.Text;
            if (int.Parse(income) > 10000)
            {

                MessageBox.Show("Sorry! Student not Qualified", "Warning", b, MessageBoxIcon.Warning);
                return;
            }

            string course = type_combo.SelectedItem.ToString();
            string money = income_txtbox.Text;
            string studID = studIDtextbox.Text;
            string studName = name_txt.Text;
            string mobile = mobile_txt.Text;
            string address = address_txt.Text;
            string bday = Convert.ToDateTime(bday_date.Text).ToString("yyyy-MM-dd");
            string gwa = gwa_txtbox.Text;
            string type = type_combo.SelectedText;
            string gender = male_radio.Checked ? "Male" : "Female";

            // Check if cmd is not initialized
            if (cmd == null)
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
            }

            string insert = $"UPDATE INTO scholars (student_id,studentName, sex, income, course_code, gwa, mobile_number, date_birth, address)" +
                             $" VALUES ('{studID}','{studName}', '{gender}', '{money}', '{course}', '{gwa}','{mobile}', '{bday}', '{address}')";

            string update = $"Update INTO scholars (student_id,studentName, sex, income,  course_code, gwa,  mobile_number, date_birth, address)" +
                             $" VALUES ('{studID}','{studName}', '{gender}', '{money}', '{course}', '{gwa}','{mobile}', '{bday}', '{address}')";

            string q = edit ? update : insert;

            try
            {
                conn.Open();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                conn.Close();

                string message = edit ? "Added Successfully!" : "Successfully Added!";
                MessageBox.Show(message, "Success", b, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"Error: {ex.Message}", "Error", b, MessageBoxIcon.Error);
                conn.Close();
            }


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            reset();
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

            if (main_panel.Controls.Contains(f4) || main_panel.Controls.Contains(f5))
            {
                main_panel.Controls.Remove(f5);
                main_panel.Controls.Remove(f4);
                f4?.Close();
                f5?.Close();
                f4 = null;
                f5 = null;
            }

        }

        private void surname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Already in Enrollment Form", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (!main_panel.Controls.Contains(f4))
            {
                f4 = new Form4();
                f5?.Close();
                f4.TopLevel = false;
                main_panel.Controls.Add(f4);
                f4.BringToFront();
                f4.Dock = DockStyle.Fill;
                f4.Show();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void course_combo_SelectedIndexChanged_1(object sender, EventArgs e)
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
