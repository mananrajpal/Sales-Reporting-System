﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace phpsreps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //DBConnect.Connect();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form2 = new Form1();
			form2.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
