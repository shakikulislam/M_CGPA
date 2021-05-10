using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
        readonly SyllabusBll _syllabusBll=new SyllabusBll();
        readonly SelectLanguage _selectLanguage=new SelectLanguage();
        readonly SyllabusM _syllabusM=new SyllabusM();
        readonly BookAccountM _bookAccountM=new BookAccountM();
        readonly BookAccountBll _bookAccountBll=new BookAccountBll();
        readonly ResultM _resultM=new ResultM();
        readonly ResultBll _resultBll=new ResultBll();
        readonly GradePointM _gradePointM=new GradePointM();
        readonly GradePoingBll _gradePoingBll=new GradePoingBll();

        int _fieldLocation = 1;
        DataTable _bookLIst;
        public Student()
        {
            InitializeComponent();

            SelectLanguage();
            LoadLanguage();

            comboBoxClass.DataSource = _classBll.GetAllClass();
            //comboBoxARClass.DataSource = _classBll.GetAllClass();
            comboBoxBAClass.DataSource = _classBll.GetAllClass();
            GetAll();
        }

        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetGroupBoxLabelFont(groupBoxAddStudent, groupBoxFilter);
                new SetPanelLabelFont(panelTitlebar, panelAddForm, panelBA);
                new SetPanelButtonFont(panelAddForm);

                foreach (var button in Controls.OfType<Button>())
                {
                    button.Font = new Font(Font.Name, 14);
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
            labelBARoll.Text = _selectLanguage.Language.Roll;
            labelBAName.Text = _selectLanguage.Language.StudentName;
            labelBAClass.Text = _selectLanguage.Language.Class;
            labelBAYear.Text = _selectLanguage.Language.Year;
            labelHelAreadyHasTheBook.Text = _selectLanguage.Language.HelAreadyHasTheBook;
        }

        public CheckBox AddNewCheckBox(string cbName, string cbBook)
        {
            var newCheckBox = new CheckBox();
            panelBookList.Controls.Add(newCheckBox);

            newCheckBox.Top = _fieldLocation * 28;
            newCheckBox.Left = 15;
            newCheckBox.Name = cbName;
            newCheckBox.Text = cbBook;
            _fieldLocation += 1;

            return newCheckBox;
        }

        public Label AddNewLabel(string lblText, int location, Control field)
        {
            var newLabel = new Label();
            field.Controls.Add(newLabel);

            newLabel.Top = _fieldLocation * location;
            newLabel.Left = 15;
            newLabel.Text = lblText;
            //newLabel.AutoSize = true;
            newLabel.Height = 25;
            newLabel.TextAlign = ContentAlignment.BottomLeft;
            newLabel.Width = panelARBookList.Width-50;
            _fieldLocation += 1;

            return newLabel;
        }

        public TextBox AddNewTextBox(string tbName, int location, Control field)
        {
            var newTextBox = new TextBox();
            field.Controls.Add(newTextBox);

            newTextBox.Top = _fieldLocation*location;
            newTextBox.Left = 15;
            newTextBox.Name = tbName;
            newTextBox.Height = 25;
            newTextBox.BorderStyle = BorderStyle.FixedSingle;
            _fieldLocation += 1;

            return newTextBox;
        }

        private void GetAll()
        {
            dataGridViewStudentList.DataSource = _studentBll.GetAllByJoin();
            labelTotalStudent.Text = @"Total= " + dataGridViewStudentList.Rows.Count;
        }

        private static void ClearFields(Control field)
        {
            foreach (var control in field.Controls.OfType<TextBox>())
            {
                control.Clear();
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields(panelAddForm);
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
                        
                        dataGridViewStudentList.DataSource = _studentBll.GetByFilter(_studentM.Roll.ToString());

                        ClearFields(panelAddForm);
                        
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

                    ClearFields(panelAddForm);
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
                        
                        ClearFields(panelAddForm);
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
            ClearFields(panelAddForm);
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
            ClearFields(panelAddForm);
            try
            {
                var dg = dataGridViewStudentList.Rows[e.RowIndex];
                _studentM.Id = Convert.ToInt32(dg.Cells["id"].Value);
                _studentM.Roll = Convert.ToInt32(dg.Cells["roll"].Value);
                _studentM.Reg = Convert.ToInt32(dg.Cells["reg"].Value);
                _studentM.ClassId = Convert.ToInt32(dg.Cells["classId"].Value);
                _studentM.Class = dg.Cells["clas"].Value.ToString();
                _studentM.Session = dg.Cells["session"].Value.ToString();
                _studentM.AdmissionDate = Convert.ToDateTime(dg.Cells["admissionDate"].Value);
                _studentM.Dob = Convert.ToDateTime(dg.Cells["dob"].Value);
                _studentM.StudentName = dg.Cells["studentName"].Value.ToString();
                _studentM.SPhone = dg.Cells["sPhone"].Value.ToString();
                _studentM.FatherName = dg.Cells["fatherName"].Value.ToString();
                _studentM.FPhone = dg.Cells["fPhone"].Value.ToString();
                _studentM.MotherName = dg.Cells["motherName"].Value.ToString();
                _studentM.MPhone = dg.Cells["mPhone"].Value.ToString();
                _studentM.Nid = dg.Cells["nid"].Value.ToString();
                _studentM.Brn = dg.Cells["brn"].Value.ToString();
                _studentM.PresentAddress = dg.Cells["presentAddress"].Value.ToString();
                _studentM.PermanentAddress = dg.Cells["permanentAddress"].Value.ToString();

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
            catch {}

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = textBoxSearch.Text;
            dataGridViewStudentList.DataSource = _studentBll.GetByFilter(filter);
            labelTotalStudent.Text = @"Total= " + dataGridViewStudentList.Rows.Count;
        }

        private void textBoxARSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBoxARSearch.Text != "" && e.KeyCode == Keys.Enter)
                {
                    var student = _studentBll.GetByRollFilter(textBoxARSearch.Text);
                    labelARStudentName.Text = student.Rows[0]["StudentName"].ToString();
                    
                    var classIdValue = (int)student.Rows[0]["classId"];
                    comboBoxARClass.DataSource = _classBll.GetById(classIdValue);
                    comboBoxARClass.SelectedValue = classIdValue;
                    
                    _syllabusM.ClassId = classIdValue;
                    _syllabusM.Year = textBoxARYear.Text.Trim();

                    _resultM.StudentId = (int) student.Rows[0]["Id"];

                    LoadBook();
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    textBoxARSearch.Clear();
                    labelARStudentName.Text = "";
                    //comboBoxARClass.DataSource = null;
                    DeleteAutoGenerateFields(panelARBookList);
                }
                else
                {
                    labelARStudentName.Text = "";
                    //comboBoxARClass.DataSource = null;
                    DeleteAutoGenerateFields(panelARBookList);
                }
            }
            catch{}
        }
        
        private void textBoxABSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBoxBASearch.Text != "" && e.KeyCode == Keys.Enter)
                {
                    var student = _studentBll.GetByRollFilter(textBoxBASearch.Text);
                    labelBAStudentName.Text = student.Rows[0]["StudentName"].ToString();

                    _bookAccountM.StudentId = (int) student.Rows[0]["Id"];

                    var classIdValue = (int)student.Rows[0]["classId"];
                    comboBoxBAClass.SelectedValue = classIdValue;

                    LoadBookForBookAccount();
                    LoadAssignedBookList();
                    //CheckedAssignedBookList();
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    textBoxBASearch.Clear();
                    labelBAStudentName.Text = "";
                    comboBoxBAClass.SelectedValue = 0;
                    DeleteAutoGenerateFields(panelBookList);
                    dataGridViewBAAssignedBook.DataSource = null;
                }
                else
                {
                    labelBAStudentName.Text = "";
                    comboBoxBAClass.SelectedValue = 0;
                    DeleteAutoGenerateFields(panelBookList);
                    dataGridViewBAAssignedBook.DataSource = null;
                }
            }
            catch { }
        }

        private void LoadBookForBookAccount()
        {
            try
            {
                panelBookList.Controls.Clear();
                _fieldLocation = 1;

                // load book list
                _syllabusM.ClassId = (int) comboBoxBAClass.SelectedValue;
                _syllabusM.Year = textBoxBAYear.Text;
                _bookLIst = _syllabusBll.GetByFilter(_syllabusM);
                _bookAccountM.Year = textBoxBAYear.Text;
                if (_bookLIst.Rows.Count > 0)
                {
                    for (int i = 0; i < _bookLIst.Rows.Count; i++)
                    {
                        var cbName = _bookLIst.Rows[i][0].ToString();
                        var cbValue = _bookLIst.Rows[i]["Book"].ToString();
                        AddNewCheckBox(cbName, cbValue);
                    }
                    labelBATottalBook.Text = @"Total Book " + _bookLIst.Rows.Count;
                }
                else
                {
                    DeleteAutoGenerateFields(panelBookList);
                    labelBATottalBook.Text = "";
                }
            }
            catch
            {
            }
        }

        private void LoadBook()
        {
            try
            {
                panelARBookList.Controls.Clear();
                _fieldLocation = 1;

                _bookLIst = _syllabusBll.GetByFilter(_syllabusM);

                if (_bookLIst.Rows.Count > 0)
                {
                    for (int i = 0; i < _bookLIst.Rows.Count; i++)
                    {
                        var cbName = _bookLIst.Rows[i][0].ToString();
                        var value = _bookLIst.Rows[i]["Book"].ToString();
                        AddNewLabel(value, 25, panelARBookList);
                        AddNewTextBox(cbName, 25, panelARBookList);
                    }
                }
                else
                {
                    DeleteAutoGenerateFields(panelARBookList);
                }
            }
            catch
            {
            }
        }

        private void LoadAssignedBookList()
        {
            // load assigned book list in DataGridView
            var bookAccountTable = _bookAccountBll.GetAll(_bookAccountM);

            if (bookAccountTable.Rows.Count > 0)
            {
                _bookAccountM.Id = (int)bookAccountTable.Rows[0]["Id"];
                _bookAccountM.Book = bookAccountTable.Rows[0]["Book"].ToString();

                if (_bookAccountM.Book == "" || _bookAccountM.Book == "0")
                {
                    dataGridViewBAAssignedBook.DataSource = null;
                }
                else
                {
                    var table=new DataTable();
                    table.Columns.Add("year");
                    table.Columns.Add("class");
                    table.Columns.Add("book");
                    foreach (DataRow dataRowBook in bookAccountTable.Rows)
                    {
                        _bookAccountM.Book = dataRowBook["Book"].ToString();

                        var syllabusList = _syllabusBll.GetBySyllabusId(_bookAccountM);
                        foreach (DataRow dataRowSl in syllabusList.Rows)
                        {
                            table.Rows.Add(
                                dataRowSl["Year"].ToString(),
                                dataRowSl["Class"].ToString(),
                                dataRowSl["Book"].ToString()
                                );
                        }
                    }
                    dataGridViewBAAssignedBook.DataSource = table;
                }

                buttonBAAddBook.Visible = false;
                buttonBAUpdateBook.Visible = true;
            }
            else
            {
                dataGridViewBAAssignedBook.DataSource = null;
                buttonBAAddBook.Visible = true;
                buttonBAUpdateBook.Visible = false;
            }
        }

        private void CheckedAssignedBookList()
        {
            var syllabusList = _syllabusBll.GetBySyllabusId(_bookAccountM);

            foreach (DataRow dataRow in syllabusList.Rows)
            {
                foreach (Control control in panelBookList.Controls)
                {
                    if (dataRow["id"].ToString() == control.Name)
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }
            }
        }

        private void DeleteAutoGenerateFields(Control panel)
        {
            _fieldLocation = 1;
            panel.Controls.Clear();
        }

        private void textBoxBAYear_TextChanged(object sender, EventArgs e)
        {
            LoadBookForBookAccount();
        }

        private void buttonBAUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                _bookAccountM.Book = "";
                foreach (var checkBox in panelBookList.Controls.OfType<CheckBox>())
                {
                    if (checkBox.Checked)
                    {
                        _bookAccountM.Book = _bookAccountM.Book == "" ? _bookAccountM.Book += checkBox.Name : _bookAccountM.Book += "," + checkBox.Name;
                    }
                }
                
                var isUpdate = _bookAccountBll.Update(_bookAccountM);
                if (isUpdate)
                {
                    LoadBookForBookAccount();
                    MessageBox.Show("Success...");
                }
            }
            catch { }
        }

        private void buttonBAAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                _bookAccountM.Book = "";
                foreach (var checkBox in panelBookList.Controls.OfType<CheckBox>())
                {
                        if (checkBox.Checked)
                        {
                            _bookAccountM.Book = _bookAccountM.Book == "" ? _bookAccountM.Book += checkBox.Name : _bookAccountM.Book += "," + checkBox.Name;
                        }
                    
                }

                var isSuccess = _bookAccountBll.Insert(_bookAccountM);
                if (isSuccess)
                {
                    LoadBookForBookAccount();
                }
            }
            catch { }
        }

        private void dataGridViewBAAssignedBook_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewBAAssignedBook.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void comboBoxABClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookForBookAccount();
        }

        private void dataGridViewBAAssignedBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = dataGridViewBAAssignedBook.Rows[e.RowIndex];
            comboBoxBAClass.Text = dg.Cells["classBA"].Value.ToString();
            textBoxBAYear.Text = dg.Cells["yearBA"].Value.ToString();

            CheckedAssignedBookList();
        }

        private void textBoxARSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonARAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                _resultM.SyllabusId = "";
                //_resultM.Result = "";
                _resultM.RangeOfMarks = "";
                _resultM.Number = "";

                foreach (var textBox in panelARBookList.Controls.OfType<TextBox>())
                {
                    _syllabusM.Id = Convert.ToInt32(textBox.Name);
                    var totalMark = (int) _syllabusBll.GetBookMarkBySyllabusId(_syllabusM).Rows[0]["Mark"];
                    var mark = Convert.ToDouble(textBox.Text.Trim());

                    var grade = _gradePoingBll.GetByMark(mark, totalMark).Rows[0]["Grade"];
                    var point = _gradePoingBll.GetByMark(mark, totalMark).Rows[0]["Point"];

                    if (_resultM.Number != "")
                    {
                        _resultM.Number = textBox.Text == ""? _resultM.Number += ",0": _resultM.Number += "," + textBox.Text.Trim();
                        _resultM.SyllabusId = _resultM.SyllabusId += "," + textBox.Name;
                    }
                    else
                    {
                        _resultM.Number = textBox.Text == "" ? _resultM.Number = "0" : textBox.Text.Trim();
                        _resultM.SyllabusId = textBox.Name;
                    }
                }

                //foreach (Control control in panelARBookList.Controls)
                //{
                //    if (control is TextBox)
                //    {
                //        if (_resultM.Result=="")
                //        {
                //            _resultM.Result = control.Text == ""? _resultM.Result = "0": control.Text.Trim();
                //            _resultM.SyllabusId = control.Name;
                //        }
                //        else
                //        {
                //            _resultM.Result = control.Text == "" ? _resultM.Result += ",0" : _resultM.Result += ","+control.Text.Trim();
                //            _resultM.SyllabusId = _resultM.SyllabusId += "," + control.Name;
                //        }
                //    }
                //}

                var isSuccess = _resultBll.Insert(_resultM);
                if (isSuccess)
                {
                    MessageBox.Show("Save Success...");
                    textBoxARSearch.Clear();
                    textBoxARSearch.Focus();
                    
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
