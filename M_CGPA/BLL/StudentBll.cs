using System;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class StudentBll
    {
        readonly StudentDal _studentDal=new StudentDal();
        readonly SelectLanguage _language = new SelectLanguage();

        public bool Insert(StudentM student)
        {
            _language.UserLanguage();

            var isExist = _studentDal.Get(student);
            if (isExist)
            {
                throw new Exception(_language.Language.StudentAlreadyExist);
            }

            var isSaved = _studentDal.Insert(student);
            return isSaved;
        }

        public bool Update(StudentM student)
        {
            //_language.UserLanguage();

            //var isExist = _studentDal.Get(student);
            //if (isExist)
            //{
            //    throw new Exception(_language.Language.StudentAlreadyExist);
            //}

            return _studentDal.Update(student);
        }

        public bool Delete(StudentM student)
        {
            return _studentDal.Delete(student);
        }

        public object GetAllByJoin()
        {
            return _studentDal.GetAllByJoin();
        }

        public object GetByFilter(string filter)
        {
            return _studentDal.GetByFilter(filter);
        }
    }
}
