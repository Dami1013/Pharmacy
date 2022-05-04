using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form_Admin : System.Windows.Forms.Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        private void Form_Admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void AddAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddAdmin obj = new Form_AddAdmin();
            obj.Show();
        }

        private void UpdateAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateAdmin obj = new Form_UpdateAdmin();
            obj.Show();
        }

        private void ViewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewAdmin obj = new Form_ViewAdmin();
            obj.Show();
        }

        private void DeleteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DeleteAdmin obj = new Form_DeleteAdmin();
            obj.Show();
        }
        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddEmployee obj = new Form_AddEmployee();
            obj.Show();
        }

        private void UpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateEmployee obj = new Form_UpdateEmployee();
            obj.Show();
        }
        
        private void ViewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewEmployee obj = new Form_ViewEmployee();
            obj.Show();
        }

        private void DeleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DeleteEmployee obj = new Form_DeleteEmployee();
            obj.Show();
        }

        private void AddSupplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddSupplier obj = new Form_AddSupplier();
            obj.Show();
        }

        private void UpdateSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateSupplier obj = new Form_UpdateSupplier();
            obj.Show();
        }

        private void ViewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewSupplier obj = new Form_ViewSupplier();
            obj.Show();
        }

        private void DeleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DeleteSupplier obj = new Form_DeleteSupplier();
            obj.Show();
        }
    
        private void AddMedicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddMedicineType obj = new Form_AddMedicineType();
            obj.Show();
        }

        private void UpdateMedicineTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_UpdateMedicineType obj = new Form_UpdateMedicineType();
            obj.Show();
        }

        private void ViewMedicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewMedicineType obj = new Form_ViewMedicineType();
            obj.Show();
        }

        private void DeleteMedicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DeleteMedicineType obj = new Form_DeleteMedicineType();
            obj.Show();
        }
        private void AddMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddMedicine obj = new Form_AddMedicine();
            obj.Show();
        }

        private void UpdateMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateMedicine obj = new Form_UpdateMedicine();
            obj.Show();
        }

        private void VeiwMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewMedicine obj = new Form_ViewMedicine();
            obj.Show();
        }

        private void DeleteMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DeleteMedicine obj = new Form_DeleteMedicine();
            obj.Show();
        }

        private void AddGoodReceiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddGRN obj = new Form_AddGRN();
            obj.Show();
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Order obj = new Form_Order();
            obj.Show();
        }

        private void LogoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Login obj = new Form_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Form_Login obj = new Form_Login();
            obj.Show();
            this.Hide();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Backup obj = new Form_Backup();
            obj.Show();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            Form_Backup obj = new Form_Backup();
            obj.Show();
        }

        private void AddPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddPurOrder obj = new Form_AddPurOrder();
            obj.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdatreGoodReceiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateGRN obj = new Form_UpdateGRN();
            obj.Show();
        }

        private void ViewGoodReceiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ViewGRN obj = new Form_ViewGRN();
            obj.Show();
        }
    }
}
