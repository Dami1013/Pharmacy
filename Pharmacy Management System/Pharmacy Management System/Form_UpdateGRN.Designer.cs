namespace Pharmacy_Management_System
{
    partial class Form_UpdateGRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateGRN));
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.btn_Medicine = new System.Windows.Forms.Button();
            this.btn_Supplier = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.cmb_Medicine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MedicineID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.date_Invoice = new System.Windows.Forms.DateTimePicker();
            this.date_GRN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_InvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SupID = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1234 = new System.Windows.Forms.Label();
            this.btn_UpdateStock = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_UpdateGRN = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_GRN = new System.Windows.Forms.DataGridView();
            this.GRN_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_GRNID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.btn_UpdateRow = new System.Windows.Forms.Button();
            this.btn_ClearFields = new System.Windows.Forms.Button();
            this.date_Exp = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SalePrice = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRN)).BeginInit();
            this.SuspendLayout();
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            // 
            // medicineBindingSource1
            // 
            this.medicineBindingSource1.DataMember = "Medicine";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubTotal.Location = new System.Drawing.Point(220, 367);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.ReadOnly = true;
            this.txt_SubTotal.Size = new System.Drawing.Size(250, 29);
            this.txt_SubTotal.TabIndex = 72;
            // 
            // btn_Medicine
            // 
            this.btn_Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medicine.Location = new System.Drawing.Point(504, 164);
            this.btn_Medicine.Name = "btn_Medicine";
            this.btn_Medicine.Size = new System.Drawing.Size(110, 37);
            this.btn_Medicine.TabIndex = 71;
            this.btn_Medicine.Text = "Medicine";
            this.btn_Medicine.UseVisualStyleBackColor = true;
            this.btn_Medicine.Click += new System.EventHandler(this.Btn_Medicine_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supplier.Location = new System.Drawing.Point(504, 114);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Size = new System.Drawing.Size(110, 37);
            this.btn_Supplier.TabIndex = 70;
            this.btn_Supplier.Text = "Supplier";
            this.btn_Supplier.UseVisualStyleBackColor = true;
            this.btn_Supplier.Click += new System.EventHandler(this.Btn_Supplier_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(850, 375);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(110, 37);
            this.btn_Remove.TabIndex = 69;
            this.btn_Remove.Text = "&Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(550, 375);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 37);
            this.btn_Add.TabIndex = 68;
            this.btn_Add.Text = "&Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 67;
            this.label9.Text = "Unit Price";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(220, 267);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(250, 29);
            this.txt_UnitPrice.TabIndex = 66;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.AllowDrop = true;
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(220, 117);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(250, 32);
            this.cmb_Supplier.TabIndex = 65;
            // 
            // cmb_Medicine
            // 
            this.cmb_Medicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Medicine.FormattingEnabled = true;
            this.cmb_Medicine.Location = new System.Drawing.Point(220, 167);
            this.cmb_Medicine.Name = "cmb_Medicine";
            this.cmb_Medicine.Size = new System.Drawing.Size(250, 32);
            this.cmb_Medicine.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(850, 267);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(250, 29);
            this.txt_Quantity.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Medicine Name";
            // 
            // txt_MedicineID
            // 
            this.txt_MedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedicineID.Location = new System.Drawing.Point(850, 167);
            this.txt_MedicineID.Name = "txt_MedicineID";
            this.txt_MedicineID.ReadOnly = true;
            this.txt_MedicineID.Size = new System.Drawing.Size(250, 29);
            this.txt_MedicineID.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Medicine ID";
            // 
            // date_Invoice
            // 
            this.date_Invoice.Location = new System.Drawing.Point(850, 72);
            this.date_Invoice.Name = "date_Invoice";
            this.date_Invoice.Size = new System.Drawing.Size(250, 20);
            this.date_Invoice.TabIndex = 51;
            // 
            // date_GRN
            // 
            this.date_GRN.Location = new System.Drawing.Point(850, 22);
            this.date_GRN.Name = "date_GRN";
            this.date_GRN.Size = new System.Drawing.Size(250, 20);
            this.date_GRN.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "GRN Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(650, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Invoice Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "GRN ID";
            // 
            // txt_InvoiceID
            // 
            this.txt_InvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvoiceID.Location = new System.Drawing.Point(220, 67);
            this.txt_InvoiceID.Name = "txt_InvoiceID";
            this.txt_InvoiceID.Size = new System.Drawing.Size(250, 29);
            this.txt_InvoiceID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Invoice ID";
            // 
            // txt_SupID
            // 
            this.txt_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupID.Location = new System.Drawing.Point(850, 117);
            this.txt_SupID.Name = "txt_SupID";
            this.txt_SupID.ReadOnly = true;
            this.txt_SupID.Size = new System.Drawing.Size(250, 29);
            this.txt_SupID.TabIndex = 58;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(650, 120);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(113, 24);
            this.label123.TabIndex = 56;
            this.label123.Text = "Supplier ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Supplier Name";
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1234.Location = new System.Drawing.Point(22, 370);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(99, 24);
            this.label1234.TabIndex = 73;
            this.label1234.Text = "Sub Total";
            // 
            // btn_UpdateStock
            // 
            this.btn_UpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateStock.Location = new System.Drawing.Point(500, 15);
            this.btn_UpdateStock.Name = "btn_UpdateStock";
            this.btn_UpdateStock.Size = new System.Drawing.Size(150, 37);
            this.btn_UpdateStock.TabIndex = 34;
            this.btn_UpdateStock.Text = "&Update Stock";
            this.btn_UpdateStock.UseVisualStyleBackColor = true;
            this.btn_UpdateStock.Click += new System.EventHandler(this.btn_UpdateStock_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(700, 15);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(110, 37);
            this.btn_Print.TabIndex = 35;
            this.btn_Print.Text = "&Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(850, 15);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(110, 37);
            this.btn_New.TabIndex = 36;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(1000, 15);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 40;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_UpdateGRN);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_New);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.btn_UpdateStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 75);
            this.panel1.TabIndex = 54;
            // 
            // btn_UpdateGRN
            // 
            this.btn_UpdateGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateGRN.Location = new System.Drawing.Point(300, 15);
            this.btn_UpdateGRN.Name = "btn_UpdateGRN";
            this.btn_UpdateGRN.Size = new System.Drawing.Size(150, 37);
            this.btn_UpdateGRN.TabIndex = 77;
            this.btn_UpdateGRN.Text = "&Update GRN";
            this.btn_UpdateGRN.UseVisualStyleBackColor = true;
            this.btn_UpdateGRN.Click += new System.EventHandler(this.Btn_UpdateGRN_Click);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(26, 15);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(110, 37);
            this.btn_View.TabIndex = 76;
            this.btn_View.Text = "&View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_GRN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 225);
            this.panel3.TabIndex = 74;
            // 
            // dataGridView_GRN
            // 
            this.dataGridView_GRN.AllowUserToDeleteRows = false;
            this.dataGridView_GRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRN_Id,
            this.Grid_Order_No,
            this.Med_Id,
            this.Med_Name,
            this.Sup_Id,
            this.Sup_Name,
            this.Qty,
            this.Unit_Price,
            this.Exp_Date,
            this.Discount,
            this.Sale_Amount,
            this.Total});
            this.dataGridView_GRN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_GRN.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_GRN.Name = "dataGridView_GRN";
            this.dataGridView_GRN.ReadOnly = true;
            this.dataGridView_GRN.Size = new System.Drawing.Size(1134, 225);
            this.dataGridView_GRN.TabIndex = 1;
            this.dataGridView_GRN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_GRN_CellContentClick);
            // 
            // GRN_Id
            // 
            this.GRN_Id.HeaderText = "GRN_Id";
            this.GRN_Id.Name = "GRN_Id";
            this.GRN_Id.ReadOnly = true;
            // 
            // Grid_Order_No
            // 
            this.Grid_Order_No.HeaderText = "Grid_Order_No";
            this.Grid_Order_No.Name = "Grid_Order_No";
            this.Grid_Order_No.ReadOnly = true;
            // 
            // Med_Id
            // 
            this.Med_Id.HeaderText = "Med_Id";
            this.Med_Id.Name = "Med_Id";
            this.Med_Id.ReadOnly = true;
            // 
            // Med_Name
            // 
            this.Med_Name.HeaderText = "Med_Name";
            this.Med_Name.Name = "Med_Name";
            this.Med_Name.ReadOnly = true;
            // 
            // Sup_Id
            // 
            this.Sup_Id.HeaderText = "Sup_Id";
            this.Sup_Id.Name = "Sup_Id";
            this.Sup_Id.ReadOnly = true;
            // 
            // Sup_Name
            // 
            this.Sup_Name.HeaderText = "Sup_Name";
            this.Sup_Name.Name = "Sup_Name";
            this.Sup_Name.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit_Price";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Exp_Date
            // 
            this.Exp_Date.HeaderText = "Exp_Date";
            this.Exp_Date.Name = "Exp_Date";
            this.Exp_Date.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Sale_Amount
            // 
            this.Sale_Amount.HeaderText = "Sale_Amount";
            this.Sale_Amount.Name = "Sale_Amount";
            this.Sale_Amount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // cmb_GRNID
            // 
            this.cmb_GRNID.AllowDrop = true;
            this.cmb_GRNID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GRNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GRNID.FormattingEnabled = true;
            this.cmb_GRNID.Location = new System.Drawing.Point(220, 17);
            this.cmb_GRNID.Name = "cmb_GRNID";
            this.cmb_GRNID.Size = new System.Drawing.Size(250, 32);
            this.cmb_GRNID.TabIndex = 75;
            this.cmb_GRNID.SelectedIndexChanged += new System.EventHandler(this.Cmb_GRNID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 77;
            this.label8.Text = "Discount";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(220, 317);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(250, 29);
            this.txt_Discount.TabIndex = 76;
            // 
            // btn_UpdateRow
            // 
            this.btn_UpdateRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRow.Location = new System.Drawing.Point(700, 375);
            this.btn_UpdateRow.Name = "btn_UpdateRow";
            this.btn_UpdateRow.Size = new System.Drawing.Size(110, 37);
            this.btn_UpdateRow.TabIndex = 79;
            this.btn_UpdateRow.Text = "&Update";
            this.btn_UpdateRow.UseVisualStyleBackColor = true;
            // 
            // btn_ClearFields
            // 
            this.btn_ClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearFields.Location = new System.Drawing.Point(1000, 375);
            this.btn_ClearFields.Name = "btn_ClearFields";
            this.btn_ClearFields.Size = new System.Drawing.Size(110, 37);
            this.btn_ClearFields.TabIndex = 78;
            this.btn_ClearFields.Text = "&Clear";
            this.btn_ClearFields.UseVisualStyleBackColor = true;
            this.btn_ClearFields.Click += new System.EventHandler(this.Btn_ClearFields_Click_1);
            // 
            // date_Exp
            // 
            this.date_Exp.Location = new System.Drawing.Point(220, 225);
            this.date_Exp.Name = "date_Exp";
            this.date_Exp.Size = new System.Drawing.Size(250, 20);
            this.date_Exp.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "Expire Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(654, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 83;
            this.label11.Text = "Sale Price";
            // 
            // txt_SalePrice
            // 
            this.txt_SalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalePrice.Location = new System.Drawing.Point(850, 317);
            this.txt_SalePrice.Name = "txt_SalePrice";
            this.txt_SalePrice.Size = new System.Drawing.Size(250, 29);
            this.txt_SalePrice.TabIndex = 82;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form_UpdateGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 761);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_SalePrice);
            this.Controls.Add(this.date_Exp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_UpdateRow);
            this.Controls.Add(this.btn_ClearFields);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.cmb_GRNID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.btn_Medicine);
            this.Controls.Add(this.btn_Supplier);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.cmb_Supplier);
            this.Controls.Add(this.cmb_Medicine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MedicineID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_Invoice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date_GRN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InvoiceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SupID);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_UpdateGRN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Good Recieve Note Details";
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.BindingSource medicineBindingSource1;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.Button btn_Medicine;
        private System.Windows.Forms.Button btn_Supplier;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.ComboBox cmb_Medicine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MedicineID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_Invoice;
        private System.Windows.Forms.DateTimePicker date_GRN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_InvoiceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SupID;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Button btn_UpdateStock;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_GRNID;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.DataGridView dataGridView_GRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRN_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid_Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btn_UpdateRow;
        private System.Windows.Forms.Button btn_ClearFields;
        private System.Windows.Forms.Button btn_UpdateGRN;
        private System.Windows.Forms.DateTimePicker date_Exp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_SalePrice;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}