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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAddForm = new System.Windows.Forms.Panel();
            this.labelMPhone = new System.Windows.Forms.Label();
            this.textBoxMPhone = new System.Windows.Forms.TextBox();
            this.labelFPhone = new System.Windows.Forms.Label();
            this.textBoxFPhone = new System.Windows.Forms.TextBox();
            this.labelSPhone = new System.Windows.Forms.Label();
            this.textBoxSPhone = new System.Windows.Forms.TextBox();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.dateTimePickerAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.classMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelRoll = new System.Windows.Forms.Label();
            this.textBoxReg = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxSession = new System.Windows.Forms.TextBox();
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.tabPageAddResult = new System.Windows.Forms.TabPage();
            this.labelARStudentName = new System.Windows.Forms.Label();
            this.labelARName = new System.Windows.Forms.Label();
            this.textBoxARSearch = new System.Windows.Forms.TextBox();
            this.labelARRoll = new System.Windows.Forms.Label();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.labelARStudentClass = new System.Windows.Forms.Label();
            this.labelARClass = new System.Windows.Forms.Label();
            this.panelTitlebar.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMBindingSource)).BeginInit();
            this.groupBoxAddStudent.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).BeginInit();
            this.tabControlStudent.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.tabPageAddResult.SuspendLayout();
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
            this.groupBoxFilter.Controls.Add(this.textBoxSearch);
            this.groupBoxFilter.Controls.Add(this.labelSearch);
            this.groupBoxFilter.Controls.Add(this.dataGridViewStudentList);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.ForeColor = System.Drawing.Color.Black;
            this.groupBoxFilter.Location = new System.Drawing.Point(541, 19);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(333, 433);
            this.groupBoxFilter.TabIndex = 2;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.Location = new System.Drawing.Point(17, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(298, 26);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSearch.Location = new System.Drawing.Point(17, 22);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(298, 25);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Search for anything";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentList.AutoGenerateColumns = false;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.roll,
            this.reg,
            this.classId,
            this.studentName,
            this.clas,
            this.session,
            this.admissionDate,
            this.dob,
            this.sPhone,
            this.fatherName,
            this.fPhone,
            this.motherName,
            this.mPhone,
            this.nid,
            this.brn,
            this.presentAddress,
            this.permanentAddress});
            this.dataGridViewStudentList.DataSource = this.studentMBindingSource;
            this.dataGridViewStudentList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.RowHeadersVisible = false;
            this.dataGridViewStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(327, 275);
            this.dataGridViewStudentList.TabIndex = 18;
            this.dataGridViewStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellDoubleClick);
            this.dataGridViewStudentList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewStudentList_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // roll
            // 
            this.roll.DataPropertyName = "Roll";
            this.roll.HeaderText = "Roll";
            this.roll.Name = "roll";
            this.roll.ReadOnly = true;
            // 
            // reg
            // 
            this.reg.DataPropertyName = "Reg";
            this.reg.HeaderText = "Reg";
            this.reg.Name = "reg";
            this.reg.ReadOnly = true;
            this.reg.Visible = false;
            // 
            // classId
            // 
            this.classId.DataPropertyName = "ClassId";
            this.classId.HeaderText = "ClassId";
            this.classId.Name = "classId";
            this.classId.ReadOnly = true;
            this.classId.Visible = false;
            // 
            // studentName
            // 
            this.studentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentName.DataPropertyName = "StudentName";
            this.studentName.HeaderText = "Student Name";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // clas
            // 
            this.clas.DataPropertyName = "Class";
            this.clas.HeaderText = "Class";
            this.clas.Name = "clas";
            this.clas.ReadOnly = true;
            // 
            // session
            // 
            this.session.DataPropertyName = "Session";
            this.session.HeaderText = "Session";
            this.session.Name = "session";
            this.session.ReadOnly = true;
            this.session.Visible = false;
            // 
            // admissionDate
            // 
            this.admissionDate.DataPropertyName = "AdmissionDate";
            this.admissionDate.HeaderText = "Admission Date";
            this.admissionDate.Name = "admissionDate";
            this.admissionDate.ReadOnly = true;
            this.admissionDate.Visible = false;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "Dob";
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Visible = false;
            // 
            // sPhone
            // 
            this.sPhone.DataPropertyName = "SPhone";
            this.sPhone.HeaderText = "Student Phone";
            this.sPhone.Name = "sPhone";
            this.sPhone.ReadOnly = true;
            this.sPhone.Visible = false;
            // 
            // fatherName
            // 
            this.fatherName.DataPropertyName = "FatherName";
            this.fatherName.HeaderText = "Father Name";
            this.fatherName.Name = "fatherName";
            this.fatherName.ReadOnly = true;
            this.fatherName.Visible = false;
            // 
            // fPhone
            // 
            this.fPhone.DataPropertyName = "FPhone";
            this.fPhone.HeaderText = "Father Phone";
            this.fPhone.Name = "fPhone";
            this.fPhone.ReadOnly = true;
            this.fPhone.Visible = false;
            // 
            // motherName
            // 
            this.motherName.DataPropertyName = "MotherName";
            this.motherName.HeaderText = "MotherName";
            this.motherName.Name = "motherName";
            this.motherName.ReadOnly = true;
            this.motherName.Visible = false;
            // 
            // mPhone
            // 
            this.mPhone.DataPropertyName = "MPhone";
            this.mPhone.HeaderText = "MPhone";
            this.mPhone.Name = "mPhone";
            this.mPhone.ReadOnly = true;
            this.mPhone.Visible = false;
            // 
            // nid
            // 
            this.nid.DataPropertyName = "Nid";
            this.nid.HeaderText = "Nid";
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            this.nid.Visible = false;
            // 
            // brn
            // 
            this.brn.DataPropertyName = "Brn";
            this.brn.HeaderText = "Brn";
            this.brn.Name = "brn";
            this.brn.ReadOnly = true;
            this.brn.Visible = false;
            // 
            // presentAddress
            // 
            this.presentAddress.DataPropertyName = "PresentAddress";
            this.presentAddress.HeaderText = "PresentAddress";
            this.presentAddress.Name = "presentAddress";
            this.presentAddress.ReadOnly = true;
            this.presentAddress.Visible = false;
            // 
            // permanentAddress
            // 
            this.permanentAddress.DataPropertyName = "PermanentAddress";
            this.permanentAddress.HeaderText = "PermanentAddress";
            this.permanentAddress.Name = "permanentAddress";
            this.permanentAddress.ReadOnly = true;
            this.permanentAddress.Visible = false;
            // 
            // studentMBindingSource
            // 
            this.studentMBindingSource.DataSource = typeof(M_CGPA.Model.StudentM);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDob.Location = new System.Drawing.Point(347, 91);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(108, 26);
            this.dateTimePickerDob.TabIndex = 3;
            // 
            // labelPermanentAddress
            // 
            this.labelPermanentAddress.Location = new System.Drawing.Point(5, 487);
            this.labelPermanentAddress.Name = "labelPermanentAddress";
            this.labelPermanentAddress.Size = new System.Drawing.Size(150, 25);
            this.labelPermanentAddress.TabIndex = 0;
            this.labelPermanentAddress.Text = "Permanent Address";
            this.labelPermanentAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPresentAddress
            // 
            this.labelPresentAddress.Location = new System.Drawing.Point(4, 426);
            this.labelPresentAddress.Name = "labelPresentAddress";
            this.labelPresentAddress.Size = new System.Drawing.Size(151, 25);
            this.labelPresentAddress.TabIndex = 0;
            this.labelPresentAddress.Text = "Present Address";
            this.labelPresentAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPermanentAddress
            // 
            this.textBoxPermanentAddress.Location = new System.Drawing.Point(154, 484);
            this.textBoxPermanentAddress.Multiline = true;
            this.textBoxPermanentAddress.Name = "textBoxPermanentAddress";
            this.textBoxPermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPermanentAddress.Size = new System.Drawing.Size(301, 50);
            this.textBoxPermanentAddress.TabIndex = 1;
            // 
            // textBoxPresentAddress
            // 
            this.textBoxPresentAddress.Location = new System.Drawing.Point(154, 423);
            this.textBoxPresentAddress.Multiline = true;
            this.textBoxPresentAddress.Name = "textBoxPresentAddress";
            this.textBoxPresentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPresentAddress.Size = new System.Drawing.Size(301, 50);
            this.textBoxPresentAddress.TabIndex = 1;
            // 
            // textBoxBRN
            // 
            this.textBoxBRN.Location = new System.Drawing.Point(154, 386);
            this.textBoxBRN.Name = "textBoxBRN";
            this.textBoxBRN.Size = new System.Drawing.Size(301, 26);
            this.textBoxBRN.TabIndex = 1;
            // 
            // labelBrn
            // 
            this.labelBrn.Location = new System.Drawing.Point(0, 390);
            this.labelBrn.Name = "labelBrn";
            this.labelBrn.Size = new System.Drawing.Size(156, 25);
            this.labelBrn.TabIndex = 0;
            this.labelBrn.Text = "Birth Registration No";
            this.labelBrn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNid
            // 
            this.textBoxNid.Location = new System.Drawing.Point(122, 349);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(333, 26);
            this.textBoxNid.TabIndex = 1;
            // 
            // labelNid
            // 
            this.labelNid.Location = new System.Drawing.Point(9, 352);
            this.labelNid.Name = "labelNid";
            this.labelNid.Size = new System.Drawing.Size(113, 25);
            this.labelNid.TabIndex = 0;
            this.labelNid.Text = "NID";
            this.labelNid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDob
            // 
            this.labelDob.Location = new System.Drawing.Point(238, 95);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(103, 25);
            this.labelDob.TabIndex = 0;
            this.labelDob.Text = "Date of Birth";
            this.labelDob.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMName
            // 
            this.textBoxMName.Location = new System.Drawing.Point(122, 275);
            this.textBoxMName.Name = "textBoxMName";
            this.textBoxMName.Size = new System.Drawing.Size(333, 26);
            this.textBoxMName.TabIndex = 1;
            // 
            // labelMotherName
            // 
            this.labelMotherName.Location = new System.Drawing.Point(1, 278);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(121, 25);
            this.labelMotherName.TabIndex = 0;
            this.labelMotherName.Text = "Mother Name";
            this.labelMotherName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(122, 202);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(333, 26);
            this.textBoxFName.TabIndex = 1;
            // 
            // labelFatherName
            // 
            this.labelFatherName.Location = new System.Drawing.Point(1, 205);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(121, 25);
            this.labelFatherName.TabIndex = 0;
            this.labelFatherName.Text = "Father Name";
            this.labelFatherName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(122, 128);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(333, 26);
            this.textBoxSName.TabIndex = 1;
            // 
            // labelStudentName
            // 
            this.labelStudentName.Location = new System.Drawing.Point(1, 131);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(121, 25);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name";
            this.labelStudentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.Location = new System.Drawing.Point(0, 96);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(122, 25);
            this.labelAdmissionDate.TabIndex = 0;
            this.labelAdmissionDate.Text = "Admission Date";
            this.labelAdmissionDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddStudent.Controls.Add(this.panelButtons);
            this.groupBoxAddStudent.Controls.Add(this.panelAddForm);
            this.groupBoxAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddStudent.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAddStudent.Location = new System.Drawing.Point(18, 19);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(489, 436);
            this.groupBoxAddStudent.TabIndex = 2;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Student Information";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonClear);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(3, 396);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(483, 37);
            this.panelButtons.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Purple;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(102, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 31);
            this.buttonCancel.TabIndex = 29;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(358, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 31);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Green;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(230, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 31);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Navy;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(230, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(122, 31);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(358, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelAddForm
            // 
            this.panelAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddForm.AutoScroll = true;
            this.panelAddForm.Controls.Add(this.labelMPhone);
            this.panelAddForm.Controls.Add(this.textBoxMPhone);
            this.panelAddForm.Controls.Add(this.labelFPhone);
            this.panelAddForm.Controls.Add(this.textBoxFPhone);
            this.panelAddForm.Controls.Add(this.labelSPhone);
            this.panelAddForm.Controls.Add(this.textBoxSPhone);
            this.panelAddForm.Controls.Add(this.textBoxRoll);
            this.panelAddForm.Controls.Add(this.labelPermanentAddress);
            this.panelAddForm.Controls.Add(this.labelFatherName);
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
            this.panelAddForm.Location = new System.Drawing.Point(3, 25);
            this.panelAddForm.Name = "panelAddForm";
            this.panelAddForm.Size = new System.Drawing.Size(480, 346);
            this.panelAddForm.TabIndex = 6;
            // 
            // labelMPhone
            // 
            this.labelMPhone.Location = new System.Drawing.Point(1, 315);
            this.labelMPhone.Name = "labelMPhone";
            this.labelMPhone.Size = new System.Drawing.Size(121, 25);
            this.labelMPhone.TabIndex = 8;
            this.labelMPhone.Text = "Phone";
            this.labelMPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxMPhone
            // 
            this.textBoxMPhone.Location = new System.Drawing.Point(122, 312);
            this.textBoxMPhone.Name = "textBoxMPhone";
            this.textBoxMPhone.Size = new System.Drawing.Size(333, 26);
            this.textBoxMPhone.TabIndex = 9;
            // 
            // labelFPhone
            // 
            this.labelFPhone.Location = new System.Drawing.Point(1, 241);
            this.labelFPhone.Name = "labelFPhone";
            this.labelFPhone.Size = new System.Drawing.Size(121, 25);
            this.labelFPhone.TabIndex = 6;
            this.labelFPhone.Text = "Phone";
            this.labelFPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFPhone
            // 
            this.textBoxFPhone.Location = new System.Drawing.Point(122, 238);
            this.textBoxFPhone.Name = "textBoxFPhone";
            this.textBoxFPhone.Size = new System.Drawing.Size(333, 26);
            this.textBoxFPhone.TabIndex = 7;
            // 
            // labelSPhone
            // 
            this.labelSPhone.Location = new System.Drawing.Point(1, 168);
            this.labelSPhone.Name = "labelSPhone";
            this.labelSPhone.Size = new System.Drawing.Size(121, 25);
            this.labelSPhone.TabIndex = 4;
            this.labelSPhone.Text = "Phone";
            this.labelSPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSPhone
            // 
            this.textBoxSPhone.Location = new System.Drawing.Point(122, 165);
            this.textBoxSPhone.Name = "textBoxSPhone";
            this.textBoxSPhone.Size = new System.Drawing.Size(333, 26);
            this.textBoxSPhone.TabIndex = 5;
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(122, 17);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(102, 26);
            this.textBoxRoll.TabIndex = 1;
            // 
            // dateTimePickerAdmissionDate
            // 
            this.dateTimePickerAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAdmissionDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerAdmissionDate.Location = new System.Drawing.Point(122, 91);
            this.dateTimePickerAdmissionDate.Name = "dateTimePickerAdmissionDate";
            this.dateTimePickerAdmissionDate.Size = new System.Drawing.Size(102, 26);
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
            this.comboBoxClass.Size = new System.Drawing.Size(108, 28);
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
            this.labelRoll.Size = new System.Drawing.Size(118, 24);
            this.labelRoll.TabIndex = 0;
            this.labelRoll.Text = "Roll No";
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxReg
            // 
            this.textBoxReg.Location = new System.Drawing.Point(122, 54);
            this.textBoxReg.Name = "textBoxReg";
            this.textBoxReg.Size = new System.Drawing.Size(102, 26);
            this.textBoxReg.TabIndex = 1;
            // 
            // labelClass
            // 
            this.labelClass.Location = new System.Drawing.Point(265, 18);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(76, 25);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSession
            // 
            this.labelSession.Location = new System.Drawing.Point(265, 57);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(76, 25);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Session";
            this.labelSession.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelReg
            // 
            this.labelReg.Location = new System.Drawing.Point(0, 57);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(122, 25);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "Registration No";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSession
            // 
            this.textBoxSession.Location = new System.Drawing.Point(347, 54);
            this.textBoxSession.Name = "textBoxSession";
            this.textBoxSession.Size = new System.Drawing.Size(108, 26);
            this.textBoxSession.TabIndex = 1;
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlStudent.Controls.Add(this.tabPageAddResult);
            this.tabControlStudent.Controls.Add(this.tabPageBook);
            this.tabControlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStudent.ItemSize = new System.Drawing.Size(71, 25);
            this.tabControlStudent.Location = new System.Drawing.Point(0, 31);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(900, 509);
            this.tabControlStudent.TabIndex = 3;
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.BackColor = System.Drawing.Color.White;
            this.tabPageAddStudent.Controls.Add(this.groupBoxAddStudent);
            this.tabPageAddStudent.Controls.Add(this.groupBoxFilter);
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(892, 476);
            this.tabPageAddStudent.TabIndex = 0;
            this.tabPageAddStudent.Text = "Add Student";
            // 
            // tabPageAddResult
            // 
            this.tabPageAddResult.BackColor = System.Drawing.Color.White;
            this.tabPageAddResult.Controls.Add(this.labelARStudentClass);
            this.tabPageAddResult.Controls.Add(this.labelARClass);
            this.tabPageAddResult.Controls.Add(this.labelARStudentName);
            this.tabPageAddResult.Controls.Add(this.labelARName);
            this.tabPageAddResult.Controls.Add(this.textBoxARSearch);
            this.tabPageAddResult.Controls.Add(this.labelARRoll);
            this.tabPageAddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddResult.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddResult.Name = "tabPageAddResult";
            this.tabPageAddResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddResult.Size = new System.Drawing.Size(892, 476);
            this.tabPageAddResult.TabIndex = 1;
            this.tabPageAddResult.Text = "Add Result";
            // 
            // labelARStudentName
            // 
            this.labelARStudentName.AutoSize = true;
            this.labelARStudentName.Location = new System.Drawing.Point(175, 130);
            this.labelARStudentName.Name = "labelARStudentName";
            this.labelARStudentName.Size = new System.Drawing.Size(0, 20);
            this.labelARStudentName.TabIndex = 24;
            this.labelARStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelARName
            // 
            this.labelARName.Location = new System.Drawing.Point(22, 128);
            this.labelARName.Name = "labelARName";
            this.labelARName.Size = new System.Drawing.Size(147, 25);
            this.labelARName.TabIndex = 23;
            this.labelARName.Text = "Name";
            this.labelARName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxARSearch
            // 
            this.textBoxARSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxARSearch.Location = new System.Drawing.Point(297, 64);
            this.textBoxARSearch.Name = "textBoxARSearch";
            this.textBoxARSearch.Size = new System.Drawing.Size(298, 26);
            this.textBoxARSearch.TabIndex = 22;
            this.textBoxARSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxARSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxARSearch_KeyDown);
            // 
            // labelARRoll
            // 
            this.labelARRoll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelARRoll.Location = new System.Drawing.Point(297, 33);
            this.labelARRoll.Name = "labelARRoll";
            this.labelARRoll.Size = new System.Drawing.Size(298, 25);
            this.labelARRoll.TabIndex = 21;
            this.labelARRoll.Text = "Roll";
            this.labelARRoll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageBook
            // 
            this.tabPageBook.BackColor = System.Drawing.Color.White;
            this.tabPageBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(892, 476);
            this.tabPageBook.TabIndex = 2;
            this.tabPageBook.Text = "Book";
            // 
            // labelARStudentClass
            // 
            this.labelARStudentClass.AutoSize = true;
            this.labelARStudentClass.Location = new System.Drawing.Point(175, 155);
            this.labelARStudentClass.Name = "labelARStudentClass";
            this.labelARStudentClass.Size = new System.Drawing.Size(0, 20);
            this.labelARStudentClass.TabIndex = 26;
            this.labelARStudentClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelARClass
            // 
            this.labelARClass.Location = new System.Drawing.Point(22, 153);
            this.labelARClass.Name = "labelARClass";
            this.labelARClass.Size = new System.Drawing.Size(147, 25);
            this.labelARClass.TabIndex = 25;
            this.labelARClass.Text = "Class";
            this.labelARClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.tabControlStudent);
            this.Controls.Add(this.panelTitlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.panelTitlebar.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMBindingSource)).EndInit();
            this.groupBoxAddStudent.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelAddForm.ResumeLayout(false);
            this.panelAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).EndInit();
            this.tabControlStudent.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddResult.ResumeLayout(false);
            this.tabPageAddResult.PerformLayout();
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
        private System.Windows.Forms.Panel panelAddForm;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.BindingSource classMBindingSource;
        private System.Windows.Forms.BindingSource studentMBindingSource;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelMPhone;
        private System.Windows.Forms.TextBox textBoxMPhone;
        private System.Windows.Forms.Label labelFPhone;
        private System.Windows.Forms.TextBox textBoxFPhone;
        private System.Windows.Forms.Label labelSPhone;
        private System.Windows.Forms.TextBox textBoxSPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn classId;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clas;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn motherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn brn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanentAddress;
        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageAddResult;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.TextBox textBoxARSearch;
        private System.Windows.Forms.Label labelARRoll;
        private System.Windows.Forms.Label labelARName;
        private System.Windows.Forms.Label labelARStudentName;
        private System.Windows.Forms.Label labelARStudentClass;
        private System.Windows.Forms.Label labelARClass;
    }
}