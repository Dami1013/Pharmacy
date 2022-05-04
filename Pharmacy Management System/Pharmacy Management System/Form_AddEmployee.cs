using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy_Management_System
{
    public partial class Form_AddEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_AddEmployee()
        {
            InitializeComponent();
            ShowEmployee(); //Data View on Grid
        }

        private void Form_AddEmployee_Load(object sender, EventArgs e)
        {
            GenerateEmployeeID(); //Unique ID Generation 
        }

        //Unique ID Generation
        public void GenerateEmployeeID()
        {
            string EmpID= "EMP";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(Emp_ID) FROM Employee", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
                txt_EmpID.Text = EmpID + 0 + z.ToString();

            else
                txt_EmpID.Text = EmpID + z.ToString();
        }

        void Refresh()
        {
            this.Close();
            Form_AddEmployee obj = new Form_AddEmployee();
            obj.Show();
        }

        //Data View on Grid
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_EmpName.Text == "" || txt_EmpAddress.Text == "" || txt_EmpTelephone.Text == "" || cmb_EmpGender.SelectedIndex == -1 || date_DOB.Checked == false || txt_EmpAge.Text == "" || txt_EmpNIC.Text == "" || txt_EmpUsername.Text == "" || txt_EmpPassword.Text == "")
                MessageBox.Show(this, "Missing Informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                try
                {
                    con.Open();

                    cmd = new SqlCommand("INSERT INTO Employee VALUES (@EMPID, @EMPNAME, @EMPADDRESS, @EMPTELEPHONE, @EMPGENDER, @EMPDOB, @EMPAGE, @EMPNIC, @EMPUSERNAME, @EMPPASSWORD)", con);
                    cmd.Parameters.AddWithValue("EMPID", txt_EmpID.Text);
                    cmd.Parameters.AddWithValue("EMPNAME", txt_EmpName.Text);
                    cmd.Parameters.AddWithValue("EMPADDRESS", txt_EmpAddress.Text);
                    cmd.Parameters.AddWithValue("EMPTELEPHONE", Convert.ToInt32(txt_EmpTelephone.Text));
                    cmd.Parameters.AddWithValue("EMPGENDER", cmb_EmpGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("EMPDOB", date_DOB.Value);
                    cmd.Parameters.AddWithValue("EMPAGE", Convert.ToInt32(txt_EmpAge.Text));
                    cmd.Parameters.AddWithValue("EMPNIC", txt_EmpNIC.Text);
                    cmd.Parameters.AddWithValue("EMPUSERNAME", txt_EmpUsername.Text);
                    cmd.Parameters.AddWithValue("EMPPASSWORD", txt_EmpPassword.Text);

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
            txt_EmpName.Clear();
            txt_EmpAddress.Clear();
            txt_EmpTelephone.Clear();
            cmb_EmpGender.SelectedIndex = -1;
            date_DOB.Value = DateTime.Now;
            txt_EmpAge.Clear();
            txt_EmpNIC.Clear();
            txt_EmpUsername.Clear();
            txt_EmpPassword.Clear();

        }
    }
}
