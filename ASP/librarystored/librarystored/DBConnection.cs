using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarystored
{
  
        public static class DBConnection
        {
            public static SqlConnection con;
            public static SqlConnection getConnection()
            {
                con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=Trust");

                return con;
            }
        }
    }
}

