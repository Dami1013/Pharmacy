using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (radioBtn_Admin.Checked == false && radioBtn_Employee.Checked == false)
                {
                    MessageBox.Show(this, "Please select a Login method and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (radioBtn_Admin.Checked == true)
                {
                    con.Open();

                    string username = txt_Username.Text;
                    string password = txt_Passsword.Text;

                    cmd = new SqlCommand("SELECT Admin_Username, Admin_Password FROM Admin WHERE Admin_Username = '" + txt_Username.Text + "' AND Admin_Password = '" + txt_Passsword.Text + "'", con);
                    da = new SqlDataAdapter(cmd);

                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Form_Admin obj = new Form_Admin();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Please check username and password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
                else if (radioBtn_Employee.Checked == true)
                {
                    con.Open();

                    string username = txt_Username.Text;
                    string password = txt_Passsword.Text;

                    cmd = new SqlCommand("SELECT Emp_Username, Emp_Password FROM Employee WHERE Emp_Username = '" + txt_Username.Text + "' AND Emp_Password = '" + txt_Passsword.Text + "'", con);
                    da = new SqlDataAdapter(cmd);

                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Form_Employee obj = new Form_Employee();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Please check username and password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
