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
        DataSet _dataSet;
        private SqlDataReader _sqlDataReader;

        public void DbConnection()
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;
        }

        public bool AddClass(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO Class(Name)VALUES('" + classM.Name + "')";
            var isSaved=_sqlCommand.ExecuteNonQuery();

            return isSaved>0;
        }

        public bool GetClass(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Class WHERE Name='" + classM.Name + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();
        }

        public object GetAllClass()
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Class";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataSet=new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }

        public bool UpdateClass(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE Class SET Name='" + classM.Name + "' WHERE Id='" + classM.Id + "'";
            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        public bool DeleteClass(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "DELETE Class WHERE Id='" + classM.Id + "'";
            var isDelete = _sqlCommand.ExecuteNonQuery();

            return isDelete > 0;
        }
    }
}
