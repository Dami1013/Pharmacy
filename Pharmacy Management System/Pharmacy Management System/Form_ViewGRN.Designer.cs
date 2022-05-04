namespace Pharmacy_Management_System
{
    partial class Form_ViewGRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ViewGRN));
            this.radioBtn_SupName = new System.Windows.Forms.RadioButton();
            this.radioBtn_GRNID = new System.Windows.Forms.RadioButton();
            this.cmb_GRNID = new System.Windows.Forms.ComboBox();
            this.radioBtn_MedID = new System.Windows.Forms.RadioButton();
            this.radioBtn_MedName = new System.Windows.Forms.RadioButton();
            this.radioBtn_SupID = new System.Windows.Forms.RadioButton();
            this.cmb_SupID = new System.Windows.Forms.ComboBox();
            this.cmb_MedID = new System.Windows.Forms.ComboBox();
            this.txt_SupName = new System.Windows.Forms.TextBox();
            this.txt_MedName = new System.Windows.Forms.TextBox();
            this.dataGridView_GRNDetails = new System.Windows.Forms.DataGridView();
            this.dataGridView_GRNMaster = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRNDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRNMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtn_SupName
            // 
            this.radioBtn_SupName.AutoSize = true;
            this.radioBtn_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_SupName.Location = new System.Drawing.Point(500, 70);
            this.radioBtn_SupName.Name = "radioBtn_SupName";
            this.radioBtn_SupName.Size = new System.Drawing.Size(154, 28);
            this.radioBtn_SupName.TabIndex = 43;
            this.radioBtn_SupName.TabStop = true;
            this.radioBtn_SupName.Text = "Supplier Name";
            this.radioBtn_SupName.UseVisualStyleBackColor = true;
            // 
            // radioBtn_GRNID
            // 
            this.radioBtn_GRNID.AutoSize = true;
            this.radioBtn_GRNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_GRNID.Location = new System.Drawing.Point(20, 20);
            this.radioBtn_GRNID.Name = "radioBtn_GRNID";
            this.radioBtn_GRNID.Size = new System.Drawing.Size(91, 28);
            this.radioBtn_GRNID.TabIndex = 42;
            this.radioBtn_GRNID.TabStop = true;
            this.radioBtn_GRNID.Text = "GRN ID";
            this.radioBtn_GRNID.UseVisualStyleBackColor = true;
            // 
            // cmb_GRNID
            // 
            this.cmb_GRNID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GRNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GRNID.FormattingEnabled = true;
            this.cmb_GRNID.Location = new System.Drawing.Point(220, 19);
            this.cmb_GRNID.Name = "cmb_GRNID";
            this.cmb_GRNID.Size = new System.Drawing.Size(220, 32);
            this.cmb_GRNID.TabIndex = 41;
            // 
            // radioBtn_MedID
            // 
            this.radioBtn_MedID.AutoSize = true;
            this.radioBtn_MedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedID.Location = new System.Drawing.Point(20, 120);
            this.radioBtn_MedID.Name = "radioBtn_MedID";
            this.radioBtn_MedID.Size = new System.Drawing.Size(128, 28);
            this.radioBtn_MedID.TabIndex = 46;
            this.radioBtn_MedID.TabStop = true;
            this.radioBtn_MedID.Text = "Medicine ID";
            this.radioBtn_MedID.UseVisualStyleBackColor = true;
            // 
            // radioBtn_MedName
            // 
            this.radioBtn_MedName.AutoSize = true;
            this.radioBtn_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_MedName.Location = new System.Drawing.Point(500, 120);
            this.radioBtn_MedName.Name = "radioBtn_MedName";
            this.radioBtn_MedName.Size = new System.Drawing.Size(106, 28);
            this.radioBtn_MedName.TabIndex = 47;
            this.radioBtn_MedName.TabStop = true;
            this.radioBtn_MedName.Text = "Medicine";
            this.radioBtn_MedName.UseVisualStyleBackColor = true;
            // 
            // radioBtn_SupID
            // 
            this.radioBtn_SupID.AutoSize = true;
            this.radioBtn_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_SupID.Location = new System.Drawing.Point(20, 70);
            this.radioBtn_SupID.Name = "radioBtn_SupID";
            this.radioBtn_SupID.Size = new System.Drawing.Size(120, 28);
            this.radioBtn_SupID.TabIndex = 48;
            this.radioBtn_SupID.TabStop = true;
            this.radioBtn_SupID.Text = "Supplier ID";
            this.radioBtn_SupID.UseVisualStyleBackColor = true;
            // 
            // cmb_SupID
            // 
            this.cmb_SupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SupID.FormattingEnabled = true;
            this.cmb_SupID.Location = new System.Drawing.Point(220, 70);
            this.cmb_SupID.Name = "cmb_SupID";
            this.cmb_SupID.Size = new System.Drawing.Size(220, 32);
            this.cmb_SupID.TabIndex = 49;
            // 
            // cmb_MedID
            // 
            this.cmb_MedID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MedID.FormattingEnabled = true;
            this.cmb_MedID.Location = new System.Drawing.Point(220, 119);
            this.cmb_MedID.Name = "cmb_MedID";
            this.cmb_MedID.Size = new System.Drawing.Size(220, 32);
            this.cmb_MedID.TabIndex = 50;
            // 
            // txt_SupName
            // 
            this.txt_SupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupName.Location = new System.Drawing.Point(700, 69);
            this.txt_SupName.Name = "txt_SupName";
            this.txt_SupName.Size = new System.Drawing.Size(250, 29);
            this.txt_SupName.TabIndex = 51;
            // 
            // txt_MedName
            // 
            this.txt_MedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedName.Location = new System.Drawing.Point(700, 119);
            this.txt_MedName.Name = "txt_MedName";
            this.txt_MedName.Size = new System.Drawing.Size(250, 29);
            this.txt_MedName.TabIndex = 52;
            // 
            // dataGridView_GRNDetails
            // 
            this.dataGridView_GRNDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GRNDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_GRNDetails.Location = new System.Drawing.Point(0, 461);
            this.dataGridView_GRNDetails.Name = "dataGridView_GRNDetails";
            this.dataGridView_GRNDetails.Size = new System.Drawing.Size(984, 300);
            this.dataGridView_GRNDetails.TabIndex = 53;
            // 
            // dataGridView_GRNMaster
            // 
            this.dataGridView_GRNMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GRNMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_GRNMaster.Location = new System.Drawing.Point(0, 261);
            this.dataGridView_GRNMaster.Name = "dataGridView_GRNMaster";
            this.dataGridView_GRNMaster.Size = new System.Drawing.Size(984, 200);
            this.dataGridView_GRNMaster.TabIndex = 54;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 193);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 56;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(330, 193);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 37);
            this.btn_Search.TabIndex = 55;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(700, 193);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(110, 37);
            this.btn_Print.TabIndex = 57;
            this.btn_Print.Text = "&Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // Form_ViewGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_GRNMaster);
            this.Controls.Add(this.dataGridView_GRNDetails);
            this.Controls.Add(this.txt_MedName);
            this.Controls.Add(this.txt_SupName);
            this.Controls.Add(this.cmb_MedID);
            this.Controls.Add(this.cmb_SupID);
            this.Controls.Add(this.radioBtn_SupID);
            this.Controls.Add(this.radioBtn_MedName);
            this.Controls.Add(this.radioBtn_MedID);
            this.Controls.Add(this.radioBtn_SupName);
            this.Controls.Add(this.radioBtn_GRNID);
            this.Controls.Add(this.cmb_GRNID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ViewGRN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View & Search Good Recieve Note Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRNDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GRNMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtn_SupName;
        private System.Windows.Forms.RadioButton radioBtn_GRNID;
        private System.Windows.Forms.ComboBox cmb_GRNID;
        private System.Windows.Forms.RadioButton radioBtn_MedID;
        private System.Windows.Forms.RadioButton radioBtn_MedName;
        private System.Windows.Forms.RadioButton radioBtn_SupID;
        private System.Windows.Forms.ComboBox cmb_SupID;
        private System.Windows.Forms.ComboBox cmb_MedID;
        private System.Windows.Forms.TextBox txt_SupName;
        private System.Windows.Forms.TextBox txt_MedName;
        private System.Windows.Forms.DataGridView dataGridView_GRNDetails;
        private System.Windows.Forms.DataGridView dataGridView_GRNMaster;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Print;
    }
}