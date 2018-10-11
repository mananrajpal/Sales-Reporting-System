using System.Text;

namespace phpsreps
{
    public class Company
    {
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public Company(string cID, string cName, string cAddr, string cTel)
        {
            CompanyID = cID;
            CompanyName = cName;
            Address = cAddr;
            Tel = cTel;
        }

        #region Company Insert

        public void InsertCompany()
        {
            string sqlNewCompany = SqlNewCompanyString();
            TsqlNonQuery insertNewCompany = new TsqlNonQuery("New Company", sqlNewCompany);

            CompanyList.companies.Add(this);
        }

        private string SqlNewCompanyString()
        {
            StringBuilder sqlInsert = new StringBuilder();

            sqlInsert.AppendFormat(@"
            -- Insert a new company to the DB
            INSERT INTO dbo.companies(ID, Company_Name, Address, Tel)
            VALUES ('{0}', '{1}', '{2}', '{3}');
            ", CompanyID, CompanyName, Address, Tel);

            return sqlInsert.ToString();
        }

        #endregion
    }
}
