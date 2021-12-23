using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace test3
{
    static class ShoW
    {
        static SqlConnection connection = SqlConnect.connect();

        static public DateTime AddWeek(int num)
        {
            return DateTime.Now.AddDays(7 * num);
        }

        static public DateTime AddDays(int num)
        {
            return DateTime.Now.AddDays(num);
        }

        static public DataTable show(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        static public DataTable show(Func<int, DateTime> func)
        {
            DateTime today = DateTime.Now.Date, last;
            //T var = (T)(object)(-1);
            last = func(-1);
            last.ToString("yyyy'-'MM'-'dd");
            today.ToString("yyyy'-'MM'-'dd");
            return show("select * from orders where Date between '" + last + "' and '" + today + "'");
        }

        static public DataTable show(string from, string to)
        {
            return show("select * from orders where Date between '" + from + "' and '" + to + "'");
        }
    }
}
