namespace Pharmacy_Management_System
{
    partial class Form_ViewAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Admin = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cmb_AdminID = new System.Windows.Forms.ComboBox();
            this.txt_AdminName = new System.Windows.Forms.TextBox();
            this.radioBtn_AdminName = new System.Windows.Forms.RadioButton();
            this.radioBtn_AdminID = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 525);
            this.panel1.TabIndex = 44;
            // 
            // dataGridView_Admin
            // 
            this.dataGridView_Admin.AllowUserToAddRows = false;
            this.dataGridView_Admin.AllowUserToDeleteRows = false;
            this.dataGridView_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Admin.Name = "dataGridView_Admin";
            this.dataGridView_Admin.ReadOnly = true;
            this.dataGridView_Admin.Size = new System.Drawing.Size(984, 525);
            this.dataGridView_Admin.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 70);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 43;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // cmb_AdminID
            // 
            this.cmb_AdminID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AdminID.FormattingEnabled = true;
            this.cmb_AdminID.Location = new System.Drawing.Point(220, 19);
            this.cmb_AdminID.Name = "cmb_AdminID";
            this.cmb_AdminID.Size = new System.Drawing.Size(220, 32);
            this.cmb_AdminID.TabIndex = 41;
            // 
            // txt_AdminName
            // 
            this.txt_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminName.Location = new System.Drawing.Point(700, 19);
            this.txt_AdminName.Name = "txt_AdminName";
            this.txt_AdminName.Size = new System.Drawing.Size(250, 29);
            this.txt_AdminName.TabIndex = 47;
            // 
            // radioBtn_AdminName
            // 
            this.radioBtn_AdminName.AutoSize = true;
            this.radioBtn_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AdminName.Location = new System.Drawing.Point(500, 20);
            this.radioBtn_AdminName.Name = "radioBtn_AdminName";
            this.radioBtn_AdminName.Size = new System.Drawing.Size(139, 28);
            this.radioBtn_AdminName.TabIndex = 46;
            this.radioBtn_AdminName.TabStop = true;
            this.radioBtn_AdminName.Text = "Admin Name";
            this.radioBtn_AdminName.UseVisualStyleBackColor = true;
            // 
            // radioBtn_AdminID
            // 
            this.radioBtn_AdminID.AutoSize = true;
            this.radioBtn_AdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AdminID.Location = new System.Drawing.Point(20, 20);
            this.radioBtn_AdminID.Name = "radioBtn_AdminID";
            this.radioBtn_AdminID.Size = new System.Drawing.Size(105, 28);
            this.radioBtn_AdminID.TabIndex = 45;
            this.radioBtn_AdminID.TabStop = true;
            this.radioBtn_AdminID.Text = "Admin ID";
            this.radioBtn_AdminID.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(330, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 37);
            this.btn_Search.TabIndex = 42;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Form_ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cmb_AdminID);
            this.Controls.Add(this.txt_AdminName);
            this.Controls.Add(this.radioBtn_AdminName);
            this.Controls.Add(this.radioBtn_AdminID);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Admin Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Admin;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmb_AdminID;
        private System.Windows.Forms.TextBox txt_AdminName;
        private System.Windows.Forms.RadioButton radioBtn_AdminName;
        private System.Windows.Forms.RadioButton radioBtn_AdminID;
        private System.Windows.Forms.Button btn_Search;
    }
}