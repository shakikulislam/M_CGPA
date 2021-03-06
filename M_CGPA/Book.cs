﻿using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Model;

namespace M_CGPA
{
    public partial class Book : Form
    {
        readonly BookBll _bookBll=new BookBll();
        readonly BookM _bookM=new BookM();
        readonly SelectLanguage _selectLanguage = new SelectLanguage();
        public Book()
        {
            InitializeComponent();
            
            SelectLanguage();

            LoadLanguage();
            GetAll();
        }

        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelTitlebar,panelForm,panelSearch);
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

            labelTitle.Text = _selectLanguage.Language.TitleBook;
            labelBookCode.Text = _selectLanguage.Language.BookCode;
            labelBookName.Text = _selectLanguage.Language.BookName;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
            buttonUpdate.Text = _selectLanguage.Language.BtnUpdate;
            buttonDelete.Text = _selectLanguage.Language.BtnDelete;
            buttonCancel.Text = _selectLanguage.Language.BtnCancel;
            labelBookMark.Text = _selectLanguage.Language.Mark;
            labelSearch.Text = _selectLanguage.Language.Search;
        }

        private void GetAll()
        {
            dataGridViewBookList.DataSource = _bookBll.GetAll();
        }
        
        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (textBoxBookCode.Text != "" && textBoxBookName.Text != "" && textBoxBookMark.Text != "")
                {
                    _bookM.Code = textBoxBookCode.Text.Trim();
                    _bookM.Name = textBoxBookName.Text;
                    _bookM.Mark = Convert.ToInt32(textBoxBookMark.Text.Trim());

                    var isSaved = _bookBll.Insert(_bookM);
                    if (isSaved)
                    {
                        textBoxBookCode.Clear();
                        textBoxBookName.Clear();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBookCode.Text != "" && textBoxBookName.Text!="" && textBoxBookMark.Text!="")
                {
                    _bookM.Code = textBoxBookCode.Text.Trim();
                    _bookM.Name = textBoxBookName.Text;
                    _bookM.Mark = Convert.ToInt32(textBoxBookMark.Text.Trim());
                    
                    var isUpdate = _bookBll.Update(_bookM);
                    if (isUpdate)
                    {
                        GetAll();
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        textBoxBookCode.Clear();
                        textBoxBookName.Clear();

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
                var isDelete = _bookBll.Delete(_bookM);
                if (isDelete)
                {
                    GetAll();
                    MessageBox.Show(_selectLanguage.Language.DeleteSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxBookCode.Clear();
                    textBoxBookName.Clear();
                    textBoxBookMark.Clear();
                    
                    buttonUpdate.Visible = false;
                    buttonDelete.Visible = false;
                    buttonCancel.Visible = false;
                    buttonAdd.Visible = true;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            textBoxBookCode.Clear();
            textBoxBookName.Clear();

            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonCancel.Visible = false;
            buttonAdd.Visible = true;
        }

        private void dataGridViewBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var DG = dataGridViewBookList.Rows[e.RowIndex];
            _bookM.Id = (int) DG.Cells["id"].Value;
            _bookM.Code = DG.Cells["code"].Value.ToString();
            _bookM.Name = DG.Cells["name"].Value.ToString();
            _bookM.Mark = (int) DG.Cells["mark"].Value;

            textBoxBookCode.Text = _bookM.Code;
            textBoxBookName.Text = _bookM.Name;
            textBoxBookMark.Text = _bookM.Mark.ToString();

            buttonAdd.Visible = false;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            buttonCancel.Visible = true;

            textBoxBookName.Focus();
        }

        private void dataGridViewBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewBookList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewBookList.DataSource = null;

            string filtervalue = textBoxSearch.Text;

            dataGridViewBookList.DataSource = _bookBll.GetByFilter(filtervalue);
         }

    }
}
