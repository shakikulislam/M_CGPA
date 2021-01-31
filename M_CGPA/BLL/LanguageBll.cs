using M_CGPA.DAL;

namespace M_CGPA.BLL
{
    class LanguageBll
    {
        LanguageDal _dal=new LanguageDal();

        public object LanguageList()
        {

            return _dal.LanguageList();
        }
    }
}
