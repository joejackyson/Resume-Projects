namespace FloorAndCarpet
{
    partial class Quotation
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
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtQuotation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(173, 12);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(468, 232);
            this.txtCustomerAddress.TabIndex = 0;
            // 
            // txtQuotation
            // 
            this.txtQuotation.Location = new System.Drawing.Point(173, 250);
            this.txtQuotation.Multiline = true;
            this.txtQuotation.Name = "txtQuotation";
            this.txtQuotation.ReadOnly = true;
            this.txtQuotation.Size = new System.Drawing.Size(468, 232);
            this.txtQuotation.TabIndex = 1;
            // 
            // Quotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 502);
            this.Controls.Add(this.txtQuotation);
            this.Controls.Add(this.txtCustomerAddress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quotation";
            this.Text = "Quotation";
            this.Load += new System.EventHandler(this.Quotation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtQuotation;
    }
}