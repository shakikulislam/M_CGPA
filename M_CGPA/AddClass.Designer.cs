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
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAddClass = new System.Windows.Forms.Panel();
            this.panelTitlebar.SuspendLayout();
            this.panelAddClass.SuspendLayout();
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
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.labelClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.labelClassName.Location = new System.Drawing.Point(43, 12);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(94, 20);
            this.labelClassName.TabIndex = 2;
            this.labelClassName.Text = "Class Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 3;
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
            // 
            // panelAddClass
            // 
            this.panelAddClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddClass.BackColor = System.Drawing.Color.Transparent;
            this.panelAddClass.Controls.Add(this.labelClassName);
            this.panelAddClass.Controls.Add(this.buttonAdd);
            this.panelAddClass.Controls.Add(this.textBox1);
            this.panelAddClass.Location = new System.Drawing.Point(61, 55);
            this.panelAddClass.Name = "panelAddClass";
            this.panelAddClass.Size = new System.Drawing.Size(473, 45);
            this.panelAddClass.TabIndex = 7;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.panelAddClass);
            this.Controls.Add(this.panelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClass";
            this.panelTitlebar.ResumeLayout(false);
            this.panelAddClass.ResumeLayout(false);
            this.panelAddClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAddClass;

    }
}