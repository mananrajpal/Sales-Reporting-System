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
    public partial class SalesOutput : Form
    {
        private List<List<String>> _salesrecord;
        private String _productid, _salesid, _quantity, _totalcost;
        public SalesOutput(List<List<String>> salesrecord)
        {
            InitializeComponent();
            _salesrecord = salesrecord;
        }

        private void SetDataGridRecrod()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Product Id");
            dt.Columns.Add("Sales Id");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total Cost");

            for (int i = 0; i < _salesrecord.Count; i++)
            {
                dt.Rows.Add(_salesrecord[i][0], _salesrecord[i][1], _salesrecord[i][2], _salesrecord[i][3]);
            }
            gridView.DataSource = dt;
        }
    }
}
