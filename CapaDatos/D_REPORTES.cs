using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class D_REPORTES
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            DataTable table = new DataTable();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("getSalesOrder"))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(table);
                    return table;
                }
            }
        }
    }
}
