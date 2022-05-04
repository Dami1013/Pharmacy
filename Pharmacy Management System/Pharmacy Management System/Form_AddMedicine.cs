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
using System.Configuration;

namespace Pharmacy_Management_System
{
    public partial class Form_AddMedicine : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_AddMedicine()
        {
            InitializeComponent();
            ShowMedicine();
            fillComboBox();
        }

        private void Form_AddMedicine_Load(object sender, EventArgs e)
        {
            GenerateMedicineID();
        }

        private void ShowMedicine()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Medicine", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Medicine.DataSource = ds.Tables[0];

            con.Close();
        }

        void Refresh()
        {
            this.Close();
            Form_AddMedicine obj = new Form_AddMedicine();
            obj.Show();
        }

        //Unique ID 
        public void GenerateMedicineID()
        {
            string MedID = "MED";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(Med_ID) FROM Medicine", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
                txt_MedID.Text = MedID + 0 + z.ToString();

            else
                txt_MedID.Text = MedID + z.ToString();
        }

        private void  fillComboBox()
        {
            con.Open();

            cmd = new SqlCommand("SELECT MedType_Name FROM MedicineType", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dt = new DataTable();
            da.Fill(dt);

            cmb_MedType.DataSource = dt;
            cmb_MedType.DisplayMember = "MedType_Name";
            cmb_MedType.ValueMember = "MedType_Name";

            con.Close();

            cmb_MedType.SelectedIndex = -1;
        }
    
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MedName.Text == "" || txt_MedUnitPrice.Text == "" || cmb_MedType.SelectedIndex == -1)
                MessageBox.Show("Missing Informations");

            else
                try
                {
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO Medicine VALUES (@MEDID, @MEDNAME, @MEDTYPE, @MEDUNITPRICE)", con);
                    cmd.Parameters.AddWithValue("MEDID", txt_MedID.Text);
                    cmd.Parameters.AddWithValue("MEDNAME", txt_MedName.Text);
                    cmd.Parameters.AddWithValue("MEDTYPE", cmb_MedType.SelectedValue.ToString());//Combo Box changes
                    cmd.Parameters.AddWithValue("MEDUNITPRICE", Convert.ToDecimal(txt_MedUnitPrice.Text));

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
            txt_MedID.Clear();
            txt_MedName.Clear();
            cmb_MedType.SelectedIndex = -1;
            txt_MedUnitPrice.Clear();
        }


    }
}
