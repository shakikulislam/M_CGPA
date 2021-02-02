using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class ClassDal
    {
        readonly ConnectionString _connectionString = new ConnectionString();
        private readonly SqlCommand _sqlCommand = new SqlCommand();
        private SqlDataAdapter _sqlDataAdapter;
        readonly DataSet _dataSet = new DataSet();
        private SqlDataReader _sqlDataReader;

        public bool AddClass(ClassM classM)
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;

            _sqlCommand.CommandText = "INSERT INTO Class(Name)VALUES('" + classM.Name + "')";
            var isSaved=_sqlCommand.ExecuteNonQuery();
            
            return isSaved>0?true:false;
        }

        public bool GetClass(ClassM classM)
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;

            _sqlCommand.CommandText = "SELECT *FROM Class WHERE Name='" + classM.Name + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();

        }

        public object GetAllClass()
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;

            _sqlCommand.CommandText = "SELECT *FROM Class";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }
    }
}
