namespace Pharmacy_Management_System
{
    partial class Form_UpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UpdateEmployee));
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lable14 = new System.Windows.Forms.Label();
            this.txt_EmpUsername = new System.Windows.Forms.TextBox();
            this.lable13 = new System.Windows.Forms.Label();
            this.txt_EmpNIC = new System.Windows.Forms.TextBox();
            this.txt_EmpAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_DOB = new System.Windows.Forms.DateTimePicker();
            this.lable12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_EmpGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lable11 = new System.Windows.Forms.Label();
            this.txt_EmpPassword = new System.Windows.Forms.TextBox();
            this.txt_EmpAddress = new System.Windows.Forms.TextBox();
            this.txt_EmpTelephone = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.lable10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.AllowUserToDeleteRows = false;
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Employee.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.ReadOnly = true;
            this.dataGridView_Employee.Size = new System.Drawing.Size(984, 325);
            this.dataGridView_Employee.TabIndex = 0;
            this.dataGridView_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Employee_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Employee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 325);
            this.panel1.TabIndex = 35;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(504, 270);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 34;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(365, 270);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 37);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // lable14
            // 
            this.lable14.AutoSize = true;
            this.lable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable14.Location = new System.Drawing.Point(500, 220);
            this.lable14.Name = "lable14";
            this.lable14.Size = new System.Drawing.Size(100, 24);
            this.lable14.TabIndex = 34;
            this.lable14.Text = "Password";
            // 
            // txt_EmpUsername
            // 
            this.txt_EmpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpUsername.Location = new System.Drawing.Point(225, 217);
            this.txt_EmpUsername.Name = "txt_EmpUsername";
            this.txt_EmpUsername.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpUsername.TabIndex = 33;
            // 
            // lable13
            // 
            this.lable13.AutoSize = true;
            this.lable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable13.Location = new System.Drawing.Point(25, 220);
            this.lable13.Name = "lable13";
            this.lable13.Size = new System.Drawing.Size(105, 24);
            this.lable13.TabIndex = 32;
            this.lable13.Text = "Username";
            // 
            // txt_EmpNIC
            // 
            this.txt_EmpNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpNIC.Location = new System.Drawing.Point(700, 167);
            this.txt_EmpNIC.Name = "txt_EmpNIC";
            this.txt_EmpNIC.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpNIC.TabIndex = 31;
            // 
            // txt_EmpAge
            // 
            this.txt_EmpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAge.Location = new System.Drawing.Point(225, 167);
            this.txt_EmpAge.Name = "txt_EmpAge";
            this.txt_EmpAge.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpAge.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date of Birth";
            // 
            // date_DOB
            // 
            this.date_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOB.Location = new System.Drawing.Point(700, 122);
            this.date_DOB.Name = "date_DOB";
            this.date_DOB.Size = new System.Drawing.Size(250, 20);
            this.date_DOB.TabIndex = 28;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.Location = new System.Drawing.Point(25, 120);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(80, 24);
            this.lable12.TabIndex = 27;
            this.lable12.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "NIC";
            // 
            // cmb_EmpGender
            // 
            this.cmb_EmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EmpGender.FormattingEnabled = true;
            this.cmb_EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_EmpGender.Location = new System.Drawing.Point(225, 117);
            this.cmb_EmpGender.Name = "cmb_EmpGender";
            this.cmb_EmpGender.Size = new System.Drawing.Size(248, 32);
            this.cmb_EmpGender.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Age";
            // 
            // lable11
            // 
            this.lable11.AutoSize = true;
            this.lable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable11.Location = new System.Drawing.Point(500, 70);
            this.lable11.Name = "lable11";
            this.lable11.Size = new System.Drawing.Size(151, 24);
            this.lable11.TabIndex = 23;
            this.lable11.Text = "Telephone No.";
            // 
            // txt_EmpPassword
            // 
            this.txt_EmpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpPassword.Location = new System.Drawing.Point(700, 217);
            this.txt_EmpPassword.Name = "txt_EmpPassword";
            this.txt_EmpPassword.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpPassword.TabIndex = 22;
            // 
            // txt_EmpAddress
            // 
            this.txt_EmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAddress.Location = new System.Drawing.Point(225, 67);
            this.txt_EmpAddress.Name = "txt_EmpAddress";
            this.txt_EmpAddress.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpAddress.TabIndex = 20;
            // 
            // txt_EmpTelephone
            // 
            this.txt_EmpTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpTelephone.Location = new System.Drawing.Point(700, 67);
            this.txt_EmpTelephone.Name = "txt_EmpTelephone";
            this.txt_EmpTelephone.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpTelephone.TabIndex = 19;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpName.Location = new System.Drawing.Point(700, 17);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpName.TabIndex = 16;
            // 
            // lable10
            // 
            this.lable10.AutoSize = true;
            this.lable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable10.Location = new System.Drawing.Point(25, 70);
            this.lable10.Name = "lable10";
            this.lable10.Size = new System.Drawing.Size(87, 24);
            this.lable10.TabIndex = 18;
            this.lable10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee ID";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpID.Location = new System.Drawing.Point(225, 17);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.ReadOnly = true;
            this.txt_EmpID.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpID.TabIndex = 36;
            // 
            // Form_UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.lable14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_EmpUsername);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lable13);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_EmpNIC);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.txt_EmpAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_DOB);
            this.Controls.Add(this.lable10);
            this.Controls.Add(this.lable12);
            this.Controls.Add(this.txt_EmpTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EmpAddress);
            this.Controls.Add(this.cmb_EmpGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_EmpPassword);
            this.Controls.Add(this.lable11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lable14;
        private System.Windows.Forms.TextBox txt_EmpUsername;
        private System.Windows.Forms.Label lable13;
        private System.Windows.Forms.TextBox txt_EmpNIC;
        private System.Windows.Forms.TextBox txt_EmpAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_DOB;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EmpGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable11;
        private System.Windows.Forms.TextBox txt_EmpPassword;
        private System.Windows.Forms.TextBox txt_EmpAddress;
        private System.Windows.Forms.TextBox txt_EmpTelephone;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EmpID;
    }
}