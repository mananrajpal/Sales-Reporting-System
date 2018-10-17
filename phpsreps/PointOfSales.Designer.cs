namespace phpsreps
{
    partial class frmPointOfSales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPointOfSales));
			this.btnRemoveItem = new System.Windows.Forms.Button();
			this.btnClearSale = new System.Windows.Forms.Button();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.dgvSale = new System.Windows.Forms.DataGridView();
			this.clmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.nudQuantity = new System.Windows.Forms.NumericUpDown();
			this.lblProduct = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.txtCost = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRemoveItem
			// 
			this.btnRemoveItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRemoveItem.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveItem.Location = new System.Drawing.Point(12, 454);
			this.btnRemoveItem.Name = "btnRemoveItem";
			this.btnRemoveItem.Size = new System.Drawing.Size(126, 45);
			this.btnRemoveItem.TabIndex = 4;
			this.btnRemoveItem.Text = "Remove Item";
			this.btnRemoveItem.UseVisualStyleBackColor = false;
			this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
			// 
			// btnClearSale
			// 
			this.btnClearSale.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnClearSale.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearSale.Location = new System.Drawing.Point(144, 454);
			this.btnClearSale.Name = "btnClearSale";
			this.btnClearSale.Size = new System.Drawing.Size(126, 45);
			this.btnClearSale.TabIndex = 5;
			this.btnClearSale.Text = "Clear Sale";
			this.btnClearSale.UseVisualStyleBackColor = false;
			this.btnClearSale.Click += new System.EventHandler(this.btnClearSale_Click);
			// 
			// btnCheckout
			// 
			this.btnCheckout.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCheckout.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckout.Location = new System.Drawing.Point(699, 454);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(126, 45);
			this.btnCheckout.TabIndex = 6;
			this.btnCheckout.Text = "Checkout";
			this.btnCheckout.UseVisualStyleBackColor = false;
			this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
			// 
			// dgvSale
			// 
			this.dgvSale.AllowUserToAddRows = false;
			this.dgvSale.AllowUserToDeleteRows = false;
			this.dgvSale.AllowUserToResizeColumns = false;
			this.dgvSale.AllowUserToResizeRows = false;
			this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSale.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItem,
            this.clmQuantity,
            this.clmPrice,
            this.clmTotal});
			this.dgvSale.Location = new System.Drawing.Point(12, 129);
			this.dgvSale.Name = "dgvSale";
			this.dgvSale.ReadOnly = true;
			this.dgvSale.Size = new System.Drawing.Size(813, 319);
			this.dgvSale.TabIndex = 7;
			// 
			// clmItem
			// 
			this.clmItem.HeaderText = "Item Number";
			this.clmItem.Name = "clmItem";
			this.clmItem.ReadOnly = true;
			// 
			// clmQuantity
			// 
			this.clmQuantity.HeaderText = "Quantity";
			this.clmQuantity.Name = "clmQuantity";
			this.clmQuantity.ReadOnly = true;
			// 
			// clmPrice
			// 
			this.clmPrice.HeaderText = "Unit Price";
			this.clmPrice.Name = "clmPrice";
			this.clmPrice.ReadOnly = true;
			// 
			// clmTotal
			// 
			this.clmTotal.HeaderText = "Total";
			this.clmTotal.Name = "clmTotal";
			this.clmTotal.ReadOnly = true;
			// 
			// txtProduct
			// 
			this.txtProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtProduct.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProduct.Location = new System.Drawing.Point(106, 86);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(356, 29);
			this.txtProduct.TabIndex = 8;
			// 
			// nudQuantity
			// 
			this.nudQuantity.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudQuantity.Location = new System.Drawing.Point(573, 85);
			this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(120, 29);
			this.nudQuantity.TabIndex = 9;
			this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.BackColor = System.Drawing.SystemColors.Info;
			this.lblProduct.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduct.Location = new System.Drawing.Point(12, 90);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(88, 21);
			this.lblProduct.TabIndex = 10;
			this.lblProduct.Text = "Product";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(468, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "Quantity";
			// 
			// btnAddItem
			// 
			this.btnAddItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAddItem.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddItem.Location = new System.Drawing.Point(699, 77);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(126, 45);
			this.btnAddItem.TabIndex = 12;
			this.btnAddItem.Text = "Add Item";
			this.btnAddItem.UseVisualStyleBackColor = false;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// txtCost
			// 
			this.txtCost.BackColor = System.Drawing.Color.Black;
			this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCost.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtCost.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCost.ForeColor = System.Drawing.Color.Lime;
			this.txtCost.Location = new System.Drawing.Point(16, 12);
			this.txtCost.Multiline = true;
			this.txtCost.Name = "txtCost";
			this.txtCost.ReadOnly = true;
			this.txtCost.Size = new System.Drawing.Size(809, 59);
			this.txtCost.TabIndex = 13;
			this.txtCost.Text = "$0";
			this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// frmPointOfSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(837, 511);
			this.Controls.Add(this.txtCost);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.nudQuantity);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.dgvSale);
			this.Controls.Add(this.btnCheckout);
			this.Controls.Add(this.btnClearSale);
			this.Controls.Add(this.btnRemoveItem);
			this.Name = "frmPointOfSales";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowIcon = false;
			this.Text = "PHP-SRePS";
			((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearSale;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtCost;
    }
}