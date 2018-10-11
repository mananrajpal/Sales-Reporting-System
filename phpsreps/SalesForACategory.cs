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
    public partial class SalesForACategory : Form
    {
        private ErrorProvider error;

        public SalesForACategory()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        private bool CheckForCategoryName()
        {
            if (!(category_name.Text.Equals(Category.Beauty.ToString()) || category_name.Text.Equals(Category.FirstAid.ToString()) || category_name.Text.Equals(Category.Medicines.ToString()) || category_name.Text.Equals(Category.PersonalCare.ToString()) || category_name.Text.Equals(Category.Supplements.ToString())))
            {
                return false;
            }
            return true;
        }

        private bool ValidateField()
        {
            if (category_name.Text.Length == 0)
            {
                category_name.Focus();
                error.SetError(category_name, MessageBox.Show("Please enter the Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            else if (CheckForCategoryName() == false)
            {
                category_name.Focus();
                error.SetError(category_name, MessageBox.Show("Categories can only be FirstAid or Medicines or PersonalCare or Supplements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                return false;
            }
            return true;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (ValidateField() == true)
            {
                //Call the code for the category list to be populated depending upon the category name
                this.Hide();
                List<List<string>> salesrecord = ProductList.GetItemisedCategorySales(category_name.Text);
                SalesOutputForACategory ss = new SalesOutputForACategory(salesrecord);
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
