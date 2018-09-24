namespace phpsreps
{
	partial class editProduct
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.product_code = new System.Windows.Forms.TextBox();
			this.inStock = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(187, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Edit item";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Product code:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(58, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "In-stock:";
			// 
			// product_code
			// 
			this.product_code.BackColor = System.Drawing.SystemColors.Info;
			this.product_code.Location = new System.Drawing.Point(191, 97);
			this.product_code.Name = "product_code";
			this.product_code.Size = new System.Drawing.Size(197, 20);
			this.product_code.TabIndex = 8;
			// 
			// inStock
			// 
			this.inStock.BackColor = System.Drawing.SystemColors.Info;
			this.inStock.Location = new System.Drawing.Point(191, 136);
			this.inStock.Name = "inStock";
			this.inStock.Size = new System.Drawing.Size(117, 20);
			this.inStock.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(103, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 30);
			this.button1.TabIndex = 15;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(259, 193);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 30);
			this.button2.TabIndex = 16;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// editProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(464, 249);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inStock);
			this.Controls.Add(this.product_code);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "editProduct";
			this.Text = "PHP-SRePS";
			this.Load += new System.EventHandler(this.editProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox product_code;
		private System.Windows.Forms.TextBox inStock;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}