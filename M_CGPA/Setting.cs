using System;
using System.Drawing;
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

            SelectLanguage();
            LoadLanguage();

            comboBoxLanguage.DataSource = _bll.LanguageList();
            comboBoxLanguage.SelectedValue = 0;
            GetAll();
        }


        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                //new SetGroupBoxLabelFont(groupBoxAddStudent, groupBoxFilter);
                //new SetPanelLabelFont(panelTitlebar, panelAddForm, panelBA);
                //new SetPanelButtonFont(panelAddForm);

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
            
        }
        
        public void PanelTextBoxClean(Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox) control).Text = "";
                }
            }
        }

        private void buttonChangeLanguage_Click(object sender, EventArgs e)
        {
            var languageId = comboBoxLanguage.SelectedValue;
            Settings.Default.Language = (int) languageId;
            Settings.Default.Save();
            Application.Restart();
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

                        PanelTextBoxClean(panelGPForm);

                        textBoxGPMinimum.Focus();

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

        private void dataGridViewGPList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var DG = dataGridViewGPList.Rows[e.RowIndex];
            _gradePoint.Id = Convert.ToInt32(DG.Cells["idGP"].Value);
            _gradePoint.Minimum = Convert.ToInt32(DG.Cells["minimumGP"].Value);
            _gradePoint.Maximum = Convert.ToInt32(DG.Cells["maximumGP"].Value);
            _gradePoint.Grade = DG.Cells["gradeGP"].Value.ToString();
            _gradePoint.Point = Convert.ToDouble(DG.Cells["pointGP"].Value);

            textBoxGPMinimum.Text = _gradePoint.Minimum.ToString();
            textBoxGPMaximum.Text = _gradePoint.Maximum.ToString();
            textBoxGPGrade.Text = _gradePoint.Grade.ToString();
            textBoxGPPoint.Text = _gradePoint.Point.ToString();

            buttonGPAdd.Visible = false;
            buttonGPClose.Visible = true;
            buttonGPDelete.Visible = true;
            buttonGPUpdate.Visible = true;
        }

        private void buttonGPClose_Click(object sender, EventArgs e)
        {
            buttonGPAdd.Visible = true;
            buttonGPClose.Visible = false;
            buttonGPDelete.Visible = false;
            buttonGPUpdate.Visible = false;

            PanelTextBoxClean(panelGPForm);
        }


        private void buttonGPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxGPMinimum.Text != "" || textBoxGPMaximum.Text != "" || textBoxGPGrade.Text != "" || textBoxGPPoint.Text != "")
                {
                    _gradePoint.Minimum = Convert.ToInt32(textBoxGPMinimum.Text.Trim());
                    _gradePoint.Maximum = Convert.ToInt32(textBoxGPMaximum.Text.Trim());
                    _gradePoint.Grade = textBoxGPGrade.Text;
                    _gradePoint.Point = Convert.ToDouble(textBoxGPPoint.Text.Trim());

                    var isUpdate = _gradePoingBll.Update(_gradePoint);
                    if (isUpdate)
                    {
                        MessageBox.Show(_selectLanguage.Language.UpdateSuccessMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetAll();

                        buttonGPAdd.Visible = true;
                        buttonGPClose.Visible = false;
                        buttonGPDelete.Visible = false;
                        buttonGPUpdate.Visible = false;

                        PanelTextBoxClean(panelGPForm);

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

        private void buttonGPDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(_selectLanguage.Language.DeleteConfirmation,_selectLanguage.Language.MessageTitle,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                var isDelete=_gradePoingBll.Delete(_gradePoint);
                if (isDelete)
                {
                    MessageBox.Show(_selectLanguage.Language.DeleteSuccessMessage,_selectLanguage.Language.MessageTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    GetAll();

                    buttonGPAdd.Visible = true;
                    buttonGPClose.Visible = false;
                    buttonGPDelete.Visible = false;
                    buttonGPUpdate.Visible = false;

                    PanelTextBoxClean(panelGPForm);
                }
                else
                {
                    MessageBox.Show(_selectLanguage.Language.ErrorMessage, _selectLanguage.Language.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
