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

        public Home()
        {
            InitializeComponent();

            LoadLanguage();

            timerClock.Start();
            //Bengali bengali=new Bengali();
            //bengali.Lang();

        }


        public void LoadLanguage()
        {
            var language = new SelectLanguage();
            //language.UserLanguage(Settings.Default.Language);

            

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
                frm.BackColor = panelBody.BackColor;
                frm.Show();
            }
        }


        private void MenuButtonsBackcolor(object activeButton)
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.Transparent;
                    control.ForeColor = Color.White;
                }
            }

            var activeBtn = activeButton as Button;
            if (activeBtn != null) activeBtn.BackColor = Color.FromArgb(153, 180, 209);
            if (activeBtn != null) activeBtn.ForeColor = Color.Black;
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

        private void buttonClass_Click(object sender, EventArgs e)
        {
            MenuButtonsBackcolor(buttonClass);
            ShowForm(new Class());

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            MenuButtonsBackcolor(buttonBook);
            ShowForm(new Book());
        }

        private void buttonSyllabus_Click(object sender, EventArgs e)
        {
            MenuButtonsBackcolor(buttonSyllabus);
            ShowForm(new Syllabus());
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();

        }



    }
}
