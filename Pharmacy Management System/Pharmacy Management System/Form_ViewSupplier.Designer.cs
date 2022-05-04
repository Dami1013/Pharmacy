namespace Pharmacy_Management_System
{
    partial class Form_ViewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewSupplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Supplier = new System.Windows.Forms.DataGridView();
            this.txt_SupName = new System.Windows.Forms.TextBox();
            this.radioBtn_SupName = new System.Windows.Forms.RadioButton();
            this.cmb_SupID = new System.Windows.Forms.ComboBox();
            this.radioBtn_SupID = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Supplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 500);
            this.panel1.TabIndex = 43;
            // 
            // dataGridView_Supplier
            // 
            this.dataGridView_Supplier.AllowUserToAddRows = false;
            this.dataGridView_Supplier.AllowUserToDeleteRows = false;
            this.dataGridView_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Supplier.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Supplier.Name = "dataGridView_Supplier";
            this.dataGridView_Supplier.ReadOnly = true;
            this.dataGridView_Supplier.Size = new System.Drawing.Size(984, 500);
            this.dataGridView_Supplier.TabIndex = 0;
            // 
            // txt_SupName
            // 
            this.txt_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupName.Location = new System.Drawing.Point(700, 20);
            this.txt_SupName.Name = "txt_SupName";
            this.txt_SupName.Size = new System.Drawing.Size(250, 29);
            this.txt_SupName.TabIndex = 52;
            // 
            // radioBtn_SupName
            // 
            this.radioBtn_SupName.AutoSize = true;
            this.radioBtn_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_SupName.Location = new System.Drawing.Point(500, 20);
            this.radioBtn_SupName.Name = "radioBtn_SupName";
            this.radioBtn_SupName.Size = new System.Drawing.Size(162, 28);
            this.radioBtn_SupName.TabIndex = 51;
            this.radioBtn_SupName.TabStop = true;
            this.radioBtn_SupName.Text = "Medicine Name";
            this.radioBtn_SupName.UseVisualStyleBackColor = true;
            // 
            // cmb_SupID
            // 
            this.cmb_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SupID.FormattingEnabled = true;
            this.cmb_SupID.Location = new System.Drawing.Point(220, 20);
            this.cmb_SupID.Name = "cmb_SupID";
            this.cmb_SupID.Size = new System.Drawing.Size(220, 32);
            this.cmb_SupID.TabIndex = 47;
            // 
            // radioBtn_SupID
            // 
            this.radioBtn_SupID.AutoSize = true;
            this.radioBtn_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_SupID.Location = new System.Drawing.Point(26, 20);
            this.radioBtn_SupID.Name = "radioBtn_SupID";
            this.radioBtn_SupID.Size = new System.Drawing.Size(120, 28);
            this.radioBtn_SupID.TabIndex = 50;
            this.radioBtn_SupID.TabStop = true;
            this.radioBtn_SupID.Text = "Supplier ID";
            this.radioBtn_SupID.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(330, 93);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 37);
            this.btn_Search.TabIndex = 48;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 93);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 49;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form_ViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_SupName);
            this.Controls.Add(this.radioBtn_SupName);
            this.Controls.Add(this.cmb_SupID);
            this.Controls.Add(this.radioBtn_SupID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Supplier Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Supplier;
        private System.Windows.Forms.TextBox txt_SupName;
        private System.Windows.Forms.RadioButton radioBtn_SupName;
        private System.Windows.Forms.ComboBox cmb_SupID;
        private System.Windows.Forms.RadioButton radioBtn_SupID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
    }
}