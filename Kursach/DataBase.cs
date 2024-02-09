using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Kursach
{
    internal class DataBase
    {
        SqlConnection sqlconn = new SqlConnection(@"Data Source=LAPTOP-1JBH7IQQ\SQLEXPRESS;initial catalog= Beauty_Salon;Integrated Security=True");        public void openconection()
        {
            if (sqlconn.State == System.Data.ConnectionState.Closed)
            {
                sqlconn.Open();
            }
        }
        public void closeconection()
        {
            if (sqlconn.State == System.Data.ConnectionState.Open)
            {
                sqlconn.Close();
            }
        }
        public SqlConnection getconnection()
        {
            return sqlconn;
        }

        internal DataTable ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
