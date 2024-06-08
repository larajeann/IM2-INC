namespace req
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.male_radio = new System.Windows.Forms.RadioButton();
            this.female_radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.mobile_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bday_date = new System.Windows.Forms.DateTimePicker();
            this.main_panel = new System.Windows.Forms.Panel();
            this.del_btn = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.gwa_txtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.income_txtbox = new System.Windows.Forms.TextBox();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studIDtextbox = new System.Windows.Forms.TextBox();
            this.edit_btn = new FontAwesome.Sharp.IconButton();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(420, 109);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(300, 27);
            this.name_txt.TabIndex = 0;
            this.name_txt.TextChanged += new System.EventHandler(this.surname_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // male_radio
            // 
            this.male_radio.AutoSize = true;
            this.male_radio.Checked = true;
            this.male_radio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radio.Location = new System.Drawing.Point(436, 254);
            this.male_radio.Name = "male_radio";
            this.male_radio.Size = new System.Drawing.Size(67, 25);
            this.male_radio.TabIndex = 2;
            this.male_radio.TabStop = true;
            this.male_radio.Text = "Male";
            this.male_radio.UseVisualStyleBackColor = true;
            this.male_radio.CheckedChanged += new System.EventHandler(this.male_radio_CheckedChanged);
            // 
            // female_radio
            // 
            this.female_radio.AutoSize = true;
            this.female_radio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radio.Location = new System.Drawing.Point(518, 256);
            this.female_radio.Name = "female_radio";
            this.female_radio.Size = new System.Drawing.Size(85, 25);
            this.female_radio.TabIndex = 2;
            this.female_radio.TabStop = true;
            this.female_radio.Text = "Female";
            this.female_radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sex:";
            // 
            // mobile_txt
            // 
            this.mobile_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_txt.Location = new System.Drawing.Point(19, 177);
            this.mobile_txt.MaxLength = 11;
            this.mobile_txt.Name = "mobile_txt";
            this.mobile_txt.ReadOnly = true;
            this.mobile_txt.Size = new System.Drawing.Size(325, 27);
            this.mobile_txt.TabIndex = 0;
            this.mobile_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Contact number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // address_txt
            // 
            this.address_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txt.Location = new System.Drawing.Point(19, 252);
            this.address_txt.Name = "address_txt";
            this.address_txt.ReadOnly = true;
            this.address_txt.Size = new System.Drawing.Size(325, 27);
            this.address_txt.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birth date:";
            // 
            // bday_date
            // 
            this.bday_date.CustomFormat = "MMMM- dd - yyyy";
            this.bday_date.Enabled = false;
            this.bday_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bday_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bday_date.Location = new System.Drawing.Point(420, 178);
            this.bday_date.Name = "bday_date";
            this.bday_date.Size = new System.Drawing.Size(300, 26);
            this.bday_date.TabIndex = 3;
            this.bday_date.Value = new System.DateTime(2024, 1, 27, 0, 0, 0, 0);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Teal;
            this.main_panel.Controls.Add(this.del_btn);
            this.main_panel.Controls.Add(this.label12);
            this.main_panel.Controls.Add(this.gwa_txtbox);
            this.main_panel.Controls.Add(this.label11);
            this.main_panel.Controls.Add(this.income_txtbox);
            this.main_panel.Controls.Add(this.type_combo);
            this.main_panel.Controls.Add(this.label10);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.label9);
            this.main_panel.Controls.Add(this.label3);
            this.main_panel.Controls.Add(this.studIDtextbox);
            this.main_panel.Controls.Add(this.edit_btn);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Controls.Add(this.name_txt);
            this.main_panel.Controls.Add(this.male_radio);
            this.main_panel.Controls.Add(this.female_radio);
            this.main_panel.Controls.Add(this.bday_date);
            this.main_panel.Controls.Add(this.label4);
            this.main_panel.Controls.Add(this.label7);
            this.main_panel.Controls.Add(this.label5);
            this.main_panel.Controls.Add(this.mobile_txt);
            this.main_panel.Controls.Add(this.address_txt);
            this.main_panel.Controls.Add(this.label6);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(809, 394);
            this.main_panel.TabIndex = 8;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.del_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.del_btn.IconColor = System.Drawing.Color.Black;
            this.del_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.del_btn.IconSize = 30;
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.del_btn.Location = new System.Drawing.Point(627, 325);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(71, 47);
            this.del_btn.TabIndex = 26;
            this.del_btn.Text = "Reject";
            this.del_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "GWA:";
            // 
            // gwa_txtbox
            // 
            this.gwa_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gwa_txtbox.Location = new System.Drawing.Point(420, 327);
            this.gwa_txtbox.MaxLength = 11;
            this.gwa_txtbox.Name = "gwa_txtbox";
            this.gwa_txtbox.ReadOnly = true;
            this.gwa_txtbox.Size = new System.Drawing.Size(183, 27);
            this.gwa_txtbox.TabIndex = 24;
            this.gwa_txtbox.TextChanged += new System.EventHandler(this.gwa_txtbox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Monthly Income:";
            // 
            // income_txtbox
            // 
            this.income_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_txtbox.Location = new System.Drawing.Point(160, 327);
            this.income_txtbox.MaxLength = 11;
            this.income_txtbox.Name = "income_txtbox";
            this.income_txtbox.ReadOnly = true;
            this.income_txtbox.Size = new System.Drawing.Size(184, 27);
            this.income_txtbox.TabIndex = 22;
            // 
            // type_combo
            // 
            this.type_combo.BackColor = System.Drawing.SystemColors.Window;
            this.type_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.Enabled = false;
            this.type_combo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "BSIT",
            "BSCE",
            "BSME"});
            this.type_combo.Location = new System.Drawing.Point(15, 325);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(112, 27);
            this.type_combo.TabIndex = 21;
            this.type_combo.SelectedIndexChanged += new System.EventHandler(this.course_combo_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(313, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Student Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(291, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "SCHOLARSHIP FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student ID:";
            // 
            // studIDtextbox
            // 
            this.studIDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studIDtextbox.Location = new System.Drawing.Point(15, 111);
            this.studIDtextbox.Name = "studIDtextbox";
            this.studIDtextbox.ReadOnly = true;
            this.studIDtextbox.Size = new System.Drawing.Size(329, 29);
            this.studIDtextbox.TabIndex = 12;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.edit_btn.IconColor = System.Drawing.Color.Black;
            this.edit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_btn.IconSize = 30;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edit_btn.Location = new System.Drawing.Point(704, 327);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(74, 46);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Add";
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 438);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton male_radio;
        private System.Windows.Forms.RadioButton female_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mobile_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker bday_date;
        private System.Windows.Forms.Panel main_panel;
        private FontAwesome.Sharp.IconButton edit_btn;
        private System.Windows.Forms.TextBox studIDtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox income_txtbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox gwa_txtbox;
        private FontAwesome.Sharp.IconButton del_btn;
    }
}