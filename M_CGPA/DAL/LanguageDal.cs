using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace M_CGPA.DAL
{
    class LanguageDal
    {
        readonly ConnectionString _connectionString=new ConnectionString();
        private readonly SqlCommand _sqlCommand=new SqlCommand();
        private SqlDataAdapter _sqlDataAdapter;
        readonly DataSet _dataSet=new DataSet();

        public object LanguageList()
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;
            _sqlCommand.CommandText = "SELECT *FROM Language";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _sqlDataAdapter.Fill(_dataSet);
            return _dataSet.Tables[0];

        }
    }
}
