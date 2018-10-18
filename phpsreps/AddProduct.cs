using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace phpsreps
{
    public partial class AddProduct : Form
    {
        private String product_code, category_code, product_name,
            company_id, cost_price, retail_price, in_stock;
        private ErrorProvider errorprovider;
        private String _regexfordecimal, _regexforstock;

		private void in_stockTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void retail_priceTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void cost_priceTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void company_idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void product_nameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void category_codeTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void product_codeTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private Product product;

        public AddProduct()
        {
            InitializeComponent();
            errorprovider = new ErrorProvider();
            _regexfordecimal = @"^\d*\.+\d*$";
            _regexforstock = @"^[1-9]\d*$";
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
            cost_price = cost_priceTextBox.Text;
            retail_price = retail_priceTextBox.Text;
            in_stock = in_stockTextBox.Text;
        }

        private Boolean validation()
        {
            if (product_codeTextBox.Text.Length == 0)
            {
                product_codeTextBox.Focus();
                errorprovider.SetError(product_codeTextBox, MessageBox.Show("Please enter the Product Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (product_nameTextBox.Text.Length == 0)
            {
                product_nameTextBox.Focus();
                errorprovider.SetError(product_nameTextBox, MessageBox.Show("Please enter the Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (category_codeTextBox.Text.Length == 0)
            {
                category_codeTextBox.Focus();
                errorprovider.SetError(category_codeTextBox, MessageBox.Show("Please enter the Category Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (company_idTextBox.Text.Length == 0)
            {
                company_idTextBox.Focus();
                errorprovider.SetError(company_idTextBox, MessageBox.Show("Please enter the Company ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (cost_priceTextBox.Text.Length == 0)
            {
                cost_priceTextBox.Focus();
                errorprovider.SetError(cost_priceTextBox, MessageBox.Show("Please enter the Cost Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (retail_priceTextBox.Text.Length == 0)
            {
                retail_priceTextBox.Focus();
                errorprovider.SetError(retail_priceTextBox, MessageBox.Show("Please enter the Retail Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (in_stockTextBox.Text.Length == 0)
            {
                in_stockTextBox.Focus();
                errorprovider.SetError(in_stockTextBox, MessageBox.Show("Please enter the Stock Count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (!Regex.IsMatch(cost_priceTextBox.Text, _regexfordecimal))
            {
                cost_priceTextBox.Focus();
                errorprovider.SetError(cost_priceTextBox, MessageBox.Show("Please enter the Cost Price in Decimal Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (!Regex.IsMatch(retail_priceTextBox.Text, _regexfordecimal))
            {
                retail_priceTextBox.Focus();
                errorprovider.SetError(retail_priceTextBox, MessageBox.Show("Please enter the Retail Price in Decimal Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (!Regex.IsMatch(in_stockTextBox.Text, _regexforstock))
            {
                in_stockTextBox.Focus();
                errorprovider.SetError(in_stockTextBox, MessageBox.Show("Stock Count can only be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (!((category_codeTextBox.Text.Equals(Category.Beauty.ToString())) || (category_codeTextBox.Text.Equals(Category.FirstAid.ToString())) || (category_codeTextBox.Text.Equals(Category.Medicines.ToString())) || (category_codeTextBox.Text.Equals(Category.PersonalCare.ToString())) || (category_codeTextBox.Text.Equals(Category.Supplements.ToString()))))
            {
                category_codeTextBox.Focus();
                errorprovider.SetError(category_codeTextBox, MessageBox.Show("Category can only be Beauty, FirstAid, PersonalCare, Supplements or  Medicines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (CheckCompanyCode() == false)
            {
                company_idTextBox.Focus();
                errorprovider.SetError(company_idTextBox, MessageBox.Show("The Company Id entered does not pre-exist, please enter that company details first or correct the company id","Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (product_nameTextBox.Text.Contains(" "))
            {
                product_nameTextBox.Focus();
                errorprovider.SetError(product_nameTextBox, MessageBox.Show("Please replace spaces in Product Name with '_'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean CheckCompanyCode()
        {
            
            for (int i = 0; i < CompanyList.companies.Count; i++)
            { 
                if (CompanyList.companies[i].CompanyID.Trim().ToString().Equals(company_idTextBox.Text.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //check the validation first
            if (validation() == true)
            {
                errorprovider.Clear();
                //initialize local variables
                InitializeVariable();
                product = new Product(product_code, category_code, product_name, company_id, cost_price, retail_price, in_stock);
                product.InsertProduct();
                //Process the data to the database
                MessageBox.Show("Product Created Successfully");
            }
            else
            {
                errorprovider.Clear();
            }
            //if everything is right than proceed to connecting with database
            //submit the details to the server
        }
    }
}
