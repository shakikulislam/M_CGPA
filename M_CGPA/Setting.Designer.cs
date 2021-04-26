namespace M_CGPA
{
    partial class Setting
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
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.languageMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonChangeLanguage = new System.Windows.Forms.Button();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelGPForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGPMinimum = new System.Windows.Forms.TextBox();
            this.buttonGPDelete = new System.Windows.Forms.Button();
            this.buttonGPUpdate = new System.Windows.Forms.Button();
            this.buttonGPAdd = new System.Windows.Forms.Button();
            this.textBoxGPMaximum = new System.Windows.Forms.TextBox();
            this.textBoxGPGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGPPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGPList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePointMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.languageMBindingSource)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelGPForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGPList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradePointMBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.Location = new System.Drawing.Point(18, 47);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(130, 20);
            this.labelLanguage.TabIndex = 12;
            this.labelLanguage.Text = "Select Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DataSource = this.languageMBindingSource;
            this.comboBoxLanguage.DisplayMember = "Name";
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(154, 44);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(172, 28);
            this.comboBoxLanguage.TabIndex = 13;
            this.comboBoxLanguage.ValueMember = "Id";
            // 
            // languageMBindingSource
            // 
            this.languageMBindingSource.DataSource = typeof(M_CGPA.Model.LanguageM);
            // 
            // buttonChangeLanguage
            // 
            this.buttonChangeLanguage.BackColor = System.Drawing.Color.Black;
            this.buttonChangeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeLanguage.ForeColor = System.Drawing.Color.White;
            this.buttonChangeLanguage.Location = new System.Drawing.Point(174, 91);
            this.buttonChangeLanguage.Name = "buttonChangeLanguage";
            this.buttonChangeLanguage.Size = new System.Drawing.Size(152, 31);
            this.buttonChangeLanguage.TabIndex = 11;
            this.buttonChangeLanguage.Text = "Change Language";
            this.buttonChangeLanguage.UseVisualStyleBackColor = false;
            this.buttonChangeLanguage.Click += new System.EventHandler(this.buttonChangeLanguage_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.Black;
            this.panelTitlebar.Controls.Add(this.labelTitle);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(778, 31);
            this.panelTitlebar.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(778, 31);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Setting";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSettings.Location = new System.Drawing.Point(23, 23);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(752, 433);
            this.tabControlSettings.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelLanguage);
            this.tabPage1.Controls.Add(this.buttonChangeLanguage);
            this.tabPage1.Controls.Add(this.comboBoxLanguage);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panelGPForm);
            this.tabPage2.Controls.Add(this.dataGridViewGPList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grade Point";
            // 
            // panelGPForm
            // 
            this.panelGPForm.Controls.Add(this.label2);
            this.panelGPForm.Controls.Add(this.textBoxGPMinimum);
            this.panelGPForm.Controls.Add(this.buttonGPDelete);
            this.panelGPForm.Controls.Add(this.buttonGPUpdate);
            this.panelGPForm.Controls.Add(this.buttonGPAdd);
            this.panelGPForm.Controls.Add(this.textBoxGPMaximum);
            this.panelGPForm.Controls.Add(this.textBoxGPGrade);
            this.panelGPForm.Controls.Add(this.label4);
            this.panelGPForm.Controls.Add(this.textBoxGPPoint);
            this.panelGPForm.Controls.Add(this.label3);
            this.panelGPForm.Controls.Add(this.label1);
            this.panelGPForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGPForm.Location = new System.Drawing.Point(3, 3);
            this.panelGPForm.Name = "panelGPForm";
            this.panelGPForm.Size = new System.Drawing.Size(738, 165);
            this.panelGPForm.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Range of Marks\r\n(percentance)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGPMinimum
            // 
            this.textBoxGPMinimum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGPMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGPMinimum.Location = new System.Drawing.Point(118, 71);
            this.textBoxGPMinimum.Name = "textBoxGPMinimum";
            this.textBoxGPMinimum.Size = new System.Drawing.Size(80, 26);
            this.textBoxGPMinimum.TabIndex = 0;
            // 
            // buttonGPDelete
            // 
            this.buttonGPDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGPDelete.BackColor = System.Drawing.Color.Red;
            this.buttonGPDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGPDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGPDelete.ForeColor = System.Drawing.Color.White;
            this.buttonGPDelete.Location = new System.Drawing.Point(243, 118);
            this.buttonGPDelete.Name = "buttonGPDelete";
            this.buttonGPDelete.Size = new System.Drawing.Size(122, 31);
            this.buttonGPDelete.TabIndex = 29;
            this.buttonGPDelete.Text = "Delete";
            this.buttonGPDelete.UseVisualStyleBackColor = false;
            // 
            // buttonGPUpdate
            // 
            this.buttonGPUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGPUpdate.BackColor = System.Drawing.Color.Blue;
            this.buttonGPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGPUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGPUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonGPUpdate.Location = new System.Drawing.Point(371, 118);
            this.buttonGPUpdate.Name = "buttonGPUpdate";
            this.buttonGPUpdate.Size = new System.Drawing.Size(122, 31);
            this.buttonGPUpdate.TabIndex = 29;
            this.buttonGPUpdate.Text = "Update";
            this.buttonGPUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonGPAdd
            // 
            this.buttonGPAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGPAdd.BackColor = System.Drawing.Color.Green;
            this.buttonGPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGPAdd.ForeColor = System.Drawing.Color.White;
            this.buttonGPAdd.Location = new System.Drawing.Point(499, 118);
            this.buttonGPAdd.Name = "buttonGPAdd";
            this.buttonGPAdd.Size = new System.Drawing.Size(122, 31);
            this.buttonGPAdd.TabIndex = 29;
            this.buttonGPAdd.Text = "Add";
            this.buttonGPAdd.UseVisualStyleBackColor = false;
            this.buttonGPAdd.Click += new System.EventHandler(this.buttonGPAdd_Click);
            // 
            // textBoxGPMaximum
            // 
            this.textBoxGPMaximum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGPMaximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGPMaximum.Location = new System.Drawing.Point(246, 71);
            this.textBoxGPMaximum.Name = "textBoxGPMaximum";
            this.textBoxGPMaximum.Size = new System.Drawing.Size(80, 26);
            this.textBoxGPMaximum.TabIndex = 0;
            // 
            // textBoxGPGrade
            // 
            this.textBoxGPGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGPGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGPGrade.Location = new System.Drawing.Point(469, 36);
            this.textBoxGPGrade.Name = "textBoxGPGrade";
            this.textBoxGPGrade.Size = new System.Drawing.Size(152, 26);
            this.textBoxGPGrade.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Point";
            // 
            // textBoxGPPoint
            // 
            this.textBoxGPPoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxGPPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGPPoint.Location = new System.Drawing.Point(469, 68);
            this.textBoxGPPoint.Name = "textBoxGPPoint";
            this.textBoxGPPoint.Size = new System.Drawing.Size(152, 26);
            this.textBoxGPPoint.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grade";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "<=>";
            // 
            // dataGridViewGPList
            // 
            this.dataGridViewGPList.AllowUserToAddRows = false;
            this.dataGridViewGPList.AllowUserToDeleteRows = false;
            this.dataGridViewGPList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewGPList.AutoGenerateColumns = false;
            this.dataGridViewGPList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGPList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idDataGridViewTextBoxColumn,
            this.minimumDataGridViewTextBoxColumn,
            this.maximumDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn});
            this.dataGridViewGPList.DataSource = this.gradePointMBindingSource;
            this.dataGridViewGPList.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewGPList.Location = new System.Drawing.Point(105, 210);
            this.dataGridViewGPList.Name = "dataGridViewGPList";
            this.dataGridViewGPList.ReadOnly = true;
            this.dataGridViewGPList.RowHeadersVisible = false;
            this.dataGridViewGPList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGPList.Size = new System.Drawing.Size(534, 152);
            this.dataGridViewGPList.TabIndex = 30;
            this.dataGridViewGPList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewGPList_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // minimumDataGridViewTextBoxColumn
            // 
            this.minimumDataGridViewTextBoxColumn.DataPropertyName = "Minimum";
            this.minimumDataGridViewTextBoxColumn.HeaderText = "Minimum";
            this.minimumDataGridViewTextBoxColumn.Name = "minimumDataGridViewTextBoxColumn";
            this.minimumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximumDataGridViewTextBoxColumn
            // 
            this.maximumDataGridViewTextBoxColumn.DataPropertyName = "Maximum";
            this.maximumDataGridViewTextBoxColumn.HeaderText = "Maximum";
            this.maximumDataGridViewTextBoxColumn.Name = "maximumDataGridViewTextBoxColumn";
            this.maximumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 79;
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.HeaderText = "Point";
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            this.pointDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointDataGridViewTextBoxColumn.Width = 70;
            // 
            // gradePointMBindingSource
            // 
            this.gradePointMBindingSource.DataSource = typeof(M_CGPA.Model.GradePointM);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabControlSettings, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 459);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageMBindingSource)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelGPForm.ResumeLayout(false);
            this.panelGPForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGPList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradePointMBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonChangeLanguage;
        private System.Windows.Forms.BindingSource languageMBindingSource;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGPMaximum;
        private System.Windows.Forms.TextBox textBoxGPMinimum;
        private System.Windows.Forms.Button buttonGPAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGPPoint;
        private System.Windows.Forms.TextBox textBoxGPGrade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewGPList;
        private System.Windows.Forms.Panel panelGPForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gradePointMBindingSource;
        private System.Windows.Forms.Button buttonGPDelete;
        private System.Windows.Forms.Button buttonGPUpdate;
    }
}