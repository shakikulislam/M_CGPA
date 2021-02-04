﻿namespace M_CGPA
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitleAddStudent = new System.Windows.Forms.Label();
            this.groupBoxStudentInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.labelPermanentAddress = new System.Windows.Forms.Label();
            this.labelPresentAddress = new System.Windows.Forms.Label();
            this.textBoxPermanentAddress = new System.Windows.Forms.TextBox();
            this.textBoxPresentAddress = new System.Windows.Forms.TextBox();
            this.textBoxBRN = new System.Windows.Forms.TextBox();
            this.labelBrn = new System.Windows.Forms.Label();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.labelNid = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.textBoxMName = new System.Windows.Forms.TextBox();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelAdmissionDate = new System.Windows.Forms.Label();
            this.groupBoxAcademicInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.classMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxSession = new System.Windows.Forms.TextBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.labelRoll = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.languageMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTitlebar.SuspendLayout();
            this.groupBoxStudentInformation.SuspendLayout();
            this.groupBoxAcademicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.Black;
            this.panelTitlebar.Controls.Add(this.labelTitleAddStudent);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(740, 31);
            this.panelTitlebar.TabIndex = 0;
            // 
            // labelTitleAddStudent
            // 
            this.labelTitleAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleAddStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitleAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAddStudent.ForeColor = System.Drawing.Color.White;
            this.labelTitleAddStudent.Location = new System.Drawing.Point(0, 0);
            this.labelTitleAddStudent.Name = "labelTitleAddStudent";
            this.labelTitleAddStudent.Size = new System.Drawing.Size(740, 31);
            this.labelTitleAddStudent.TabIndex = 2;
            this.labelTitleAddStudent.Text = "Add Student";
            this.labelTitleAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxStudentInformation
            // 
            this.groupBoxStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStudentInformation.Controls.Add(this.dateTimePickerDob);
            this.groupBoxStudentInformation.Controls.Add(this.labelPermanentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.labelPresentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxPermanentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxPresentAddress);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxBRN);
            this.groupBoxStudentInformation.Controls.Add(this.labelBrn);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxNid);
            this.groupBoxStudentInformation.Controls.Add(this.labelNid);
            this.groupBoxStudentInformation.Controls.Add(this.labelDob);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxMName);
            this.groupBoxStudentInformation.Controls.Add(this.labelMotherName);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxFName);
            this.groupBoxStudentInformation.Controls.Add(this.labelFatherName);
            this.groupBoxStudentInformation.Controls.Add(this.textBoxSName);
            this.groupBoxStudentInformation.Controls.Add(this.labelStudentName);
            this.groupBoxStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudentInformation.ForeColor = System.Drawing.Color.Black;
            this.groupBoxStudentInformation.Location = new System.Drawing.Point(25, 167);
            this.groupBoxStudentInformation.Name = "groupBoxStudentInformation";
            this.groupBoxStudentInformation.Size = new System.Drawing.Size(684, 320);
            this.groupBoxStudentInformation.TabIndex = 2;
            this.groupBoxStudentInformation.TabStop = false;
            this.groupBoxStudentInformation.Text = "Student Information";
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDob.Location = new System.Drawing.Point(188, 130);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(116, 26);
            this.dateTimePickerDob.TabIndex = 3;
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
            // textBoxPermanentAddress
            // 
            this.textBoxPermanentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPermanentAddress.Location = new System.Drawing.Point(188, 253);
            this.textBoxPermanentAddress.Multiline = true;
            this.textBoxPermanentAddress.Name = "textBoxPermanentAddress";
            this.textBoxPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPermanentAddress.Size = new System.Drawing.Size(485, 50);
            this.textBoxPermanentAddress.TabIndex = 1;
            // 
            // textBoxPresentAddress
            // 
            this.textBoxPresentAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPresentAddress.Location = new System.Drawing.Point(188, 197);
            this.textBoxPresentAddress.Multiline = true;
            this.textBoxPresentAddress.Name = "textBoxPresentAddress";
            this.textBoxPresentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPresentAddress.Size = new System.Drawing.Size(485, 50);
            this.textBoxPresentAddress.TabIndex = 1;
            // 
            // textBoxBRN
            // 
            this.textBoxBRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBRN.Location = new System.Drawing.Point(188, 165);
            this.textBoxBRN.Name = "textBoxBRN";
            this.textBoxBRN.Size = new System.Drawing.Size(485, 26);
            this.textBoxBRN.TabIndex = 1;
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
            // textBoxNid
            // 
            this.textBoxNid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNid.Location = new System.Drawing.Point(413, 130);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(260, 26);
            this.textBoxNid.TabIndex = 1;
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
            // textBoxMName
            // 
            this.textBoxMName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMName.Location = new System.Drawing.Point(188, 98);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(485, 26);
            this.textBoxMName.TabIndex = 1;
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
            // textBoxFName
            // 
            this.textBoxFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFName.Location = new System.Drawing.Point(188, 66);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(485, 26);
            this.textBoxFName.TabIndex = 1;
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
            // textBoxSName
            // 
            this.textBoxSName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSName.Location = new System.Drawing.Point(188, 34);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(485, 26);
            this.textBoxSName.TabIndex = 1;
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
            this.labelAdmissionDate.Location = new System.Drawing.Point(243, 71);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(121, 20);
            this.labelAdmissionDate.TabIndex = 0;
            this.labelAdmissionDate.Text = "Admission Date";
            // 
            // groupBoxAcademicInformation
            // 
            this.groupBoxAcademicInformation.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAcademicInformation.Controls.Add(this.dateTimePickerAdmissionDate);
            this.groupBoxAcademicInformation.Controls.Add(this.comboBoxClass);
            this.groupBoxAcademicInformation.Controls.Add(this.textBoxReg);
            this.groupBoxAcademicInformation.Controls.Add(this.labelReg);
            this.groupBoxAcademicInformation.Controls.Add(this.textBoxSession);
            this.groupBoxAcademicInformation.Controls.Add(this.labelSession);
            this.groupBoxAcademicInformation.Controls.Add(this.labelClass);
            this.groupBoxAcademicInformation.Controls.Add(this.textBoxRoll);
            this.groupBoxAcademicInformation.Controls.Add(this.labelRoll);
            this.groupBoxAcademicInformation.Controls.Add(this.labelAdmissionDate);
            this.groupBoxAcademicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcademicInformation.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAcademicInformation.Location = new System.Drawing.Point(25, 47);
            this.groupBoxAcademicInformation.Name = "groupBoxAcademicInformation";
            this.groupBoxAcademicInformation.Size = new System.Drawing.Size(684, 114);
            this.groupBoxAcademicInformation.TabIndex = 2;
            this.groupBoxAcademicInformation.TabStop = false;
            this.groupBoxAcademicInformation.Text = "Academic Information";
            // 
            // dateTimePickerAdmissionDate
            // 
            this.dateTimePickerAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmissionDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerAdmissionDate.Location = new System.Drawing.Point(370, 68);
            this.dateTimePickerAdmissionDate.Name = "dateTimePickerAdmissionDate";
            this.dateTimePickerAdmissionDate.Size = new System.Drawing.Size(110, 26);
            this.dateTimePickerAdmissionDate.TabIndex = 3;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DataSource = this.classMBindingSource;
            this.comboBoxClass.DisplayMember = "Name";
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(90, 68);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(131, 28);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.ValueMember = "Id";
            // 
            // classMBindingSource
            // 
            this.classMBindingSource.DataSource = typeof(M_CGPA.Model.ClassM);
            // 
            // textBoxReg
            // 
            this.textBoxReg.Location = new System.Drawing.Point(370, 31);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(110, 26);
            this.textBoxReg.TabIndex = 1;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(245, 34);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(119, 20);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "Registration No";
            // 
            // textBoxSession
            // 
            this.textBoxSession.Location = new System.Drawing.Point(569, 31);
            this.textBoxSession.Name = "textBoxSession";
            this.textBoxSession.Size = new System.Drawing.Size(104, 26);
            this.textBoxSession.TabIndex = 1;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(497, 34);
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
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(90, 31);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(131, 26);
            this.textBoxRoll.TabIndex = 1;
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
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(563, 493);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.Navy;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(405, 493);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 31);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // languageMBindingSource
            // 
            this.languageMBindingSource.DataSource = typeof(M_CGPA.Model.LanguageM);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxAcademicInformation);
            this.Controls.Add(this.groupBoxStudentInformation);
            this.Controls.Add(this.panelTitlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.panelTitlebar.ResumeLayout(false);
            this.groupBoxStudentInformation.ResumeLayout(false);
            this.groupBoxStudentInformation.PerformLayout();
            this.groupBoxAcademicInformation.ResumeLayout(false);
            this.groupBoxAcademicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitleAddStudent;
        private System.Windows.Forms.GroupBox groupBoxStudentInformation;
        private System.Windows.Forms.TextBox textBoxBRN;
        private System.Windows.Forms.Label labelBrn;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.Label labelNid;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.TextBox textBoxMName;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelAdmissionDate;
        private System.Windows.Forms.GroupBox groupBoxAcademicInformation;
        private System.Windows.Forms.TextBox textBoxSession;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.TextBox textBoxReg;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmissionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Label labelPermanentAddress;
        private System.Windows.Forms.Label labelPresentAddress;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxPresentAddress;
        private System.Windows.Forms.TextBox textBoxPermanentAddress;
        private System.Windows.Forms.BindingSource languageMBindingSource;
        private System.Windows.Forms.BindingSource classMBindingSource;
    }
}