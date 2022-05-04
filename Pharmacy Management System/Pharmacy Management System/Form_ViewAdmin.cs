using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy_Management_System
{
    public partial class Form_ViewAdmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewAdmin()
        {
            InitializeComponent();
            ShowAdmin();
            fillComboBox();
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

        private void fillComboBox()
        {


            con.Open();
            cmd = new SqlCommand("SELECT Admin_ID FROM Admin", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_AdminID.DataSource = dt;
            cmb_AdminID.DisplayMember = "Admin_ID";
            cmb_AdminID.ValueMember = "Admin_ID";

            con.Close();

            cmb_AdminID.SelectedIndex = -1;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtn_AdminID.Checked == false && radioBtn_AdminName.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_AdminID.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Admin WHERE Admin_ID = '" + cmb_AdminID.SelectedValue.ToString() + "' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Admin.DataSource = dt;
                    con.Close();
                }
                else if (radioBtn_AdminName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Admin WHERE Admin_Name LIKE '" + txt_AdminName.Text + "%' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Admin.DataSource = dt;
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
            cmb_AdminID.SelectedIndex = -1;
            txt_AdminName.Clear();
        }
    }
}
