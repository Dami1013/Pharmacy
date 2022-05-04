using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class Form_AddGRN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkaru\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int index;

        public Form_AddGRN()
        {
            InitializeComponent();
            fillComboBoxMedicine();
            fillComboBoxSupplier();
            txt_Discount.Text = Convert.ToString("0");
        }

        private void Form_GRN_Load(object sender, EventArgs e)
        {
            Generate_GRN_ID();
        }

        public void Generate_GRN_ID()
        {
            string GRNID = "GRN";

            con.Open();

            cmd = new SqlCommand("SELECT COUNT(GRN_Id) FROM GRN_Master", con);
            int z = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            z++;

            if (z < 10)
                txt_GRNID.Text = GRNID + 0 + z.ToString();

            else
                txt_GRNID.Text = GRNID + z.ToString();
        }

        void Refresh()
        {
            this.Close();
            Form_AddGRN obj = new Form_AddGRN();
            obj.Show();
        }

        private void fillComboBoxMedicine()
        {
            con.Open();



            cmd = new SqlCommand("SELECT * FROM Medicine", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dt = new DataTable();
            da.Fill(dt);

            cmb_Medicine.DataSource = dt;
            cmb_Medicine.DisplayMember = "Med_Name";
            cmb_Medicine.ValueMember = "Med_Name";

            con.Close();

            cmb_Medicine.SelectedIndex = -1;
        }

        private void fillComboBoxSupplier()
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM Supplier", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            dt = new DataTable();
            da.Fill(dt);

            cmb_Supplier.DataSource = dt;
            cmb_Supplier.DisplayMember = "Sup_Name";
            cmb_Supplier.ValueMember = "Sup_Name";

            con.Close();

            cmb_Supplier.SelectedIndex = -1;
        }
               
        private void Btn_Supplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Supplier.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Select Supplier ID and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();

                    cmd = new SqlCommand("SELECT Sup_Id FROM Supplier WHERE Sup_Name = '" + cmb_Supplier.SelectedValue.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string supName = (string)dr["Sup_Id"].ToString();
                        txt_SupID.Text = supName;
                    }

                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Errors " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Medicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Medicine.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Select Medicine ID and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();

                    cmd = new SqlCommand("SELECT Med_Id FROM Medicine WHERE Med_Name = '" + cmb_Medicine.SelectedValue.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string medName = (string)dr["Med_Id"].ToString();
                        txt_MedicineID.Text = medName;
                    }

                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Errors " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_GRNID.Text == "" || cmb_Medicine.SelectedIndex == -1 || txt_Quantity.Text == "" || txt_UnitPrice.Text == "")
                    MessageBox.Show(this, "Missing Informations. Complete and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                else
                {
                    decimal tot, discount_Price;
                    int i = dataGridView_GRN.Rows.Count;
                    tot = Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(txt_UnitPrice.Text);
                    discount_Price = tot * (Convert.ToDecimal(txt_Discount.Text) / 100);
                    tot = tot - discount_Price;


                    dataGridView_GRN.Rows.Add(txt_GRNID.Text, i, txt_MedicineID.Text, cmb_Medicine.SelectedValue.ToString(), txt_SupID.Text, cmb_Supplier.SelectedValue.ToString(), txt_Quantity.Text, txt_UnitPrice.Text, date_Exp.Value.ToString("yyyy-MM-dd"), txt_Discount.Text, txt_SalePrice.Text, tot);

                    txt_SubTotal.Text = (from DataGridViewRow row in dataGridView_GRN.Rows where row.Cells[11].FormattedValue.ToString() != string.Empty select Convert.ToDecimal(row.Cells[11].FormattedValue)).Sum().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Errors " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UpdateRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_GRNID.Text == "" || cmb_Medicine.SelectedIndex == -1 || txt_Quantity.Text == "" || txt_UnitPrice.Text == "")
                    MessageBox.Show(this, "Confirm ?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    DataGridViewRow row = dataGridView_GRN.Rows[index];

                    decimal tot, discount_Price, sum = 0;
                    tot = Convert.ToDecimal(txt_Quantity.Text) * Convert.ToDecimal(txt_UnitPrice.Text);
                    discount_Price = tot * (Convert.ToDecimal(txt_Discount.Text) / 100);
                    tot = tot - discount_Price;

                    row.Cells[2].Value = txt_MedicineID.Text;
                    row.Cells[3].Value = cmb_Medicine.SelectedValue;
                    row.Cells[4].Value = txt_SupID.Text;
                    row.Cells[5].Value = cmb_Supplier.SelectedValue;
                    row.Cells[6].Value = txt_Quantity.Text;
                    row.Cells[7].Value = txt_UnitPrice.Text;
                    row.Cells[8].Value = date_Exp.Value.ToString("yyyy-MM-dd");
                    row.Cells[9].Value = txt_Discount.Text;
                    row.Cells[10].Value = txt_SalePrice.Text;
                    row.Cells[11].Value = tot;

                    for (int i = 0; i < dataGridView_GRN.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(dataGridView_GRN.Rows[i].Cells[11].Value);
                    }

                    txt_SubTotal.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Errors " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView_GRN.CurrentCell.RowIndex;
                dataGridView_GRN.Rows.RemoveAt(rowIndex);

                txt_SubTotal.Text = (from DataGridViewRow row in dataGridView_GRN.Rows where row.Cells[9].FormattedValue.ToString() != string.Empty select Convert.ToDecimal(row.Cells[9].FormattedValue)).Sum().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Select a row and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ClearFields_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmb_Medicine.SelectedIndex = -1;
                txt_MedicineID.Clear();
                date_Exp.Value = DateTime.Now;
                txt_UnitPrice.Clear();
                txt_Quantity.Clear();
                txt_Discount.Text = Convert.ToString("0");
                txt_SalePrice.Clear();
            }
        }

        private void DataGridView_GRN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = this.dataGridView_GRN.Rows[index];

                txt_MedicineID.Text = row.Cells[2].Value.ToString();
                cmb_Medicine.SelectedValue = row.Cells[3].Value.ToString();
                txt_SupID.Text = row.Cells[4].Value.ToString();
                cmb_Supplier.SelectedValue = row.Cells[5].Value.ToString();
                txt_Quantity.Text = row.Cells[6].Value.ToString();
                txt_UnitPrice.Text = row.Cells[7].Value.ToString();
                date_Exp.Value = Convert.ToDateTime(row.Cells[8].Value);
                txt_Discount.Text = row.Cells[9].Value.ToString();
                txt_SalePrice.Text = row.Cells[10].Value.ToString();
            }
        }

        private void btn_SaveGRN_Click(object sender, EventArgs e)
        {
            if(txt_GRNID.Text == "" || txt_InvoiceID.Text == "" || cmb_Supplier.SelectedIndex == -1 || cmb_Medicine.SelectedIndex == -1 || txt_SupID.Text == "" || txt_MedicineID.Text == "" || txt_UnitPrice.Text == "" || txt_Quantity.Text == "" || txt_Discount.Text == "")
            {
                MessageBox.Show(this, "Missing Informations. Complete and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Comfirm complete adding data", "Add Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        for (int y = 0; y < 2; y++)
                        {
                            if (y == 0)
                            {
                                con.Open();

                                cmd = new SqlCommand("INSERT INTO GRN_Master VALUES (@GRNID, @GRNDATE, @INVID, @INVDATE, @SUBTOTAL, @SUPID)", con);

                                cmd.Parameters.AddWithValue("@GRNID", txt_GRNID.Text);
                                cmd.Parameters.AddWithValue("@GRNDATE", date_GRN.Value);
                                cmd.Parameters.AddWithValue("@INVID", txt_InvoiceID.Text);
                                cmd.Parameters.AddWithValue("@INVDATE", date_Invoice.Value);
                                cmd.Parameters.AddWithValue("@SUBTOTAL", Convert.ToDecimal(txt_SubTotal.Text));
                                cmd.Parameters.AddWithValue("@SUPID", txt_SupID.Text);

                                cmd.ExecuteNonQuery();

                                con.Close();
                                cmd.Dispose();
                            }

                            else if (y == 1)
                            {
                                for (int i = 0; i < dataGridView_GRN.Rows.Count - 1; i++)
                                {
                                    cmd = new SqlCommand("INSERT INTO GRN_Detail VALUES (@GRNID, @GRIDORDERNO, @MEDID, @MEDNAME, @SUPID, @SUPNAME, @QTY, @UNITPRICE, @EXPDATE, @DISCOUNT, @SALEPRICE, @TOTAMOUNT)", con);
                                    {
                                        con.Open();

                                        cmd.Parameters.AddWithValue("@GRNID", dataGridView_GRN.Rows[i].Cells["GRN_Id"].Value);
                                        cmd.Parameters.AddWithValue("@GRIDORDERNO", dataGridView_GRN.Rows[i].Cells["Grid_Order_No"].Value);
                                        cmd.Parameters.AddWithValue("@MEDID", dataGridView_GRN.Rows[i].Cells["Med_Id"].Value);
                                        cmd.Parameters.AddWithValue("@MEDNAME", dataGridView_GRN.Rows[i].Cells["Med_Name"].Value);
                                        cmd.Parameters.AddWithValue("@SUPID", dataGridView_GRN.Rows[i].Cells["Sup_Id"].Value);
                                        cmd.Parameters.AddWithValue("@SUPNAME", dataGridView_GRN.Rows[i].Cells["Sup_Name"].Value);
                                        cmd.Parameters.AddWithValue("@QTY", dataGridView_GRN.Rows[i].Cells["Qty"].Value);
                                        cmd.Parameters.AddWithValue("@UNITPRICE", dataGridView_GRN.Rows[i].Cells["Unit_Price"].Value);
                                        cmd.Parameters.AddWithValue("@EXPDATE", dataGridView_GRN.Rows[i].Cells["Exp_Date"].Value);
                                        cmd.Parameters.AddWithValue("@DISCOUNT", dataGridView_GRN.Rows[i].Cells["Discount"].Value);
                                        cmd.Parameters.AddWithValue("@SALEPRICE", dataGridView_GRN.Rows[i].Cells["Sale_Amount"].Value);
                                        cmd.Parameters.AddWithValue("@TOTAMOUNT", dataGridView_GRN.Rows[i].Cells["Total"].Value);


                                        cmd.ExecuteNonQuery();


                                        con.Close();
                                    }
                                }
                                cmd.Dispose();
                            }
                        }
                        MessageBox.Show(this, "Inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Exception Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show(this, "Data is not saved", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void Btn_AddStock_Click(object sender, EventArgs e)
        {
            if (txt_GRNID.Text == "" || txt_InvoiceID.Text == "" || cmb_Supplier.SelectedIndex == -1 || cmb_Medicine.SelectedIndex == -1 || txt_SupID.Text == "" || txt_MedicineID.Text == "" || txt_UnitPrice.Text == "" || txt_Quantity.Text == "" || txt_Discount.Text == "")
            {
                MessageBox.Show(this, "Missing Informations. Complete and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (MessageBox.Show("Comfirm complete adding data", "Add Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < dataGridView_GRN.Rows.Count - 1; i++)
                        {
                            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(Item_Order_No)+1 FROM Stock WHERE Med_Id = @MEDID2", con);
                          
                            cmd2.Parameters.AddWithValue("@MEDID2", dataGridView_GRN.Rows[i].Cells[2].Value);

                            con.Open();

                            int j = Convert.ToInt32(cmd2.ExecuteScalar());

                            using (cmd = new SqlCommand("INSERT INTO Stock VALUES (@GRNID, @MEDID, @ITEMORDERNO, @GRIDORDERNO, @MEDNAME, @SUPID, @SUPNAME, @QTY, @UNITPRICE, @EXPDATE, @SALEPRICE)", con))
                            {
                                string expDate = Convert.ToString(dataGridView_GRN.CurrentRow.Cells[8].Value);

                                cmd.Parameters.AddWithValue("@GRNID", Convert.ToString(dataGridView_GRN.Rows[i].Cells[0].Value));
                                cmd.Parameters.AddWithValue("@GRIDORDERNO", Convert.ToInt32(dataGridView_GRN.Rows[i].Cells[1].Value));
                                cmd.Parameters.AddWithValue("@MEDID", Convert.ToString(dataGridView_GRN.Rows[i].Cells[2].Value));
                                cmd.Parameters.AddWithValue("@ITEMORDERNO", j);
                                cmd.Parameters.AddWithValue("@MEDNAME", Convert.ToString(dataGridView_GRN.Rows[i].Cells[3].Value));
                                cmd.Parameters.AddWithValue("@SUPID", Convert.ToString(dataGridView_GRN.Rows[i].Cells[4].Value));
                                cmd.Parameters.AddWithValue("@SUPNAME", Convert.ToString(dataGridView_GRN.Rows[i].Cells[5].Value));
                                cmd.Parameters.AddWithValue("@QTY", Convert.ToDecimal(dataGridView_GRN.Rows[i].Cells[6].Value));
                                cmd.Parameters.AddWithValue("@UNITPRICE", Convert.ToDecimal(dataGridView_GRN.Rows[i].Cells[7].Value));
                                cmd.Parameters.AddWithValue("@EXPDATE", Convert.ToDateTime(expDate));
                                cmd.Parameters.AddWithValue("@SALEPRICE", Convert.ToDecimal(dataGridView_GRN.Rows[i].Cells[10].Value));

                                cmd.ExecuteNonQuery();
                            }
                            con.Close();
                        }

                        MessageBox.Show(this, "Stock added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "An exception occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show(this, "Stock is not saved", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if(txt_GRNID.Text == "" || txt_InvoiceID.Text == "" || cmb_Supplier.SelectedIndex == -1 || cmb_Medicine.SelectedIndex == -1 || txt_SupID.Text == "" || txt_MedicineID.Text == "" || txt_UnitPrice.Text == "" || txt_Quantity.Text == "" || txt_Discount.Text == "")
            {
                MessageBox.Show(this, "Missing Informations. Complete and try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Roboto", 12);
            float fontHeight = font.GetHeight();
            int startx = 350;
            int starty = 125;
            int offset = 30;

            int printHeight = 100;
            int printWidth = 125;
            int leftMargin2 = 375;
            int rightMargin = 0;

            System.Drawing.Image img = System.Drawing.Image.FromFile(@"D:\\Project\\CODSE19.1F-034\\Code 3\\Logo.ico");

            graphics.DrawImage(img, new Rectangle(leftMargin2, rightMargin, printWidth, printHeight));
            graphics.DrawString("Good Recieved Note", new Font("Roboto", 14), new SolidBrush(Color.Black), startx, starty);
            graphics.DrawString("------------------------------------------------", font, new SolidBrush(Color.Black), 325, starty + offset);

            offset = offset + (int)fontHeight;
            string grnNo = "GRN No : " + Convert.ToString(txt_GRNID.Text);
            string dateTime_GRN = "GRN Date : " + Convert.ToString(date_GRN.Value.ToString("yyyy-MM-dd")).PadRight(5);
            graphics.DrawString(grnNo, font, new SolidBrush(Color.Black), 75, starty + offset);
            graphics.DrawString(dateTime_GRN, font, new SolidBrush(Color.Black), 615, starty + offset);

            offset = offset + (int)fontHeight;
            graphics.DrawString("\n", font, new SolidBrush(Color.Black), 50, starty + offset);

            offset = offset + (int)fontHeight;
            string invNo = "Invoice No : " + Convert.ToString(txt_InvoiceID.Text);
            string dateTime_Invoice = "Invoice Date : " + Convert.ToString(date_Invoice.Value.ToString("yyyy-MM-dd")).PadRight(5);
            graphics.DrawString(invNo, font, new SolidBrush(Color.Black), 75, starty + offset);
            graphics.DrawString(dateTime_Invoice, font, new SolidBrush(Color.Black), 615, starty + offset);

            offset = offset + (int)fontHeight;
            graphics.DrawString("\n", font, new SolidBrush(Color.Black), 50, starty + offset);

            offset = offset + (int)fontHeight;
            string supName = "Supplier : " + Convert.ToString(cmb_Supplier.SelectedValue.ToString());
            graphics.DrawString(supName, font, new SolidBrush(Color.Black), 75, starty + offset);


            offset = offset + (int)fontHeight;
            graphics.DrawString("\n\n\n", font, new SolidBrush(Color.Black), 50, starty + offset);

            offset = offset + (int)fontHeight;
            graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), 70, starty + offset);

            offset = offset + (int)fontHeight;
            graphics.DrawString("No \t Item \t\t\t QTY \t\t Unit Price \t Discount \t Total", font, new SolidBrush(Color.Black), 75, starty + offset);

            offset = offset + 20;
            graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), 70, starty + offset);

            offset = offset + 30;
            foreach (DataGridViewRow dr in dataGridView_GRN.Rows)
            {

                graphics.DrawString(dr.Cells[1].Value + "\t" + dr.Cells[3].Value + "\t\t\t" + dr.Cells[6].Value + "\t\t" + Convert.ToDecimal(dr.Cells[7].Value) + "%\t\t" + dr.Cells[8].Value + "\t\t" + Convert.ToDecimal(dr.Cells[9].Value), font, new SolidBrush(Color.Black), 80, starty + offset);
                offset = offset + 20;
            }

            offset = offset + 20;
            graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), 70, starty + offset);

            offset = offset + 30;
            graphics.DrawString("Sub Total : \t" + Convert.ToDecimal(txt_SubTotal.Text), font, new SolidBrush(Color.Black), 615, starty + offset);
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            date_GRN.Value = DateTime.Now;
            txt_InvoiceID.Clear();
            date_Invoice.Value = DateTime.Now;
            cmb_Supplier.SelectedIndex = -1;
            txt_SupID.Clear();
            cmb_Medicine.SelectedIndex = -1;
            txt_MedicineID.Clear();
            date_Exp.Value = DateTime.Now;
            txt_UnitPrice.Clear();
            txt_Quantity.Clear();
            txt_Discount.Text = Convert.ToString("0");
            txt_SubTotal.Clear();
            dataGridView_GRN.Rows.Clear();
            Refresh();
        }
    }
}
