namespace Pharmacy_Management_System
{
    partial class Form_UpdateMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateMedicine));
            this.dataGridView_Medicine = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_MedType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MedID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MedUnitPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Medicine
            // 
            this.dataGridView_Medicine.AllowUserToDeleteRows = false;
            this.dataGridView_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Medicine.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Medicine.Name = "dataGridView_Medicine";
            this.dataGridView_Medicine.ReadOnly = true;
            this.dataGridView_Medicine.Size = new System.Drawing.Size(984, 475);
            this.dataGridView_Medicine.TabIndex = 0;
            this.dataGridView_Medicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Medicine_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Medicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 475);
            this.panel1.TabIndex = 44;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(504, 120);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 43;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(365, 120);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 37);
            this.btn_Update.TabIndex = 42;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cmb_MedType
            // 
            this.cmb_MedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MedType.FormattingEnabled = true;
            this.cmb_MedType.Location = new System.Drawing.Point(227, 70);
            this.cmb_MedType.Name = "cmb_MedType";
            this.cmb_MedType.Size = new System.Drawing.Size(248, 32);
            this.cmb_MedType.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Unit Price";
            // 
            // txt_MedName
            // 
            this.txt_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedName.Location = new System.Drawing.Point(700, 17);
            this.txt_MedName.Name = "txt_MedName";
            this.txt_MedName.Size = new System.Drawing.Size(250, 29);
            this.txt_MedName.TabIndex = 0;
            this.txt_MedName.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Medicine Name";
            // 
            // txt_MedID
            // 
            this.txt_MedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedID.Location = new System.Drawing.Point(225, 17);
            this.txt_MedID.Name = "txt_MedID";
            this.txt_MedID.ReadOnly = true;
            this.txt_MedID.Size = new System.Drawing.Size(250, 29);
            this.txt_MedID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Medicine ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Medicine Type";
            // 
            // txt_MedUnitPrice
            // 
            this.txt_MedUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedUnitPrice.Location = new System.Drawing.Point(700, 67);
            this.txt_MedUnitPrice.Name = "txt_MedUnitPrice";
            this.txt_MedUnitPrice.Size = new System.Drawing.Size(250, 29);
            this.txt_MedUnitPrice.TabIndex = 39;
            this.txt_MedUnitPrice.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Form_UpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cmb_MedType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MedUnitPrice);
            this.Controls.Add(this.txt_MedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MedID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_UpdateMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Medicine Details";
            this.Load += new System.EventHandler(this.Form_UpdateMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Medicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmb_MedType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MedID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MedUnitPrice;
    }
}