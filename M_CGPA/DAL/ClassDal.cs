using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class ClassDal
    {
        readonly ConnectionString _connectionString = new ConnectionString();
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;
        DataSet _dataSet;
        private DataTable _dataTable;
        private SqlDataReader _sqlDataReader;

        public void DbConnection()
        {
            _connectionString.Connection();
            _sqlCommand = new SqlCommand {Connection = _connectionString.SqlConnection};
        }

        public bool Insert(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO Class VALUES('" + classM.Name + "','"+classM.Number+"')";
            var isSaved=_sqlCommand.ExecuteNonQuery();

            return isSaved>0;
        }

        public bool Update(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE Class SET Name='" + classM.Name + "', Number='"+classM.Number+"' WHERE Id='" + classM.Id + "'";
            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        public bool Delete(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "DELETE Class WHERE Id='" + classM.Id + "'";
            var isDelete = _sqlCommand.ExecuteNonQuery();

            return isDelete > 0;
        }

        public bool GetByName(ClassM classM)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Class WHERE Name='" + classM.Name + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();
        }
        
        public object GetAll()
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Class ORDER BY Number ASC";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }

        public DataTable GetById(int id)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Class WHERE Id='" + id + "'";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }
    }
}
