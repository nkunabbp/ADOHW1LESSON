using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOHW1LESSON
{
    internal class DataConnect
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=RegTable;Integrated Security=SSPI;");

        //ne ocen razobralas kak podklucit bd v wf poetomu sdelala metod iz interneta
        public void openconnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
        }

        public void closeconnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();

            }
        }

        public SqlConnection getsqlConnection() { return sqlConnection; }
    }
}