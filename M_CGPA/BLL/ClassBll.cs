using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class ClassBll
    {
        readonly ClassDal _classDal=new ClassDal();
        readonly SelectLanguage _selectLanguage=new SelectLanguage();
        public string AddClass(ClassM classM)
        {
            var isSaved=_classDal.AddClass(classM);
            return isSaved?_selectLanguage.Language.SaveStudentSuccessMessage:_selectLanguage.Language.SaveStudentErrorMessage;

        }
    }
}
