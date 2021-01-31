using M_CGPA.Language.Lang;
using M_CGPA.Properties;

namespace M_CGPA.Language
{
    public class SelectLanguage
    {
        private readonly Bengali _bengali=new Bengali();
        private readonly English _english=new English();

        public LanguagePro Language=new LanguagePro();

        

        public void UserLanguage()
        {
            var id = Settings.Default.Language;
            switch (id)
            {
                case 1:
                    _bengali.Lang();
                    Language = _bengali.Pro;
                    break;
                case 2:
                    _english.Lang();
                    Language = _english.Pro;
                    break;
                default:
                    _english.Lang();
                    Language = _english.Pro;
                    break;
            }
        }
    }
}
