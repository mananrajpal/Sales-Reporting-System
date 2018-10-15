using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace phpsreps
{
    static class ProductList
    {
        public static List<Product> products = new List<Product>();

        /// <summary>
        /// Removes bad characters from a query.
        /// </summary>
        /// <param name="dirtyString"></param>
        public static string CleanString(string dirtyString)
        {
            HashSet<char> removeChars = new HashSet<char>(" ?&^$#@!()+-,:;<>’\'-_*");
            StringBuilder result = new StringBuilder(dirtyString.Length);
            foreach (char c in dirtyString)
                if (!removeChars.Contains(c)) // prevent dirty chars
                    result.Append(c);
            return result.ToString();
        }
        
        /// <summary>
        /// Updates the internal product list from the DB.
        /// </summary>
        public static void UpdateProducts()
        {
            products.Clear();

            TsqlQuery query = new TsqlQuery("Update products from DB", DBProductQueryString());

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product(
                    CleanString(reader.GetString(0)),
                    CleanString(reader.GetString(1)),
                    CleanString(reader.GetString(2)),
                    CleanString(reader.GetString(3)),
                    CleanString(reader.GetDecimal(4).ToString()),
                    CleanString(reader.GetDecimal(5).ToString()),
                    CleanString(reader.GetInt16(6).ToString()));

                products.Add(p);
            }

            reader.Close();

        }

        /// <summary>
        /// Creates a query string.
        /// </summary>
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
        public static Product SearchForProduct(string pCode)
        {
            foreach (Product p in products)
            {
                if (p.ProductCode == pCode)
                { return p; }
            }

            return null; //Should this return empty?
        }

        /// <summary>
        /// Returns a list of all sale lines for a specific product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static List<List<string>> GetProductSales(string product)
        {
            TsqlQuery query = new TsqlQuery("Get Products by SaleID", QuerySaleItemsString(product));
            List<List<string>> productSales = new List<List<string>>();

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                string p = CleanString(reader.GetString(0));
                string s = CleanString(reader.GetInt32(1).ToString());
                string q = CleanString(reader.GetInt16(2).ToString());
                string tc = CleanString(reader.GetDecimal(3).ToString());

                List<string> line = new List<string>();

                line.Add(p); // product_ID
                line.Add(s); // sale_ID
                line.Add(q); // qty
                line.Add(tc); //total cost

                productSales.Add(line);
            }

            return productSales;
        }

        /// <summary>
        /// returns an SQL query to retrieve sale lines for a specific product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private static string QuerySaleItemsString(string product)
        {
            StringBuilder saleItemQuery = new StringBuilder();

            saleItemQuery.AppendFormat(@"
                -- new sales line
                SELECT s.Product_ID, s.Sale_ID, s.Qty_Sold, s.Total_Cost FROM dbo.sale_items s
                WHERE s.Product_ID = '{0}'
                ORDER BY s.Sale_ID;
                ", product);

            return saleItemQuery.ToString();
        }

        /// <summary>
        /// returns an itemised list by category of each sale line.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public static List<List<string>> GetItemisedCategorySales(string category = null)
        {
            TsqlQuery query = new TsqlQuery("Get Sales by Category", QuerySaleCategoryString(true, category));
            List<List<string>> categorySales = new List<List<string>>();

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                string p = CleanString(reader.GetString(0));
                string c = CleanString(reader.GetString(1));
                string s = CleanString(reader.GetInt32(2).ToString());
                string q = CleanString(reader.GetInt16(3).ToString());
                string tc = CleanString(reader.GetDecimal(4).ToString());

                List<string> line = new List<string>();

                line.Add(p); // product_ID
                line.Add(c); // category
                line.Add(s); // sale_ID
                line.Add(q); // qty
                line.Add(tc); //total cost

                categorySales.Add(line);
            }

            return categorySales;
        }

        /// <summary>
        /// Will return a list of categories and their summarised sales.
        /// </summary>
        /// <returns></returns>
        public static List<List<string>> GetSummarisedCategorySales()
        {
            TsqlQuery query = new TsqlQuery("Get Sales by Category", QuerySaleCategoryString());
            List<List<string>> categorySales = new List<List<string>>();

            SqlDataReader reader = query.Command.ExecuteReader();

            while (reader.Read())
            {
                string c = CleanString(reader.GetString(0));
                string tc = CleanString(reader.GetString(1));

                List<string> line = new List<string>();

                line.Add(c); // category
                line.Add(tc); //total cost

                categorySales.Add(line);
            }

            return categorySales;
        }

        /// <summary>
        /// This query string will produce an SQL query for sales by category.
        /// It can be passed two optional parameters. The first to switch between itemised or summarised results.
        /// The second to narrow the itemised reults to a specific category.
        /// Sending a category string for a summarisation will have no effect.
        /// </summary>
        /// <param name="itemised"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        private static string QuerySaleCategoryString(bool itemised = false, string category = null)
        {
            StringBuilder saleItemQuery = new StringBuilder();

            if (itemised)
            {
                saleItemQuery.AppendFormat(@"
                -- Itemised Sales by Category
                SELECT s.Product_ID, p.Category, s.Sale_ID, s.Qty_Sold, s.Total_Cost
                FROM dbo.sale_items s INNER JOIN dbo.products p ON s.Product_ID = p.Product_Code
                
                ");

                if (category != null)
                {
                    saleItemQuery.AppendFormat(@"
                    WHERE p.Category = '{0}'
                    ", category);
                }

                saleItemQuery.AppendFormat(@"
                ORDER BY p.Category, s.Sale_ID
                ");

            }
            else
            {
                saleItemQuery.AppendFormat(@"
                    -- Summarised Sales by Category
                    SELECT p.Category, SUM(s.Total_Cost)
                    FROM dbo.sale_items s INNER JOIN dbo.products p ON s.Product_ID = p.Product_Code
                    GROUP BY p.Category
                    ");
            }

            return saleItemQuery.ToString();
        }
    }
}
