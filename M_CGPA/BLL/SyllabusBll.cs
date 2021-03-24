
using System;
using System.Data;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class SyllabusBll
    {
        readonly SyllabusDal _syllabus=new SyllabusDal();
        readonly SelectLanguage _language = new SelectLanguage();

        public bool Insert(SyllabusM syllabus)
        {
            _language.UserLanguage();

            var isExist = _syllabus.Get(syllabus);
            if (isExist)
            {
                throw new Exception(_language.Language.BookAlreadyExist);
            }

            var isSaved = _syllabus.Insert(syllabus);
            return isSaved;
        }

        public bool Update(SyllabusM syllabus)
        {
            _language.UserLanguage();

            var isExist = _syllabus.Get(syllabus);
            if (isExist)
            {
                throw new Exception(_language.Language.BookAlreadyExist);
            }

            return _syllabus.Update(syllabus);
        }

        public bool Delete(SyllabusM syllabus)
        {
            return _syllabus.Delete(syllabus);
        }

        public object GetAllByJoin()
        {
            return _syllabus.GetAllByJoin();
        }

        public DataTable GetByLikeFilter(SyllabusM syllabus)
        {
            return _syllabus.GetByLikeFilter(syllabus);
        }
        public DataTable GetByFilter(SyllabusM syllabus)
        {
            return _syllabus.GetByFilter(syllabus);
        }
        public DataTable GetBySyllabusId(BookAccountM bookAccountM)
        {
            return _syllabus.GetBySyllabusId(bookAccountM);
        }
    }
}
