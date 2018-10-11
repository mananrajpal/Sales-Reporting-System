using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phpsreps
{
    public partial class SalesForAProduct : Form
    {
        ErrorProvider error;
        String _productid;

        public SalesForAProduct()
        {
            InitializeComponent();
            error = new ErrorProvider();   
        }

        private void InitializeTextFields()
        {
            _productid = ProductId.Text.ToString();
        }

        private Boolean CheckForProductCode()
        {
            for (int i = 0; i < ProductList.products.Count; i++)
            {
                Console.WriteLine(ProductList.products[i].ProductCode.ToString());
                if (ProductList.products[i].ProductCode.Equals(ProductId.Text.ToString()))
                {
                    return true;
                }
            }

            return false;
        }
        
        private Boolean CheckForValidation()
        {
            //check if the field is not empty
            if (ProductId.Text.Length == 0)
            {
                ProductId.Focus();
                error.SetError(ProductId, MessageBox.Show("Please enter the Product Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (CheckForProductCode() == false)
            {
                ProductId.Focus();
                error.SetError(ProductId, MessageBox.Show("Product id entered does not match the database ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckForValidation() == true)
            {
                //proceed to getting sales record for the product id
                this.Hide();
                InitializeTextFields();
                List<List<string>> salesrecord = ProductList.GetProductSales(_productid);
                SalesOutputForAProduct ss = new SalesOutputForAProduct(salesrecord);
                ss.Closed += (s, args) => this.Close();
                ss.Show();
            }
            else
            {
                //do nothing
            }
        }
    }
}
