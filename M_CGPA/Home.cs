using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Home : Form
    {
        public Point FormLocationPoint;

        public Home()
        {
            InitializeComponent();

            LoadMenubarLanguage();
            FieldLanguage();


            //Bengali bengali=new Bengali();
            //bengali.Lang();

        }

        public readonly LanguagePro Language = new LanguagePro();
        public void LoadMenubarLanguage()
        {
            var language=new SelectLanguage();
            language.UserLanguage(Settings.Default.Language);

            //fileToolStripMenuItem.Text = language.Language.MenuFile;
            //exitToolStripMenuItem.Text = language.Language.MenuFileExit;
            //insertToolStripMenuItem.Text = language.Language.MenuInsert;
            //studentToolStripMenuItem.Text = language.Language.MenuInsertStudent;
            //classToolStripMenuItem.Text = language.Language.MenuInsertClass;
            //markToolStripMenuItem.Text = language.Language.MenuInsertMark;
            //reportToolStripMenuItem.Text = language.Language.MenuReport;
            //reportStudentToolStripMenuItem.Text = language.Language.MenuReportStudent;
            //reportResultToolStripMenuItem.Text = language.Language.MenuReportResult;
            //settingToolStripMenuItem.Text = language.Language.MenuSetting;
            //helpToolStripMenuItem.Text = language.Language.MenuHelp;
            
        }

        private void ShowForm(object form)
        {
            if (panelBody.Controls.Count > 0)
            {
                panelBody.Controls.RemoveAt(0);
            }

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(frm);
            panelBody.Tag = frm;
            frm.Show();

        }

        public void FieldLanguage()
        {
            
        }

        private void studentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //var student=new FormAddStudent();
            //student.ShowDialog();
            ShowForm(new FormAddStudent());
        }

        

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormLocationPoint = new Point(-e.X, -e.Y);
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState==FormWindowState.Normal)
            {
                //Point point = MousePosition;
                var point = MousePosition;
                point.Offset(FormLocationPoint.X, FormLocationPoint.Y);
                Location = point;

            }
        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ResetMenuButtonBackcolor();
            ShowForm(new FormSetting());
            buttonSetting.BackColor = Color.FromArgb(33, 31, 46);
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            ResetMenuButtonBackcolor();
            ShowForm(new FormAddStudent());
            buttonStudent.BackColor = Color.FromArgb(33, 31, 46);

        }

        private void ResetMenuButtonBackcolor()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor= Color.Transparent;
                }
            }
        }


    }
}
