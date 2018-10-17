namespace phpsreps
{
    partial class SalesForACategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForACategory));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.category_name = new System.Windows.Forms.TextBox();
			this.submit_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(103, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "View records for a category";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Info;
			this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(80, 103);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Category Name:";
			// 
			// category_name
			// 
			this.category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.category_name.Location = new System.Drawing.Point(311, 103);
			this.category_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.category_name.Name = "category_name";
			this.category_name.Size = new System.Drawing.Size(168, 23);
			this.category_name.TabIndex = 2;
			// 
			// submit_button
			// 
			this.submit_button.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.submit_button.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submit_button.Location = new System.Drawing.Point(209, 167);
			this.submit_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.submit_button.Name = "submit_button";
			this.submit_button.Size = new System.Drawing.Size(96, 44);
			this.submit_button.TabIndex = 3;
			this.submit_button.Text = "Submit";
			this.submit_button.UseVisualStyleBackColor = false;
			this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
			// 
			// SalesForACategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(546, 249);
			this.Controls.Add(this.submit_button);
			this.Controls.Add(this.category_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "SalesForACategory";
			this.Text = "PHP-SRePS";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Button submit_button;
    }
}