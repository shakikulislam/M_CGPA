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

        public bool AddClass(ClassM classM)
        {
            _connectionString.Connection();
            _sqlCommand.Connection = _connectionString.SqlConnection;

            _sqlCommand.CommandText = "INSERT INTO Class(Name)VALUES('" + classM.Name + "')";
            var isSaved=_sqlCommand.ExecuteNonQuery();
            
            return isSaved>0?true:false;
        }
    }
}
