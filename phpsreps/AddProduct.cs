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
    public partial class AddProduct : Form
    {
        private String product_code, category_code, product_name, company_id;
        private double cost_price, retail_price;
        private int in_stock;
        private string _errors;
        private ErrorProvider errorProvider;

        public AddProduct()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            product_codeTextBox.Text = "";
            category_codeTextBox.Text = "";
            product_nameTextBox.Text = "";
            company_idTextBox.Text = "";
            cost_priceTextBox.Text = "";
            retail_priceTextBox.Text = "";
            in_stockTextBox.Text = "";
        }

        public void InitializeVariable()
        {
            product_code = product_codeTextBox.Text;
            category_code = category_codeTextBox.Text;
            product_name = product_nameTextBox.Text;
            company_id = company_idTextBox.Text;
            cost_price = Double.Parse(cost_priceTextBox.Text);
            retail_price = Double.Parse(retail_priceTextBox.Text);
            in_stock = Int32.Parse(in_stockTextBox.Text);
        }

        private Boolean validation()
        {
            if (product_codeTextBox.Text.Length == 0)
            {
                product_codeTextBox.Focus();
                errorProvider.SetError(product_codeTextBox, MessageBox.Show("Please enter the Product Code", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (category_codeTextBox.Text.Length == 0)
            {
                category_codeTextBox.Focus();
                errorProvider.SetError(category_codeTextBox, MessageBox.Show("Please enter the Category Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (company_idTextBox.Text.Length == 0)
            {
                company_idTextBox.Focus();
                errorProvider.SetError(company_idTextBox, MessageBox.Show("Please enter the Company ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (cost_priceTextBox.Text.Length == 0)
            {
                cost_priceTextBox.Focus();
                errorProvider.SetError(cost_priceTextBox, MessageBox.Show("Please enter the Cost Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (retail_priceTextBox.Text.Length == 0)
            {
                retail_priceTextBox.Focus();
                errorProvider.SetError(retail_priceTextBox, MessageBox.Show("Please enter the Retail Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (in_stockTextBox.Text.Length == 0)
            {
                in_stockTextBox.Focus();
                errorProvider.SetError(in_stockTextBox, MessageBox.Show("Please enter the Stock Count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else
            {
                return true;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //check the validation first
            if (validation() == true)
            {
                errorProvider.Clear();
                InitializeVariable();
            }
            else
            {
                errorProvider.Clear();
            }
            //if everything is right than proceed to connecting with database
            //submit the details to the server
        }
    }
}
