using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theTexasStateGraderApplication
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = null;

            string connectionString = "Data Source=sql.mccoy.txstate.edu;Initial Catalog=cis3325_students;Integrated Security=True";

            conn = new SqlConnection(connectionString);

            return conn;
        }
    }
}
