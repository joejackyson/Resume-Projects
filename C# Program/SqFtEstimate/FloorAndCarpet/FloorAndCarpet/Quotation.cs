using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloorAndCarpet
{
    public partial class Quotation : Form
    {
        public Quotation()
        {
            InitializeComponent();
        }

        private void Quotation_Load(object sender, EventArgs e)
        {

            this.txtCustomerAddress.AutoSize = true;
            this.txtCustomerAddress.Text = Form1.ValueForTxtAddressOutPut;
            this.txtQuotation.AutoSize = true;
            this.txtQuotation.Text = Form1.ValueForTxtQuotation;
            
        }
    }
}
