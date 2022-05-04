namespace Pharmacy_Management_System
{
    partial class Form_AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.lable10 = new System.Windows.Forms.Label();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_EmpAddress = new System.Windows.Forms.TextBox();
            this.lable11 = new System.Windows.Forms.Label();
            this.txt_EmpPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_EmpGender = new System.Windows.Forms.ComboBox();
            this.lable12 = new System.Windows.Forms.Label();
            this.date_DOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EmpAge = new System.Windows.Forms.TextBox();
            this.lable13 = new System.Windows.Forms.Label();
            this.lable14 = new System.Windows.Forms.Label();
            this.txt_EmpUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_EmpTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EmpNIC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // lable10
            // 
            this.lable10.AutoSize = true;
            this.lable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable10.Location = new System.Drawing.Point(20, 70);
            this.lable10.Name = "lable10";
            this.lable10.Size = new System.Drawing.Size(87, 24);
            this.lable10.TabIndex = 2;
            this.lable10.Text = "Address";
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpName.Location = new System.Drawing.Point(700, 17);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpName.TabIndex = 0;
            // 
            // txt_EmpAddress
            // 
            this.txt_EmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAddress.Location = new System.Drawing.Point(220, 67);
            this.txt_EmpAddress.Name = "txt_EmpAddress";
            this.txt_EmpAddress.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpAddress.TabIndex = 4;
            // 
            // lable11
            // 
            this.lable11.AutoSize = true;
            this.lable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable11.Location = new System.Drawing.Point(500, 70);
            this.lable11.Name = "lable11";
            this.lable11.Size = new System.Drawing.Size(151, 24);
            this.lable11.TabIndex = 5;
            this.lable11.Text = "Telephone No.";
            // 
            // txt_EmpPassword
            // 
            this.txt_EmpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpPassword.Location = new System.Drawing.Point(700, 217);
            this.txt_EmpPassword.Name = "txt_EmpPassword";
            this.txt_EmpPassword.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // cmb_EmpGender
            // 
            this.cmb_EmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_EmpGender.FormattingEnabled = true;
            this.cmb_EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_EmpGender.Location = new System.Drawing.Point(220, 117);
            this.cmb_EmpGender.Name = "cmb_EmpGender";
            this.cmb_EmpGender.Size = new System.Drawing.Size(248, 32);
            this.cmb_EmpGender.TabIndex = 7;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.Location = new System.Drawing.Point(20, 120);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(80, 24);
            this.lable12.TabIndex = 8;
            this.lable12.Text = "Gender";
            // 
            // date_DOB
            // 
            this.date_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_DOB.Location = new System.Drawing.Point(700, 122);
            this.date_DOB.Name = "date_DOB";
            this.date_DOB.Size = new System.Drawing.Size(250, 20);
            this.date_DOB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // txt_EmpAge
            // 
            this.txt_EmpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpAge.Location = new System.Drawing.Point(220, 167);
            this.txt_EmpAge.Name = "txt_EmpAge";
            this.txt_EmpAge.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpAge.TabIndex = 11;
            // 
            // lable13
            // 
            this.lable13.AutoSize = true;
            this.lable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable13.Location = new System.Drawing.Point(20, 220);
            this.lable13.Name = "lable13";
            this.lable13.Size = new System.Drawing.Size(105, 24);
            this.lable13.TabIndex = 12;
            this.lable13.Text = "Username";
            // 
            // lable14
            // 
            this.lable14.AutoSize = true;
            this.lable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable14.Location = new System.Drawing.Point(500, 220);
            this.lable14.Name = "lable14";
            this.lable14.Size = new System.Drawing.Size(100, 24);
            this.lable14.TabIndex = 14;
            this.lable14.Text = "Password";
            // 
            // txt_EmpUsername
            // 
            this.txt_EmpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpUsername.Location = new System.Drawing.Point(220, 217);
            this.txt_EmpUsername.Name = "txt_EmpUsername";
            this.txt_EmpUsername.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpUsername.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(500, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Employee Name";
            // 
            // txt_EmpTelephone
            // 
            this.txt_EmpTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpTelephone.Location = new System.Drawing.Point(700, 67);
            this.txt_EmpTelephone.Name = "txt_EmpTelephone";
            this.txt_EmpTelephone.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpTelephone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIC";
            // 
            // txt_EmpNIC
            // 
            this.txt_EmpNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpNIC.Location = new System.Drawing.Point(700, 167);
            this.txt_EmpNIC.Name = "txt_EmpNIC";
            this.txt_EmpNIC.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpNIC.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Employee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 325);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.AllowUserToDeleteRows = false;
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Employee.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Employee.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.ReadOnly = true;
            this.dataGridView_Employee.Size = new System.Drawing.Size(984, 325);
            this.dataGridView_Employee.TabIndex = 0;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpID.Location = new System.Drawing.Point(220, 17);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.ReadOnly = true;
            this.txt_EmpID.Size = new System.Drawing.Size(250, 29);
            this.txt_EmpID.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(365, 270);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 37);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(504, 270);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 37);
            this.btn_Clear.TabIndex = 35;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form_AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lable14);
            this.Controls.Add(this.txt_EmpUsername);
            this.Controls.Add(this.lable13);
            this.Controls.Add(this.txt_EmpNIC);
            this.Controls.Add(this.txt_EmpAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_DOB);
            this.Controls.Add(this.lable12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_EmpGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable11);
            this.Controls.Add(this.txt_EmpPassword);
            this.Controls.Add(this.txt_EmpID);
            this.Controls.Add(this.txt_EmpAddress);
            this.Controls.Add(this.txt_EmpTelephone);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.lable10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Details";
            this.Load += new System.EventHandler(this.Form_AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_EmpAddress;
        private System.Windows.Forms.Label lable11;
        private System.Windows.Forms.TextBox txt_EmpPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_EmpGender;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.DateTimePicker date_DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EmpAge;
        private System.Windows.Forms.Label lable13;
        private System.Windows.Forms.Label lable14;
        private System.Windows.Forms.TextBox txt_EmpUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_EmpTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EmpNIC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
    }
}