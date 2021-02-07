using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
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
                //new SetPanelLabelFont(panelAddClass, panelTitlebar);
                //new SetPanelButtonFont(panelAddClass);


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

            labelTitle.Text = _selectLanguage.Language.Book;
            labelClassName.Text = _selectLanguage.Language.ClassName;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
            buttonUpdate.Text = _selectLanguage.Language.BtnUpdate;
            buttonDelete.Text = _selectLanguage.Language.BtnDelete;
        }

        private void GetAll()
        {
            bDataGridBookList.DataSource = _bookBll.GetAll();
        }

        private void bDataGridBookList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            bDataGridBookList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            _bookM.Code = textBoxBookCode.Text.Trim();
            _bookM.Name = textBoxBookName.Text;
            try
            {
                if (_bookM.Code != "" && _bookM.Name != "")
                {
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

        private void bDataGridBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _bookM.Id = (int)bDataGridBookList.Rows[e.RowIndex].Cells[1].Value;
            _bookM.Code = bDataGridBookList.Rows[e.RowIndex].Cells[2].Value.ToString();
            _bookM.Name = bDataGridBookList.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBoxBookCode.Text = _bookM.Code;
            textBoxBookName.Text = _bookM.Name;

            buttonAdd.Visible = false;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;

            textBoxBookName.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBookCode.Text != "" && textBoxBookName.Text!="")
                {
                    _bookM.Code = textBoxBookCode.Text.Trim();
                    _bookM.Name = textBoxBookName.Text;
                    
                    var isUpdate = _bookBll.Update(_bookM);
                    if (isUpdate)
                    {
                        GetAll();
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        textBoxBookCode.Clear();
                        textBoxBookName.Clear();

                        buttonUpdate.Visible = false;
                        buttonDelete.Visible = false;
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

                    buttonUpdate.Visible = false;
                    buttonDelete.Visible = false;
                    buttonAdd.Visible = true;
                }
            }
        }

    }
}
