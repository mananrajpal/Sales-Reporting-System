using System;
using System.Data.SqlClient;   // System.Data.dll 

namespace phpsreps
{
    class TsqlNonQuery
    {
        private SqlConnection Connection { get => DBConnect.Session;  }

        /// <summary>
        /// Creates a Non query with the DB. Such as an Insert etc...
        /// </summary>
        /// <param name="tsqlPurpose">The purpose of the NonQuery</param>
        /// <param name="tsqlSourceCode">The source code string to control the DB</param>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        public TsqlNonQuery(string tsqlPurpose, string tsqlSourceCode, string parameterName = null, string parameterValue = null)
        {
            //MessageBox.Show("Finalising Sale...");

            using (var command = new SqlCommand(tsqlSourceCode, Connection))
            {
                if (parameterName != null)
                {
                    command.Parameters.AddWithValue(  // Or, use SqlParameter class.
                       parameterName,
                       parameterValue);
                }
                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
