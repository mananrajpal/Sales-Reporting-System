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

            DBConnect.Session.Open(); // open the connection with the database

            // Populate the internal product and companies listings
            ProductList.UpdateProducts(); 
            CompanyList.UpdateCompanies();

            Application.Run(new Form1()); // run the main program form.

            #region Testing Single Forms

            //Application.Run(new frmPointOfSales()); // run the main program form.

            //Application.Run(new SalesForACategory());

            #endregion

            DBConnect.Session.Close(); // safely close the connection to the database.
        }
    }

}