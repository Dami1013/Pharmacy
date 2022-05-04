using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy_Management_System
{
    public partial class Form_UpdateMedicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_UpdateMedicine()
        {
            InitializeComponent();
            ShowMedicine();
            fillComboBox();
        }

        private void ShowMedicine()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM Medicine", con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();

            da.Fill(ds);


            dataGridView_Medicine.DataSource = ds.Tables[0];

            con.Close();
        }

        private void fillComboBox()
        {


            con.Open();
            cmd = new SqlCommand("SELECT MedType_Name FROM MedicineType", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_MedType.DataSource = dt;
            cmb_MedType.DisplayMember = "MedType_Name";
            cmb_MedType.ValueMember = "MedType_Name";

            con.Close();

            cmb_MedType.SelectedIndex = -1;
        }

        void Refresh()
        {
            this.Close();
            Form_UpdateMedicine obj = new Form_UpdateMedicine();
            obj.Show();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_Medicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_Medicine.Rows[e.RowIndex];

                txt_MedID.Text = row.Cells["Med_ID"].Value.ToString();
                txt_MedName.Text = row.Cells["Med_Name"].Value.ToString();
                cmb_MedType.Text = row.Cells["Med_Type"].Value.ToString();
                txt_MedUnitPrice.Text = row.Cells["Med_UnitPrice"].Value.ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Close();


            if (MessageBox.Show("Are you sure you want to update this data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("UPDATE Medicine SET Med_Name = @MEDNAME, Med_Type = @MEDTYPE, Med_UnitPrice = @MEDUNITPRICE WHERE Med_Id = @MEDID", con);

                cmd.Parameters.AddWithValue("MEDID", txt_MedID.Text);
                cmd.Parameters.AddWithValue("MEDNAME", txt_MedName.Text);
                cmd.Parameters.AddWithValue("MEDTYPE", cmb_MedType.SelectedValue.ToString());//Combo Box changes
                cmd.Parameters.AddWithValue("MEDUNITPRICE", Convert.ToDecimal(txt_MedUnitPrice.Text));


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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MedID.Clear();
            txt_MedName.Clear();
            cmb_MedType.SelectedIndex = -1;
            txt_MedUnitPrice.Clear();
        }
    }
}
