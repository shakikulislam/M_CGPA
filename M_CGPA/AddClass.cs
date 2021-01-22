using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Language.Font;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            var selectLanguage=new SelectLanguage();
            selectLanguage.UserLanguage(Settings.Default.Language);

            if (selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelAddClass);
                new SetPanelButtonFont(panelAddClass);

                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Font = new Font(this.Font.Name, 14);
                    }
                }
            }

            labelTitle.Text = selectLanguage.Language.TitleClass;
            labelClassName.Text = selectLanguage.Language.ClassName;
            buttonAdd.Text = selectLanguage.Language.BtnAdd;
        }


    }
}
