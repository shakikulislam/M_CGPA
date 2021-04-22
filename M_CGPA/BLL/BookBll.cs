using System;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class BookBll
    {
        readonly BookDal _book = new BookDal();
        readonly SelectLanguage _language = new SelectLanguage();

        public bool Insert(BookM bookM)
        {
            _language.UserLanguage();

            var isExist = _book.Get(bookM);
            if (isExist)
            {
                throw new Exception(_language.Language.BookAlreadyExist);
            }

            var isSaved = _book.Insert(bookM);
            return isSaved;
        }
        
        public bool Update(BookM bookM)
        {
            _language.UserLanguage();

            var isExist = _book.Get(bookM);
            if (isExist)
            {
                //throw new Exception(_language.Language.BookAlreadyExist);
            }

            return _book.Update(bookM);
        }

        public bool Delete(BookM bookM)
        {
            return _book.Delete(bookM);
        }

        public object GetAll()
        {
            return _book.GetAll();
        }

        public object GetByFilter(string filtervalue)
        {
            return _book.GetByFilter(filtervalue);
        }
    }
}
