namespace req
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stud_table = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_panel = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.del_btn = new FontAwesome.Sharp.IconButton();
            this.edit_btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.stud_table)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stud_table
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stud_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stud_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stud_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.fullname,
            this.sex,
            this.sub_code,
            this.gwa,
            this.mobile_num,
            this.date_birth,
            this.address});
            this.stud_table.Location = new System.Drawing.Point(3, 3);
            this.stud_table.MultiSelect = false;
            this.stud_table.Name = "stud_table";
            this.stud_table.ReadOnly = true;
            this.stud_table.Size = new System.Drawing.Size(787, 349);
            this.stud_table.TabIndex = 3;
            this.stud_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stud_table_CellClick);
            this.stud_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stud_table_CellContentClick);
            // 
            // student_id
            // 
            this.student_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.student_id.HeaderText = "Student ID";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 91;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 90;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sex.HeaderText = "Sex";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 56;
            // 
            // sub_code
            // 
            this.sub_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sub_code.HeaderText = "Enrolled Course";
            this.sub_code.Name = "sub_code";
            this.sub_code.ReadOnly = true;
            this.sub_code.Width = 124;
            // 
            // gwa
            // 
            this.gwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gwa.HeaderText = "GWA";
            this.gwa.Name = "gwa";
            this.gwa.ReadOnly = true;
            // 
            // mobile_num
            // 
            this.mobile_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mobile_num.HeaderText = "Mobile Number";
            this.mobile_num.Name = "mobile_num";
            this.mobile_num.ReadOnly = true;
            this.mobile_num.Width = 120;
            // 
            // date_birth
            // 
            this.date_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date_birth.HeaderText = "Birth Date";
            this.date_birth.Name = "date_birth";
            this.date_birth.ReadOnly = true;
            this.date_birth.Width = 88;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Teal;
            this.main_panel.Controls.Add(this.iconButton4);
            this.main_panel.Controls.Add(this.stud_table);
            this.main_panel.Controls.Add(this.del_btn);
            this.main_panel.Controls.Add(this.edit_btn);
            this.main_panel.Location = new System.Drawing.Point(2, 2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(793, 410);
            this.main_panel.TabIndex = 4;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // iconButton4
            // 
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 24;
            this.iconButton4.Location = new System.Drawing.Point(16, 358);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(64, 47);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "Refresh";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            this.del_btn.Location = new System.Drawing.Point(719, 358);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(71, 47);
            this.del_btn.TabIndex = 4;
            this.del_btn.Text = "Delete";
            this.del_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.edit_btn.IconColor = System.Drawing.Color.Black;
            this.edit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_btn.IconSize = 30;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edit_btn.Location = new System.Drawing.Point(96, 358);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(65, 47);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Visible = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stud_table)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView stud_table;
        private System.Windows.Forms.Panel main_panel;
        private FontAwesome.Sharp.IconButton edit_btn;
        private FontAwesome.Sharp.IconButton del_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_id;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn gwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

