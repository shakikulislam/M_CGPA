using System;
using System.Data;
using System.Windows.Forms;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class GradePoingBll
    {
        readonly GradePointDal _gradePointDal = new GradePointDal();
        readonly SelectLanguage _language = new SelectLanguage();

        public bool Insert(GradePointM gradePoint)
        {
            _language.UserLanguage();

            var isExist = _gradePointDal.Get(gradePoint);
            if (isExist)
            {
                throw new Exception(_language.Language.GradePointAlreadyExist);
            }

            var isSaved = _gradePointDal.Insert(gradePoint);
            return isSaved;
        }

        public bool Update(GradePointM gradePoint)
        {
            //_language.UserLanguage();

            //var isExist = _studentDal.Get(student);
            //if (isExist)
            //{
            //    throw new Exception(_language.Language.StudentAlreadyExist);
            //}

            return _gradePointDal.Update(gradePoint);
        }

        public bool Delete(GradePointM gradePoint)
        {
            return _gradePointDal.Delete(gradePoint);
        }

        public DataTable GetById(GradePointM gradePoint)
        {
            return _gradePointDal.GetById(gradePoint);
        }

        internal DataTable getAll()
        {
            return _gradePointDal.GetAll();
        }
    }
}
