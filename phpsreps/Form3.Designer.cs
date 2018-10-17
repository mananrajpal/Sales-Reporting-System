namespace phpsreps
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saleCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phpsrepsDataSet1 = new phpsreps.phpsrepsDataSet1();
			this.salesTableAdapter = new phpsreps.phpsrepsDataSet1TableAdapters.salesTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phpsrepsDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
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
			this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(359, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sales";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.saleCostDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.salesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(44, 149);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(743, 338);
			this.dataGridView1.TabIndex = 2;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 233;
			// 
			// saleDateDataGridViewTextBoxColumn
			// 
			this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "Sale_Date";
			this.saleDateDataGridViewTextBoxColumn.HeaderText = "Sale_Date";
			this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
			this.saleDateDataGridViewTextBoxColumn.Width = 233;
			// 
			// saleCostDataGridViewTextBoxColumn
			// 
			this.saleCostDataGridViewTextBoxColumn.DataPropertyName = "Sale_Cost";
			this.saleCostDataGridViewTextBoxColumn.HeaderText = "Sale_Cost";
			this.saleCostDataGridViewTextBoxColumn.Name = "saleCostDataGridViewTextBoxColumn";
			this.saleCostDataGridViewTextBoxColumn.Width = 233;
			// 
			// salesBindingSource
			// 
			this.salesBindingSource.DataMember = "sales";
			this.salesBindingSource.DataSource = this.phpsrepsDataSet1;
			// 
			// phpsrepsDataSet1
			// 
			this.phpsrepsDataSet1.DataSetName = "phpsrepsDataSet1";
			this.phpsrepsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// salesTableAdapter
			// 
			this.salesTableAdapter.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(44, 86);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 48);
			this.button1.TabIndex = 3;
			this.button1.Text = "Sales for a Category";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(241, 86);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(156, 48);
			this.button2.TabIndex = 4;
			this.button2.Text = "Sales for a Product";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(437, 86);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "Sales Output for a Category";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(631, 86);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(156, 48);
			this.button4.TabIndex = 6;
			this.button4.Text = "Sales Output for a Product";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(833, 511);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form3";
			this.Text = "PHP-SRePS";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phpsrepsDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private phpsrepsDataSet1 phpsrepsDataSet1;
		private System.Windows.Forms.BindingSource salesBindingSource;
		private phpsrepsDataSet1TableAdapters.salesTableAdapter salesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn saleCostDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}