using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class ResultDal
    {
        readonly ConnectionString _connectionString = new ConnectionString();
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;
        DataSet _dataSet;
        private SqlDataReader _sqlDataReader;

        public void DbConnection()
        {
            _connectionString.Connection();
            _sqlCommand = new SqlCommand { Connection = _connectionString.SqlConnection };
        }

        public bool Insert(ResultM result)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO Result (StudentId,SyllabusId,Number,OptionalSubject,Grade,Point,AverageGrade,AveragePoint,Result,RangeOfMarks) " +
                                      "VALUES('" + result.StudentId + "','" + result.SyllabusId + "','" + result.Number +
                                      "','" + result.OptionalSubject + "','" + result.Grade + "','" + result.Point +
                                      "','" + result.AverageGrade + "','" + result.AveragePoint + "','" + result.Result +
                                      "','" + result.RangeOfMarks + "')";
            var isSaved = _sqlCommand.ExecuteNonQuery();

            return isSaved > 0;
        }

        //public bool Update(BookM book)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "UPDATE Book SET Code='" + book.Code + "', Name='" + book.Name + "', Mark='" + book.Mark + "' WHERE Id='" + book.Id + "'";
        //    var isUpdate = _sqlCommand.ExecuteNonQuery();

        //    return isUpdate > 0;
        //}

        //public bool Delete(BookM book)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "DELETE Book WHERE Id='" + book.Id + "'";
        //    var isDelete = _sqlCommand.ExecuteNonQuery();

        //    return isDelete > 0;
        //}

        //public bool Get(BookM book)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "SELECT *FROM Book WHERE Code='" + book.Code + "' AND Name='" + book.Name + "' AND Mark='" + book.Mark + "'";
        //    _sqlDataReader = _sqlCommand.ExecuteReader();

        //    return _sqlDataReader.Read();
        //}

        //public object GetAll()
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "SELECT *FROM Book";
        //    _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
        //    _dataSet = new DataSet();
        //    _sqlDataAdapter.Fill(_dataSet);

        //    return _dataSet.Tables[0];
        //}
        //public object GetByFilter(string filtervalue)
        //{
        //    DbConnection();
        //    _sqlCommand.CommandText = "SELECT *FROM Book WHERE Code LIKE '%" + filtervalue + "%' OR Name LIKE '%" + filtervalue + "%' OR Mark LIKE '%" + filtervalue + "%' ";
        //    _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
        //    _dataSet = new DataSet();
        //    _sqlDataAdapter.Fill(_dataSet);

        //    return _dataSet.Tables[0];
        //}
    }
}
