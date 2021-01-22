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
            this.labelTitlebar = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.Black;
            this.panelTitlebar.Controls.Add(this.labelTitlebar);
            this.panelTitlebar.Controls.Add(this.labelClose);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(390, 31);
            this.panelTitlebar.TabIndex = 7;
            // 
            // labelTitlebar
            // 
            this.labelTitlebar.AutoSize = true;
            this.labelTitlebar.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlebar.ForeColor = System.Drawing.Color.White;
            this.labelTitlebar.Location = new System.Drawing.Point(3, 2);
            this.labelTitlebar.Name = "labelTitlebar";
            this.labelTitlebar.Size = new System.Drawing.Size(74, 24);
            this.labelTitlebar.TabIndex = 2;
            this.labelTitlebar.Text = "Setting";
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Red;
            this.labelClose.Location = new System.Drawing.Point(366, 7);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 16);
            this.labelClose.TabIndex = 2;
            this.labelClose.Tag = "";
            this.labelClose.Text = "X";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.panelTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClass";
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label labelTitlebar;
        private System.Windows.Forms.Label labelClose;
    }
}