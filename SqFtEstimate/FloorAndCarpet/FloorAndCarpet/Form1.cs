using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FloorAndCarpet
{
    public partial class Form1 : Form
    {
        public static string CustValues = String.Empty;
        public static string ValueForTxtQuotation;
        public static string ValueForTxtAddressOutPut;
        


        public Form1()
        {
            InitializeComponent();
            List<string> listStates = new List<string>();
            listStates.Add("AL");
            listStates.Add("NC");
            listStates.Add("TN");
            listStates.Add("SC");
            listStates.Add("GA");
            comboState.Items.AddRange(listStates.ToArray());
            comboState.SelectedIndex = comboState.Items.IndexOf("TN");
            
            txtLaborCharge.Text = "30";
        }
      /* private List<Material> getMaterialData()
        {
            string strDSN = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + /* dir@"C:\Users\Joe\Desktop\ProjectRes\FloorDatabase\Materials.accdb";
            string strSQL = "SELECT MatName, PricePerSquareFoot, Description, Thickness FROM Materials";
            OleDbConnection myConn = new OleDbConnection(strDSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
            myConn.Open();
            DataSet dtSet = new DataSet();
            myCmd.Fill(dtSet, "Materials");
            foreach(DataGridViewRow in dtSet)
            myConn.Close();
            
            return ;
        }*/

    


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Floor and Carpet \n\nVersion1.0");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string path1 = Path.GetDirectoryName(Environment.CurrentDirectory);
            string path2 = Path.GetDirectoryName(path1);
            string fileName = @"\FloorDatabase\Materials.accdb";
            string path = path2 + fileName;
            string strDSN = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + /* dir*/ path;
            string strSQL = "SELECT ID, MatName, PricePerSquareFoot, Description, Thickness FROM Materials";
            OleDbConnection myConn = new OleDbConnection(strDSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
           
            DataTable dtSet = new DataTable();
            myCmd.Fill(dtSet);
            //bindingSource1.DataSource = dtSet.Tables["Materials"].DefaultView;
            //dgMaterials.DataSource = bindingSource1;

            
            dgMaterials.ReadOnly = true;
            dgMaterials.DataSource = dtSet;
            RdoPro.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if(!string.IsNullOrEmpty(txtName.Text))
            {
                customer.Fullname = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.AddressLine2 = txtAddress2.Text;
                customer.City = txtCity.Text;
                customer.State = comboState.SelectedItem.ToString();
                customer.ZipCode = txtZip.Text;
            }
            txtCustomerInfo.Text = customer.ToStringFormatted();
            ValueForTxtAddressOutPut = customer.ToStringFormatted();
        }
        private void OpenQuotation_Click(Object sender, EventArgs e)
        {
            ValueForTxtAddressOutPut = txtCustomerInfo.Text;
            Quotation p = new Quotation();
            p.Show();
        }

        private void dgMaterials_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewCellCollection cells = dgMaterials.CurrentRow.Cells.I;
            decimal price = 0;

            //if (!Decimal.TryParse(dgMaterials.CurrentRow.Cells[2].ToString(), out price)) { price = 0; }
            string mat1, mat2, mat3 = null;
            if (dgMaterials.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgMaterials.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgMaterials.Rows[selectedrowindex];
                mat1 = Convert.ToString(selectedRow.Cells["MatName"].Value);
                mat2 = Convert.ToString(selectedRow.Cells["Description"].Value);
                mat3 = Convert.ToString(selectedRow.Cells["PricePerSquareFoot"].Value);
                decimal.TryParse(mat3, out price);
            }
            else { mat1 = null; mat2 = null; }
            Material ft = new Material(mat1, mat2, price);
            txtMaterialDesc.Text = ft.Description;
            txtMaterialName.Text = ft.MatName;
            txtMaterialPrice.Text = ft.PricePerSquareFoot.ToString();
            UpdateCalculation();
            
        }
        private void UpdateCalculation()
        {
            decimal installationCost = 0.00m;
            if(!Decimal.TryParse(txtMaterialPrice.Text, out decimal defaultMaterialPrice))
            {
                defaultMaterialPrice = 1.00m;
            }
            Material buffer = new Material(txtMaterialName.Text, txtMaterialDesc.Text, defaultMaterialPrice);
            txtOutput.Text = string.Empty;
            if (!double.TryParse(txtLength.Text, out double length))
            {
                txtLength.Text = 1.0.ToString();
                length = 1.0;
            }
            buffer.Length = length;
            if (!double.TryParse(txtWidth.Text, out double width))
            {
                txtWidth.Text = 1.0.ToString();
                width = 1.0;
            }
            buffer.Width = width;
            if(RdoPro.Checked) 
            {
                if(!decimal.TryParse(txtLaborCharge.Text, out installationCost))
                {
                    installationCost = 30.00m;
                }
            }
            else
            {
                installationCost = 0.00m;
            }
            buffer.Labor = installationCost * (decimal)buffer.AreaSqYards;
            txtSqFt.Text = buffer.Area.ToString();
            txtSqYd.Text = buffer.AreaSqYards.ToString();

            txtMaterialCost.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.GetCost);
            txtEstimateTotal.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.TotalCost);
            txtLaborCost.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", buffer.Labor);
            txtOutput.Text = buffer.ToStringDetail();
            ValueForTxtQuotation = txtOutput.Text;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            UpdateCalculation();
        }

        private void RdoPro_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculation();
        }

        private void btnDBEntry_Click(object sender, EventArgs e)
        {
            if (txtMaterialEntry.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for material name.", "Material name required");
                txtMaterialEntry.Text = string.Empty;
                txtMaterialEntry.Focus();
            }
            string MaterialEntry = txtMaterialEntry.Text;
            if (!decimal.TryParse(txtPPSqFtEntry.Text, out decimal PPSqFt))
            {
                MessageBox.Show("Please enter a decimal number.", "Decimal expected");
                txtPPSqFtEntry.Text = string.Empty;
                txtPPSqFtEntry.Focus();
            }
            if (txtThicknessEntry.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for material thickness.", "Material thickness required");
                txtThicknessEntry.Text = string.Empty;
                txtThicknessEntry.Focus();
            }
            string ThicknessEntry = txtThicknessEntry.Text;
            if (txtDescriptionEntry.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for material description.", "Material description required");
                txtDescriptionEntry.Text = string.Empty;
                txtDescriptionEntry.Focus();
            }
            string path1 = Path.GetDirectoryName(Environment.CurrentDirectory);
            string path2 = Path.GetDirectoryName(path1);
            string fileName = @"\FloorDatabase\Materials.accdb";
            string path = path2 + fileName;
            string DescriptionEntry = txtDescriptionEntry.Text;
            string cmdString = "INSERT INTO Materials (MatName,PricePerSquareFoot,Description,Thickness) VALUES (@val1, @va2, @val3, @val4)";
            string connString = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + /* dir*/path;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", MaterialEntry);
                    comm.Parameters.AddWithValue("@val2", PPSqFt);
                    comm.Parameters.AddWithValue("@val3", DescriptionEntry);
                    comm.Parameters.AddWithValue("@val4", ThicknessEntry);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();


                }
                txtMaterialEntry.Text = string.Empty;
                txtPPSqFtEntry.Text = string.Empty;
                txtDescriptionEntry.Text = string.Empty;
                txtThicknessEntry.Text = string.Empty;
                MessageBox.Show("Entry created.");
            }
        }

        private void btnDelEntry_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMatID.Text, out int matID))
            {
                MessageBox.Show("Please enter an integer.", "int expected");
                txtMatID.Text = string.Empty;
                txtMatID.Focus();
            }
            string path1 = Path.GetDirectoryName(Environment.CurrentDirectory);
            string path2 = Path.GetDirectoryName(path1);
            string fileName = @"\FloorDatabase\Materials.accdb";
            string path = path2 + fileName;
            string cmdString = "DELETE FROM Materials WHERE ID=(@val1)";
            string connString = "Provider= Microsoft.ACE.OLEDB.12.0; Data Source = " + /* dir*/path;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", matID);
                    
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();


                }
            }
            txtMatID.Text = string.Empty;
            MessageBox.Show("Entry deleted.");
        }
    }
}
