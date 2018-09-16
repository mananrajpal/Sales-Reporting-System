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

        public AddProduct()
        {
            InitializeComponent();
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

        private Boolean Validate()
        {
            
            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //check the validation first
            bool check = Validate();
            if (check == true)
            {
                InitializeVariable();
            }
            else
            {

            }
            //if everything is right than proceed to connecting with database
            //submit the details to the server
        }
    }
}
