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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static List<SaleLine> GetProductSales(string product)
        {
            TsqlQuery query = new TsqlQuery("Get Products by SaleID", QuerySaleItemsString(product));
            List<SaleLine> productSales = new List<SaleLine>();

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                SaleLine s = new SaleLine(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3));

                productSales.Add(s);

            }

            return productSales;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private static string QuerySaleItemsString(string product)
        {
            StringBuilder saleItemQuery = new StringBuilder();

            saleItemQuery.AppendFormat(@"
                -- new sales line
                SELECT 'Product_ID','Sale_ID', 'Qty_Sold', 'Total_Cost' FROM dbo.sale_items
                ORDER BY Sale_ID
                WHERE Product_ID = '{1}';
                ", product);

            return saleItemQuery.ToString();
        }
    }
}
