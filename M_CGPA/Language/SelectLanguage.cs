
using M_CGPA.Language.Lang;

namespace M_CGPA.Language
{
    public class SelectLanguage
    {
        private readonly Arabic _arabic=new Arabic();
        private readonly Bengali _bengali=new Bengali();
        private readonly English _english=new English();

        public LanguagePro Language=new LanguagePro();

        public void UserLanguage(int id)
        {
            switch (id)
            {
                case 1:
                    _arabic.Lang();
                    Language = _arabic._languagePro;
                    break;
                case 2:
                    _bengali.Lang();
                    Language = _bengali._languagePro;
                    break;
                case 3:
                    _english.Lang();
                    Language = _english._languagePro;
                    break;
                default:
                    _english.Lang();
                    Language = _english._languagePro;
                    break;
            }
        }
    }
}
