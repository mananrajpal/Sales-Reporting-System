using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace phpsreps
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnect.Session.Open();

            //ProductList.UpdateProducts();
            //CompanyList.UpdateCompanies();

            DataExport.ExportProducts();
            DataExport.ExportCompanies();
            DataExport.ExportSales("2010-10-10", "2018-10-10");

            //long time1 = DateTime.Now.Ticks;
            //MessageBox.Show(time1.ToString());
            //Application.Run(new SalesForAProduct()); // run the main program form.
            //Application.Run(new Form1()); // run the main program form.
            Application.Run(new SalesForACategory());




            //DBConnect.Session.Close(); // safely close the connection to the database.
        }
    }

}