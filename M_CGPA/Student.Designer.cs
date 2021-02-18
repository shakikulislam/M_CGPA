namespace M_CGPA
{
    partial class Student
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
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
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
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.panelAddForm = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.classMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelRoll = new System.Windows.Forms.Label();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxSession = new System.Windows.Forms.TextBox();
            this.languageMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTitlebar.SuspendLayout();
            this.groupBoxAddStudent.SuspendLayout();
            this.panelAddForm.SuspendLayout();
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
            this.panelTitlebar.Size = new System.Drawing.Size(900, 31);
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
            this.labelTitleAddStudent.Size = new System.Drawing.Size(900, 31);
            this.labelTitleAddStudent.TabIndex = 2;
            this.labelTitleAddStudent.Text = "Add Student";
            this.labelTitleAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.ForeColor = System.Drawing.Color.Black;
            this.groupBoxFilter.Location = new System.Drawing.Point(520, 47);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(355, 452);
            this.groupBoxFilter.TabIndex = 2;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Search";
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDob.Location = new System.Drawing.Point(347, 91);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(116, 26);
            this.dateTimePickerDob.TabIndex = 3;
            // 
            // labelPermanentAddress
            // 
            this.labelPermanentAddress.Location = new System.Drawing.Point(5, 377);
            this.labelPermanentAddress.Name = "labelPermanentAddress";
            this.labelPermanentAddress.Size = new System.Drawing.Size(150, 20);
            this.labelPermanentAddress.TabIndex = 0;
            this.labelPermanentAddress.Text = "Permanent Address";
            this.labelPermanentAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPresentAddress
            // 
            this.labelPresentAddress.Location = new System.Drawing.Point(4, 316);
            this.labelPresentAddress.Name = "labelPresentAddress";
            this.labelPresentAddress.Size = new System.Drawing.Size(151, 20);
            this.labelPresentAddress.TabIndex = 0;
            this.labelPresentAddress.Text = "Present Address";
            this.labelPresentAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPermanentAddress
            // 
            this.textBoxPermanentAddress.Location = new System.Drawing.Point(154, 374);
            this.textBoxPermanentAddress.Multiline = true;
            this.textBoxPermanentAddress.Name = "textBoxPermanentAddress";
            this.textBoxPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPermanentAddress.Size = new System.Drawing.Size(309, 50);
            this.textBoxPermanentAddress.TabIndex = 1;
            // 
            // textBoxPresentAddress
            // 
            this.textBoxPresentAddress.Location = new System.Drawing.Point(154, 313);
            this.textBoxPresentAddress.Multiline = true;
            this.textBoxPresentAddress.Name = "textBoxPresentAddress";
            this.textBoxPresentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPresentAddress.Size = new System.Drawing.Size(309, 50);
            this.textBoxPresentAddress.TabIndex = 1;
            // 
            // textBoxBRN
            // 
            this.textBoxBRN.Location = new System.Drawing.Point(154, 276);
            this.textBoxBRN.Name = "textBoxBRN";
            this.textBoxBRN.Size = new System.Drawing.Size(309, 26);
            this.textBoxBRN.TabIndex = 1;
            // 
            // labelBrn
            // 
            this.labelBrn.Location = new System.Drawing.Point(0, 280);
            this.labelBrn.Name = "labelBrn";
            this.labelBrn.Size = new System.Drawing.Size(156, 20);
            this.labelBrn.TabIndex = 0;
            this.labelBrn.Text = "Birth Registration No";
            this.labelBrn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNid
            // 
            this.textBoxNid.Location = new System.Drawing.Point(122, 239);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(341, 26);
            this.textBoxNid.TabIndex = 1;
            // 
            // labelNid
            // 
            this.labelNid.Location = new System.Drawing.Point(38, 242);
            this.labelNid.Name = "labelNid";
            this.labelNid.Size = new System.Drawing.Size(84, 20);
            this.labelNid.TabIndex = 0;
            this.labelNid.Text = "NID";
            this.labelNid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDob
            // 
            this.labelDob.Location = new System.Drawing.Point(238, 95);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(103, 20);
            this.labelDob.TabIndex = 0;
            this.labelDob.Text = "Date of Birth";
            this.labelDob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(122, 202);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(341, 26);
            this.textBoxMName.TabIndex = 1;
            // 
            // labelMotherName
            // 
            this.labelMotherName.Location = new System.Drawing.Point(1, 205);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(121, 20);
            this.labelMotherName.TabIndex = 0;
            this.labelMotherName.Text = "Mother Name";
            this.labelMotherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(122, 165);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(341, 26);
            this.textBoxFName.TabIndex = 1;
            // 
            // labelFatherName
            // 
            this.labelFatherName.Location = new System.Drawing.Point(1, 168);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(121, 20);
            this.labelFatherName.TabIndex = 0;
            this.labelFatherName.Text = "Father Name";
            this.labelFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(122, 128);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(341, 26);
            this.textBoxSName.TabIndex = 1;
            // 
            // labelStudentName
            // 
            this.labelStudentName.Location = new System.Drawing.Point(1, 131);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(121, 20);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name";
            this.labelStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.Location = new System.Drawing.Point(0, 96);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(122, 20);
            this.labelAdmissionDate.TabIndex = 0;
            this.labelAdmissionDate.Text = "Admission Date";
            this.labelAdmissionDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddStudent.Controls.Add(this.panelAddForm);
            this.groupBoxAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddStudent.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAddStudent.Location = new System.Drawing.Point(25, 47);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(489, 452);
            this.groupBoxAddStudent.TabIndex = 2;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Academic Information";
            // 
            // panelAddForm
            // 
            this.panelAddForm.AutoScroll = true;
            this.panelAddForm.Controls.Add(this.buttonClear);
            this.panelAddForm.Controls.Add(this.textBoxRoll);
            this.panelAddForm.Controls.Add(this.labelPermanentAddress);
            this.panelAddForm.Controls.Add(this.labelFatherName);
            this.panelAddForm.Controls.Add(this.buttonAdd);
            this.panelAddForm.Controls.Add(this.textBoxFName);
            this.panelAddForm.Controls.Add(this.dateTimePickerDob);
            this.panelAddForm.Controls.Add(this.labelStudentName);
            this.panelAddForm.Controls.Add(this.textBoxPermanentAddress);
            this.panelAddForm.Controls.Add(this.labelMotherName);
            this.panelAddForm.Controls.Add(this.labelPresentAddress);
            this.panelAddForm.Controls.Add(this.textBoxSName);
            this.panelAddForm.Controls.Add(this.dateTimePickerAdmissionDate);
            this.panelAddForm.Controls.Add(this.textBoxMName);
            this.panelAddForm.Controls.Add(this.comboBoxClass);
            this.panelAddForm.Controls.Add(this.labelAdmissionDate);
            this.panelAddForm.Controls.Add(this.textBoxPresentAddress);
            this.panelAddForm.Controls.Add(this.labelRoll);
            this.panelAddForm.Controls.Add(this.textBoxReg);
            this.panelAddForm.Controls.Add(this.labelDob);
            this.panelAddForm.Controls.Add(this.textBoxBRN);
            this.panelAddForm.Controls.Add(this.labelClass);
            this.panelAddForm.Controls.Add(this.labelBrn);
            this.panelAddForm.Controls.Add(this.labelSession);
            this.panelAddForm.Controls.Add(this.labelReg);
            this.panelAddForm.Controls.Add(this.labelNid);
            this.panelAddForm.Controls.Add(this.textBoxSession);
            this.panelAddForm.Controls.Add(this.textBoxNid);
            this.panelAddForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddForm.Location = new System.Drawing.Point(3, 22);
            this.panelAddForm.Name = "panelAddForm";
            this.panelAddForm.Size = new System.Drawing.Size(483, 427);
            this.panelAddForm.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Navy;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(153, 453);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 31);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(122, 17);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(110, 26);
            this.textBoxRoll.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(311, 453);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerAdmissionDate
            // 
            this.dateTimePickerAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmissionDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerAdmissionDate.Location = new System.Drawing.Point(122, 91);
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
            this.comboBoxClass.Location = new System.Drawing.Point(347, 15);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(116, 28);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.ValueMember = "Id";
            // 
            // classMBindingSource
            // 
            this.classMBindingSource.DataSource = typeof(M_CGPA.Model.ClassM);
            // 
            // labelRoll
            // 
            this.labelRoll.Location = new System.Drawing.Point(4, 19);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(118, 20);
            this.labelRoll.TabIndex = 0;
            this.labelRoll.Text = "Roll No";
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxReg
            // 
            this.textBoxReg.Location = new System.Drawing.Point(122, 54);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(110, 26);
            this.textBoxReg.TabIndex = 1;
            // 
            // labelClass
            // 
            this.labelClass.Location = new System.Drawing.Point(265, 18);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(76, 20);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSession
            // 
            this.labelSession.Location = new System.Drawing.Point(265, 57);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(76, 20);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Session";
            this.labelSession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReg
            // 
            this.labelReg.Location = new System.Drawing.Point(0, 57);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(122, 20);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "Registration No";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSession
            // 
            this.textBoxSession.Location = new System.Drawing.Point(347, 54);
            this.textBoxSession.Name = "textBoxSession";
            this.textBoxSession.Size = new System.Drawing.Size(116, 26);
            this.textBoxSession.TabIndex = 1;
            // 
            // languageMBindingSource
            // 
            this.languageMBindingSource.DataSource = typeof(M_CGPA.Model.LanguageM);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.groupBoxAddStudent);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.panelTitlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.panelTitlebar.ResumeLayout(false);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.panelAddForm.ResumeLayout(false);
            this.panelAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitleAddStudent;
        private System.Windows.Forms.GroupBox groupBoxFilter;
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
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
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
        private System.Windows.Forms.Panel panelAddForm;
    }
}