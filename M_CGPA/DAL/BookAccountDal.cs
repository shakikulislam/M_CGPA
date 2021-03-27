
using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class BookAccountDal
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
            _sqlCommand = new SqlCommand { Connection = _connectionString.SqlConnection };
        }

        public bool Insert(BookAccountM bookAccountM)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO BookAccount(StudentId,Book,Year)VALUES('" + bookAccountM.StudentId + "','" + bookAccountM.Book + "','" + bookAccountM.Year + "')";
            var isSaved = _sqlCommand.ExecuteNonQuery();

            return isSaved > 0;
        }

        public bool Update(BookAccountM bookAccountM)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE BookAccount SET Book='" + bookAccountM.Book + "' WHERE Id='" + bookAccountM.Id + "'";
            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        //public bool Delete(BookAccountM bookAccountM)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "DELETE Book WHERE Id='" + book.Id + "'";
        //    var isDelete = _sqlCommand.ExecuteNonQuery();

        //    return isDelete > 0;
        //}

        public DataTable GetAll(BookAccountM bookAccountM)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM BookAccount WHERE StudentId='" + bookAccountM.StudentId + "' ";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }
        

        //public object GetBook()
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "SELECT *FROM BookAccount";
        //    _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
        //    _dataSet = new DataSet();
        //    _sqlDataAdapter.Fill(_dataSet);

        //    return _dataSet.Tables[0];
        //}

        //public object GetByFilter(BookAccountM bookAccountM)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "SELECT *FROM Book WHERE Code LIKE '%" + book.Code + "%' AND Name LIKE '%" + book.Name + "%' ";
        //    _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
        //    _dataSet = new DataSet();
        //    _sqlDataAdapter.Fill(_dataSet);

        //    return _dataSet.Tables[0];
        //}
    }
}
