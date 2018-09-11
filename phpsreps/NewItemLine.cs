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

        public NewItemLine()
        {
            // TODO: Get Info from UI
        }

        
    }
}
