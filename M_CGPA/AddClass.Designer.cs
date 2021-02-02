namespace M_CGPA
{
    partial class AddClass
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAddClass = new System.Windows.Forms.Panel();
            this.dataGridViewListOfClass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTitlebar.SuspendLayout();
            this.panelAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).BeginInit();
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
            this.panelTitlebar.Size = new System.Drawing.Size(594, 31);
            this.panelTitlebar.TabIndex = 1;
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
            this.labelTitle.Size = new System.Drawing.Size(594, 31);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Add Class";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClassName
            // 
            this.labelClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.ForeColor = System.Drawing.Color.Black;
            this.labelClassName.Location = new System.Drawing.Point(43, 12);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(94, 20);
            this.labelClassName.TabIndex = 2;
            this.labelClassName.Text = "Class Name";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassName.Location = new System.Drawing.Point(144, 9);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(189, 26);
            this.textBoxClassName.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(350, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelAddClass
            // 
            this.panelAddClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddClass.BackColor = System.Drawing.Color.Transparent;
            this.panelAddClass.Controls.Add(this.labelClassName);
            this.panelAddClass.Controls.Add(this.buttonAdd);
            this.panelAddClass.Controls.Add(this.textBoxClassName);
            this.panelAddClass.Location = new System.Drawing.Point(61, 55);
            this.panelAddClass.Name = "panelAddClass";
            this.panelAddClass.Size = new System.Drawing.Size(473, 45);
            this.panelAddClass.TabIndex = 7;
            // 
            // dataGridViewListOfClass
            // 
            this.dataGridViewListOfClass.AllowUserToAddRows = false;
            this.dataGridViewListOfClass.AllowUserToDeleteRows = false;
            this.dataGridViewListOfClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewListOfClass.AutoGenerateColumns = false;
            this.dataGridViewListOfClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewListOfClass.DataSource = this.classMBindingSource;
            this.dataGridViewListOfClass.Location = new System.Drawing.Point(40, 122);
            this.dataGridViewListOfClass.Name = "dataGridViewListOfClass";
            this.dataGridViewListOfClass.ReadOnly = true;
            this.dataGridViewListOfClass.RowHeadersVisible = false;
            this.dataGridViewListOfClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListOfClass.Size = new System.Drawing.Size(515, 200);
            this.dataGridViewListOfClass.TabIndex = 8;
            this.dataGridViewListOfClass.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewListOfClass_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classMBindingSource
            // 
            this.classMBindingSource.DataSource = typeof(M_CGPA.Model.ClassM);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.dataGridViewListOfClass);
            this.Controls.Add(this.panelAddClass);
            this.Controls.Add(this.panelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClass";
            this.panelTitlebar.ResumeLayout(false);
            this.panelAddClass.ResumeLayout(false);
            this.panelAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAddClass;
        private System.Windows.Forms.DataGridView dataGridViewListOfClass;
        private System.Windows.Forms.BindingSource classMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

    }
}