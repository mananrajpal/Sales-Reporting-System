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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			//This line of code loads data into the 'phpsrepsDataSet1.sales' table. You can move, or remove it, as needed.
			this.salesTableAdapter.Fill(this.phpsrepsDataSet1.sales);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SalesForACategory saleCat = new SalesForACategory();
			saleCat.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SalesForAProduct saleProduct = new SalesForAProduct();
			saleProduct.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SalesOutputForACategory saleOutputCat = new SalesOutputForACategory();
			saleOutputCat.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SalesOutputForAProduct saleOutputProduct = new SalesOutputForAProduct();
			saleOutputProduct.Show();
		}
	}
}
