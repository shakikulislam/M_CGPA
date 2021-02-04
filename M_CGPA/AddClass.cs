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
    public partial class AddClass : Form
    {
        readonly ClassBll _classBll=new ClassBll();
        readonly ClassM _classM=new ClassM();
        readonly SelectLanguage _selectLanguage=new SelectLanguage();

        public AddClass()
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
            labelTitle.Text = _selectLanguage.Language.TitleClass;
            labelClassName.Text = _selectLanguage.Language.ClassName;
            buttonAdd.Text = _selectLanguage.Language.BtnAdd;
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            var className = textBoxClassName.Text;
            try
            {
                if (className !="")
                {
                    _classM.Name = className;
                    var isSaved=_classBll.AddClass(_classM);
                    if (isSaved)
                    {
                        textBoxClassName.Clear();
                        AllClass();
                        MessageBox.Show(_selectLanguage.Language.SaveSuccessMessage,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(_selectLanguage.Language.SaveErrorMessage,"",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AllClass()
        {
            dataGridViewListOfClass.DataSource = _classBll.GetAllClass();
        }

        private void dataGridViewListOfClass_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewListOfClass.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

    }
}
