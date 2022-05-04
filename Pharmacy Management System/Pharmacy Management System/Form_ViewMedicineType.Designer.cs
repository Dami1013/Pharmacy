namespace Pharmacy_Management_System
{
    partial class Form_ViewMedicineType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewMedicineType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_MedType = new System.Windows.Forms.DataGridView();
            this.txt_MedType = new System.Windows.Forms.TextBox();
            this.radioBtn_MedType = new System.Windows.Forms.RadioButton();
            this.cmb_MedTypeID = new System.Windows.Forms.ComboBox();
            this.radioBtn_MedTypeID = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_MedType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 525);
            this.panel1.TabIndex = 49;
            // 
            // dataGridView_MedType
            // 
            this.dataGridView_MedType.AllowUserToAddRows = false;
            this.dataGridView_MedType.AllowUserToDeleteRows = false;
            this.dataGridView_MedType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MedType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MedType.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MedType.Name = "dataGridView_MedType";
            this.dataGridView_MedType.ReadOnly = true;
            this.dataGridView_MedType.Size = new System.Drawing.Size(984, 525);
            this.dataGridView_MedType.TabIndex = 0;
            // 
            // txt_MedType
            // 
            this.txt_MedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedType.Location = new System.Drawing.Point(700, 19);
            this.txt_MedType.Name = "txt_MedType";
            this.txt_MedType.Size = new System.Drawing.Size(250, 29);
            this.txt_MedType.TabIndex = 53;
            // 
            // radioBtn_MedType
            // 
            this.radioBtn_MedType.AutoSize = true;
            this.radioBtn_MedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedType.Location = new System.Drawing.Point(500, 20);
            this.radioBtn_MedType.Name = "radioBtn_MedType";
            this.radioBtn_MedType.Size = new System.Drawing.Size(154, 28);
            this.radioBtn_MedType.TabIndex = 52;
            this.radioBtn_MedType.TabStop = true;
            this.radioBtn_MedType.Text = "Medicine Type";
            this.radioBtn_MedType.UseVisualStyleBackColor = true;
            // 
            // cmb_MedTypeID
            // 
            this.cmb_MedTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MedTypeID.FormattingEnabled = true;
            this.cmb_MedTypeID.Location = new System.Drawing.Point(220, 19);
            this.cmb_MedTypeID.Name = "cmb_MedTypeID";
            this.cmb_MedTypeID.Size = new System.Drawing.Size(220, 32);
            this.cmb_MedTypeID.TabIndex = 47;
            // 
            // radioBtn_MedTypeID
            // 
            this.radioBtn_MedTypeID.AutoSize = true;
            this.radioBtn_MedTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedTypeID.Location = new System.Drawing.Point(20, 20);
            this.radioBtn_MedTypeID.Name = "radioBtn_MedTypeID";
            this.radioBtn_MedTypeID.Size = new System.Drawing.Size(176, 28);
            this.radioBtn_MedTypeID.TabIndex = 51;
            this.radioBtn_MedTypeID.TabStop = true;
            this.radioBtn_MedTypeID.Text = "Medicine Type ID";
            this.radioBtn_MedTypeID.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(330, 70);
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
            this.btn_Clear.Location = new System.Drawing.Point(500, 70);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 50;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form_ViewMedicineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_MedType);
            this.Controls.Add(this.radioBtn_MedType);
            this.Controls.Add(this.cmb_MedTypeID);
            this.Controls.Add(this.radioBtn_MedTypeID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewMedicineType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " View Medicine Type Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_MedType;
        private System.Windows.Forms.TextBox txt_MedType;
        private System.Windows.Forms.RadioButton radioBtn_MedType;
        private System.Windows.Forms.ComboBox cmb_MedTypeID;
        private System.Windows.Forms.RadioButton radioBtn_MedTypeID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
    }
}