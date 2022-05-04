namespace Pharmacy_Management_System
{
    partial class Form_ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewEmployee));
            this.cmb_EmpID = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.radioBtn_EmpID = new System.Windows.Forms.RadioButton();
            this.radioBtn_EmpName = new System.Windows.Forms.RadioButton();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_EmpID
            // 
            this.cmb_EmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EmpID.FormattingEnabled = true;
            this.cmb_EmpID.Location = new System.Drawing.Point(220, 19);
            this.cmb_EmpID.Name = "cmb_EmpID";
            this.cmb_EmpID.Size = new System.Drawing.Size(220, 32);
            this.cmb_EmpID.TabIndex = 27;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 70);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Employee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 525);
            this.panel1.TabIndex = 37;
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.AllowUserToAddRows = false;
            this.dataGridView_Employee.AllowUserToDeleteRows = false;
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Employee.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.ReadOnly = true;
            this.dataGridView_Employee.Size = new System.Drawing.Size(984, 525);
            this.dataGridView_Employee.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(330, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 37);
            this.btn_Search.TabIndex = 35;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // radioBtn_EmpID
            // 
            this.radioBtn_EmpID.AutoSize = true;
            this.radioBtn_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_EmpID.Location = new System.Drawing.Point(25, 20);
            this.radioBtn_EmpID.Name = "radioBtn_EmpID";
            this.radioBtn_EmpID.Size = new System.Drawing.Size(136, 28);
            this.radioBtn_EmpID.TabIndex = 38;
            this.radioBtn_EmpID.TabStop = true;
            this.radioBtn_EmpID.Text = "Employee ID";
            this.radioBtn_EmpID.UseVisualStyleBackColor = true;
            // 
            // radioBtn_EmpName
            // 
            this.radioBtn_EmpName.AutoSize = true;
            this.radioBtn_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_EmpName.Location = new System.Drawing.Point(500, 20);
            this.radioBtn_EmpName.Name = "radioBtn_EmpName";
            this.radioBtn_EmpName.Size = new System.Drawing.Size(170, 28);
            this.radioBtn_EmpName.TabIndex = 39;
            this.radioBtn_EmpName.TabStop = true;
            this.radioBtn_EmpName.Text = "Employee Name";
            this.radioBtn_EmpName.UseVisualStyleBackColor = true;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpName.Location = new System.Drawing.Point(700, 19);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpName.TabIndex = 40;
            // 
            // Form_ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.radioBtn_EmpName);
            this.Controls.Add(this.radioBtn_EmpID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_EmpID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search & View Employee Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_EmpID;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton radioBtn_EmpID;
        private System.Windows.Forms.RadioButton radioBtn_EmpName;
        private System.Windows.Forms.TextBox txt_EmpName;
    }
}