using M_CGPA.DAL;
using M_CGPA.Model;

namespace M_CGPA.BLL
{
    class ResultBll
    {
        private ResultDal _resultDal=new ResultDal();
        public bool Insert(ResultM result)
        {
            return _resultDal.Insert(result);
        }
    }
}
