using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_ViewEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewEmployee()
        {
            InitializeComponent();
            ShowEmployee();
            fillComboBox();
        }

        private void ShowEmployee()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Employee", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_Employee.DataSource = ds.Tables[0];

            con.Close();
        }

        private void fillComboBox()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Emp_ID FROM Employee", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_EmpID.DataSource = dt;
            cmb_EmpID.DisplayMember = "Emp_ID";
            cmb_EmpID.ValueMember = "Emp_ID";

            con.Close();

            cmb_EmpID.SelectedIndex = -1;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioBtn_EmpID.Checked == false && radioBtn_EmpName.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_EmpID.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Employee WHERE Emp_ID = '" + cmb_EmpID.SelectedValue.ToString() + "' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Employee.DataSource = dt;
                    con.Close();
                }
                else if(radioBtn_EmpName.Checked == true)
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Employee WHERE Emp_Name LIKE '" + txt_EmpName.Text + "%' ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_Employee.DataSource = dt;
                    con.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_EmpID.SelectedIndex = -1;
            txt_EmpName.Clear();
        }
    }
}
