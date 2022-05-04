namespace Pharmacy_Management_System
{
    partial class Form_ViewMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewMedicine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Medicine = new System.Windows.Forms.DataGridView();
            this.txt_MedName = new System.Windows.Forms.TextBox();
            this.radioBtn_MedName = new System.Windows.Forms.RadioButton();
            this.radioBtn_MedID = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.cmb_MedID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Medicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 525);
            this.panel1.TabIndex = 43;
            // 
            // dataGridView_Medicine
            // 
            this.dataGridView_Medicine.AllowUserToAddRows = false;
            this.dataGridView_Medicine.AllowUserToDeleteRows = false;
            this.dataGridView_Medicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Medicine.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Medicine.Name = "dataGridView_Medicine";
            this.dataGridView_Medicine.ReadOnly = true;
            this.dataGridView_Medicine.Size = new System.Drawing.Size(984, 525);
            this.dataGridView_Medicine.TabIndex = 0;
            // 
            // txt_MedName
            // 
            this.txt_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedName.Location = new System.Drawing.Point(700, 19);
            this.txt_MedName.Name = "txt_MedName";
            this.txt_MedName.Size = new System.Drawing.Size(250, 29);
            this.txt_MedName.TabIndex = 46;
            // 
            // radioBtn_MedName
            // 
            this.radioBtn_MedName.AutoSize = true;
            this.radioBtn_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedName.Location = new System.Drawing.Point(500, 20);
            this.radioBtn_MedName.Name = "radioBtn_MedName";
            this.radioBtn_MedName.Size = new System.Drawing.Size(162, 28);
            this.radioBtn_MedName.TabIndex = 45;
            this.radioBtn_MedName.TabStop = true;
            this.radioBtn_MedName.Text = "Medicine Name";
            this.radioBtn_MedName.UseVisualStyleBackColor = true;
            // 
            // radioBtn_MedID
            // 
            this.radioBtn_MedID.AutoSize = true;
            this.radioBtn_MedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedID.Location = new System.Drawing.Point(26, 20);
            this.radioBtn_MedID.Name = "radioBtn_MedID";
            this.radioBtn_MedID.Size = new System.Drawing.Size(128, 28);
            this.radioBtn_MedID.TabIndex = 44;
            this.radioBtn_MedID.TabStop = true;
            this.radioBtn_MedID.Text = "Medicine ID";
            this.radioBtn_MedID.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(500, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 37);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(330, 70);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(110, 37);
            this.btn_View.TabIndex = 42;
            this.btn_View.Text = "Search";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // cmb_MedID
            // 
            this.cmb_MedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MedID.FormattingEnabled = true;
            this.cmb_MedID.Location = new System.Drawing.Point(220, 20);
            this.cmb_MedID.Name = "cmb_MedID";
            this.cmb_MedID.Size = new System.Drawing.Size(220, 32);
            this.cmb_MedID.TabIndex = 41;
            // 
            // Form_ViewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_MedName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioBtn_MedName);
            this.Controls.Add(this.cmb_MedID);
            this.Controls.Add(this.radioBtn_MedID);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search & View Medicine Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Medicine;
        private System.Windows.Forms.TextBox txt_MedName;
        private System.Windows.Forms.RadioButton radioBtn_MedName;
        private System.Windows.Forms.RadioButton radioBtn_MedID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.ComboBox cmb_MedID;
    }
}