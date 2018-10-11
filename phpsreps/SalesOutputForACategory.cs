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
    public partial class SalesOutputForACategory : Form
    {
        private List<List<String>> _salesrecord;
        public SalesOutputForACategory(List<List<String>> salesrecord)
        {
            InitializeComponent();
            _salesrecord = salesrecord;
            SetDataGridRecord();
        }

        private void SetDataGridRecord()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Product Id");
            dt.Columns.Add("Category");
            dt.Columns.Add("Sales Id");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total Cost");

            for (int i = 0; i < _salesrecord.Count; i++)
            {
                dt.Rows.Add(_salesrecord[i][0], _salesrecord[i][1], _salesrecord[i][2], _salesrecord[i][3], _salesrecord[i][4]);
            }
            gridView.DataSource = dt;
        }


    }
}
