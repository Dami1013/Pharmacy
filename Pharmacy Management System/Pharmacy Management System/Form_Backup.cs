using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_Backup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_Backup()
        {
            InitializeComponent();
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txt_Location.Text = dlg.SelectedPath;
                btn_Backup.Enabled = true;
            }
        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();
            cmd = new SqlCommand("BACKUP DATABASE PHARMACYDB TO DISK = 'D:\\Project\\CODSE19.1F-034\\Code 3.bak'", con); //\\" + database + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "
            cmd.ExecuteNonQuery();
            MessageBox.Show(this, "Backup completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            /*if(txt_Location.Text == string.Empty)
            {
                MessageBox.Show(this, "Please select a Backup location and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("BACKUP DATABASE PharmacyDB TO DISK = 'D:\\Project\\CODSE19.1F-034\\Code 3'.bak'", con); //\\" + database + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "
                cmd.ExecuteNonQuery();
                MessageBox.Show(this, "Backup completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                btn_Backup.Enabled = false;
            }*/
        }
    }
}
