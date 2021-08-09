using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Model;
using ShakikulFramework;

namespace M_CGPA
{
    public partial class Class : Form
    {
        readonly ClassBll _classBll=new ClassBll();
        readonly ClassM _classM=new ClassM();
        readonly SelectLanguage _selectLanguage=new SelectLanguage();
        readonly FormAlert _alert=new FormAlert();
        //FormValidation _formValidation=new FormValidation();
        
        public Class()
        {
            InitializeComponent();

            SelectLanguage();

            LoadLanguage();

            AllClass();
        }

        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelAddClass, panelTitlebar);
                new SetPanelButtonFont(panelAddClass);


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

            labelClassNumber.Text = _selectLanguage.Language.ClassNumber;
            labelTitle.Text = _selectLanguage.Language.TitleClass;
            labelClassName.Text = _selectLanguage.Language.ClassName;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
            buttonUpdate.Text = _selectLanguage.Language.BtnUpdate;
            buttonDelete.Text = _selectLanguage.Language.BtnDelete;
            buttonCancel.Text = _selectLanguage.Language.BtnCancel;
        }
        
        private void AllClass()
        {
            dataGridViewClassList.DataSource = _classBll.GetAllClass();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var className = textBoxClassName.Text.Trim();
            var classNumber = textBoxClassNumber.Text.Trim();
            try
            {
                if (className != "" & classNumber!="")
                {
                    _classM.Name = className;
                    _classM.Number = Convert.ToInt32(classNumber);
                    var isSaved = _classBll.AddClass(_classM);
                    if (isSaved)
                    {
                        textBoxClassName.Clear();
                        AllClass();
                        //MessageBox.Show(_selectLanguage.Language.SaveSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _alert.ShowAlert(_selectLanguage.Language.SaveSuccessMessage,FormAlert.TypeEnum.Success);
                    }
                    else
                    {
                        //MessageBox.Show(_selectLanguage.Language.ErrorMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        _alert.ShowAlert(_selectLanguage.Language.ErrorMessage, FormAlert.TypeEnum.Error);

                    }

                }
                else
                {
                    //MessageBox.Show(_selectLanguage.Language.BlankFiled, _selectLanguage.Language.MessageTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    
                    _alert.ShowAlert(_selectLanguage.Language.BlankFiled, FormAlert.TypeEnum.Error);

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
                var className = textBoxClassName.Text.Trim();
                var classNumber = textBoxClassNumber.Text.Trim();

                if (className != "" & classNumber != "")
                {
                    _classM.Name = className;
                    _classM.Number = Convert.ToInt32(classNumber);

                    var isUpdate = _classBll.UpdateClass(_classM);

                    if (isUpdate)
                    {
                        AllClass();
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxClassName.Clear();
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
                    _alert.ShowAlert(_selectLanguage.Language.BlankFiled, FormAlert.TypeEnum.Error);

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //customMessageBox.Show("titless","tt",CustomMessageBox.Buttons.YesNoCancel);
            //customMessageBox.ShowDialog();
            if (MessageBox.Show(_selectLanguage.Language.DeleteConfirmation, _selectLanguage.Language.MessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var isDelete = _classBll.DeleteClass(_classM);
                if (isDelete)
                {
                    AllClass();
                    MessageBox.Show(_selectLanguage.Language.DeleteSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxClassName.Clear();
                    textBoxClassNumber.Clear();
                    textBoxClassName.Focus();

                    buttonUpdate.Visible = false;
                    buttonDelete.Visible = false;
                    buttonCancel.Visible = false;
                    buttonAdd.Visible = true;
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxClassName.Clear();
            textBoxClassNumber.Clear();
            textBoxClassName.Focus();

            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
            buttonCancel.Visible = false;
            buttonAdd.Visible = true;
        }

        private void dataGridViewClassList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _classM.Id = (int)dataGridViewClassList.Rows[e.RowIndex].Cells["id"].Value;
            _classM.Name = dataGridViewClassList.Rows[e.RowIndex].Cells["name"].Value.ToString();
            _classM.Number=Convert.ToInt32(dataGridViewClassList.Rows[e.RowIndex].Cells["Number"].Value.ToString());
            textBoxClassName.Text = _classM.Name;
            textBoxClassNumber.Text = _classM.Number.ToString();

            buttonAdd.Visible = false;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
            buttonCancel.Visible = true;

            textBoxClassName.Focus();
        }

        private void dataGridViewClassList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewClassList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }



    }
}
