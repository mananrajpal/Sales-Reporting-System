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
    public partial class PopupForm : Form
    {
        private String _message;
        private DialogResult dialog;
        public PopupForm(String message)
        {
            InitializeComponent();
            _message = message;
            ShowPopup();
        }

        public void ShowPopup()
        {
            ErrorList.Text = _message;
            dialog = this.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
        }

        private void ErrorButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}