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
    public partial class Form_DeleteMedicine : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_DeleteMedicine()
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
            cmd = new SqlCommand("SELECT Med_ID FROM Medicine", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_MedID.DataSource = dt;
            cmb_MedID.DisplayMember = "Med_ID";
            cmb_MedID.ValueMember = "Med_ID";

            con.Close();

            cmb_MedID.SelectedIndex = -1;
        }

        void Refresh()
        {
            this.Close();
            Form_DeleteEmployee obj = new Form_DeleteEmployee();
            obj.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_MedID.SelectedIndex == -1)
                MessageBox.Show(this, "Select an Medicine ID and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                if (MessageBox.Show("Are you sure you want to delete this data?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Medicine WHERE Med_ID = @MEDID", con);
                    cmd.Parameters.AddWithValue("@MEDID", cmb_MedID.SelectedValue.ToString());

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

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_MedID.SelectedIndex = -1;
        }
    }
}
