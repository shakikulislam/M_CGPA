using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Model;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Student : Form
    {
        readonly ClassBll _classBll=new ClassBll();
        readonly StudentM _studentM=new StudentM();
        readonly StudentBll _studentBll=new StudentBll();
        readonly SelectLanguage _selectLanguage=new SelectLanguage();

        public Student()
        {
            InitializeComponent();

            SelectLanguage();
            LoadLanguage();

            comboBoxClass.DataSource = _classBll.GetAllClass();
            GetAll();
        }

        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetGroupBoxLabelFont(groupBoxAddStudent, groupBoxFilter);
                new SetPanelLabelFont(panelTitlebar, panelAddForm);
                new SetPanelButtonFont(panelAddForm);

                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Font = new Font(this.Font.Name, 14);
                    }
                }
            }
        }

        private void LoadLanguage()
        {
            labelTitleAddStudent.Text = _selectLanguage.Language.TitleAddStudent;
            groupBoxAddStudent.Text = _selectLanguage.Language.StudentInformation;
            groupBoxFilter.Text = _selectLanguage.Language.BtnSearch;
            labelRoll.Text = _selectLanguage.Language.Roll;
            labelReg.Text = _selectLanguage.Language.Reg;
            labelSession.Text = _selectLanguage.Language.Session;
            labelClass.Text = _selectLanguage.Language.Class;
            labelAdmissionDate.Text = _selectLanguage.Language.AdmissionDate;
            labelStudentName.Text = _selectLanguage.Language.StudentName;
            labelFatherName.Text = _selectLanguage.Language.FatherName;
            labelMotherName.Text = _selectLanguage.Language.MotherName;
            labelDob.Text = _selectLanguage.Language.DOB;
            labelNid.Text = _selectLanguage.Language.NID;
            labelBrn.Text = _selectLanguage.Language.BRN;
            labelPresentAddress.Text = _selectLanguage.Language.PresentAddress;
            labelPermanentAddress.Text = _selectLanguage.Language.PermanenetAddress;
            buttonClear.Text = _selectLanguage.Language.BtnClear;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
        }

        private void GetAll()
        {
            dataGridViewStudentList.DataSource = _studentBll.GetAllByJoin();
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
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRoll.Text != "" && textBoxSName.Text != "" && comboBoxClass.Text != "")
                {
                    _studentM.Roll =Convert.ToInt32(textBoxRoll.Text.Trim());
                    _studentM.Reg = Convert.ToInt32(textBoxReg.Text.Trim());
                    _studentM.ClassId = (int) comboBoxClass.SelectedValue;
                    _studentM.Session = textBoxSession.Text.Trim();
                    _studentM.AdmissionDate = dateTimePickerAdmissionDate.Value;
                    _studentM.Dob = dateTimePickerDob.Value;
                    _studentM.StudentName = textBoxSName.Text.Trim();
                    _studentM.FatherName = textBoxFName.Text.Trim();
                    _studentM.MotherName = textBoxMName.Text.Trim();
                    _studentM.Nid = textBoxNid.Text.Trim();
                    _studentM.Brn = textBoxBRN.Text.Trim();
                    _studentM.PresentAddress = textBoxPresentAddress.Text.Trim();
                    _studentM.PermanentAddress = textBoxPermanentAddress.Text.Trim();

                    var isSaved = _studentBll.Insert(_studentM);
                    if (isSaved)
                    {
                        GetAll();
                        MessageBox.Show(_selectLanguage.Language.SaveSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(_selectLanguage.Language.ErrorMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(_selectLanguage.Language.BlankFiled, _selectLanguage.Language.MessageTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
