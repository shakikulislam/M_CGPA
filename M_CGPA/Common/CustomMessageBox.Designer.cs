﻿namespace M_CGPA.Common
{
    partial class CustomMessageBox
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
            this.bunifuCardsTitle = new Bunifu.Framework.UI.BunifuCards();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMessageTitle = new System.Windows.Forms.Label();
            this.bunifuDragControlMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlMessage = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlIcon = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControlTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelButtonBox = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.bunifuDragControlButtonPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCardsTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCardsTitle
            // 
            this.bunifuCardsTitle.BackColor = System.Drawing.Color.White;
            this.bunifuCardsTitle.BorderRadius = 0;
            this.bunifuCardsTitle.BottomSahddow = true;
            this.bunifuCardsTitle.color = System.Drawing.Color.Navy;
            this.bunifuCardsTitle.Controls.Add(this.labelMessageTitle);
            this.bunifuCardsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCardsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCardsTitle.LeftSahddow = false;
            this.bunifuCardsTitle.Location = new System.Drawing.Point(0, 0);
            this.bunifuCardsTitle.Name = "bunifuCardsTitle";
            this.bunifuCardsTitle.RightSahddow = true;
            this.bunifuCardsTitle.ShadowDepth = 20;
            this.bunifuCardsTitle.Size = new System.Drawing.Size(389, 40);
            this.bunifuCardsTitle.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Location = new System.Drawing.Point(70, 55);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(307, 79);
            this.labelMessage.TabIndex = 17;
            this.labelMessage.Text = "label1";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 55);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIcon.TabIndex = 16;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYes.ForeColor = System.Drawing.Color.Black;
            this.buttonYes.Location = new System.Drawing.Point(291, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(74, 31);
            this.buttonYes.TabIndex = 15;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.Black;
            this.buttonOk.Location = new System.Drawing.Point(217, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(74, 31);
            this.buttonOk.TabIndex = 15;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(143, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 31);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMessageTitle
            // 
            this.labelMessageTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMessageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.labelMessageTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMessageTitle.Name = "labelMessageTitle";
            this.labelMessageTitle.Size = new System.Drawing.Size(389, 40);
            this.labelMessageTitle.TabIndex = 1;
            this.labelMessageTitle.Text = "label1";
            this.labelMessageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControlMain
            // 
            this.bunifuDragControlMain.Fixed = true;
            this.bunifuDragControlMain.Horizontal = true;
            this.bunifuDragControlMain.TargetControl = this;
            this.bunifuDragControlMain.Vertical = true;
            // 
            // bunifuDragControlMessage
            // 
            this.bunifuDragControlMessage.Fixed = true;
            this.bunifuDragControlMessage.Horizontal = true;
            this.bunifuDragControlMessage.TargetControl = this.labelMessage;
            this.bunifuDragControlMessage.Vertical = true;
            // 
            // bunifuDragControlIcon
            // 
            this.bunifuDragControlIcon.Fixed = true;
            this.bunifuDragControlIcon.Horizontal = true;
            this.bunifuDragControlIcon.TargetControl = this.pictureBoxIcon;
            this.bunifuDragControlIcon.Vertical = true;
            // 
            // bunifuDragControlTitle
            // 
            this.bunifuDragControlTitle.Fixed = true;
            this.bunifuDragControlTitle.Horizontal = true;
            this.bunifuDragControlTitle.TargetControl = this.labelMessageTitle;
            this.bunifuDragControlTitle.Vertical = true;
            // 
            // panelButtonBox
            // 
            this.panelButtonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtonBox.Controls.Add(this.buttonNo);
            this.panelButtonBox.Controls.Add(this.buttonCancel);
            this.panelButtonBox.Controls.Add(this.buttonOk);
            this.panelButtonBox.Controls.Add(this.buttonYes);
            this.panelButtonBox.Location = new System.Drawing.Point(12, 150);
            this.panelButtonBox.Name = "panelButtonBox";
            this.panelButtonBox.Size = new System.Drawing.Size(365, 31);
            this.panelButtonBox.TabIndex = 18;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Transparent;
            this.buttonNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNo.ForeColor = System.Drawing.Color.Black;
            this.buttonNo.Location = new System.Drawing.Point(69, 0);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(74, 31);
            this.buttonNo.TabIndex = 16;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Visible = false;
            // 
            // bunifuDragControlButtonPanel
            // 
            this.bunifuDragControlButtonPanel.Fixed = true;
            this.bunifuDragControlButtonPanel.Horizontal = true;
            this.bunifuDragControlButtonPanel.TargetControl = this.panelButtonBox;
            this.bunifuDragControlButtonPanel.Vertical = true;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 193);
            this.Controls.Add(this.panelButtonBox);
            this.Controls.Add(this.bunifuCardsTitle);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBoxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.bunifuCardsTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCardsTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMain;
        private System.Windows.Forms.Label labelMessageTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonOk;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlMessage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlIcon;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlTitle;
        private System.Windows.Forms.Panel panelButtonBox;
        private System.Windows.Forms.Button buttonNo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlButtonPanel;
    }
}