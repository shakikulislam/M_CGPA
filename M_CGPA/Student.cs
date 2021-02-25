using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Model;

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
            labelSPhone.Text = _selectLanguage.Language.Phone;
            labelFatherName.Text = _selectLanguage.Language.FatherName;
            labelFPhone.Text = _selectLanguage.Language.Phone;
            labelMotherName.Text = _selectLanguage.Language.MotherName;
            labelMPhone.Text = _selectLanguage.Language.Phone;
            labelDob.Text = _selectLanguage.Language.DOB;
            labelNid.Text = _selectLanguage.Language.NID;
            labelBrn.Text = _selectLanguage.Language.BRN;
            labelPresentAddress.Text = _selectLanguage.Language.PresentAddress;
            labelPermanentAddress.Text = _selectLanguage.Language.PermanenetAddress;
            buttonClear.Text = _selectLanguage.Language.BtnClear;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
            labelSearch.Text = _selectLanguage.Language.Search;
        }

        private void GetAll()
        {
            dataGridViewStudentList.DataSource = _studentBll.GetAllByJoin();
        }

        private void ClearFields()
        {
            foreach (Control control in panelAddForm.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBoxBase)control).Clear();
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRoll.Text != "" && textBoxSName.Text != "" && comboBoxClass.Text != "" && textBoxFPhone.Text!="")
                {
                    _studentM.Roll =Convert.ToInt32(textBoxRoll.Text.Trim());
                    _studentM.Reg = Convert.ToInt32(textBoxReg.Text.Trim());
                    _studentM.ClassId = (int) comboBoxClass.SelectedValue;
                    _studentM.Session = textBoxSession.Text.Trim();
                    _studentM.AdmissionDate = dateTimePickerAdmissionDate.Value;
                    _studentM.Dob = dateTimePickerDob.Value;
                    _studentM.StudentName = textBoxSName.Text.Trim();
                    _studentM.SPhone = textBoxSPhone.Text.Trim();
                    _studentM.FatherName = textBoxFName.Text.Trim();
                    _studentM.FPhone = textBoxFPhone.Text.Trim();
                    _studentM.MotherName = textBoxMName.Text.Trim();
                    _studentM.MPhone = textBoxMPhone.Text.Trim();
                    _studentM.Nid = textBoxNid.Text.Trim();
                    _studentM.Brn = textBoxBRN.Text.Trim();
                    _studentM.PresentAddress = textBoxPresentAddress.Text.Trim();
                    _studentM.PermanentAddress = textBoxPermanentAddress.Text.Trim();

                    var isSaved = _studentBll.Insert(_studentM);
                    if (isSaved)
                    {
                        MessageBox.Show(_selectLanguage.Language.SaveSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        GetAll();

                        ClearFields();
                        
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_selectLanguage.Language.DeleteConfirmation, _selectLanguage.Language.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var isDelete = _studentBll.Delete(_studentM);
                if (isDelete)
                {
                    GetAll();
                    MessageBox.Show(_selectLanguage.Language.DeleteSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    comboBoxClass.SelectedValue = 0;

                    buttonDelete.Visible = false;
                    buttonUpdate.Visible = false;
                    buttonCancel.Visible = false;
                    buttonClear.Visible = true;
                    buttonAdd.Visible = true;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRoll.Text != "" && textBoxSName.Text != "" && comboBoxClass.Text != "" && textBoxFPhone.Text!="")
                {
                    _studentM.Roll = Convert.ToInt32(textBoxRoll.Text.Trim());
                    _studentM.Reg = Convert.ToInt32(textBoxReg.Text.Trim());
                    _studentM.ClassId = (int)comboBoxClass.SelectedValue;
                    _studentM.Session = textBoxSession.Text.Trim();
                    _studentM.AdmissionDate = dateTimePickerAdmissionDate.Value;
                    _studentM.Dob = dateTimePickerDob.Value;
                    _studentM.StudentName = textBoxSName.Text.Trim();
                    _studentM.SPhone = textBoxSPhone.Text.Trim();
                    _studentM.FatherName = textBoxFName.Text.Trim();
                    _studentM.FPhone = textBoxFPhone.Text.Trim();
                    _studentM.MotherName = textBoxMName.Text.Trim();
                    _studentM.MPhone = textBoxMPhone.Text.Trim();
                    _studentM.Nid = textBoxNid.Text.Trim();
                    _studentM.Brn = textBoxBRN.Text.Trim();
                    _studentM.PresentAddress = textBoxPresentAddress.Text.Trim();
                    _studentM.PermanentAddress = textBoxPermanentAddress.Text.Trim();

                    var isUpdate = _studentBll.Update(_studentM);
                    if (isUpdate)
                    {
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        GetAll();
                        
                        ClearFields();
                        buttonDelete.Visible = false;
                        buttonUpdate.Visible = false;
                        buttonCancel.Visible = false;
                        buttonClear.Visible = true;
                        buttonAdd.Visible = true;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            buttonDelete.Visible = false;
            buttonUpdate.Visible = false;
            buttonCancel.Visible = false;
            buttonClear.Visible = true;
            buttonAdd.Visible = true;

        }

        private void dataGridViewStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStudentList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();

            _studentM.Id = Convert.ToInt32(dataGridViewStudentList.Rows[e.RowIndex].Cells["id"].Value);
            _studentM.Roll = Convert.ToInt32(dataGridViewStudentList.Rows[e.RowIndex].Cells["roll"].Value);
            _studentM.Reg = Convert.ToInt32(dataGridViewStudentList.Rows[e.RowIndex].Cells["reg"].Value);
            _studentM.ClassId = Convert.ToInt32(dataGridViewStudentList.Rows[e.RowIndex].Cells["classId"].Value);
            _studentM.Class = dataGridViewStudentList.Rows[e.RowIndex].Cells["clas"].Value.ToString();
            _studentM.Session = dataGridViewStudentList.Rows[e.RowIndex].Cells["session"].Value.ToString();
            _studentM.AdmissionDate = Convert.ToDateTime(dataGridViewStudentList.Rows[e.RowIndex].Cells["admissionDate"].Value);
            _studentM.Dob = Convert.ToDateTime(dataGridViewStudentList.Rows[e.RowIndex].Cells["dob"].Value);
            _studentM.StudentName = dataGridViewStudentList.Rows[e.RowIndex].Cells["studentName"].Value.ToString();
            _studentM.SPhone = dataGridViewStudentList.Rows[e.RowIndex].Cells["sPhone"].Value.ToString();
            _studentM.FatherName = dataGridViewStudentList.Rows[e.RowIndex].Cells["fatherName"].Value.ToString();
            _studentM.FPhone = dataGridViewStudentList.Rows[e.RowIndex].Cells["fPhone"].Value.ToString();
            _studentM.MotherName = dataGridViewStudentList.Rows[e.RowIndex].Cells["motherName"].Value.ToString();
            _studentM.MPhone = dataGridViewStudentList.Rows[e.RowIndex].Cells["mPhone"].Value.ToString();
            _studentM.Nid = dataGridViewStudentList.Rows[e.RowIndex].Cells["nid"].Value.ToString();
            _studentM.Brn = dataGridViewStudentList.Rows[e.RowIndex].Cells["brn"].Value.ToString();
            _studentM.PresentAddress = dataGridViewStudentList.Rows[e.RowIndex].Cells["presentAddress"].Value.ToString();
            _studentM.PermanentAddress = dataGridViewStudentList.Rows[e.RowIndex].Cells["permanentAddress"].Value.ToString();

            textBoxRoll.Text = _studentM.Roll.ToString();
            comboBoxClass.SelectedValue = _studentM.ClassId;
            textBoxReg.Text = _studentM.Reg.ToString();
            textBoxSession.Text = _studentM.Session;
            dateTimePickerAdmissionDate.Value = _studentM.AdmissionDate;
            dateTimePickerDob.Value = _studentM.Dob;
            textBoxSName.Text = _studentM.StudentName;
            textBoxSPhone.Text = _studentM.SPhone;
            textBoxFName.Text = _studentM.FatherName;
            textBoxFPhone.Text = _studentM.FPhone;
            textBoxMName.Text = _studentM.MotherName;
            textBoxMPhone.Text = _studentM.MPhone;
            textBoxNid.Text = _studentM.Nid;
            textBoxBRN.Text = _studentM.Brn;
            textBoxPresentAddress.Text = _studentM.PresentAddress;
            textBoxPermanentAddress.Text = _studentM.PermanentAddress;


            buttonDelete.Visible = true;
            buttonUpdate.Visible = true;
            buttonCancel.Visible = true;
            buttonClear.Visible = false;
            buttonAdd.Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxSearch.Text;
            dataGridViewStudentList.DataSource = _studentBll.GetByFilter(filter);
        }


    }
}
