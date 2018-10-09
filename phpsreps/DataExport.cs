using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phpsreps
{
    static class DataExport
    {
        private static SortedDictionary<string, Dictionary<string,string>> productsToCSV = new SortedDictionary<string, Dictionary<string,string>>();
        private static SortedDictionary<string, Dictionary<string, string>> companiesToCSV = new SortedDictionary<string, Dictionary<string, string>>();
        private static SortedDictionary<string, Dictionary<string, string>> salesToCSV = new SortedDictionary<string, Dictionary<string, string>>();
        private static SortedDictionary<string, Dictionary<string, string>> stockflowToCSV = new SortedDictionary<string, Dictionary<string, string>>();

        /// <summary>
        /// First updates the product list from the database to scrape for changes. Then exports to csv.
        /// </summary>
        public static void ExportProducts()
        {
            ProductList.UpdateProducts();
            Dictionary<string,string> productDetails = new Dictionary<string, string>()
            {
                {"Name", "" },
                {"Category", "" },
                {"Cost_Price", "" },
                {"Retail_Cost", "" },
                {"Current_Stock", "" }
            };

            foreach (Product p in ProductList.products)
            {
                if (!productsToCSV.ContainsKey(p.ProductCode))
                {
                    string product = p.ProductCode;
                    productsToCSV.Add(p.ProductCode, new Dictionary<string,string>(productDetails));
                    productsToCSV[product]["Name"] = p.ProductName;
                    productsToCSV[product]["Category"] = p.Cat.ToString();
                    productsToCSV[product]["Cost_Price"] = p.CostPrice.ToString();
                    productsToCSV[product]["Retail_Cost"] = p.RetailPrice.ToString();
                    productsToCSV[product]["Current_Stock"] = p.StockLevel.ToString();
                }
            }

            string file = "Product_List_as_of_" + DateTime.Today.Date.Year + "-" + DateTime.Today.Date.Month + "-" + DateTime.Today.Date.Day + ".csv";

            WriteCSV(file, productsToCSV);
        }

        /// <summary>
        /// First Updates the company list from the database to scrape changes, then exports to a csv.
        /// </summary>
        public static void ExportCompanies()
        {
            CompanyList.UpdateCompanies();
            Dictionary<string, string> companyDetails = new Dictionary<string, string>()
            {
                {"Name", "" },
                {"Address", "" },
                {"Tel", "" }
            };

            foreach (Company c in CompanyList.companies)
            {
                if (!companiesToCSV.ContainsKey(c.CompanyID))
                {
                    string company = c.CompanyID;
                    companiesToCSV.Add(c.CompanyID, new Dictionary<string, string>(companyDetails));
                    companiesToCSV[company]["Name"] = c.CompanyName;
                    companiesToCSV[company]["Address"] = c.Address;
                    companiesToCSV[company]["Telephone"] = c.Tel;
                }
            }

            string file = "Company_List_as_of_" + DateTime.Today.Date.Year + "-" + DateTime.Today.Date.Month + "-" + DateTime.Today.Date.Day + ".csv";

            WriteCSV(file, companiesToCSV);
        }

        /// <summary>
        /// Queries the database between two dates and produces a csv of the sales line info.
        /// </summary>
        /// <param name="earliest">The ealiest date to export sales from</param>
        /// <param name="latest">The latest date to export sales from</param>
        public static void ExportSales(string earliest, string latest)
        {
            TsqlQuery query = new TsqlQuery("Get sales lines for export", QuerySalesString(earliest, latest));
            SqlDataReader reader = query.Command.ExecuteReader();

            Dictionary<string, string> saleDetails = new Dictionary<string, string>()
            {
                {"SaleID", "" },
                {"SaleDate", "" },
                {"ProductID", "" },
                {"QuantitySold", "" },
                {"CostPerItem", "" },
                {"LineTotal", "" }
            };

            while (reader.Read())
            {
                if(!salesToCSV.ContainsKey(reader.GetInt32(0).ToString()))
                {
                    string key = reader.GetInt32(0).ToString();
                    salesToCSV.Add(key, new Dictionary<string, string>(saleDetails));
                    salesToCSV[key]["SaleID"] = reader.GetInt32(1).ToString();
                    salesToCSV[key]["SaleDate"] = reader.GetDateTime(2).ToString();
                    salesToCSV[key]["ProductID"] = reader.GetString(3);
                    salesToCSV[key]["QuantitySold"] = reader.GetInt16(4).ToString();
                    salesToCSV[key]["CostPerItem"] = reader.GetDecimal(5).ToString();
                    salesToCSV[key]["LineTotal"] = reader.GetDecimal(6).ToString();
                }
            }

            reader.Close();
            string file = "Sale_Details_" + earliest + "_-_" + latest + ".csv";
            WriteCSV(file, salesToCSV);
        }
        
        /// <summary>
        /// Query of sales between two dates
        /// </summary>
        /// <param name="earliest"></param>
        /// <param name="latest"></param>
        /// <returns></returns>
        private static string QuerySalesString(string earliest, string latest)
        {
            StringBuilder salesExportQuery = new StringBuilder();

            salesExportQuery.AppendFormat(@"
                SELECT s.ID, s.Sale_ID, x.Sale_Date, s.Product_ID, s.Qty_Sold, s.Cost_Per_Item, s.Total_Cost
                FROM dbo.sale_items s LEFT JOIN dbo.sales x ON s.Sale_ID = x.ID
                WHERE x.Sale_Date BETWEEN '{0}' AND '{1}'; 
                ", earliest, latest);

            return salesExportQuery.ToString();
        }

        /// <summary>
        /// Writes a sorted dictionary to a csv.
        /// </summary>
        /// <param name="d"></param>
        private static void WriteCSV(string file, SortedDictionary<string,Dictionary<string,string>> d)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + file;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                
                foreach (string key in d.Keys)
                {
                    int index = 0;
                    foreach (KeyValuePair<string,string> kvp in d[key])
                    {
                        index++;
                        sw.Write(kvp.Value);
                        if (index < d[key].Count())
                        {
                            sw.Write(", ");
                        }
                    }
                    sw.WriteLine();
                }

                sw.Close();
            }
        }
    }
}
