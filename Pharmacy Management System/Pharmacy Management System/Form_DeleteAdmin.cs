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
    public partial class Form_DeleteAdmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Form_DeleteAdmin()
        {
            InitializeComponent();
            ShowAdmin();
            fillComboBox();
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

        private void fillComboBox()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Admin_ID FROM Admin", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_AdminID.DataSource = dt;
            cmb_AdminID.DisplayMember = "Admin_ID";
            cmb_AdminID.ValueMember = "Admin_ID";

            con.Close();

            cmb_AdminID.SelectedIndex = -1;
        }

        void Refresh()
        {
            this.Close();
            Form_DeleteAdmin obj = new Form_DeleteAdmin();
            obj.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_AdminID.SelectedIndex == -1)
                MessageBox.Show(this, "Select an Admin ID and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                if (MessageBox.Show("Are you sure you want to delete this data?", "Remove Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Admin WHERE Admin_ID = @ADMINID", con);
                    cmd.Parameters.AddWithValue("@ADMINID", cmb_AdminID.SelectedValue.ToString());

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
            cmb_AdminID.SelectedIndex = -1;
        }
    }
}
