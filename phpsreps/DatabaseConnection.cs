using System;
using System.Data.SqlClient;   // System.Data.dll 
//using System.Data;           // For:  SqlDbType , ParameterDirection

namespace phpsreps
{
    public static class DBConnect
    {
        public static SqlConnection Session = new SqlConnection(Details());

        /// <summary>
        /// Hardcoded string details for connecting to the database. In roduction in would be necessary for these
        /// details to be encrypted and not plain text for security.
        /// </summary>
        /// <returns>
        /// Cnnection string for the database to open a session.
        /// </returns>
        private static string Details()
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "phpsreps.database.windows.net";
            cb.UserID = "SwinDP2tu05g1";
            cb.Password = "SwinDP2team"; // should not be plain text.
            cb.InitialCatalog = "phpsreps";

            return cb.ConnectionString;
        }
    }
}

