using System;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Language;
using M_CGPA.Model;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Setting : Form
    {
        readonly LanguageBll _bll=new LanguageBll();
        GradePointM _gradePoint=new GradePointM();
        GradePoingBll _gradePoingBll=new GradePoingBll();
        SelectLanguage _selectLanguage=new SelectLanguage();


        public Setting()
        {
            InitializeComponent();

            comboBoxLanguage.DataSource = _bll.LanguageList();
            comboBoxLanguage.SelectedValue = 0;
            GetAll();
        }


        private void buttonChangeLanguage_Click(object sender, EventArgs e)
        {
            var languageId = comboBoxLanguage.SelectedValue;
            Settings.Default.Language = (int) languageId;
            Settings.Default.Save();
            Application.Restart();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void buttonGPAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxGPMinimum.Text != "" || textBoxGPMaximum.Text != "" || textBoxGPGrade.Text != "" || textBoxGPPoint.Text != "")
                {
                    _gradePoint.Minimum = Convert.ToInt32(textBoxGPMinimum.Text.Trim()) ;
                    _gradePoint.Maximum = Convert.ToInt32(textBoxGPMaximum.Text.Trim()) ;
                    _gradePoint.Grade = textBoxGPGrade.Text ;
                    _gradePoint.Point = Convert.ToDouble(textBoxGPPoint.Text.Trim());

                    var isSaved = _gradePoingBll.Insert(_gradePoint);
                    if (isSaved)
                    {
                        MessageBox.Show(_selectLanguage.Language.SaveSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetAll();

                        //ClearFields
                        textBoxGPMinimum.Clear();
                        textBoxGPMaximum.Clear();
                        textBoxGPGrade.Clear();
                        textBoxGPPoint.Clear();

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

        private void GetAll()
        {
            dataGridViewGPList.DataSource = _gradePoingBll.getAll();
        }
        
        private void dataGridViewGPList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewGPList.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
