using System;
using System.Text;

namespace phpsreps
{
    public enum Category
    {
        FirstAid,
        Medicines,
        Beauty,
        PersonalCare,
        Supplements
    }

    public class Product
    {
        public string ProductCode { get; set; }
        public Category Cat { get; set; }
        public string ProductName { get; set; }
        public string CompanyID { get; set; }
        public float CostPrice { get; set; }
        public float RetailPrice { get; set; }
        public int StockLevel { get; set; }

        public Product(string pCode, string cat, string pName, string compID, string cost, string retail, string levels = "0")
        {
            ProductCode = pCode;

            if (!Enum.TryParse(cat, out Category outcat))
            {
                //ToDo : break and send warning...
            }

            Cat = outcat;

            ProductName = pName;
            CompanyID = compID;

            if (!float.TryParse(cost, out float c))
            {
                //ToDo : break and send warning...
            }

            CostPrice = c;

            if (!float.TryParse(retail, out float r))
            {
                //ToDo : break and send warning...
            }
            
            RetailPrice = r;

            if (!Int32.TryParse(levels, out int l))
            {
                //ToDo : break and send warning...
            }

            StockLevel = l;
        }

        #region ProductInsert

        /// <summary>
        /// Insert this product into the DB and the programs product list.
        /// </summary>
        public void InsertProduct()
        {
            string sqlNewProduct = SqlNewProductString();
            TsqlNonQuery insertNewProduct = new TsqlNonQuery("New Product", sqlNewProduct);
            ProductList.products.Add(this); // add self to current list.
        }

        private string SqlNewProductString()
        {
            StringBuilder sqlInsert = new StringBuilder();

            sqlInsert.AppendFormat(@"
            -- Insert a new porduct to the DB
            INSERT INTO dbo.products(Product_Code, Category, Product_Name, Company_ID, Cost_Price, Retail_Price, InStock)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6});
            ", ProductCode, Cat, ProductName, CompanyID, CostPrice, RetailPrice, StockLevel);

            return sqlInsert.ToString();
        }

        #endregion

        #region UpdateStock

        /// <summary>
        /// Update the stock level of a product.
        /// </summary>
        /// <param name="change">The change in stock level. Negative for sale, positive for order recieved</param>
        public void UpdateStockLevel(string change)
        {
            if (!Int32.TryParse(change, out int c))
            {
                //ToDO: create breakpoint
            }

            string sqlUpdateStock = SqlUpdateStock(c);
            TsqlNonQuery UpdateStock = new TsqlNonQuery("Update Stock Levels", sqlUpdateStock);
        }

        private string SqlUpdateStock(int change)
        {
            StringBuilder sqlUpdate = new StringBuilder();

            sqlUpdate.AppendFormat(@"
            -- Update Stock Levels
            UPDATE dbo.products
            SET InStock += {0}
            WHERE Product_Code = {1};
            ", change, ProductCode);

            return sqlUpdate.ToString();
        }
        #endregion

        public void DeleteProduct()
        {

        }

    }
}
