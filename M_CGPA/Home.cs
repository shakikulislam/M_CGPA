using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.Language;
using M_CGPA.Language.Lang;

namespace M_CGPA
{
    public partial class Home : Form
    {
        SelectLanguage _language=new SelectLanguage();
        private int _lang = 2;



        public Home()
        {
            InitializeComponent();

            //Bengali bengali=new Bengali();
            //bengali.Lang();

        }

        public readonly LanguagePro Language = new LanguagePro();
        public void LoadLanguage()
        {
            _language.UserLanguage(_lang);

            lbl.Text = _language.Language.MenuFile;
            //lbl.Font = new Font(lang.Font, lbl.Font.Size);
        }

        private void Home_Load(object sender, EventArgs e)
        {

            LoadLanguage();
        }
    }
}
