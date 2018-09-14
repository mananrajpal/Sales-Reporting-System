using System;
using System.Windows.Forms;
using System.Text;

namespace phpsreps
{
    class NewItemLine
    {
        public string ProductCode { get; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public float ItemCost { get; } //Create product list from DB to use }
        public float LineCost { get; set; }

        public NewItemLine(string pCode, string pName, string qty, string iCost)
        {
            //ToDo: Lookup that product code is in DB.
            ProductCode = pCode;
            ProductName = pName;
            if (!Int32.TryParse(qty, out int q))
            {
                MessageBox.Show("Qty is not a valid Number");
                Qty = q;
            }

            // ToDo: Write a DB Lookup for product code
            if (!float.TryParse(iCost, out float c))
            {
                MessageBox.Show("item cost is not a valid entry");
                ItemCost = c;
            }

            LineCost = c * q;

        }
    }
}
