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
    public partial class SalesForAllCategories : Form
    {
        private List<List<String>> _salesrecord;
        public SalesForAllCategories(List<List<String>> salesrecord)
        {
            _salesrecord = salesrecord;
            SetDataGridRecord();
            InitializeComponent();
        }

        private void SetDataGridRecord()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sale Id");
            dt.Columns.Add("Category");
            dt.Columns.Add("Product Id");
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
