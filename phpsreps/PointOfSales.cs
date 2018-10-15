using System;
using System.Globalization;
using System.Windows.Forms;

namespace phpsreps
{
    public partial class frmPointOfSales : Form
    {
        private Sale _sale;

        private void clearView()
        {
            dgvSale.Rows.Clear();
            dgvSale.Refresh();
            txtCost.Text = "$0";
        }

        public frmPointOfSales()
        {
            InitializeComponent();
            ProductList.UpdateProducts();

            AutoCompleteStringCollection productCodes = new AutoCompleteStringCollection();

            foreach (Product p in ProductList.products)
            {
                productCodes.Add(p.ProductCode);
            }
            
            txtProduct.AutoCompleteCustomSource = productCodes;
        }

        private void updateSalePrice()
        {
            float total = 0f;

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                float item_total = float.Parse(row.Cells["clmTotal"].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);

                total += item_total;
            }

            txtCost.Text = "$" + total.ToString();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvSale.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dgvSale.Rows.RemoveAt(r.Index);
                }
            }

            dgvSale.Refresh();
            updateSalePrice();
        }

        private void btnClearSale_Click(object sender, EventArgs e)
        {
            clearView();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            _sale = new Sale();

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                string code = (string) row.Cells["clmItem"].Value;
                string quantity = (string) row.Cells["clmQuantity"].Value;
                string price = (string) row.Cells["clmPrice"].Value;
                string total = (string) row.Cells["clmTotal"].Value;

                _sale.NewItem(code, quantity, price, total);
            }

            _sale.InsertSale();

            clearView();

            MessageBox.Show("Sale has successfully been processed.");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool newItem = true;

            string code = txtProduct.Text;
            int quantity = Convert.ToInt32(nudQuantity.Value.ToString());

            Product p = ProductList.SearchForProduct(code);

            if (p != null)
            {
                float price = p.CostPrice;
                float total = p.CostPrice * quantity;

                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    string item_code = row.Cells["clmItem"].Value.ToString();

                    if (code.ToLower() == item_code.ToLower())
                    {
                        int item_quantity = Convert.ToInt32(row.Cells["clmQuantity"].Value.ToString());
                        float item_price = float.Parse(row.Cells["clmPrice"].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                        float item_total = float.Parse(row.Cells["clmTotal"].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);

                        row.Cells["clmQuantity"].Value = (item_quantity + quantity).ToString();
                        row.Cells["clmTotal"].Value = (item_price * (item_quantity + quantity)).ToString();

                        newItem = false;
                        break;
                    }
                }

                if (newItem)
                {
                    dgvSale.Rows.Add(code.ToUpper(), quantity.ToString(), price.ToString(), total.ToString());
                }

                dgvSale.Refresh();
                updateSalePrice();
            }
            else
            {
                MessageBox.Show("Invalid product code.");
            }
        }
    }
}
