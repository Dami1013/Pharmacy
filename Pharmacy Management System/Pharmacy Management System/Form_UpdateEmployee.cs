using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_UpdateEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_UpdateEmployee()
        {
            InitializeComponent();
            ShowEmployee();
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

        void Refresh()
        {
            this.Close();
            Form_UpdateEmployee obj = new Form_UpdateEmployee();
            obj.Show();
        }


        private void DataGridView_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Employee.Rows[e.RowIndex];

                txt_EmpID.Text = row.Cells["Emp_ID"].Value.ToString();
                txt_EmpName.Text = row.Cells["Emp_Name"].Value.ToString();
                txt_EmpAddress.Text = row.Cells["Emp_Address"].Value.ToString();
                txt_EmpTelephone.Text = row.Cells["Emp_Telephone"].Value.ToString();
                cmb_EmpGender.Text = row.Cells["Emp_Gender"].Value.ToString();
                date_DOB.Text = row.Cells["Emp_DOB"].Value.ToString();
                txt_EmpAge.Text = row.Cells["Emp_Age"].Value.ToString();
                txt_EmpNIC.Text = row.Cells["Emp_NIC"].Value.ToString();
                txt_EmpUsername.Text = row.Cells["Emp_Username"].Value.ToString();
                txt_EmpPassword.Text = row.Cells["Emp_Password"].Value.ToString();
            }     
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("UPDATE Employee SET Emp_Name = @EMPNAME, Emp_Address = @EMPADDRESS, Emp_Telephone = @EMPTELEPHONE, Emp_Gender = @EMPGENDER, Emp_DOB = @EMPDOB, Emp_Age = @EMPAGE, Emp_NIC = @EMPNIC, Emp_Username = @EMPUSERNAME, Emp_Password = @EMPPASSWORD WHERE Emp_ID = @EMPID", con);

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

                try
                {

                    if (i == 1)
                        MessageBox.Show(this, "Data updated successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data can't be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, "Database error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Error : " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            else
            {
                MessageBox.Show(this, "Data is not updated", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
