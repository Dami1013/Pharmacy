using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_UpdateAdmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_UpdateAdmin()
        {
            InitializeComponent();
            ShowAdmin();
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

        void Refresh()
        {
            this.Close();
            Form_AddAdmin obj = new Form_AddAdmin();
            obj.Show();
        }

        private void DataGridView_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Admin.Rows[e.RowIndex];

                txt_AdminID.Text = row.Cells["Admin_ID"].Value.ToString();
                txt_AdminName.Text = row.Cells["Admin_Name"].Value.ToString();
                txt_AdminUsername.Text = row.Cells["Admin_Username"].Value.ToString();
                txt_AdminPassword.Text = row.Cells["Admin_Password"].Value.ToString();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("UPDATE Admin SET Admin_Name = @ADMINNAME, Admin_Username = @ADMINUSERNAME, Admin_Password = @ADMINPASSWORD WHERE Admin_ID = @ADMINID", con);

                cmd.Parameters.AddWithValue("ADMINID", txt_AdminID.Text);
                cmd.Parameters.AddWithValue("ADMINNAME", txt_AdminName.Text);
                cmd.Parameters.AddWithValue("ADMINUSERNAME", txt_AdminUsername.Text);
                cmd.Parameters.AddWithValue("ADMINPASSWORD", txt_AdminPassword.Text);

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
            txt_AdminName.Clear();
            txt_AdminUsername.Clear();
            txt_AdminPassword.Clear();
        }
    }
}
