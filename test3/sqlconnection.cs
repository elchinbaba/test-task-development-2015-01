using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test3
{
    static class SqlConnect
    {
        //static string table = "ordering";
        static SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=ordering;Trusted_Connection=True;");

        public static void connect(ref SqlConnection connection)
        {
            connection = sqlConnection;
        }
        public static SqlConnection connect()
        {
            return sqlConnection;
        }
    }
}
