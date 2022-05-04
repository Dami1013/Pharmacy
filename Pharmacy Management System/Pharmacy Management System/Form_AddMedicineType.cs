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
    public partial class Form_AddMedicineType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_AddMedicineType()
        {
            InitializeComponent();
            ShowMedicineType();
        }

        private void Form_AddMedicineType_Load(object sender, EventArgs e)
        {
            GenerateMedicineTypeID();
        }

        private void ShowMedicineType()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM MedicineType", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_MedicineType.DataSource = ds.Tables[0];

            con.Close();
        }

        public void GenerateMedicineTypeID()
        {
            string MedTID = "MEDT";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(MedType_ID) FROM MedicineType", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
            {
                txt_MedTypeID.Text = MedTID + 0 + z.ToString();
            }
            else
            {
                txt_MedTypeID.Text = MedTID + z.ToString();
            }
        }

        void Refresh()
        {
            this.Close();
            Form_AddMedicineType obj = new Form_AddMedicineType();
            obj.Show();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MedTypeName.Text == "")
                MessageBox.Show("Missing Informations");

            else
                try
                {
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO MedicineType VALUES (@MEDTYPEID, @MEDTYPENAME)", con);
                    cmd.Parameters.AddWithValue("MEDTYPEID", txt_MedTypeID.Text);
                    cmd.Parameters.AddWithValue("MEDTYPENAME", txt_MedTypeName.Text);

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
    }
}
