using System;
using System.Windows.Forms;
using System.Data.SqlClient;   // System.Data.dll 
//using System.Data;           // For:  SqlDbType , ParameterDirection

namespace phpsreps
{
    public class TsqlQuery
    {
        private SqlConnection Connection { get => DBConnect.Session; }
        public SqlCommand Command { get; set; }

        public TsqlQuery(string tsqlPurpose, string tsqlSourceCode)
        {
            //MessageBox.Show(tsqlPurpose);

            Command = new SqlCommand(tsqlSourceCode, Connection);
        }
    }
}
