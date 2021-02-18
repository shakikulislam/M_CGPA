namespace M_CGPA
{
    partial class Book
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBookCode = new System.Windows.Forms.Label();
            this.textBoxBookCode = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewBookList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchForm = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.buttonAddForm = new System.Windows.Forms.Button();
            this.labelBookCodeFilter = new System.Windows.Forms.Label();
            this.textBoxBookCodeFilter = new System.Windows.Forms.TextBox();
            this.labelBookNameFilter = new System.Windows.Forms.Label();
            this.textBoxBookNameFilter = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTitlebar.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).BeginInit();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMBindingSource)).BeginInit();
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
            this.panelTitlebar.Size = new System.Drawing.Size(665, 31);
            this.panelTitlebar.TabIndex = 10;
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
            this.labelTitle.Size = new System.Drawing.Size(665, 31);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Book";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBookName
            // 
            this.labelBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.ForeColor = System.Drawing.Color.Black;
            this.labelBookName.Location = new System.Drawing.Point(41, 38);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(136, 20);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "Book Name";
            this.labelBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(181, 35);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(250, 26);
            this.textBoxBookName.TabIndex = 3;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Controls.Add(this.buttonSearchForm);
            this.panelForm.Controls.Add(this.buttonCancel);
            this.panelForm.Controls.Add(this.labelBookCode);
            this.panelForm.Controls.Add(this.textBoxBookCode);
            this.panelForm.Controls.Add(this.buttonDelete);
            this.panelForm.Controls.Add(this.buttonUpdate);
            this.panelForm.Controls.Add(this.labelBookName);
            this.panelForm.Controls.Add(this.textBoxBookName);
            this.panelForm.Controls.Add(this.buttonAdd);
            this.panelForm.Location = new System.Drawing.Point(96, 57);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(473, 108);
            this.panelForm.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Purple;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(309, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 31);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelBookCode
            // 
            this.labelBookCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookCode.ForeColor = System.Drawing.Color.Black;
            this.labelBookCode.Location = new System.Drawing.Point(42, 6);
            this.labelBookCode.Name = "labelBookCode";
            this.labelBookCode.Size = new System.Drawing.Size(135, 20);
            this.labelBookCode.TabIndex = 15;
            this.labelBookCode.Text = "Book Code";
            this.labelBookCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBookCode
            // 
            this.textBoxBookCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBookCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookCode.Location = new System.Drawing.Point(181, 3);
            this.textBoxBookCode.Name = "textBoxBookCode";
            this.textBoxBookCode.Size = new System.Drawing.Size(250, 26);
            this.textBoxBookCode.TabIndex = 16;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(181, 67);
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
            this.buttonUpdate.Location = new System.Drawing.Point(53, 67);
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
            this.buttonAdd.Location = new System.Drawing.Point(309, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 31);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewBookList
            // 
            this.dataGridViewBookList.AllowUserToAddRows = false;
            this.dataGridViewBookList.AllowUserToDeleteRows = false;
            this.dataGridViewBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewBookList.AutoGenerateColumns = false;
            this.dataGridViewBookList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.code,
            this.name});
            this.dataGridViewBookList.DataSource = this.bookMBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewBookList.Location = new System.Drawing.Point(96, 186);
            this.dataGridViewBookList.Name = "dataGridViewBookList";
            this.dataGridViewBookList.ReadOnly = true;
            this.dataGridViewBookList.RowHeadersVisible = false;
            this.dataGridViewBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookList.Size = new System.Drawing.Size(473, 135);
            this.dataGridViewBookList.TabIndex = 17;
            this.dataGridViewBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookList_CellDoubleClick);
            this.dataGridViewBookList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewBookList_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // buttonSearchForm
            // 
            this.buttonSearchForm.BackColor = System.Drawing.Color.Green;
            this.buttonSearchForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForm.ForeColor = System.Drawing.Color.White;
            this.buttonSearchForm.Location = new System.Drawing.Point(181, 67);
            this.buttonSearchForm.Name = "buttonSearchForm";
            this.buttonSearchForm.Size = new System.Drawing.Size(122, 31);
            this.buttonSearchForm.TabIndex = 27;
            this.buttonSearchForm.Text = "Search";
            this.buttonSearchForm.UseVisualStyleBackColor = false;
            this.buttonSearchForm.Click += new System.EventHandler(this.buttonSearchForm_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.Controls.Add(this.labelBookCodeFilter);
            this.panelFilter.Controls.Add(this.textBoxBookCodeFilter);
            this.panelFilter.Controls.Add(this.labelBookNameFilter);
            this.panelFilter.Controls.Add(this.textBoxBookNameFilter);
            this.panelFilter.Controls.Add(this.buttonAddForm);
            this.panelFilter.Location = new System.Drawing.Point(96, 171);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(473, 108);
            this.panelFilter.TabIndex = 26;
            this.panelFilter.Visible = false;
            // 
            // buttonAddForm
            // 
            this.buttonAddForm.BackColor = System.Drawing.Color.Green;
            this.buttonAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddForm.ForeColor = System.Drawing.Color.White;
            this.buttonAddForm.Location = new System.Drawing.Point(309, 67);
            this.buttonAddForm.Name = "buttonAddForm";
            this.buttonAddForm.Size = new System.Drawing.Size(122, 31);
            this.buttonAddForm.TabIndex = 24;
            this.buttonAddForm.Text = "Add";
            this.buttonAddForm.UseVisualStyleBackColor = false;
            this.buttonAddForm.Click += new System.EventHandler(this.buttonAddForm_Click);
            // 
            // labelBookCodeFilter
            // 
            this.labelBookCodeFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBookCodeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookCodeFilter.ForeColor = System.Drawing.Color.Black;
            this.labelBookCodeFilter.Location = new System.Drawing.Point(42, 6);
            this.labelBookCodeFilter.Name = "labelBookCodeFilter";
            this.labelBookCodeFilter.Size = new System.Drawing.Size(135, 20);
            this.labelBookCodeFilter.TabIndex = 27;
            this.labelBookCodeFilter.Text = "Book Code";
            this.labelBookCodeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBookCodeFilter
            // 
            this.textBoxBookCodeFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBookCodeFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBookCodeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookCodeFilter.Location = new System.Drawing.Point(181, 3);
            this.textBoxBookCodeFilter.Name = "textBoxBookCodeFilter";
            this.textBoxBookCodeFilter.Size = new System.Drawing.Size(250, 26);
            this.textBoxBookCodeFilter.TabIndex = 28;
            this.textBoxBookCodeFilter.TextChanged += new System.EventHandler(this.textBoxBookCodeFilter_TextChanged);
            // 
            // labelBookNameFilter
            // 
            this.labelBookNameFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBookNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookNameFilter.ForeColor = System.Drawing.Color.Black;
            this.labelBookNameFilter.Location = new System.Drawing.Point(41, 38);
            this.labelBookNameFilter.Name = "labelBookNameFilter";
            this.labelBookNameFilter.Size = new System.Drawing.Size(136, 20);
            this.labelBookNameFilter.TabIndex = 25;
            this.labelBookNameFilter.Text = "Book Name";
            this.labelBookNameFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBookNameFilter
            // 
            this.textBoxBookNameFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBookNameFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBookNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookNameFilter.Location = new System.Drawing.Point(181, 35);
            this.textBoxBookNameFilter.Name = "textBoxBookNameFilter";
            this.textBoxBookNameFilter.Size = new System.Drawing.Size(250, 26);
            this.textBoxBookNameFilter.TabIndex = 26;
            this.textBoxBookNameFilter.TextChanged += new System.EventHandler(this.textBoxBookNameFilter_TextChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // code
            // 
            this.code.DataPropertyName = "Code";
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bookMBindingSource
            // 
            this.bookMBindingSource.DataSource = typeof(M_CGPA.Model.BookM);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 440);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridViewBookList);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.Text = "Book";
            this.panelTitlebar.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookList)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource bookMBindingSource;
        private System.Windows.Forms.Label labelBookCode;
        private System.Windows.Forms.TextBox textBoxBookCode;
        private System.Windows.Forms.DataGridView dataGridViewBookList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button buttonSearchForm;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label labelBookCodeFilter;
        private System.Windows.Forms.TextBox textBoxBookCodeFilter;
        private System.Windows.Forms.Label labelBookNameFilter;
        private System.Windows.Forms.TextBox textBoxBookNameFilter;
        private System.Windows.Forms.Button buttonAddForm;
    }
}