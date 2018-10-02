using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phpsreps
{
    public class SaleLine
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string SaleId { get; set; }
        public int Qty { get; set; }
        public float TotalCost { get; set; }

        public SaleLine(string product, string sale, string qty, string tcost)
        {
            ProductId = product;
            SaleId = sale;

            if (!int.TryParse(qty, out int q))
            {
                //ToDo : break and send warning...
            }

            Qty = q;

            if (!float.TryParse(tcost, out float c))
            {
                //ToDo : break and send warning...
            }

            TotalCost = c;
        }
    }
}
