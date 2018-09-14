using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace phpsreps
{
    public static class CompanyList
    {
        public static List<Company> companies = new List<Company>();

        public static void UpdateCompanies()
        {
            companies.Clear();

            TsqlQuery query = new TsqlQuery("Update companies from DB", DBCompanyQueryString());

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                Company c = new Company(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                    );

                companies.Add(c);
            }
        }

        private static string DBCompanyQueryString()
        {
            StringBuilder tSqlQueryString = new StringBuilder();

            tSqlQueryString.AppendFormat(@"
            -- returns all companies in DB
            SELECT * FROM dbo.companies
            ");

            return tSqlQueryString.ToString();
        }
    }
}
