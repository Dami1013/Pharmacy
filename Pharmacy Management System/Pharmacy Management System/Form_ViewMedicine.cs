using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_ViewMedicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewMedicine()
        {
            InitializeComponent();
            ShowEmployee();
            fillComboBox();
        }

        private void fillComboBox()
        {


            con.Open();
            cmd = new SqlCommand("SELECT Med_ID FROM Medicine", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_MedID.DataSource = dt;
            cmb_MedID.DisplayMember = "Med_ID";
            cmb_MedID.ValueMember = "Med_ID";

            con.Close();

            cmb_MedID.SelectedIndex = -1;
        }
        private void ShowEmployee()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Medicine", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Medicine.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtn_MedID.Checked == false && radioBtn_MedName.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_MedID.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Medicine WHERE Med_ID = '" + cmb_MedID.SelectedValue.ToString() + "' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Medicine.DataSource = dt;
                    con.Close();
                }
                else if (radioBtn_MedName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Medicine WHERE Med_Name LIKE '" + txt_MedName.Text + "%' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Medicine.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmb_MedID.SelectedIndex = -1;
            txt_MedName.Clear();
        }
    }
}
