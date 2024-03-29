﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShakikulFramework;
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
        readonly FormAlert _alert = new FormAlert();

        
        public Syllabus()
        {
            InitializeComponent();

            SelectLanguage();
            LoadLanguage();

            comboBoxClass.DataSource = _classBll.GetAllClass();
            comboBoxBook.DataSource = _bookBll.GetAll();
            comboBoxClassFilter.DataSource = _classBll.GetAllClass();

            GetAll();
        }
        
        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelForm, panelTitlebar, panelFilter);
                new SetPanelButtonFont(panelForm);

                foreach (var button in Controls.OfType<Button>())
                {
                    button.Font=new Font(Font.Name,14);
                }

                //foreach (Control control in Controls)
                //{
                //    if (control is Button)
                //    {
                //        control.Font = new Font(this.Font.Name, 14);
                //    }
                //}
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
            labelYearFilter.Text = _selectLanguage.Language.Year;
            labelClassFilter.Text=_selectLanguage.Language.ClassName;
            buttonSearchForm.Text = _selectLanguage.Language.BtnSearch;
            buttonAddForm.Text = _selectLanguage.Language.BtnAdd;

        }

        private void GetAll()
        {
            dataGridViewSyllabusList.DataSource = _syllabusBll.GetAllByJoin();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxYear.Text != "" && comboBoxClass.Text != "" && comboBoxBook.Text != "" && comboBoxType.Text !="")
                {
                    _syllabusM.Year = textBoxYear.Text.Trim();
                    _syllabusM.ClassId = (int)comboBoxClass.SelectedValue;
                    _syllabusM.BookId = (int)comboBoxBook.SelectedValue;
                    _syllabusM.Type = comboBoxType.Text;

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
            _syllabusM.Id = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells["ids"].Value;
            _syllabusM.Year = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Years"].Value.ToString();
            _syllabusM.ClassId = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells["ClassIds"].Value;
            _syllabusM.BookId = (int) dataGridViewSyllabusList.Rows[e.RowIndex].Cells["BookIds"].Value;
            _syllabusM.Class = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Classs"].Value.ToString();
            _syllabusM.Book = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Books"].Value.ToString();
            _syllabusM.Type = dataGridViewSyllabusList.Rows[e.RowIndex].Cells["Type"].Value.ToString();

            textBoxYear.Text = _syllabusM.Year;
            comboBoxClass.SelectedValue = _syllabusM.ClassId;
            comboBoxBook.SelectedValue = _syllabusM.BookId;
            comboBoxType.Text = _syllabusM.Type;

            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            buttonCancel.Visible = true;
            buttonSearchForm.Visible = false;
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
            buttonSearchForm.Visible = true;
            buttonAdd.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxYear.Text != "" && comboBoxClass.Text != "" && comboBoxBook.Text!="" && comboBoxType.Text!="")
                {
                    _syllabusM.Year = textBoxYear.Text.Trim();
                    _syllabusM.ClassId = (int) comboBoxClass.SelectedValue;
                    _syllabusM.BookId = (int) comboBoxBook.SelectedValue;
                    _syllabusM.Type = comboBoxType.Text;
                    
                    var isUpdate = _syllabusBll.Update(_syllabusM);
                    if (isUpdate)
                    {
                        GetAll();
                        //MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _alert.ShowAlert(_selectLanguage.Language.UpdateSuccessMessage, FormAlert.TypeEnum.Information);

                        textBoxYear.Clear();
                        comboBoxClass.SelectedValue = 0;
                        comboBoxBook.SelectedValue = 0;

                        buttonUpdate.Visible = false;
                        buttonDelete.Visible = false;
                        buttonCancel.Visible = false;
                        buttonSearchForm.Visible = true;
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
                    buttonSearchForm.Visible = true;
                    buttonAdd.Visible = true;
                }
            }
        }
        
        private void buttonSearchForm_Click(object sender, EventArgs e)
        {
            panelFilter.Location = panelForm.Location;
            panelForm.Visible = false;
            panelFilter.Visible = true;
        }

        private void buttonAddForm_Click(object sender, EventArgs e)
        {
            panelForm.Visible = true;
            panelFilter.Visible = false;
            GetAll();
        }

        private void textBoxYearFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxClassFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            dataGridViewSyllabusList.DataSource = null;

            _syllabusM.Year = textBoxYearFilter.Text;
            _syllabusM.ClassId = (int) comboBoxClassFilter.SelectedValue;

            dataGridViewSyllabusList.DataSource = _syllabusBll.GetByLikeFilter(_syllabusM);

        }


    }
}
