namespace Pharmacy_Management_System
{
    partial class Form_UpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateAdmin));
            this.dataGridView_Admin = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AdminUsername = new System.Windows.Forms.TextBox();
            this.txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.txt_AdminName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Admin
            // 
            this.dataGridView_Admin.AllowUserToDeleteRows = false;
            this.dataGridView_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Admin.Name = "dataGridView_Admin";
            this.dataGridView_Admin.ReadOnly = true;
            this.dataGridView_Admin.Size = new System.Drawing.Size(984, 475);
            this.dataGridView_Admin.TabIndex = 0;
            this.dataGridView_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Admin_CellContentClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(504, 120);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 70;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-113, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "E-mail";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 475);
            this.panel1.TabIndex = 68;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(360, 120);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 37);
            this.btn_Update.TabIndex = 67;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Password";
            // 
            // txt_AdminUsername
            // 
            this.txt_AdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminUsername.Location = new System.Drawing.Point(220, 67);
            this.txt_AdminUsername.Name = "txt_AdminUsername";
            this.txt_AdminUsername.Size = new System.Drawing.Size(250, 29);
            this.txt_AdminUsername.TabIndex = 65;
            // 
            // txt_AdminPassword
            // 
            this.txt_AdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword.Location = new System.Drawing.Point(700, 67);
            this.txt_AdminPassword.Name = "txt_AdminPassword";
            this.txt_AdminPassword.Size = new System.Drawing.Size(250, 29);
            this.txt_AdminPassword.TabIndex = 64;
            // 
            // txt_AdminName
            // 
            this.txt_AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminName.Location = new System.Drawing.Point(700, 17);
            this.txt_AdminName.Name = "txt_AdminName";
            this.txt_AdminName.Size = new System.Drawing.Size(250, 29);
            this.txt_AdminName.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Username";
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminID.Location = new System.Drawing.Point(220, 17);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.ReadOnly = true;
            this.txt_AdminID.Size = new System.Drawing.Size(250, 29);
            this.txt_AdminID.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Admin Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Admin ID";
            // 
            // Form_UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AdminUsername);
            this.Controls.Add(this.txt_AdminPassword);
            this.Controls.Add(this.txt_AdminName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AdminID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_UpdateAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Admin Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Admin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Admin;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AdminUsername;
        private System.Windows.Forms.TextBox txt_AdminPassword;
        private System.Windows.Forms.TextBox txt_AdminName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}