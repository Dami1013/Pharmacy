using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_AddSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_AddSupplier()
        {
            InitializeComponent();
            ShowSupplier();
        }

        private void ShowSupplier()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Supplier", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Supplier.DataSource = ds.Tables[0];

            con.Close();

        }

        public void GenerateSupplierID()
        {
            string SupID = "SUP";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(Sup_ID) FROM Supplier", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
            {
                txt_SupID.Text = SupID + 0 + z.ToString();
            }
            else
            {
                txt_SupID.Text = SupID + z.ToString();
            }
                
        }


        void Refresh()
        {
            this.Close();
            Form_AddSupplier obj = new Form_AddSupplier();
            obj.Show();
        }


        private void Form_AddSupplier_Load(object sender, EventArgs e)
        {
            GenerateSupplierID();
        }

        

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SupName.Text == "" || txt_SupAddress.Text == "" || txt_SupTelephone.Text == "" ||txt_SupEmail.Text == "")
                MessageBox.Show("Missing Informations");

            else
                try
                {
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO Supplier VALUES (@SUPID, @SUPNAME, @SUPADDRESS, @SUPTELEPHONE, @SUPEMAIL)", con);
                    cmd.Parameters.AddWithValue("SUPID", txt_SupID.Text);
                    cmd.Parameters.AddWithValue("SUPNAME", txt_SupName.Text);
                    cmd.Parameters.AddWithValue("SUPADDRESS", txt_SupAddress.Text);
                    cmd.Parameters.AddWithValue("SUPTELEPHONE", Convert.ToInt32(txt_SupTelephone.Text));
                    cmd.Parameters.AddWithValue("SUPEMAIL", txt_SupEmail.Text);

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
            txt_SupID.Clear();
            txt_SupName.Clear();
            txt_SupAddress.Clear();
            txt_SupTelephone.Clear();
            txt_SupEmail.Clear();
        }
    }
}
