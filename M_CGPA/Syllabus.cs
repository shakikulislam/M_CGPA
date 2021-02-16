using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Model;

namespace M_CGPA
{
    public partial class Syllabus : Form
    {

        readonly BookBll _bookBll = new BookBll();
        readonly SyllabusBll _syllabusBll=new SyllabusBll();
        readonly SyllabusM _syllabusM=new SyllabusM();
        readonly ClassBll _classBll=new ClassBll();
        readonly SelectLanguage _selectLanguage = new SelectLanguage();

        public Syllabus()
        {
            InitializeComponent();

            SelectLanguage();
            LoadLanguage();

            comboBoxClass.DataSource = _classBll.GetAllClass();
            comboBoxBook.DataSource = _bookBll.GetAll();
            GetAll();
        }


        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelForm,panelTitlebar);
                new SetPanelButtonFont(panelForm);
                
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
            _selectLanguage.UserLanguage();

            labelTitle.Text = _selectLanguage.Language.TitleSyllabus;
            labelClass.Text = _selectLanguage.Language.ClassName;
            labelBook.Text = _selectLanguage.Language.BookName;
            labelYear.Text = _selectLanguage.Language.Year;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
            buttonUpdate.Text = _selectLanguage.Language.BtnUpdate;
            buttonDelete.Text = _selectLanguage.Language.BtnDelete;
            buttonCancel.Text = _selectLanguage.Language.BtnCancel;
        }

        private void GetAll()
        {
            dataGridViewSyllabusList.DataSource = _syllabusBll.GetAllByJoin();
        }
        private void buttonAdd_Click(object sender, System.EventArgs e)
        {

            try
            {
                if (textBoxYear.Text != "" && comboBoxClass.Text != "" && comboBoxBook.Text != "")
                {
                    _syllabusM.Year = textBoxYear.Text.Trim();
                    _syllabusM.ClassId = (int)comboBoxClass.SelectedValue;
                    _syllabusM.BookId = (int)comboBoxBook.SelectedValue;

                    var isSaved = _syllabusBll.Insert(_syllabusM);
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
        
        private void dataGridViewSyllabusList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSyllabusList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewSyllabusList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _syllabusM.Id = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells[1].Value;
            _syllabusM.Year = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Year"].Value.ToString();
            _syllabusM.ClassId = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells["ClassId"].Value;
            _syllabusM.BookId = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells["BookId"].Value;
            _syllabusM.Class = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Class"].Value.ToString();
            _syllabusM.Book = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Book"].Value.ToString();

            textBoxYear.Text = _syllabusM.Year;
            comboBoxClass.SelectedValue = _syllabusM.ClassId;
            comboBoxBook.SelectedValue = _syllabusM.BookId;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            buttonCancel.Visible = true;
            buttonAdd.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxYear.Clear();
            comboBoxClass.SelectedValue = 0;
            comboBoxBook.SelectedValue = 0;

            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonCancel.Visible = false;
            buttonAdd.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxYear.Text != "" && comboBoxClass.Text != "" && comboBoxBook.Text!="")
                {
                    _syllabusM.Year = textBoxYear.Text.Trim();
                    _syllabusM.ClassId = (int) comboBoxClass.SelectedValue;
                    _syllabusM.BookId = (int) comboBoxBook.SelectedValue;
                    
                    var isUpdate = _syllabusBll.Update(_syllabusM);
                    if (isUpdate)
                    {
                        GetAll();
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxYear.Clear();
                        comboBoxClass.SelectedValue = 0;
                        comboBoxBook.SelectedValue = 0;

                        buttonUpdate.Visible = false;
                        buttonDelete.Visible = false;
                        buttonCancel.Visible = false;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_selectLanguage.Language.DeleteConfirmation, _selectLanguage.Language.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var isDelete = _syllabusBll.Delete(_syllabusM);
                if (isDelete)
                {
                    GetAll();
                    MessageBox.Show(_selectLanguage.Language.DeleteSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxYear.Clear();
                    comboBoxClass.SelectedValue = 0;
                    comboBoxBook.SelectedValue = 0;

                    buttonUpdate.Visible = false;
                    buttonDelete.Visible = false;
                    buttonCancel.Visible = false;
                    buttonAdd.Visible = true;
                }
            }
        }


    }
}
