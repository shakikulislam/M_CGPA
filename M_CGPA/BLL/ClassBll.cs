using System;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class ClassBll
    {
        readonly ClassDal _classDal=new ClassDal();
        readonly SelectLanguage _language=new SelectLanguage();
        
        public bool AddClass(ClassM classM)
        {
            _language.UserLanguage();

            var isClassExist = _classDal.GetClass(classM);
            if (isClassExist)
            {
                throw new Exception(_language.Language.ClassAlreadyExist);
            }

            var isSaved=_classDal.AddClass(classM);
            return isSaved;
            
        }

        public object GetAllClass()
        {
            return _classDal.GetAllClass();
        }

    }
}
