namespace phpsreps
{
    partial class PopupForm
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
            this.ErrorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorButton
            // 
            this.ErrorButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorButton.Location = new System.Drawing.Point(326, 390);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(122, 36);
            this.ErrorButton.TabIndex = 0;
            this.ErrorButton.Text = "Okay";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please fix the following errors:";
            // 
            // ErrorList
            // 
            this.ErrorList.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorList.Location = new System.Drawing.Point(255, 66);
            this.ErrorList.Name = "ErrorList";
            this.ErrorList.ReadOnly = true;
            this.ErrorList.Size = new System.Drawing.Size(264, 27);
            this.ErrorList.TabIndex = 2;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorButton);
            this.Name = "PopupForm";
            this.Text = "PopupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ErrorList;
    }
}