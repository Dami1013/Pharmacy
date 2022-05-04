using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_DeleteMedicineType : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_DeleteMedicineType()
        {
            InitializeComponent();
            ShowMedType();
            fillComboBox();
        }

        private void ShowMedType()
        {
            con.Open();

            da = new SqlDataAdapter("SELECT * FROM MedicineType", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView_MedType.DataSource = ds.Tables[0];

            con.Close();
        }

        private void fillComboBox()
        {
            con.Open();
            cmd = new SqlCommand("SELECT MedType_ID FROM MedicineType", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_MedTypeID.DataSource = dt;
            cmb_MedTypeID.DisplayMember = "MedType_ID";
            cmb_MedTypeID.ValueMember = "MedType_ID";

            con.Close();

            cmb_MedTypeID.SelectedIndex = -1;
        }

        void Refresh()
        {
            this.Close();
            Form_DeleteMedicineType obj = new Form_DeleteMedicineType();
            obj.Show();
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_MedTypeID.SelectedIndex == -1)
                MessageBox.Show(this, "Select an Medicine Type ID and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                if (MessageBox.Show("Are you sure you want to delete this data?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM MedicineType WHERE MedType_ID = @MEDTYPEID", con);
                    cmd.Parameters.AddWithValue("@MEDTYPEID", cmb_MedTypeID.SelectedValue.ToString());

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                        MessageBox.Show(this, "Data deleted successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data can't be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();

                }
                else
                {
                    MessageBox.Show(this, "Data is not deleted", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            Refresh();
        }
    }
}
