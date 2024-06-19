using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bd
{
    class Class1
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=ELIZAVETA\SQLEXPRESS;Initial Catalog=""Agenstvo nedvijemosti"";Integrated Security=True");

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
