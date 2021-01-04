using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
