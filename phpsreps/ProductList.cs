using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace phpsreps
{
    static class ProductList
    {
        public static List<Product> products = new List<Product>();

        public static void UpdateProducts()
        {
            products.Clear();

            TsqlQuery query = new TsqlQuery("Update products from DB", DBProductQueryString());

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6));

                products.Add(p);

            }

        }

        private static string DBProductQueryString()
        {
            StringBuilder tSqlQueryString = new StringBuilder();

            tSqlQueryString.AppendFormat(@"
            -- returns all products in DB
            SELECT * FROM dbo.products
            ");

            return tSqlQueryString.ToString();
        }

        // method to lookup a pass code.
        public static Product SearchForPorduct(string pCode)
        {
            foreach (Product p in products)
            {
                if (p.ProductCode == pCode)
                { return p; }
            }

            return null; //Should this return empty?
        }
    }
}
