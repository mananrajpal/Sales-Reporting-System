using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phpsreps
{
	public partial class Form2 : Form
	{
		private ToolStripMenuItem inventoryToolStripMenuItem;
		private ToolStripMenuItem salesToolStripMenuItem;
		private ToolStripMenuItem reportsToolStripMenuItem;
		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
		private DataGridView dataGridView1;
		private phpsrepsDataSet phpsrepsDataSet;
		private BindingSource productsBindingSource;
		private IContainer components;
		private phpsrepsDataSetTableAdapters.productsTableAdapter productsTableAdapter;
		private DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn retailPriceDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
		private Button button5;
		private MenuStrip menuStrip1;

		public Form2()
		{
			InitializeComponent();
		}
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			//This line of code loads data into the 'phpsrepsDataSet.products' table
			this.productsTableAdapter.Fill(this.phpsrepsDataSet.products);

		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.retailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phpsrepsDataSet = new phpsreps.phpsrepsDataSet();
			this.productsTableAdapter = new phpsreps.phpsrepsDataSetTableAdapters.productsTableAdapter();
			this.button5 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phpsrepsDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.reportsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(833, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.salesToolStripMenuItem.Text = "Sales";
			this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(349, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventory";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(78, 98);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "New item";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(277, 98);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 4;
			this.button2.Text = "Edit item";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(472, 98);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 28);
			this.button3.TabIndex = 5;
			this.button3.Text = "Delete item";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.retailPriceDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(45, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(743, 338);
			this.dataGridView1.TabIndex = 1;
			// 
			// productCodeDataGridViewTextBoxColumn
			// 
			this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "Product_Code";
			this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product_Code";
			this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
			this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// companyIDDataGridViewTextBoxColumn
			// 
			this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "Company_ID";
			this.companyIDDataGridViewTextBoxColumn.HeaderText = "Company_ID";
			this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
			this.companyIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// costPriceDataGridViewTextBoxColumn
			// 
			this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "Cost_Price";
			this.costPriceDataGridViewTextBoxColumn.HeaderText = "Cost_Price";
			this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
			this.costPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// retailPriceDataGridViewTextBoxColumn
			// 
			this.retailPriceDataGridViewTextBoxColumn.DataPropertyName = "Retail_Price";
			this.retailPriceDataGridViewTextBoxColumn.HeaderText = "Retail_Price";
			this.retailPriceDataGridViewTextBoxColumn.Name = "retailPriceDataGridViewTextBoxColumn";
			this.retailPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// inStockDataGridViewTextBoxColumn
			// 
			this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
			this.inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
			this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
			this.inStockDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "products";
			this.productsBindingSource.DataSource = this.phpsrepsDataSet;
			// 
			// phpsrepsDataSet
			// 
			this.phpsrepsDataSet.DataSetName = "phpsrepsDataSet";
			this.phpsrepsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(667, 97);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 30);
			this.button5.TabIndex = 7;
			this.button5.Text = "Refresh";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form2
			// 
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(833, 511);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.Text = "PHP-SRePS";
			this.Load += new System.EventHandler(this.Form2_Load_1);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phpsrepsDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Form2_Load_1(object sender, EventArgs e)
		{
			//This line of code loads data into the 'phpsrepsDataSet.products' table
			this.productsTableAdapter.Fill(this.phpsrepsDataSet.products);

		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void salesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 form3 = new Form3();
			form3.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			editProduct edit_product = new editProduct();
			edit_product.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//This line of code loads data into the 'phpsrepsDataSet.products' table
			this.productsTableAdapter.Fill(this.phpsrepsDataSet.products);
		}
	}
}
