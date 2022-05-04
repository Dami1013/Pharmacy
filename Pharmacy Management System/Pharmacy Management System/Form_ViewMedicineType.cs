using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_ViewMedicineType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewMedicineType()
        {
            InitializeComponent();
            ShowEmployee();
            fillComboBox();
        }

        private void ShowEmployee()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM MedicineType", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_MedType.DataSource = ds.Tables[0];

            con.Close();
        }

        private void fillComboBox()
        {


            con.Open();
            cmd = new SqlCommand("SELECT MedType_ID FROM MedicineType", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_MedTypeID.DataSource = dt;
            cmb_MedTypeID.DisplayMember = "MedType_Id";
            cmb_MedTypeID.ValueMember = "MedType_Id";

            con.Close();

            cmb_MedTypeID.SelectedIndex = -1;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtn_MedTypeID.Checked == false && radioBtn_MedType.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_MedTypeID.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM MedicineType WHERE MedType_ID = '" + cmb_MedTypeID.SelectedValue.ToString() + "' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_MedType.DataSource = dt;
                    con.Close();
                }
                else if (radioBtn_MedType.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM MedicineType WHERE MedType_Name LIKE '" + txt_MedType.Text + "%' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_MedType.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_MedTypeID.SelectedIndex = -1;
            txt_MedType.Clear();
        }
    }
}
