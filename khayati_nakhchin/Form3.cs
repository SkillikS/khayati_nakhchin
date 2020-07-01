using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khayati_nakhchin
{
    public partial class Form3 : Form
    {
        String connectionString;
        SqlConnection cnn;
        public Form3()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
//==========================================btn_X3=================================
        private void btnClear2_Click(object sender, EventArgs e)
        {
            btnClear2.BackColor = Color.Transparent;
            btnminimyze2.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
//==========================================btn_X3=================================
        private void btnminimyze2_Click(object sender, EventArgs e)
        {

            btnminimyze2.BackColor = Color.Transparent;
            btnminimyze2.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
//==========================================btnSabte_Sefarsh3===========================================
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNamemoshtari3.Text.Trim() == "" )
            {
                MessageBox.Show("نام مشتری خالی است ");
            }
            else if (comboxDokht3.Text.Trim() == "")
            {
                MessageBox.Show("نوع سفارش مشخص نشده است ");
            }
            else if (txtMobail3.Text.Trim() == "")
            {
                MessageBox.Show("شماره موبایل ثبت نشده است ");
            }
            else
            {
                if (txtNamemoshtari3.Text != "" && txtMobail3.Text != "" 
                    && comboxDokht3.Text !="")
                {
                cnn =new SqlConnection(connectionString);
                    String n = txtNamemoshtari3.Text;
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("",cnn);


                    SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM [Customers] WHERE ([FullName] = @x)", cnn);
                    cm.Parameters.AddWithValue("@x", txtNamemoshtari3.Text.Trim());
                    int ccc = (int)cm.ExecuteScalar();
                    MessageBox.Show(ccc.ToString());

                    cnn.Close();
                    if (ccc == 0)
                    {

                        // adding use info 
    
                        string sql = null;
                        sql = "insert into Customers ([Orders], [FullName], [Gender], [Address], [PhoneNum], [Email]) values(@orders,@fullName, @gender,@address,@phoneNum,@email)";

                        // Create the connection (and be sure to dispose it at the end)
                        using (SqlConnection cnn = new SqlConnection(connectionString))
                        {
                            try
                            {
                                // Open the connection to the database. 
                                // This is the first critical step in the process.
                                // If we cannot reach the db then we have connectivity problems
                                cnn.Open();

                                // Prepare the command to be executed on the db
                                using (SqlCommand cmd3 = new SqlCommand(sql, cnn))
                                {
                                    // Create and set the parameters values 
                                    cmd3.Parameters.Add("@orders", SqlDbType.Int).Value = 1;
                                    cmd3.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = txtNamemoshtari3.Text;
                                    cmd3.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "";
                                    cmd3.Parameters.Add("@address", SqlDbType.NVarChar).Value ="";
                                    cmd3.Parameters.Add("@phoneNum", SqlDbType.VarChar).Value = txtMobail3.Text;
                                    cmd3.Parameters.Add("@email", SqlDbType.VarChar).Value ="";
                                    // Let's ask the db to execute the query
                                    int rowsAdded = cmd3.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                        MessageBox.Show("اطلاعات کاربر در پایگاه داده ایجاد شد");
                                    else
                                        // Well this should never really happen
                                        MessageBox.Show("ایجاد نشد");

                                }
                            }
                            catch (Exception ex)
                            {
                                // We should log the error somewhere, 
                                // for this example let's just show a message
                                MessageBox.Show("ERROR:" + ex.Message);
                            }
                        }






                        



                        // Finding use id


                        int id = 0;

                        using (SqlConnection cnn = new SqlConnection(connectionString))
                        {
                            string queryString = "SELECT id  FROM  Customers WHERE FullName = @Name";

                            cnn.Open();
                            using (SqlCommand cmdd = new SqlCommand(queryString, cnn))
                            {
                                cmdd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = n;
                                using (SqlDataReader reader = cmdd.ExecuteReader())
                                {
                                    try
                                    {
                                        while (reader.Read())
                                        {


                   

                                            id = (int)reader["id"];

                                            MessageBox.Show(id.ToString());

                                        }
                                    }
                                    finally
                                    {
                                        // Always call Close when done reading.
                                        reader.Close();
                                    }
                                }
                            }
                        }


                        // Adding Orders to dataset

                        string sqlN = null;
                        sqlN = "insert into Orders ([CustomersID], [FullName], [type], [PhoneNum], [Date], [Paid]) values(@c,@f, @t,@ph,@d,@paid)";

                        // Create the connection (and be sure to dispose it at the end)
                        using (SqlConnection cnn = new SqlConnection(connectionString))
                        {
                            try
                            {
                                // Open the connection to the database. 
                                // This is the first critical step in the process.
                                // If we cannot reach the db then we have connectivity problems
                                cnn.Open();

                                // Prepare the command to be executed on the db
                                using (SqlCommand cmd3 = new SqlCommand(sqlN, cnn))
                                {
                                    // Create and set the parameters values 
                                    cmd3.Parameters.Add("@c", SqlDbType.Int).Value = id;
                                    cmd3.Parameters.Add("@f", SqlDbType.NVarChar).Value = txtNamemoshtari3.Text;
                                    cmd3.Parameters.Add("@t", SqlDbType.NVarChar).Value = comboxDokht3.Text;
                                    cmd3.Parameters.Add("@ph", SqlDbType.NChar).Value = txtMobail3.Text;
                                    cmd3.Parameters.Add("@d", SqlDbType.NChar).Value = txtDate3.Text;
                                    cmd3.Parameters.Add("@paid", SqlDbType.Bit).Value = 0;
                                    // Let's ask the db to execute the query
                                    int rowsAdded = cmd3.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                        MessageBox.Show("اطلاعات کاربر در پایگاه داده ایجاد شد");
                                    else
                                        // Well this should never really happen
                                        MessageBox.Show("ایجاد نشد");

                                }
                            }
                            catch (Exception ex)
                            {
                                // We should log the error somewhere, 
                                // for this example let's just show a message
                                MessageBox.Show("ERROR:" + ex.Message);
                            }
                        }


                      
                        Form5 dd = new Form5(id);
                        dd.ShowDialog();
                    }
                    else
                    {

                        // Finding use id


                        int idd = 0;

                        using (SqlConnection cnn = new SqlConnection(connectionString))
                        {
                            string queryString = "SELECT id  FROM  Customers WHERE FullName = @Name";

                            cnn.Open();
                            using (SqlCommand cmdd = new SqlCommand(queryString, cnn))
                            {
                                cmdd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = n;
                                using (SqlDataReader reader = cmdd.ExecuteReader())
                                {
                                    try
                                    {
                                        while (reader.Read())
                                        {




                                            idd = (int)reader["id"];

                                            MessageBox.Show(idd.ToString());

                                        }
                                    }
                                    finally
                                    {
                                        // Always call Close when done reading.
                                        reader.Close();
                                    }
                                }
                            }
                        }




                        // Adding Orders to dataset
                 
                        string sqlN = null;
                        sqlN = "insert into Orders ([CustomersID], [FullName], [type], [PhoneNum], [Date], [Paid]) values(@c,@f, @t,@ph,@d,@paid)";

                        // Create the connection (and be sure to dispose it at the end)
                        using (SqlConnection cnn = new SqlConnection(connectionString))
                        {
                            try
                            {
                                // Open the connection to the database. 
                                // This is the first critical step in the process.
                                // If we cannot reach the db then we have connectivity problems
                                cnn.Open();

                                // Prepare the command to be executed on the db
                                using (SqlCommand cmd3 = new SqlCommand(sqlN, cnn))
                                {
                                    // Create and set the parameters values 
                                    cmd3.Parameters.Add("@c", SqlDbType.Int).Value = idd;
                                    cmd3.Parameters.Add("@f", SqlDbType.NVarChar).Value = txtNamemoshtari3.Text;
                                    cmd3.Parameters.Add("@t", SqlDbType.NVarChar).Value = comboxDokht3.Text;
                                    cmd3.Parameters.Add("@ph", SqlDbType.NChar).Value = txtMobail3.Text;
                                    cmd3.Parameters.Add("@d", SqlDbType.NChar).Value = txtDate3.Text;
                                    cmd3.Parameters.Add("@paid", SqlDbType.Bit).Value = 0;
                                    // Let's ask the db to execute the query
                                    int rowsAdded = cmd3.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                        MessageBox.Show("اطلاعات کاربر در پایگاه داده ایجاد شد");
                                    else
                                        // Well this should never really happen
                                        MessageBox.Show("ایجاد نشد");

                                }
                            }
                            catch (Exception ex)
                            {
                                // We should log the error somewhere, 
                                // for this example let's just show a message
                                MessageBox.Show("ERROR:" + ex.Message);
                            }
                        }





                        Form5 dd = new Form5(idd);
                        dd.ShowDialog();
                    }




                    
                }
               

            }



           

        }
//==========================================btn_Model_Dokht3===========================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboxDokht3.Items.Add("کت و شلوار");
            comboxDokht3.Items.Add("رانکو چوخه");
            comboxDokht3.Items.Add("بلوز پانتول");
            comboxDokht3.Items.Add("مرادخانی");
            comboxDokht3.Items.Add("نچیروانی");
            comboxDokht3.Items.Add("بارزانی");
            comboxDokht3.Items.Add("ستارخانی");
            comboxDokht3.Items.Add("پیراهن ساده");
            comboxDokht3.Items.Add("سایر");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 aa = new Form4();
            aa.ShowDialog();
            this.Close();
        }
        private void txtNamemoshtari3_TextChanged(object sender, EventArgs e)
        {
            txtNamemoshtari3.MaxLength = 15;
            txtMobail3.MaxLength = 11;


        }

        private void txtMobail3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && Text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar == '-' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void txtNamemoshtari3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((Control)sender).Text;
            if (e.KeyChar == '-' && Text.Length == 0 && e.KeyChar == '-' && text.Length > 0 && !text.Contains("."))
            {
                e.Handled = false;
                return;
            }
        }
    }
}
