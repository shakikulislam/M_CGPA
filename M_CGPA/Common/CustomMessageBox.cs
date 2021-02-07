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

        public void Show(string message)
        {
            labelMessageTitle.Text = "";
            labelMessage.Text = "";
            labelMessage.Text = message;
            buttonOk.Visible = true;
        }

        public void Show(string message, string title)
        {
            labelMessage.Text = "";
            labelMessage.Text = message;
            labelMessageTitle.Text = "";
            labelMessageTitle.Text = title;
            buttonOk.Visible = true;
        }

        public void Show(string message, string title, Buttons button)       
        {

            labelMessage.Text = "";
            labelMessage.Text = message;
            labelMessageTitle.Text = "";
            labelMessageTitle.Text = title;

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
