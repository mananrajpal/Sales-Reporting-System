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

namespace phpsreps
{
	public partial class editProduct : Form
	{
		public editProduct()
		{
			InitializeComponent();
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
			string constring = "Data Source=phpsreps.database.windows.net;Initial Catalog=phpsreps;User ID=SwinDP2tu05g1;Password=SwinDP2team;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			string Query = "update dbo.products set InStock='" + this.inStock.Text+ "' where Product_Code='" + this.product_code.Text + "' ;";
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
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
