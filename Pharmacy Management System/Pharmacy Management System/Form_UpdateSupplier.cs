using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_UpdateSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_UpdateSupplier()
        {
            InitializeComponent();
            ShowSupplier();
        }

        private void ShowSupplier()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Supplier", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();

            da.Fill(ds);


            dataGridView_Supplier.DataSource = ds.Tables[0];

            con.Close();

        }

        void Refresh()
        {
            this.Close();
            Form_UpdateSupplier obj = new Form_UpdateSupplier();
            obj.Show();
        }

        private void Form_UpdateSupplier_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_Supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Supplier.Rows[e.RowIndex];

                txt_SupID.Text = row.Cells["Sup_Id"].Value.ToString();
                txt_SupName.Text = row.Cells["Sup_Name"].Value.ToString();
                txt_SupAddress.Text = row.Cells["Sup_Address"].Value.ToString();
                txt_SupTelephone.Text = row.Cells["Sup_Telephone"].Value.ToString();
                txt_SupEmail.Text = row.Cells["Sup_Email"].Value.ToString();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("UPDATE Supplier SET Sup_Name = @SUPNAME, Sup_Address = @SUPADDRESS, Sup_Telephone = @SUPTELEPHONE, Sup_Email = @SUPEMAIL WHERE Sup_Id = @SUPID", con);

                cmd.Parameters.AddWithValue("SUPID", txt_SupID.Text);
                cmd.Parameters.AddWithValue("SUPNAME", txt_SupName.Text);
                cmd.Parameters.AddWithValue("SUPADDRESS", txt_SupAddress.Text);
                cmd.Parameters.AddWithValue("SUPTELEPHONE", Convert.ToInt32(txt_SupTelephone.Text));
                cmd.Parameters.AddWithValue("SUPEMAIL", txt_SupEmail.Text);


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
            txt_SupID.Clear();
            txt_SupName.Clear();
            txt_SupAddress.Clear();
            txt_SupTelephone.Clear();
            txt_SupEmail.Clear();
        }

        
    }
}
