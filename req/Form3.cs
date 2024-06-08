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
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public bool edit = false;
        int idno;
        Form f1, f2, f3, f4;
        public Form3(bool edit, int idno)
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
                bday_date.Text = reader.GetString(5);
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
            if (string.IsNullOrEmpty(studIDtextbox.Text)|| string.IsNullOrEmpty(name_txt.Text) || string.IsNullOrEmpty(mobile_txt.Text) || string.IsNullOrEmpty(address_txt.Text) 
                || string.IsNullOrEmpty(bday_date.Text) || string.IsNullOrEmpty(type_combo.Text)|| string.IsNullOrEmpty(incomeString) || string.IsNullOrEmpty(gwa_txtbox.Text))
            {
                MessageBox.Show("Must Complete the Form!", "Warning", b, MessageBoxIcon.Warning);
                return;
            }

            string income = income_txtbox.Text;


            if (int.Parse(income) > 10000 || int.Parse(income) < 1000)
            {
                
                MessageBox.Show("Sorry! You are not Qualified", "Income Exceeded", b, MessageBoxIcon.Warning);
                return;
            }

            string grade = gwa_txtbox.Text;
            if (double.Parse(grade) > 2.4)
            {

                MessageBox.Show("Sorry! You are not Qualified", "GWA Not Met!", b, MessageBoxIcon.Warning);
                return;
            }

            cmd = new MySqlCommand($"SELECT * FROM student WHERE student_id = {idno}", conn);
            if (studIDtextbox.Text != studIDtextbox.Text)
            {
                MessageBox.Show("Oppps! You are not Not Enrolled", "Warning", b, MessageBoxIcon.Warning);
                return;
            }

             cmd = new MySqlCommand($"SELECT COUNT(*) FROM scholars WHERE student_id = {idno}", conn);

            

            int count = 0;

            try
            {
                conn.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log, display an error message)
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            if (count > 0)
            {
                // Student ID exists, show an error message or handle accordingly
                MessageBox.Show("Student ID already Added.");
                return;
            }
            
            string course = type_combo.SelectedItem.ToString();
            string studID = studIDtextbox.Text;
            string studName = name_txt.Text;
            string mobile = mobile_txt.Text;
            string address = address_txt.Text;
            string bday = Convert.ToDateTime(bday_date.Text).ToString("yyyy-MM-dd");
            //string course = courseTextbox.Text;
            string gwa = gwa_txtbox.Text;
            string type = type_combo.SelectedText;
            string gender = male_radio.Checked ? "Male" : "Female";
            string money = income_txtbox.Text;

            // Check if cmd is not initialized
            if (cmd == null)
            {
                cmd = new MySqlCommand();
                cmd.Connection = conn;
            }

            string update = $"UPDATE student SET status = 'Accepted' WHERE student_id = {idno}";
            conn.Open();
            cmd = new MySqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshData();
            MessageBox.Show("Accepted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

          


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

            if (main_panel.Controls.Contains(f4) || main_panel.Controls.Contains(f3))
            {
                main_panel.Controls.Remove(f3);
                main_panel.Controls.Remove(f4);
                f4?.Close();
                f3?.Close();
                f4 = null;
                f3 = null;
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
                f3?.Close();
                f4.TopLevel = false;
                main_panel.Controls.Add(f4);
                f4.BringToFront();
                f4.Dock = DockStyle.Fill;
                f4.Show();
            }
        }

        private void course_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gwa_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }

        private void del_btn_Click_1(object sender, EventArgs e)
        {
            string income = income_txtbox.Text;
            if (int.Parse(income) < 10000 || int.Parse(income) > 0)
            {

                MessageBox.Show("NO! Student is Qualified", "Income Accepted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string grade = gwa_txtbox.Text;
            if (double.Parse(grade) < 2.5)
            {

                MessageBox.Show("NO! Student is Qualified", "GWA Met!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reject = $"UPDATE student SET status = 'Rejected' WHERE student_id = {idno}";
            conn.Open();
            cmd = new MySqlCommand(reject, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            refreshData();
            MessageBox.Show("Rejected Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
