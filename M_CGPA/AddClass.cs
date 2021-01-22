using System.Windows.Forms;
using M_CGPA.Language;

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
            labelTitlebar.Text = selectLanguage.Language.TitleAddClass;
        }
    }
}
