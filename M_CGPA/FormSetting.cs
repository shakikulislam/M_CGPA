using System;
using System.Drawing;
using System.Windows.Forms;

namespace M_CGPA
{
    public partial class FormSetting : Form
    {
        public Point FormCurrentPoint;
        public FormSetting()
        {
            InitializeComponent();
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

    }
}
