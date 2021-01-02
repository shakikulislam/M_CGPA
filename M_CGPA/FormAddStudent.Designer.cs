namespace M_CGPA
{
    partial class FormAddStudent
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
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitleAddStudent = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.groupBoxStudentInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelPermanentAddress = new System.Windows.Forms.Label();
            this.labelPresentAddress = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelBrn = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelNid = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelAdmissionDate = new System.Windows.Forms.Label();
            this.groupBoxAcademicInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.labelRoll = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelTitlebar.SuspendLayout();
            this.groupBoxStudentInformation.SuspendLayout();
            this.groupBoxAcademicInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.Black;
            this.panelTitlebar.Controls.Add(this.labelTitleAddStudent);
            this.panelTitlebar.Controls.Add(this.labelClose);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(821, 31);
            this.panelTitlebar.TabIndex = 0;
            // 
            // labelTitleAddStudent
            // 
            this.labelTitleAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAddStudent.ForeColor = System.Drawing.Color.White;
            this.labelTitleAddStudent.Location = new System.Drawing.Point(0, 0);
            this.labelTitleAddStudent.Name = "labelTitleAddStudent";
            this.labelTitleAddStudent.Size = new System.Drawing.Size(804, 31);
            this.labelTitleAddStudent.TabIndex = 2;
            this.labelTitleAddStudent.Text = "Add Student";
            this.labelTitleAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Red;
            this.labelClose.Location = new System.Drawing.Point(804, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 31);
            this.labelClose.TabIndex = 2;
            this.labelClose.Tag = "";
            this.labelClose.Text = "X";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // groupBoxStudentInformation
            // 
            this.groupBoxStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStudentInformation.Controls.Add(this.dateTimePicker2);
            this.groupBoxStudentInformation.Controls.Add(this.labelPermanentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.labelPresentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.textBox7);
            this.groupBoxStudentInformation.Controls.Add(this.textBox4);
            this.groupBoxStudentInformation.Controls.Add(this.textBox6);
            this.groupBoxStudentInformation.Controls.Add(this.labelBrn);
            this.groupBoxStudentInformation.Controls.Add(this.textBox5);
            this.groupBoxStudentInformation.Controls.Add(this.labelNid);
            this.groupBoxStudentInformation.Controls.Add(this.labelDob);
            this.groupBoxStudentInformation.Controls.Add(this.textBox3);
            this.groupBoxStudentInformation.Controls.Add(this.labelMotherName);
            this.groupBoxStudentInformation.Controls.Add(this.textBox2);
            this.groupBoxStudentInformation.Controls.Add(this.labelFatherName);
            this.groupBoxStudentInformation.Controls.Add(this.textBox1);
            this.groupBoxStudentInformation.Controls.Add(this.labelStudentName);
            this.groupBoxStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudentInformation.Location = new System.Drawing.Point(25, 167);
            this.groupBoxStudentInformation.Name = "groupBoxStudentInformation";
            this.groupBoxStudentInformation.Size = new System.Drawing.Size(768, 320);
            this.groupBoxStudentInformation.TabIndex = 2;
            this.groupBoxStudentInformation.TabStop = false;
            this.groupBoxStudentInformation.Text = "Student Information";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // labelPermanentAddress
            // 
            this.labelPermanentAddress.AutoSize = true;
            this.labelPermanentAddress.Location = new System.Drawing.Point(26, 253);
            this.labelPermanentAddress.Name = "labelPermanentAddress";
            this.labelPermanentAddress.Size = new System.Drawing.Size(150, 20);
            this.labelPermanentAddress.TabIndex = 0;
            this.labelPermanentAddress.Text = "Permanent Address";
            // 
            // labelPresentAddress
            // 
            this.labelPresentAddress.AutoSize = true;
            this.labelPresentAddress.Location = new System.Drawing.Point(26, 197);
            this.labelPresentAddress.Name = "labelPresentAddress";
            this.labelPresentAddress.Size = new System.Drawing.Size(127, 20);
            this.labelPresentAddress.TabIndex = 0;
            this.labelPresentAddress.Text = "Present Address";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(188, 253);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox7.Size = new System.Drawing.Size(562, 50);
            this.textBox7.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 197);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(562, 50);
            this.textBox4.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(188, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(562, 26);
            this.textBox6.TabIndex = 1;
            // 
            // labelBrn
            // 
            this.labelBrn.AutoSize = true;
            this.labelBrn.Location = new System.Drawing.Point(26, 168);
            this.labelBrn.Name = "labelBrn";
            this.labelBrn.Size = new System.Drawing.Size(156, 20);
            this.labelBrn.TabIndex = 0;
            this.labelBrn.Text = "Birth Registration No";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(413, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 26);
            this.textBox5.TabIndex = 1;
            // 
            // labelNid
            // 
            this.labelNid.Location = new System.Drawing.Point(307, 133);
            this.labelNid.Name = "labelNid";
            this.labelNid.Size = new System.Drawing.Size(100, 20);
            this.labelNid.TabIndex = 0;
            this.labelNid.Text = "NID";
            this.labelNid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(26, 133);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(99, 20);
            this.labelDob.TabIndex = 0;
            this.labelDob.Text = "Date of Birth";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(562, 26);
            this.textBox3.TabIndex = 1;
            // 
            // labelMotherName
            // 
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Location = new System.Drawing.Point(26, 101);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(105, 20);
            this.labelMotherName.TabIndex = 0;
            this.labelMotherName.Text = "Mother Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(562, 26);
            this.textBox2.TabIndex = 1;
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Location = new System.Drawing.Point(26, 69);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(102, 20);
            this.labelFatherName.TabIndex = 0;
            this.labelFatherName.Text = "Father Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 26);
            this.textBox1.TabIndex = 1;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(26, 37);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(112, 20);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name";
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.AutoSize = true;
            this.labelAdmissionDate.Location = new System.Drawing.Point(276, 71);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(121, 20);
            this.labelAdmissionDate.TabIndex = 0;
            this.labelAdmissionDate.Text = "Admission Date";
            // 
            // groupBoxAcademicInformation
            // 
            this.groupBoxAcademicInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAcademicInformation.Controls.Add(this.dateTimePicker1);
            this.groupBoxAcademicInformation.Controls.Add(this.comboBox1);
            this.groupBoxAcademicInformation.Controls.Add(this.textBox13);
            this.groupBoxAcademicInformation.Controls.Add(this.labelReg);
            this.groupBoxAcademicInformation.Controls.Add(this.textBox22);
            this.groupBoxAcademicInformation.Controls.Add(this.labelSession);
            this.groupBoxAcademicInformation.Controls.Add(this.labelClass);
            this.groupBoxAcademicInformation.Controls.Add(this.textBox24);
            this.groupBoxAcademicInformation.Controls.Add(this.labelRoll);
            this.groupBoxAcademicInformation.Controls.Add(this.labelAdmissionDate);
            this.groupBoxAcademicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcademicInformation.Location = new System.Drawing.Point(25, 47);
            this.groupBoxAcademicInformation.Name = "groupBoxAcademicInformation";
            this.groupBoxAcademicInformation.Size = new System.Drawing.Size(768, 114);
            this.groupBoxAcademicInformation.TabIndex = 2;
            this.groupBoxAcademicInformation.TabStop = false;
            this.groupBoxAcademicInformation.Text = "Academic Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(403, 31);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(139, 26);
            this.textBox13.TabIndex = 1;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(278, 34);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(119, 20);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "Registration No";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(626, 31);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(124, 26);
            this.textBox22.TabIndex = 1;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(554, 34);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(66, 20);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Session";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(24, 72);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(48, 20);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(90, 31);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(175, 26);
            this.textBox24.TabIndex = 1;
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Location = new System.Drawing.Point(24, 34);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(60, 20);
            this.labelRoll.TabIndex = 0;
            this.labelRoll.Text = "Roll No";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(657, 493);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Navy;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(499, 493);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 31);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(821, 540);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxAcademicInformation);
            this.Controls.Add(this.groupBoxStudentInformation);
            this.Controls.Add(this.panelTitlebar);
            this.ForeColor = System.Drawing.Color.Violet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.panelTitlebar.ResumeLayout(false);
            this.groupBoxStudentInformation.ResumeLayout(false);
            this.groupBoxStudentInformation.PerformLayout();
            this.groupBoxAcademicInformation.ResumeLayout(false);
            this.groupBoxAcademicInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelTitleAddStudent;
        private System.Windows.Forms.GroupBox groupBoxStudentInformation;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelBrn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelNid;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelAdmissionDate;
        private System.Windows.Forms.GroupBox groupBoxAcademicInformation;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelPermanentAddress;
        private System.Windows.Forms.Label labelPresentAddress;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
    }
}