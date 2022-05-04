using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_UpdateMedicineType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_UpdateMedicineType()
        {
            InitializeComponent();
            ShowMedicineType();
        }

        private void ShowMedicineType()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM MedicineType", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();

            da.Fill(ds);


            dataGridView_MedicineType.DataSource = ds.Tables[0];

            con.Close();

        }

        void Refresh()
        {
            this.Close();
            Form_UpdateMedicineType obj = new Form_UpdateMedicineType();
            obj.Show();
        }

        private void Form_UpdateMedicineType_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_MedicineType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_MedicineType.Rows[e.RowIndex];

                txt_MedTypeID.Text = row.Cells["MedType_ID"].Value.ToString();
                txt_MedTypeName.Text = row.Cells["MedType_Name"].Value.ToString();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("UPDATE MedicineType SET MedType_Name = @MEDTYPENAME WHERE MedType_Id = @MEDTYPEID", con);

                cmd.Parameters.AddWithValue("MEDTYPEID", txt_MedTypeID.Text);
                cmd.Parameters.AddWithValue("MEDTYPENAME", txt_MedTypeName.Text);

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
            txt_MedTypeID.Clear();
            txt_MedTypeName.Clear();
        }
    }
}
