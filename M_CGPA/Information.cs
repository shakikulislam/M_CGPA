using System.Windows.Forms;
using M_CGPA.Language.Font;

namespace M_CGPA.Language
{
    public partial class Information : Form
    {

        readonly SelectLanguage _selectLanguage = new SelectLanguage();

        public Information()
        {
            InitializeComponent();

            SelectLanguage();
            LoadLanguage();
            
        }


        private void SelectLanguage()
        {
            _selectLanguage.UserLanguage();

            if (_selectLanguage.Language.Language == "Bengali")
            {
                new SetPanelLabelFont(panelTitlebar,panelInformation);
                //new SetPanelButtonFont(panelForm);

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

            labelTitle.Text = _selectLanguage.Language.TitleInformation;
            labelSearch.Text = _selectLanguage.Language.Search;

        }
    }
}
