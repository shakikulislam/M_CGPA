using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();

            FieldLanguage();
        }

        public void FieldLanguage()
        {
            var selectLanguage = new SelectLanguage();
            selectLanguage.UserLanguage();

            if (selectLanguage.Language.Language=="Bengali")
            {

                new SetGroupBoxLabelFont(groupBoxAddStudent,groupBoxFilter);
                new SetPanelLabelFont(panelTitlebar,panelAddForm);
                new SetPanelButtonFont(panelAddForm);

                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Font = new Font(this.Font.Name, 14);
                    }
                }
            }

            labelTitleAddStudent.Text =selectLanguage.Language.TitleAddStudent;
            groupBoxAddStudent.Text = selectLanguage.Language.AcademicInformation;
            groupBoxFilter.Text = selectLanguage.Language.BtnSearch;
            labelRoll.Text = selectLanguage.Language.Roll;
            labelReg.Text = selectLanguage.Language.Reg;
            labelSession.Text = selectLanguage.Language.Session;
            labelClass.Text = selectLanguage.Language.Class;
            labelAdmissionDate.Text = selectLanguage.Language.AdmissionDate;
            labelStudentName.Text = selectLanguage.Language.StudentName;
            labelFatherName.Text = selectLanguage.Language.FatherName;
            labelMotherName.Text = selectLanguage.Language.MotherName;
            labelDob.Text = selectLanguage.Language.DOB;
            labelNid.Text = selectLanguage.Language.NID;
            labelBrn.Text = selectLanguage.Language.BRN;
            labelPresentAddress.Text = selectLanguage.Language.PresentAddress;
            labelPermanentAddress.Text = selectLanguage.Language.PermanenetAddress;
            buttonClear.Text = selectLanguage.Language.BtnClear;
            buttonAdd.Text = selectLanguage.Language.BtnAdd;
        }

        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBoxAddStudent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBoxBase) control).Clear();
                }
            }

            foreach (Control control in groupBoxFilter.Controls)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }


    }
}
