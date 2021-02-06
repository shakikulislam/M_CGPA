using System;
using System.Windows.Forms;

namespace M_CGPA.Common
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public enum Buttons
        {
            Ok=0, YesNo=1, YesNoCancel=2
        }

        public enum Icons
        {
            Information = 0, Error = 1, Question = 2, Stop = 3, Warning=4
        }

        public CustomMessageBox(string message)
        {
            labelMessage.Text = "";
            labelMessage.Text = message;
        }
        public CustomMessageBox(string message, string title):this(message)
        {
            labelMessageTitle.Text = "";
            labelMessageTitle.Text = title;
        }
        public CustomMessageBox(string message, string title, Buttons button):this(message,title)
        {
            if (Buttons.Ok==button)
            {
                buttonOk.Visible = true;
            }
            else if (Buttons.YesNo==button)
            {
                buttonYes.Visible = true;
                buttonNo.Visible = true;
            }
            else if (Buttons.YesNoCancel==button)
            {
                buttonYes.Visible = true;
                buttonNo.Visible = true;
                buttonCancel.Visible = true;
            }
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
