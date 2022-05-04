namespace Pharmacy_Management_System
{
    partial class Form_Employee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee));
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Order_Details = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.goodRecievedNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_sales_256;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.orderToolStripMenuItem.Text = "&Order";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_add_database_150;
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addOrderToolStripMenuItem.Text = "&Add Order";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupRestoreToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.logoutToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_maintenance_90;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.logoutToolStripMenuItem.Text = "&Tools";
            // 
            // backupRestoreToolStripMenuItem
            // 
            this.backupRestoreToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_data_backup_1001;
            this.backupRestoreToolStripMenuItem.Name = "backupRestoreToolStripMenuItem";
            this.backupRestoreToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.backupRestoreToolStripMenuItem.Text = "&Backup";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_logout_234;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.logoutToolStripMenuItem1.Text = "&Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.LogoutToolStripMenuItem1_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Maroon;
            this.btn_Logout.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1209, 649);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(225, 50);
            this.btn_Logout.TabIndex = 20;
            this.btn_Logout.Text = "Lo&gout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // btn_Order_Details
            // 
            this.btn_Order_Details.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Order_Details.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order_Details.Location = new System.Drawing.Point(25, 650);
            this.btn_Order_Details.Name = "btn_Order_Details";
            this.btn_Order_Details.Size = new System.Drawing.Size(225, 50);
            this.btn_Order_Details.TabIndex = 19;
            this.btn_Order_Details.Text = "Add O&rder";
            this.btn_Order_Details.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(625, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "&Backup";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.goodRecievedNoteToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_move_stock_96;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.stockToolStripMenuItem.Text = "S&tock";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_shopping_cart_90;
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(177, 23);
            this.purchaseToolStripMenuItem.Text = "&Purchase Order Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1209, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 66);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // goodRecievedNoteToolStripMenuItem
            // 
            this.goodRecievedNoteToolStripMenuItem.Image = global::Pharmacy_Management_System.Properties.Resources.icons8_note_150;
            this.goodRecievedNoteToolStripMenuItem.Name = "goodRecievedNoteToolStripMenuItem";
            this.goodRecievedNoteToolStripMenuItem.Size = new System.Drawing.Size(162, 23);
            this.goodRecievedNoteToolStripMenuItem.Text = "&Good Recieved Note";
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.Wallpaper;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Order_Details);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Management System 3.0";
            this.Load += new System.EventHandler(this.Form_Employee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Order_Details;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem goodRecievedNoteToolStripMenuItem;
    }
}