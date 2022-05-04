namespace Pharmacy_Management_System
{
    partial class Form_UpdateMedicineType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateMedicineType));
            this.dataGridView_MedicineType = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MedTypeName = new System.Windows.Forms.TextBox();
            this.txt_MedTypeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicineType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_MedicineType
            // 
            this.dataGridView_MedicineType.AllowUserToDeleteRows = false;
            this.dataGridView_MedicineType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MedicineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MedicineType.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MedicineType.Name = "dataGridView_MedicineType";
            this.dataGridView_MedicineType.ReadOnly = true;
            this.dataGridView_MedicineType.Size = new System.Drawing.Size(984, 525);
            this.dataGridView_MedicineType.TabIndex = 0;
            this.dataGridView_MedicineType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MedicineType_CellContentClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 70);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 53;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_MedicineType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 525);
            this.panel1.TabIndex = 52;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(360, 70);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 37);
            this.btn_Update.TabIndex = 51;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Medicine Type";
            // 
            // txt_MedTypeName
            // 
            this.txt_MedTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedTypeName.Location = new System.Drawing.Point(700, 17);
            this.txt_MedTypeName.Name = "txt_MedTypeName";
            this.txt_MedTypeName.Size = new System.Drawing.Size(250, 29);
            this.txt_MedTypeName.TabIndex = 48;
            // 
            // txt_MedTypeID
            // 
            this.txt_MedTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedTypeID.Location = new System.Drawing.Point(220, 17);
            this.txt_MedTypeID.Name = "txt_MedTypeID";
            this.txt_MedTypeID.ReadOnly = true;
            this.txt_MedTypeID.Size = new System.Drawing.Size(250, 29);
            this.txt_MedTypeID.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Medicine Type  ID";
            // 
            // Form_UpdateMedicineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MedTypeName);
            this.Controls.Add(this.txt_MedTypeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_UpdateMedicineType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Medicine Type Details";
            this.Load += new System.EventHandler(this.Form_UpdateMedicineType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicineType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MedicineType;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MedTypeName;
        private System.Windows.Forms.TextBox txt_MedTypeID;
        private System.Windows.Forms.Label label1;
    }
}