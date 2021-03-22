using System;
using M_CGPA.DAL;
using M_CGPA.Language;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class BookAccountBll
    {
        readonly BookAccountDal _bookAccountDal=new BookAccountDal();
        readonly SelectLanguage _language = new SelectLanguage();

        public bool Insert(BookAccountM bookAccountM)
        {
            _language.UserLanguage();

            //var isExist = _book.Get(bookM);
            //if (isExist)
            //{
            //    throw new Exception(_language.Language.BookAlreadyExist);
            //}

            var isSaved = _bookAccountDal.Insert(bookAccountM);
            return isSaved;
        }

        //public bool Update(BookAccountM bookAccountM)
        //{
        //    _language.UserLanguage();

        //    var isExist = _book.Get(bookM);
        //    if (isExist)
        //    {
        //        throw new Exception(_language.Language.BookAlreadyExist);
        //    }

        //    return _book.Update(bookM);
        //}

        //public bool Delete(BookAccountM bookAccountM)
        //{
        //    return _book.Delete(bookM);
        //}

        //public object GetAll()
        //{
        //    return _book.GetAll();
        //}

        //public object GetByFilter(BookAccountM bookAccountM)
        //{
        //    return _book.GetByFilter(bookM);
        //}
    }
}
