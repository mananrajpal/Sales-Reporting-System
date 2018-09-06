using System;
using System.Data.SqlClient;   // System.Data.dll 
//using System.Data;           // For:  SqlDbType , ParameterDirection

namespace phpsreps
{

    public static class DBConnect
    {

        public static void Connect()
        {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "phpsreps.database.windows.net";
                cb.UserID = "SwinDP2tu05g1";
                cb.Password = "SwinDP2team";
                cb.InitialCatalog = "phpsreps";

                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    connection.Open();

                    /*
                    Submit_Tsql_NonQuery(connection, "2 - Create-Tables",
                       //Build_2_Tsql_CreateTables());

                    Submit_Tsql_NonQuery(connection, "3 - Inserts",
                       Build_3_Tsql_Inserts());

                    Submit_Tsql_NonQuery(connection, "4 - Update-Join",
                       Build_4_Tsql_UpdateJoin(),
                       "@csharpParmDepartmentName", "Accounting");

                    Submit_Tsql_NonQuery(connection, "5 - Delete-Join",
                       Build_5_Tsql_DeleteJoin(),
                       "@csharpParmDepartmentName", "Legal");

                    */

                    DBQueries.Submit_6_Tsql_SelectProducts(connection);

                }
            }
    }
}

