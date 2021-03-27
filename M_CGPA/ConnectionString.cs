using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using M_CGPA.Properties;

namespace M_CGPA
{
    public class ConnectionString
    {
        public string Server = Environment.MachineName;
        //private readonly string _databaseLink = Settings.Default.DatabaseLink;
        private readonly string _databaseLink = @"‪E:\dbfile\M_CGPA\m_cgpa.mdf";
        //private readonly string _databaseLink = @"D:\Shakikul Islam\Create\dbfile\M_CGPA\m_cgpa.mdf";
        public SqlConnection SqlConnection = new SqlConnection();

        public void Connection()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
            //SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\dbfile\M_CGPA\m_cgpa.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Shakikul Islam\Create\dbfile\M_CGPA\m_cgpa.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlConnection =new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFileName=" + _databaseLink +"; Integrated Security=True;Connect Timeout=30;User Instance=True");
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\dbfile\M_CGPA\m_cgpa.mdf;Integrated Security=True;Connect Timeout=30
            SqlConnection.Open();

        }

    }
}
