
using System.Data;
using System.Data.SqlClient;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class GradePointDal
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

        public bool Insert(GradePointM gradePoint)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO GradePoint(Minimum,Maximum,Grade,Point)VALUES(@Minimum, @Maximum, @Grade, @Point)";

            _sqlCommand.Parameters.AddWithValue("@Minimum", gradePoint.Minimum);
            _sqlCommand.Parameters.AddWithValue("@Maximum", gradePoint.Maximum);
            _sqlCommand.Parameters.AddWithValue("@Grade", gradePoint.Grade);
            _sqlCommand.Parameters.AddWithValue("@Point", gradePoint.Point);

            var isSaved = _sqlCommand.ExecuteNonQuery();

            return isSaved > 0;
        }

        public bool Update(GradePointM gradePoint)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE GradePoint SET Minimum=@Minimum, Maximum=@Maximum, Grade=@Grade, Point=@Point WHERE Id='" + gradePoint.Id + "'";

            _sqlCommand.Parameters.AddWithValue("@Minimum", gradePoint.Minimum);
            _sqlCommand.Parameters.AddWithValue("@Maximum", gradePoint.Maximum);
            _sqlCommand.Parameters.AddWithValue("@Grade", gradePoint.Grade);
            _sqlCommand.Parameters.AddWithValue("@Point", gradePoint.Point);

            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        public bool Delete(GradePointM gradePoint)
        {
            DbConnection();
            _sqlCommand.CommandText = "DELETE GradePoint WHERE Id='" + gradePoint.Id + "'";
            var isDelete = _sqlCommand.ExecuteNonQuery();

            return isDelete > 0;
        }

        public bool Get(GradePointM gradePoint)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM GradePoint WHERE Grade='" + gradePoint.Grade + "' OR Point='" + gradePoint.Point + "'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();
        }

        public DataTable GetById(GradePointM gradePoint)
        {
            DbConnection();

            _sqlCommand.CommandText = "SELECT *FROM GradePoint WHERE Id='"+gradePoint.Id+"'";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }

        public DataTable GetAll()
        {
            DbConnection();

            _sqlCommand.CommandText = "SELECT *FROM GradePoint";
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }

        public DataTable GetByMark(double mark, double totalMark)
        {
            DbConnection();
            var marks = ((mark*100)/totalMark);
            _sqlCommand.CommandText = "SELECT *FROM GradePoint WHERE '" + marks + "' BETWEEN Minimum AND Maximum";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);

            return _dataTable;
        }
    }
}
