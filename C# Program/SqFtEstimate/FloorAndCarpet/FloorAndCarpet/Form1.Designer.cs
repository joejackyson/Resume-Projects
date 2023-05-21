namespace FloorAndCarpet
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCustomer = new System.Windows.Forms.TabPage();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabJob = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSelf = new System.Windows.Forms.RadioButton();
            this.RdoPro = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.txtSqYd = new System.Windows.Forms.TextBox();
            this.txtLaborCharge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstimateTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaterialPrice = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.txtMaterialDesc = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.dgMaterials = new System.Windows.Forms.DataGridView();
            this.tabDBUpdate = new System.Windows.Forms.TabPage();
            this.btnDBEntry = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescriptionEntry = new System.Windows.Forms.TextBox();
            this.txtThicknessEntry = new System.Windows.Forms.TextBox();
            this.txtPPSqFtEntry = new System.Windows.Forms.TextBox();
            this.txtMaterialEntry = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.txtMatID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDelEntry = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCustomer.SuspendLayout();
            this.TabJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).BeginInit();
            this.tabDBUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1041, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.OpenQuotation_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCustomer);
            this.tabControl1.Controls.Add(this.TabJob);
            this.tabControl1.Controls.Add(this.tabDBUpdate);
            this.tabControl1.Location = new System.Drawing.Point(10, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // TabCustomer
            // 
            this.TabCustomer.Controls.Add(this.txtCustomerInfo);
            this.TabCustomer.Controls.Add(this.btnSubmit);
            this.TabCustomer.Controls.Add(this.comboState);
            this.TabCustomer.Controls.Add(this.txtZip);
            this.TabCustomer.Controls.Add(this.label6);
            this.TabCustomer.Controls.Add(this.label5);
            this.TabCustomer.Controls.Add(this.txtCity);
            this.TabCustomer.Controls.Add(this.label4);
            this.TabCustomer.Controls.Add(this.txtAddress2);
            this.TabCustomer.Controls.Add(this.label3);
            this.TabCustomer.Controls.Add(this.txtAddress);
            this.TabCustomer.Controls.Add(this.label2);
            this.TabCustomer.Controls.Add(this.txtName);
            this.TabCustomer.Controls.Add(this.label1);
            this.TabCustomer.Location = new System.Drawing.Point(4, 29);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomer.Size = new System.Drawing.Size(1011, 494);
            this.TabCustomer.TabIndex = 0;
            this.TabCustomer.Text = "Customer";
            this.TabCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(452, 25);
            this.txtCustomerInfo.Multiline = true;
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.ReadOnly = true;
            this.txtCustomerInfo.Size = new System.Drawing.Size(295, 251);
            this.txtCustomerInfo.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(235, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 36);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(177, 207);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(232, 28);
            this.comboState.Sorted = true;
            this.comboState.TabIndex = 12;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(177, 250);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(232, 26);
            this.txtZip.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(177, 160);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(232, 26);
            this.txtCity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(177, 117);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(232, 26);
            this.txtAddress2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address Line 2";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(177, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TabJob
            // 
            this.TabJob.Controls.Add(this.label14);
            this.TabJob.Controls.Add(this.groupBox1);
            this.TabJob.Controls.Add(this.BtnCalculate);
            this.TabJob.Controls.Add(this.txtSqYd);
            this.TabJob.Controls.Add(this.txtLaborCharge);
            this.TabJob.Controls.Add(this.label13);
            this.TabJob.Controls.Add(this.txtEstimateTotal);
            this.TabJob.Controls.Add(this.label12);
            this.TabJob.Controls.Add(this.txtLaborCost);
            this.TabJob.Controls.Add(this.label11);
            this.TabJob.Controls.Add(this.txtMaterialCost);
            this.TabJob.Controls.Add(this.label10);
            this.TabJob.Controls.Add(this.txtSqFt);
            this.TabJob.Controls.Add(this.label9);
            this.TabJob.Controls.Add(this.txtLength);
            this.TabJob.Controls.Add(this.label8);
            this.TabJob.Controls.Add(this.txtWidth);
            this.TabJob.Controls.Add(this.label7);
            this.TabJob.Controls.Add(this.txtMaterialPrice);
            this.TabJob.Controls.Add(this.txtMaterialName);
            this.TabJob.Controls.Add(this.txtMaterialDesc);
            this.TabJob.Controls.Add(this.txtOutput);
            this.TabJob.Controls.Add(this.dgMaterials);
            this.TabJob.Location = new System.Drawing.Point(4, 29);
            this.TabJob.Name = "TabJob";
            this.TabJob.Padding = new System.Windows.Forms.Padding(3);
            this.TabJob.Size = new System.Drawing.Size(1011, 494);
            this.TabJob.TabIndex = 1;
            this.TabJob.Text = "Job Info";
            this.TabJob.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(498, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sq Yd";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSelf);
            this.groupBox1.Controls.Add(this.RdoPro);
            this.groupBox1.Location = new System.Drawing.Point(517, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation";
            // 
            // rdoSelf
            // 
            this.rdoSelf.AutoSize = true;
            this.rdoSelf.Location = new System.Drawing.Point(6, 56);
            this.rdoSelf.Name = "rdoSelf";
            this.rdoSelf.Size = new System.Drawing.Size(55, 24);
            this.rdoSelf.TabIndex = 1;
            this.rdoSelf.TabStop = true;
            this.rdoSelf.Text = "&Self";
            this.rdoSelf.UseVisualStyleBackColor = true;
            // 
            // RdoPro
            // 
            this.RdoPro.AutoSize = true;
            this.RdoPro.Location = new System.Drawing.Point(6, 25);
            this.RdoPro.Name = "RdoPro";
            this.RdoPro.Size = new System.Drawing.Size(114, 24);
            this.RdoPro.TabIndex = 0;
            this.RdoPro.TabStop = true;
            this.RdoPro.Text = "&Professional";
            this.RdoPro.UseVisualStyleBackColor = true;
            this.RdoPro.CheckedChanged += new System.EventHandler(this.RdoPro_CheckedChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(721, 376);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(85, 34);
            this.BtnCalculate.TabIndex = 20;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtSqYd
            // 
            this.txtSqYd.Location = new System.Drawing.Point(574, 332);
            this.txtSqYd.Name = "txtSqYd";
            this.txtSqYd.ReadOnly = true;
            this.txtSqYd.Size = new System.Drawing.Size(232, 26);
            this.txtSqYd.TabIndex = 19;
            this.txtSqYd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLaborCharge
            // 
            this.txtLaborCharge.Location = new System.Drawing.Point(243, 460);
            this.txtLaborCharge.Name = "txtLaborCharge";
            this.txtLaborCharge.Size = new System.Drawing.Size(232, 26);
            this.txtLaborCharge.TabIndex = 18;
            this.txtLaborCharge.Text = "0";
            this.txtLaborCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Labor Charge";
            // 
            // txtEstimateTotal
            // 
            this.txtEstimateTotal.Location = new System.Drawing.Point(243, 428);
            this.txtEstimateTotal.Name = "txtEstimateTotal";
            this.txtEstimateTotal.ReadOnly = true;
            this.txtEstimateTotal.Size = new System.Drawing.Size(232, 26);
            this.txtEstimateTotal.TabIndex = 16;
            this.txtEstimateTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Estimate Total";
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(243, 396);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.ReadOnly = true;
            this.txtLaborCost.Size = new System.Drawing.Size(232, 26);
            this.txtLaborCost.TabIndex = 14;
            this.txtLaborCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Labor Cost";
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.Location = new System.Drawing.Point(243, 364);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.ReadOnly = true;
            this.txtMaterialCost.Size = new System.Drawing.Size(232, 26);
            this.txtMaterialCost.TabIndex = 12;
            this.txtMaterialCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Material Cost";
            // 
            // txtSqFt
            // 
            this.txtSqFt.Location = new System.Drawing.Point(243, 332);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.ReadOnly = true;
            this.txtSqFt.Size = new System.Drawing.Size(232, 26);
            this.txtSqFt.TabIndex = 10;
            this.txtSqFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sq Ft";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(243, 300);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(232, 26);
            this.txtLength.TabIndex = 8;
            this.txtLength.Text = "1";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Length";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(243, 268);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(232, 26);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.Text = "1";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Width";
            // 
            // txtMaterialPrice
            // 
            this.txtMaterialPrice.Location = new System.Drawing.Point(202, 219);
            this.txtMaterialPrice.Name = "txtMaterialPrice";
            this.txtMaterialPrice.ReadOnly = true;
            this.txtMaterialPrice.Size = new System.Drawing.Size(100, 26);
            this.txtMaterialPrice.TabIndex = 4;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(80, 219);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.ReadOnly = true;
            this.txtMaterialName.Size = new System.Drawing.Size(100, 26);
            this.txtMaterialName.TabIndex = 3;
            // 
            // txtMaterialDesc
            // 
            this.txtMaterialDesc.Location = new System.Drawing.Point(322, 219);
            this.txtMaterialDesc.Name = "txtMaterialDesc";
            this.txtMaterialDesc.ReadOnly = true;
            this.txtMaterialDesc.Size = new System.Drawing.Size(100, 26);
            this.txtMaterialDesc.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(608, 6);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(320, 193);
            this.txtOutput.TabIndex = 1;
            // 
            // dgMaterials
            // 
            this.dgMaterials.AllowUserToAddRows = false;
            this.dgMaterials.AllowUserToDeleteRows = false;
            this.dgMaterials.AllowUserToOrderColumns = true;
            this.dgMaterials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterials.Location = new System.Drawing.Point(82, 6);
            this.dgMaterials.Name = "dgMaterials";
            this.dgMaterials.ReadOnly = true;
            this.dgMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMaterials.Size = new System.Drawing.Size(342, 193);
            this.dgMaterials.TabIndex = 0;
            this.dgMaterials.SelectionChanged += new System.EventHandler(this.dgMaterials_SelectionChanged);
            // 
            // tabDBUpdate
            // 
            this.tabDBUpdate.Controls.Add(this.label22);
            this.tabDBUpdate.Controls.Add(this.label21);
            this.tabDBUpdate.Controls.Add(this.btnDelEntry);
            this.tabDBUpdate.Controls.Add(this.label20);
            this.tabDBUpdate.Controls.Add(this.txtMatID);
            this.tabDBUpdate.Controls.Add(this.label19);
            this.tabDBUpdate.Controls.Add(this.btnDBEntry);
            this.tabDBUpdate.Controls.Add(this.label18);
            this.tabDBUpdate.Controls.Add(this.label17);
            this.tabDBUpdate.Controls.Add(this.label16);
            this.tabDBUpdate.Controls.Add(this.label15);
            this.tabDBUpdate.Controls.Add(this.txtDescriptionEntry);
            this.tabDBUpdate.Controls.Add(this.txtThicknessEntry);
            this.tabDBUpdate.Controls.Add(this.txtPPSqFtEntry);
            this.tabDBUpdate.Controls.Add(this.txtMaterialEntry);
            this.tabDBUpdate.Location = new System.Drawing.Point(4, 29);
            this.tabDBUpdate.Name = "tabDBUpdate";
            this.tabDBUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDBUpdate.Size = new System.Drawing.Size(1011, 494);
            this.tabDBUpdate.TabIndex = 2;
            this.tabDBUpdate.Text = "Update Materials";
            this.tabDBUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDBEntry
            // 
            this.btnDBEntry.Location = new System.Drawing.Point(238, 328);
            this.btnDBEntry.Name = "btnDBEntry";
            this.btnDBEntry.Size = new System.Drawing.Size(191, 36);
            this.btnDBEntry.TabIndex = 8;
            this.btnDBEntry.Text = "Create New Entry";
            this.btnDBEntry.UseVisualStyleBackColor = true;
            this.btnDBEntry.Click += new System.EventHandler(this.btnDBEntry_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Material Thickness";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Description";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Price per sq ft";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Material Type";
            // 
            // txtDescriptionEntry
            // 
            this.txtDescriptionEntry.Location = new System.Drawing.Point(226, 234);
            this.txtDescriptionEntry.Multiline = true;
            this.txtDescriptionEntry.Name = "txtDescriptionEntry";
            this.txtDescriptionEntry.Size = new System.Drawing.Size(217, 55);
            this.txtDescriptionEntry.TabIndex = 3;
            // 
            // txtThicknessEntry
            // 
            this.txtThicknessEntry.Location = new System.Drawing.Point(226, 185);
            this.txtThicknessEntry.Name = "txtThicknessEntry";
            this.txtThicknessEntry.Size = new System.Drawing.Size(217, 26);
            this.txtThicknessEntry.TabIndex = 2;
            // 
            // txtPPSqFtEntry
            // 
            this.txtPPSqFtEntry.Location = new System.Drawing.Point(226, 131);
            this.txtPPSqFtEntry.Name = "txtPPSqFtEntry";
            this.txtPPSqFtEntry.Size = new System.Drawing.Size(217, 26);
            this.txtPPSqFtEntry.TabIndex = 1;
            // 
            // txtMaterialEntry
            // 
            this.txtMaterialEntry.Location = new System.Drawing.Point(226, 80);
            this.txtMaterialEntry.Name = "txtMaterialEntry";
            this.txtMaterialEntry.Size = new System.Drawing.Size(217, 26);
            this.txtMaterialEntry.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(222, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 25);
            this.label19.TabIndex = 9;
            this.label19.Text = "Add New Material";
            // 
            // txtMatID
            // 
            this.txtMatID.Location = new System.Drawing.Point(663, 77);
            this.txtMatID.Name = "txtMatID";
            this.txtMatID.Size = new System.Drawing.Size(217, 26);
            this.txtMatID.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(543, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "Material ID#";
            // 
            // btnDelEntry
            // 
            this.btnDelEntry.Location = new System.Drawing.Point(663, 137);
            this.btnDelEntry.Name = "btnDelEntry";
            this.btnDelEntry.Size = new System.Drawing.Size(191, 36);
            this.btnDelEntry.TabIndex = 12;
            this.btnDelEntry.Text = "Delete Entry";
            this.btnDelEntry.UseVisualStyleBackColor = true;
            this.btnDelEntry.Click += new System.EventHandler(this.btnDelEntry_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(360, 425);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(315, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Exit and reopen program for changes to be reflected";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(658, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 25);
            this.label22.TabIndex = 14;
            this.label22.Text = "Delete Material";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SqFtEstimate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabCustomer.ResumeLayout(false);
            this.TabCustomer.PerformLayout();
            this.TabJob.ResumeLayout(false);
            this.TabJob.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterials)).EndInit();
            this.tabDBUpdate.ResumeLayout(false);
            this.tabDBUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCustomer;
        private System.Windows.Forms.TabPage TabJob;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.DataGridView dgMaterials;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtMaterialPrice;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.TextBox txtMaterialDesc;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLaborCharge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEstimateTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaterialCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSqYd;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSelf;
        private System.Windows.Forms.RadioButton RdoPro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabDBUpdate;
        private System.Windows.Forms.TextBox txtMaterialEntry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDescriptionEntry;
        private System.Windows.Forms.TextBox txtThicknessEntry;
        private System.Windows.Forms.TextBox txtPPSqFtEntry;
        private System.Windows.Forms.Button btnDBEntry;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMatID;
        private System.Windows.Forms.Button btnDelEntry;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}

