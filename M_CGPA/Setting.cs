using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Setting : Form
    {
        LanguageBll _bll=new LanguageBll();
        public Point FormCurrentPoint;
        


        public Setting()
        {
            InitializeComponent();

            comboBoxLanguage.DataSource = _bll.LanguageList();
            label1.Text = "Your Server Name is: " + Environment.MachineName;
        }



        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            FormCurrentPoint= new Point(-e.X, -e.Y);
        }

        private void panelTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                var mousePosition = MousePosition;
                mousePosition.Offset(FormCurrentPoint.X,FormCurrentPoint.Y);
                Location = mousePosition;
            }
        }

        private void buttonChangeLanguage_Click(object sender, EventArgs e)
        {
            var languageId = comboBoxLanguage.SelectedValue;
            Settings.Default.Language = (int) languageId;
            Settings.Default.Save();
            Application.Restart();
        }

    }
}
