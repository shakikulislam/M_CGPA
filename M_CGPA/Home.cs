using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Home : Form
    {
        private int _x;
        private int _y;
        private Point _point;
        public readonly LanguagePro Language = new LanguagePro();

        public Home()
        {
            InitializeComponent();

            FieldLanguage();


            //Bengali bengali=new Bengali();
            //bengali.Lang();

        }


        public void LoadMenubarLanguage()
        {
            var language = new SelectLanguage();
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

            var frm = form as Form;
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(frm);
                panelBody.Tag = frm;
                frm.Show();
            }
        }

        public void FieldLanguage()
        {

        }

        private void MenuButtonsBackcolor(object activeButton)
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.Transparent;
                }
            }

            var activeBtn = activeButton as Button;
            if (activeBtn != null) activeBtn.BackColor = Color.FromArgb(33, 31, 46);
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
            MenuButtonsBackcolor(buttonSetting);
            ShowForm(new Setting());
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            MenuButtonsBackcolor(buttonStudent);
            ShowForm(new AddStudent());

            var addStudent = new AddStudent();
            addStudent.Size = new Size(740, 540);
            addStudent.Dock = DockStyle.Left;

        }

        private void labelHomeTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _x = MousePosition.X - Location.X;
            _y = MousePosition.Y - Location.Y;
        }

        private void labelHomeTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState == FormWindowState.Normal)
            {
                _point = MousePosition;
                _point.X = _point.X - _x;
                _point.Y = _point.Y - _y;
                Location = _point;
            }
        }



    }
}
