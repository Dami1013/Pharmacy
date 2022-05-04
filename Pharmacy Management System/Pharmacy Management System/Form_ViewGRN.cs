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
    public partial class Form_ViewGRN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_ViewGRN()
        {
            InitializeComponent();
            fillComboBoxGRNID();
            fillComboBoxSupID();
            fillComboBoxMedID();
        }

        private void fillComboBoxGRNID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT GRN_Id FROM GRN_Master", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_GRNID.DataSource = dt;
            cmb_GRNID.DisplayMember = "GRN_Id";
            cmb_GRNID.ValueMember = "GRN_Id";

            con.Close();

            cmb_GRNID.SelectedIndex = -1;
        }

        private void fillComboBoxSupID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Sup_Id FROM Supplier", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_SupID.DataSource = dt;
            cmb_SupID.DisplayMember = "Sup_Id";
            cmb_SupID.ValueMember = "Sup_Id";

            con.Close();

            cmb_SupID.SelectedIndex = -1;
        }

        private void fillComboBoxMedID()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Med_Id FROM Medcine", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_SupID.DataSource = dt;
            cmb_SupID.DisplayMember = "Sup_Id";
            cmb_SupID.ValueMember = "Sup_Id";

            con.Close();

            cmb_SupID.SelectedIndex = -1;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioBtn_GRNID.Checked == false && radioBtn_MedID.Checked == false && radioBtn_MedName.Checked == false && radioBtn_SupID.Checked == false && radioBtn_SupName.Checked == false)
                {
                    MessageBox.Show(this, "Please select a method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_GRNID.Checked == true)
                {
                    for(int i = 0; i < 2; i++)
                    {
                        if(i == 0)
                        {
                            con.Open();
                            da = new SqlDataAdapter("SELECT * FROM GRN_Master WHERE GRN_Id = '" + cmb_GRNID.SelectedValue.ToString() + "' ", con);
                            dt = new DataTable();
                            da.Fill(dt);
                            dataGridView_GRNMaster.DataSource = dt;
                            con.Close();
                        }
                        else if(i == 1)
                        {
                            con.Open();
                            da = new SqlDataAdapter("SELECT * FROM GRN_Detail WHERE GRN_Id = '" + cmb_GRNID.SelectedValue.ToString() + "' ", con);
                            dt = new DataTable();
                            da.Fill(dt);
                            dataGridView_GRNDetails.DataSource = dt;
                            con.Close();
                        }
                    }
                    
                }
                else if (radioBtn_SupID.Checked == true)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            con.Open();
                            da = new SqlDataAdapter("SELECT * FROM GRN_Master WHERE Sup_Id = '" + cmb_GRNID.SelectedValue.ToString() + "' ", con);
                            dt = new DataTable();
                            da.Fill(dt);
                            dataGridView_GRNMaster.DataSource = dt;
                            con.Close();
                        }
                        else if (i == 1)
                        {
                            con.Open();
                            da = new SqlDataAdapter("SELECT * FROM GRN_Detail WHERE Sup_Id = '" + cmb_GRNID.SelectedValue.ToString() + "' ", con);
                            dt = new DataTable();
                            da.Fill(dt);
                            dataGridView_GRNDetails.DataSource = dt;
                            con.Close();
                        }
                    }


                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
