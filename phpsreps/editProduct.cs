using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace phpsreps
{
	public partial class editProduct : Form
	{
		private ErrorProvider errorprovider;
		private String _regexfordecimal, _regexforstock;
		 

		public editProduct()
		{
			InitializeComponent();
			errorprovider = new ErrorProvider();
			_regexfordecimal = @"^\d*\.+\d*$";
			_regexforstock = @"^[1-9]\d*$";
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void editProduct_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (validation() == true)
			{
				string constring = "Data Source=phpsreps.database.windows.net;Initial Catalog=phpsreps;User ID=SwinDP2tu05g1;Password=SwinDP2team;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
				string Query = "update dbo.products set Category='" + this.category.Text + "', Product_Name='" + this.product_name.Text + "', Company_ID='" + this.company_id.Text + "', Cost_Price='" + this.cost_price.Text + "', Retail_Price='" + this.retail_price.Text + "', InStock='" + this.inStock.Text + "' where Product_Code='" + this.product_code.Text + "' ;";
				SqlConnection conDatabase = new SqlConnection(constring);
				SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
				SqlDataReader myReader;

				try
				{
					conDatabase.Open();
					myReader = cmdDatabase.ExecuteReader();
					MessageBox.Show("Updated successfully!");
					while (myReader.Read())
					{

					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			} else
			{
				errorprovider.Clear();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private Boolean validation()
		{
			if (product_code.Text.Length == 0)
			{
				product_code.Focus();
				errorprovider.SetError(product_code, MessageBox.Show("Please enter the Product Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (category.Text.Length == 0)
			{
				category.Focus();
				errorprovider.SetError(category, MessageBox.Show("Please enter the Category		`", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (company_id.Text.Length == 0)
			{
				company_id.Focus();
				errorprovider.SetError(company_id, MessageBox.Show("Please enter the Company ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (cost_price.Text.Length == 0)
			{
				cost_price.Focus();
				errorprovider.SetError(cost_price, MessageBox.Show("Please enter the Cost Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (retail_price.Text.Length == 0)
			{
				retail_price.Focus();
				errorprovider.SetError(retail_price, MessageBox.Show("Please enter the Retail Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (inStock.Text.Length == 0)
			{
				inStock.Focus();
				errorprovider.SetError(inStock, MessageBox.Show("Please enter the Stock Count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (!Regex.IsMatch(cost_price.Text, _regexfordecimal))
			{
				cost_price.Focus();
				errorprovider.SetError(cost_price, MessageBox.Show("Please enter the Cost Price in Decimal Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (!Regex.IsMatch(retail_price.Text, _regexfordecimal))
			{
				retail_price.Focus();
				errorprovider.SetError(retail_price, MessageBox.Show("Please enter the Retail Price in Decimal Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (!Regex.IsMatch(inStock.Text, _regexforstock))
			{
				inStock.Focus();
				errorprovider.SetError(inStock, MessageBox.Show("Stock Count can only be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (!(category.Text.Equals(Category.Beauty)) || !(category.Text.Equals(Category.FirstAid)) || !(category.Text.Equals(Category.Medicines)))
			{
				category.Focus();
				errorprovider.SetError(category, MessageBox.Show("Category can only be Beauty, FirstAid or Medicines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
				return false;
			}
			else if (CheckCompanyCode() == false)
			{
				company_id.Focus();
				errorprovider.SetError(company_id, MessageBox.Show("The Company Id entered does not pre-exist, please enter that company details first or correct the company id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
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
				if (CompanyList.companies[i].CompanyID.Equals(company_id.Text))
				{
					return true;
				}
			}
			return false;
		}

	}
}
