namespace M_CGPA
{
    partial class Syllabus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonSearchForm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.bookMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelBook = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.classMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelClass = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.syllabusMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSyllabusList = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.buttonAddForm = new System.Windows.Forms.Button();
            this.comboBoxClassFilter = new System.Windows.Forms.ComboBox();
            this.labelClassFilter = new System.Windows.Forms.Label();
            this.labelYearFilter = new System.Windows.Forms.Label();
            this.textBoxYearFilter = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitlebar.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllabusMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyllabusList)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.Black;
            this.panelTitlebar.Controls.Add(this.labelTitle);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(790, 31);
            this.panelTitlebar.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(790, 31);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Syllabus";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(-3, 11);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(136, 20);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(139, 8);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(189, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Controls.Add(this.comboBoxType);
            this.panelForm.Controls.Add(this.labelType);
            this.panelForm.Controls.Add(this.buttonSearchForm);
            this.panelForm.Controls.Add(this.buttonCancel);
            this.panelForm.Controls.Add(this.comboBoxBook);
            this.panelForm.Controls.Add(this.labelBook);
            this.panelForm.Controls.Add(this.comboBoxClass);
            this.panelForm.Controls.Add(this.labelClass);
            this.panelForm.Controls.Add(this.buttonDelete);
            this.panelForm.Controls.Add(this.buttonUpdate);
            this.panelForm.Controls.Add(this.labelYear);
            this.panelForm.Controls.Add(this.textBoxYear);
            this.panelForm.Controls.Add(this.buttonAdd);
            this.panelForm.Location = new System.Drawing.Point(159, 61);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(473, 156);
            this.panelForm.TabIndex = 14;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Mandatory",
            "Optional"});
            this.comboBoxType.Location = new System.Drawing.Point(138, 116);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(189, 28);
            this.comboBoxType.TabIndex = 27;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Black;
            this.labelType.Location = new System.Drawing.Point(-3, 119);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(135, 20);
            this.labelType.TabIndex = 26;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSearchForm
            // 
            this.buttonSearchForm.BackColor = System.Drawing.Color.Green;
            this.buttonSearchForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForm.ForeColor = System.Drawing.Color.White;
            this.buttonSearchForm.Location = new System.Drawing.Point(334, 6);
            this.buttonSearchForm.Name = "buttonSearchForm";
            this.buttonSearchForm.Size = new System.Drawing.Size(122, 31);
            this.buttonSearchForm.TabIndex = 25;
            this.buttonSearchForm.Text = "Search";
            this.buttonSearchForm.UseVisualStyleBackColor = false;
            this.buttonSearchForm.Click += new System.EventHandler(this.buttonSearchForm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Purple;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(333, 81);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 31);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.DataSource = this.bookMBindingSource;
            this.comboBoxBook.DisplayMember = "Name";
            this.comboBoxBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(139, 82);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(189, 28);
            this.comboBoxBook.TabIndex = 17;
            this.comboBoxBook.ValueMember = "Id";
            // 
            // bookMBindingSource
            // 
            this.bookMBindingSource.DataSource = typeof(M_CGPA.Model.BookM);
            // 
            // labelBook
            // 
            this.labelBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.ForeColor = System.Drawing.Color.Black;
            this.labelBook.Location = new System.Drawing.Point(-2, 85);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(135, 20);
            this.labelBook.TabIndex = 15;
            this.labelBook.Text = "Book";
            this.labelBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DataSource = this.classMBindingSource;
            this.comboBoxClass.DisplayMember = "Name";
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(139, 44);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(189, 28);
            this.comboBoxClass.TabIndex = 17;
            this.comboBoxClass.ValueMember = "Id";
            // 
            // classMBindingSource
            // 
            this.classMBindingSource.DataSource = typeof(M_CGPA.Model.ClassM);
            // 
            // labelClass
            // 
            this.labelClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.Color.Black;
            this.labelClass.Location = new System.Drawing.Point(-2, 47);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(135, 20);
            this.labelClass.TabIndex = 15;
            this.labelClass.Text = "Class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(333, 43);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 31);
            this.buttonDelete.TabIndex = 14;
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
            this.buttonUpdate.Location = new System.Drawing.Point(333, 6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 31);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Navy;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(333, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 31);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // syllabusMBindingSource
            // 
            this.syllabusMBindingSource.DataSource = typeof(M_CGPA.Model.SyllabusM);
            // 
            // dataGridViewSyllabusList
            // 
            this.dataGridViewSyllabusList.AllowUserToAddRows = false;
            this.dataGridViewSyllabusList.AllowUserToDeleteRows = false;
            this.dataGridViewSyllabusList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewSyllabusList.AutoGenerateColumns = false;
            this.dataGridViewSyllabusList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSyllabusList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSyllabusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSyllabusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ids,
            this.years,
            this.classIds,
            this.bookIds,
            this.classs,
            this.books,
            this.Type});
            this.dataGridViewSyllabusList.DataSource = this.syllabusMBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSyllabusList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSyllabusList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewSyllabusList.Location = new System.Drawing.Point(161, 223);
            this.dataGridViewSyllabusList.Name = "dataGridViewSyllabusList";
            this.dataGridViewSyllabusList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSyllabusList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSyllabusList.RowHeadersVisible = false;
            this.dataGridViewSyllabusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSyllabusList.Size = new System.Drawing.Size(473, 168);
            this.dataGridViewSyllabusList.TabIndex = 18;
            this.dataGridViewSyllabusList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSyllabusList_CellDoubleClick);
            this.dataGridViewSyllabusList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSyllabusList_RowPostPaint);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.Controls.Add(this.buttonAddForm);
            this.panelFilter.Controls.Add(this.comboBoxClassFilter);
            this.panelFilter.Controls.Add(this.labelClassFilter);
            this.panelFilter.Controls.Add(this.labelYearFilter);
            this.panelFilter.Controls.Add(this.textBoxYearFilter);
            this.panelFilter.Location = new System.Drawing.Point(298, 277);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(473, 156);
            this.panelFilter.TabIndex = 19;
            this.panelFilter.Visible = false;
            // 
            // buttonAddForm
            // 
            this.buttonAddForm.BackColor = System.Drawing.Color.Green;
            this.buttonAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddForm.ForeColor = System.Drawing.Color.White;
            this.buttonAddForm.Location = new System.Drawing.Point(334, 7);
            this.buttonAddForm.Name = "buttonAddForm";
            this.buttonAddForm.Size = new System.Drawing.Size(122, 31);
            this.buttonAddForm.TabIndex = 24;
            this.buttonAddForm.Text = "Add";
            this.buttonAddForm.UseVisualStyleBackColor = false;
            this.buttonAddForm.Click += new System.EventHandler(this.buttonAddForm_Click);
            // 
            // comboBoxClassFilter
            // 
            this.comboBoxClassFilter.DataSource = this.classMBindingSource;
            this.comboBoxClassFilter.DisplayMember = "Name";
            this.comboBoxClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassFilter.FormattingEnabled = true;
            this.comboBoxClassFilter.Location = new System.Drawing.Point(139, 45);
            this.comboBoxClassFilter.Name = "comboBoxClassFilter";
            this.comboBoxClassFilter.Size = new System.Drawing.Size(189, 28);
            this.comboBoxClassFilter.TabIndex = 23;
            this.comboBoxClassFilter.ValueMember = "Id";
            this.comboBoxClassFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassFilter_SelectedIndexChanged);
            // 
            // labelClassFilter
            // 
            this.labelClassFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClassFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassFilter.ForeColor = System.Drawing.Color.Black;
            this.labelClassFilter.Location = new System.Drawing.Point(-2, 48);
            this.labelClassFilter.Name = "labelClassFilter";
            this.labelClassFilter.Size = new System.Drawing.Size(135, 20);
            this.labelClassFilter.TabIndex = 21;
            this.labelClassFilter.Text = "Class";
            this.labelClassFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYearFilter
            // 
            this.labelYearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearFilter.ForeColor = System.Drawing.Color.Black;
            this.labelYearFilter.Location = new System.Drawing.Point(-3, 12);
            this.labelYearFilter.Name = "labelYearFilter";
            this.labelYearFilter.Size = new System.Drawing.Size(136, 20);
            this.labelYearFilter.TabIndex = 18;
            this.labelYearFilter.Text = "Year";
            this.labelYearFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxYearFilter
            // 
            this.textBoxYearFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxYearFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYearFilter.Location = new System.Drawing.Point(139, 9);
            this.textBoxYearFilter.Name = "textBoxYearFilter";
            this.textBoxYearFilter.Size = new System.Drawing.Size(189, 26);
            this.textBoxYearFilter.TabIndex = 19;
            this.textBoxYearFilter.TextChanged += new System.EventHandler(this.textBoxYearFilter_TextChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // ids
            // 
            this.ids.DataPropertyName = "Id";
            this.ids.HeaderText = "Id";
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            this.ids.Visible = false;
            // 
            // years
            // 
            this.years.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.years.DataPropertyName = "Year";
            this.years.HeaderText = "Year";
            this.years.Name = "years";
            this.years.ReadOnly = true;
            this.years.Width = 54;
            // 
            // classIds
            // 
            this.classIds.DataPropertyName = "ClassId";
            this.classIds.HeaderText = "ClassId";
            this.classIds.Name = "classIds";
            this.classIds.ReadOnly = true;
            this.classIds.Visible = false;
            // 
            // bookIds
            // 
            this.bookIds.DataPropertyName = "BookId";
            this.bookIds.HeaderText = "BookId";
            this.bookIds.Name = "bookIds";
            this.bookIds.ReadOnly = true;
            this.bookIds.Visible = false;
            // 
            // classs
            // 
            this.classs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classs.DataPropertyName = "Class";
            this.classs.HeaderText = "Class";
            this.classs.Name = "classs";
            this.classs.ReadOnly = true;
            this.classs.Width = 57;
            // 
            // books
            // 
            this.books.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.books.DataPropertyName = "Book";
            this.books.HeaderText = "Book";
            this.books.Name = "books";
            this.books.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 56;
            // 
            // Syllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 408);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridViewSyllabusList);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Syllabus";
            this.Text = "Syllabus";
            this.panelTitlebar.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllabusMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyllabusList)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource classMBindingSource;
        private System.Windows.Forms.BindingSource bookMBindingSource;
        private System.Windows.Forms.BindingSource syllabusMBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSyllabusList;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox comboBoxClassFilter;
        private System.Windows.Forms.Label labelClassFilter;
        private System.Windows.Forms.Label labelYearFilter;
        private System.Windows.Forms.TextBox textBoxYearFilter;
        private System.Windows.Forms.Button buttonSearchForm;
        private System.Windows.Forms.Button buttonAddForm;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn years;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn classs;
        private System.Windows.Forms.DataGridViewTextBoxColumn books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}