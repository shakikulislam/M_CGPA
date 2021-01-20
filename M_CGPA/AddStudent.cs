using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();

            FieldLanguage();
        }

        public void FieldLanguage()
        {
            var language = new SelectLanguage();
            language.UserLanguage(Settings.Default.Language);

            if (language.Language.Language=="Bengali")
            {
                foreach (Control control in groupBoxAcademicInformation.Controls)
                {
                    if (control is Label)
                    {
                        control.Font = new Font(this.Font.Name,16);
                    }
                }

                foreach (Control control in groupBoxStudentInformation.Controls)
                {
                    if (control is Label)
                    {
                        control.Font = new Font(this.Font.Name,16);
                    }
                }

                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Font = new Font(this.Font.Name,14);
                    }
                }
            }

            labelTitleAddStudent.Text =language.Language.TitleAddStudent;
            groupBoxAcademicInformation.Text = language.Language.AcademicInformation;
            groupBoxStudentInformation.Text = language.Language.StudentInformation;
            labelRoll.Text = language.Language.Roll;
            labelReg.Text = language.Language.Reg;
            labelSession.Text = language.Language.Session;
            labelClass.Text = language.Language.Class;
            labelAdmissionDate.Text = language.Language.AdmissionDate;
            labelStudentName.Text = language.Language.StudentName;
            labelFatherName.Text = language.Language.FatherName;
            labelMotherName.Text = language.Language.MotherName;
            labelDob.Text = language.Language.DOB;
            labelNid.Text = language.Language.NID;
            labelBrn.Text = language.Language.BRN;
            labelPresentAddress.Text = language.Language.PresentAddress;
            labelPermanentAddress.Text = language.Language.PermanenetAddress;
            buttonClear.Text = language.Language.BtnClear;
            buttonAdd.Text = language.Language.BtnAdd;
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBoxAcademicInformation.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBoxBase) control).Clear();
                }
            }

            foreach (Control control in groupBoxStudentInformation.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBoxBase) control).Clear();
                }
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
