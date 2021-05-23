using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1712534
{
    class DataConnection
    {
        string cntString;

        public DataConnection()
        {
            cntString = "user id=superadmin;" +
                        "password=superadmin;server=localhost;" +
                        "Trusted_Connection=yes;" +
                        "database=QLSVNhom; " +
                        "connection timeout=30";
        }

         public SqlConnection getConnect()
        {
            return new SqlConnection(cntString);
        }
    }
}
