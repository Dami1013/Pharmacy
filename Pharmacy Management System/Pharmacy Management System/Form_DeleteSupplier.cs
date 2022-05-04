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
    public partial class Form_DeleteSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_DeleteSupplier()
        {
            InitializeComponent();
            ShowSupplier();
            fillComboBox();
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

        private void fillComboBox()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Sup_ID FROM Supplier", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_SupID.DataSource = dt;
            cmb_SupID.DisplayMember = "Sup_ID";
            cmb_SupID.ValueMember = "Sup_ID";

            con.Close();

            cmb_SupID.SelectedIndex = -1;
        }

        void Refresh()
        {
            this.Close();
            Form_DeleteSupplier obj = new Form_DeleteSupplier();
            obj.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_SupID.SelectedIndex == -1)
                MessageBox.Show(this, "Select an Supplier ID and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                if (MessageBox.Show("Are you sure you want to delete this data?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Supplier WHERE Sup_ID = @SUPID", con);
                cmd.Parameters.AddWithValue("@SUPID", cmb_SupID.SelectedValue.ToString());

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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_SupID.SelectedIndex = -1;
        }
    }
}
