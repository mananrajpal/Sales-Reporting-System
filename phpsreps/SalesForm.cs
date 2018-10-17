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
	public partial class SalesForm : Form
	{
		public SalesForm()
		{
			InitializeComponent();
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

	}
}
