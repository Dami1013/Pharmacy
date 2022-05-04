using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_ViewSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewSupplier()
        {
            InitializeComponent();
            ShowEmployee();
            fillComboBox();
        }
        private void ShowEmployee()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Supplier", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Supplier.DataSource = ds.Tables[0];

            con.Close();
        }

        private void fillComboBox()
        {


            con.Open();
            cmd = new SqlCommand("SELECT Sup_ID FROM Supplier", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_SupID.DataSource = dt;
            cmb_SupID.DisplayMember = "Sup_ID";
            cmb_SupID.ValueMember = "Sup_ID";

            con.Close();

            cmb_SupID.SelectedIndex = -1;
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtn_SupID.Checked == false && radioBtn_SupName.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_SupID.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Supplier WHERE Sup_ID = '" + cmb_SupID.SelectedValue.ToString() + "' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Supplier.DataSource = dt;
                    con.Close();
                }
                else if (radioBtn_SupName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Supplier WHERE Sup_Name LIKE '" + txt_SupName.Text + "%' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Supplier.DataSource = dt;
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
            cmb_SupID.SelectedIndex = -1;
            txt_SupName.Clear();
        }
    }
}
