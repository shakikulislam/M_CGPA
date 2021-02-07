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

            var isClassExist = _classDal.Get(classM);
            if (isClassExist)
            {
                throw new Exception(_language.Language.ClassAlreadyExist);
            }

            var isSaved=_classDal.Insert(classM);
            return isSaved;
        }

        public object GetAllClass()
        {
            return _classDal.GetAll();
        }

        public bool UpdateClass(ClassM classM)
        {
            _language.UserLanguage();

            var isClassExist = _classDal.Get(classM);
            if (isClassExist)
            {
                throw new Exception(_language.Language.ClassAlreadyExist);
            }

            return _classDal.Update(classM);
        }

        public bool DeleteClass(ClassM classM)
        {
            return _classDal.Delete(classM);
        }
    }
}
