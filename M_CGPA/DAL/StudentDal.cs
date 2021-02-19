﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M_CGPA.Model;

namespace M_CGPA.DAL
{
    class StudentDal
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

        public bool Insert(StudentM student)
        {
            DbConnection();
            _sqlCommand.CommandText = "INSERT INTO Student(Roll,Reg,ClassId,Session,AdmissionDate,DOB,StudentName,FatherName,MotherName,NID,BRN,PresentAddress,PermanentAddress)"+
                "VALUES(@Roll, @Reg, @ClassId, @Session, @AdmissionDate, @DOB, @StudentName, @FatherName, @MotherName, @NID, @BRN, @PresentAddress, @PermanentAddress)";
            
            _sqlCommand.Parameters.AddWithValue("@Roll",student.Roll);
            _sqlCommand.Parameters.AddWithValue("@Reg",student.Reg);
            _sqlCommand.Parameters.AddWithValue("@ClassId",student.ClassId);
            _sqlCommand.Parameters.AddWithValue("@Session",student.Session);
            _sqlCommand.Parameters.AddWithValue("@AdmissionDate",student.AdmissionDate);
            _sqlCommand.Parameters.AddWithValue("@DOB",student.Dob);
            _sqlCommand.Parameters.AddWithValue("@StudentName",student.StudentName);
            _sqlCommand.Parameters.AddWithValue("@FatherName",student.FatherName);
            _sqlCommand.Parameters.AddWithValue("@MotherName",student.MotherName);
            _sqlCommand.Parameters.AddWithValue("@NID",student.Nid);
            _sqlCommand.Parameters.AddWithValue("@BRN",student.Brn);
            _sqlCommand.Parameters.AddWithValue("@PresentAddress",student.PresentAddress);
            _sqlCommand.Parameters.AddWithValue("@PermanentAddress",student.PermanentAddress);

            var isSaved = _sqlCommand.ExecuteNonQuery();

            return isSaved > 0;
        }

        public bool Update(StudentM student)
        {
            DbConnection();
            _sqlCommand.CommandText = "UPDATE Student SET Roll='@Roll', Reg='@Reg' ,ClassId='@ClassId',Session='@Session'"+
                ",AdmissionDate='@AdmissionDate',DOB='@DOB',StudentName='@StudentName',FatherName='@FatherName',"+
                "MotherName='@MotherName',NID='@NID',BRN='@BRN',PresentAddress='@PresentAddress',PermanentAddress='@PermanentAddress')" +
                "WHERE Id='"+student.Id+"'";

            _sqlCommand.Parameters.AddWithValue("@Roll", student.Roll);
            _sqlCommand.Parameters.AddWithValue("@Reg", student.Reg);
            _sqlCommand.Parameters.AddWithValue("@ClassId", student.ClassId);
            _sqlCommand.Parameters.AddWithValue("@Session", student.Session);
            _sqlCommand.Parameters.AddWithValue("@AdmissionDate", student.AdmissionDate);
            _sqlCommand.Parameters.AddWithValue("@DOB", student.Dob);
            _sqlCommand.Parameters.AddWithValue("@StudentName", student.StudentName);
            _sqlCommand.Parameters.AddWithValue("@FatherName", student.FatherName);
            _sqlCommand.Parameters.AddWithValue("@MotherName", student.MotherName);
            _sqlCommand.Parameters.AddWithValue("@NID", student.Nid);
            _sqlCommand.Parameters.AddWithValue("@BRN", student.Brn);
            _sqlCommand.Parameters.AddWithValue("@PresentAddress", student.PresentAddress);
            _sqlCommand.Parameters.AddWithValue("@PermanentAddress", student.PermanentAddress);

            var isUpdate = _sqlCommand.ExecuteNonQuery();

            return isUpdate > 0;
        }

        public bool Delete(StudentM student)
        {
            DbConnection();
            _sqlCommand.CommandText = "DELETE Student WHERE Id='" + student.Id + "'";
            var isDelete = _sqlCommand.ExecuteNonQuery();

            return isDelete > 0;
        }

        public bool Get(StudentM student)
        {
            DbConnection();
            _sqlCommand.CommandText = "SELECT *FROM Student WHERE Roll='" + student.Roll + "' OR Reg='" + student.Reg + "' OR BRN='"+student.Brn+"'";
            _sqlDataReader = _sqlCommand.ExecuteReader();

            return _sqlDataReader.Read();
        }

        public object GetAllByJoin()
        {
            DbConnection();
            var querry = "SELECT Student.Id, Student.Roll, Student.Reg, Student.Session, Student.AdmissionDate, Student.DOB, Student.StudentName, Student.FatherName, Student.MotherName, Student.NID, Student.BRN, Student.PresentAddress, Student.PermanentAddress, Class.Id AS ClassId, Class.Name AS Class " +
                       "FROM Student " +
                       "INNER JOIN Class ON Student.ClassId=Class.Id";
            _sqlCommand.CommandText = querry;
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }

        public object GetByFilter(StudentM student)
        {
            DbConnection();
            //var querry = "SELECT Syllabus.Id, Syllabus.Year,Book.Id AS BookId, Book.Code AS BookCode, Book.Name AS Book, Class.Id AS ClassId, Class.Name AS Class " +
            //           "FROM Syllabus " +
            //           "INNER JOIN Book ON Syllabus.BookId=Book.Id " +
            //           "INNER JOIN Class ON Syllabus.ClassId=Class.Id " +
            //           "WHERE Year LIKE '%" + syllabus.Year + "%' " +
            //           "AND ClassId LIKE '%" + syllabus.ClassId + "%' ";
            //_sqlCommand.CommandText = querry;
            _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
            _dataSet = new DataSet();
            _sqlDataAdapter.Fill(_dataSet);

            return _dataSet.Tables[0];
        }
    }
}