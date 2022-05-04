using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            Form_Login obj = new Form_Login();
            obj.Show();
            this.Hide();
        }

        private void LogoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Login obj = new Form_Login();
            obj.Show();
            this.Hide();
        }
    }
}
