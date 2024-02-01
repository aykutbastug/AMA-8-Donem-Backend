using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities.Helpers
{
    public static class SqlHelper
    {
        public static DataRowCollection GetRows(string sqlCommandText, SqlConnection connection, List<CommandParameter>? parameters)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommandText, connection);
            if (parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    adapter.SelectCommand.Parameters.AddWithValue(item.Name, item.Value); 
                }
            }

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt.Rows;
        }        
    }

    public class CommandParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}


