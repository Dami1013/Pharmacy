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
    public partial class Form_AddAdmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_AddAdmin()
        {
            InitializeComponent();
            ShowAdmin();
        }

        private void ShowAdmin()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Admin", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Admin.DataSource = ds.Tables[0];

            con.Close();
        }

        public void GenerateAdminID()
        {
            string AdminID = "ADMIN";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(Admin_ID) FROM Admin", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
                txt_AdminID.Text = AdminID + 0 + z.ToString();

            else
                txt_AdminID.Text = AdminID + z.ToString();
        }


        void Refresh()
        {
            this.Close();
            Form_AddAdmin obj = new Form_AddAdmin();
            obj.Show();
        }

        private void Form_AddAdmin_Load(object sender, EventArgs e)
        {
            GenerateAdminID();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_AdminName.Text == "" || txt_AdminUsername.Text == "" || txt_AdminPassword.Text == "")
                MessageBox.Show("Missing Informations");

            else
                try
                {
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO Admin VALUES (@ADMINID, @ADMINNAME, @ADMINUSERNAME, @ADMINPASSWORD)", con);
                    cmd.Parameters.AddWithValue("ADMINID", txt_AdminID.Text);
                    cmd.Parameters.AddWithValue("ADMINNAME", txt_AdminName.Text);
                    cmd.Parameters.AddWithValue("ADMINUSERNAME", txt_AdminUsername.Text);
                    cmd.Parameters.AddWithValue("ADMINPASSWORD", txt_AdminPassword.Text);

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                        MessageBox.Show(this, "Data save Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, "Database Errors " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Errors " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            Refresh();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_AdminName.Clear();
            txt_AdminUsername.Clear();
            txt_AdminPassword.Clear();
        }
    }
}
