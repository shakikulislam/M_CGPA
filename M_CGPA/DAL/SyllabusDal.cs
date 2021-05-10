using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class SyllabusDal
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

        public bool Insert(SyllabusM syllabus)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO Syllabus(Year,ClassId,BookId)VALUES('" + syllabus.Year + "','" + syllabus.ClassId + "','"+syllabus.BookId+"')";
            var isSaved = _sqlCommand.ExecuteNonQuery();

            return isSaved > 0;
        }

        public bool Update(SyllabusM syllabus)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE Syllabus SET Year='" + syllabus.Year + "', ClassId='" + syllabus.ClassId + "',BookId='"+syllabus.BookId+"' WHERE Id='" + syllabus.Id + "'";
            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        public bool Delete(SyllabusM syllabus)
        {
            DbConnection();
            _sqlCommand.CommandText = "DELETE Syllabus WHERE Id='" + syllabus.Id + "'";
            var isDelete = _sqlCommand.ExecuteNonQuery();

            return isDelete > 0;
        }

        public bool Get(SyllabusM syllabus)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Syllabus WHERE Year='" + syllabus.Year + "' AND ClassId='" + syllabus.ClassId + "' AND BookId='"+syllabus.BookId+"'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();
        }

        public object GetAllByJoin()
        {
            DbConnection();
            var querry ="SELECT Syllabus.Id, Syllabus.Year,Book.Id AS BookId, Book.Code AS BookCode, Book.Name AS Book, Class.Id AS ClassId, Class.Name AS Class "+
                       "FROM Syllabus "+
					   "INNER JOIN Book ON Syllabus.BookId=Book.Id "+
                       "INNER JOIN Class ON Syllabus.ClassId=Class.Id";
            _sqlCommand.CommandText = querry;
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }

        public DataTable GetByLikeFilter(SyllabusM syllabus)
        {
            DbConnection();
            var querry ="SELECT Syllabus.Id, Syllabus.Year,Book.Id AS BookId, Book.Code AS BookCode, Book.Name AS Book, Class.Id AS ClassId, Class.Name AS Class " +
                "FROM Syllabus " +
                "INNER JOIN Book ON Syllabus.BookId=Book.Id " +
                "INNER JOIN Class ON Syllabus.ClassId=Class.Id " +
                "WHERE Year LIKE '%" + syllabus.Year + "%' " +
                "AND ClassId='" + syllabus.ClassId + "' ";

            _sqlCommand.CommandText = querry;
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }

        public DataTable GetByFilter(SyllabusM syllabus)
        {
            DbConnection();
            var querry ="SELECT Syllabus.Id, Syllabus.Year,Book.Id AS BookId, Book.Code AS BookCode, Book.Name AS Book, Class.Id AS ClassId, Class.Name AS Class " +
                "FROM Syllabus " +
                "INNER JOIN Book ON Syllabus.BookId=Book.Id " +
                "INNER JOIN Class ON Syllabus.ClassId=Class.Id " +
                "WHERE Year='" + syllabus.Year + "' " +
                "AND ClassId='" + syllabus.ClassId + "' ";

            _sqlCommand.CommandText = querry;
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }

        public DataTable GetBySyllabusId(BookAccountM bookAccountM)
        {
            DbConnection();
            var querry = "SELECT Syllabus.Id, Syllabus.Year, Book.Id AS BookId, Book.Code AS BookCode, Book.Name AS Book, Class.Id AS ClassId, Class.Name AS Class " +
                "FROM Syllabus " +
                "INNER JOIN Book ON Syllabus.BookId=Book.Id " +
                "INNER JOIN Class ON Syllabus.ClassId=Class.Id " +
                "WHERE Syllabus.Id IN (" + bookAccountM.Book + ") ";

            _sqlCommand.CommandText = querry;
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }

        public DataTable GetBookMarkBySyllabusId(SyllabusM syllabusM)
        {
            DbConnection();

            var querry = "SELECT Syllabus.Id, Syllabus.BookId, Book.Id AS BookId, Book.Mark AS Mark " +
                         "FROM Syllabus " +
                         "INNER JOIN Book ON Syllabus.BookId=Book.Id " +
                         "WHERE Syllabus.Id='" + syllabusM.Id + "'";
            _sqlCommand.CommandText = querry;
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }
        
    }
}
