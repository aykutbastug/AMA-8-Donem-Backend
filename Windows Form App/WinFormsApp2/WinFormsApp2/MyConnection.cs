using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public static class MyConnection
    {
        public static SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindContext"].ToString());
    }
}
