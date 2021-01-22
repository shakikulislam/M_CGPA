using System;
using System.Drawing;
using System.Windows.Forms;
using M_CGPA.BLL;
using M_CGPA.Properties;

namespace M_CGPA
{
    public partial class Setting : Form
    {
        readonly LanguageBll _bll=new LanguageBll();
        


        public Setting()
        {
            InitializeComponent();

            comboBoxLanguage.DataSource = _bll.LanguageList();
        }


        private void buttonChangeLanguage_Click(object sender, EventArgs e)
        {
            var languageId = comboBoxLanguage.SelectedValue;
            Settings.Default.Language = (int) languageId;
            Settings.Default.Save();
            Application.Restart();
        }

    }
}
