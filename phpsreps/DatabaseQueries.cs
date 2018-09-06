using System;
using System.Windows.Forms;
using System.Data.SqlClient;   // System.Data.dll 
//using System.Data;           // For:  SqlDbType , ParameterDirection

namespace phpsreps
{
    public class DBQueries

    {
        public static void Submit_6_Tsql_SelectProducts(SqlConnection connection)
        {
            MessageBox.Show("SELECT PRODUCTS...");

            string tsql = Build_6_Tsql_SelectProducts();

            using (var command = new SqlCommand(tsql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string message = String.Format("{0}",
                           reader.GetString(0));

                        MessageBox.Show(message);
                    }
                }
            }
        }

        static string Build_6_Tsql_SelectProducts()
        {
            return @"
            -- Look at all the final Employees.
            SELECT
                  prod.Product_Name
               FROM
                  dbo.products   as prod
               ORDER BY
                  Product_Name;
            ";
        }
    }
}
