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

    public partial class AddEditCustom : Form
    {
        String connectionString;
        SqlConnection cnn;
        public AddEditCustom()
        {
            InitializeComponent();
            csex.Text = "--انتخاب کنید--";
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
        }

        private void AddEditCustom_Load(object sender, EventArgs e)
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
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text.Trim() == "")
            {
                MessageBox.Show("نام مشتری خالی است ");
            }
            else if (txtphone.Text.Trim() == "")
            {
                MessageBox.Show("شماره موبایل ثبت نشده است ");
            }
            else
            {
                if (txtfullname.Text != "" && txtphone.Text != "")
                {


                    try
                    {

                        using (cnn = new SqlConnection(connectionString))
                        {

                            string sql = null;
                            sql = "insert into Customers ([Orders],[FullName],[Gender],[Address],[PhoneNum],[Email]) values" +
                                                         "(@o,@f,@g,@a,@p,@e)";

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
                                        cmd3.Parameters.Add("@o", SqlDbType.Int).Value = 0;
                                        cmd3.Parameters.Add("@f", SqlDbType.NVarChar).Value = txtfullname.Text;
                                        cmd3.Parameters.Add("@g", SqlDbType.NVarChar).Value = csex.SelectedItem.ToString();
                                        cmd3.Parameters.Add("@a", SqlDbType.NVarChar).Value = adds.Text;
                                        cmd3.Parameters.Add("@p", SqlDbType.VarChar).Value = txtphone.Text;
                                        cmd3.Parameters.Add("@e", SqlDbType.VarChar).Value = txtemail.Text;



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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }





            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 aa = new Form4();
            aa.ShowDialog();
        }


        private void btnedit_Click(object sender, EventArgs e)
        {

            int id = 0;

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string queryString = "SELECT id  FROM  Customers WHERE FullName = @Name";

                cnn.Open();
                using (SqlCommand cmdd = new SqlCommand(queryString, cnn))
                {
                    cmdd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtfullname.Text;
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
            if(id == 0)
            {
                FMessegeBox.FarsiMessegeBox.Show("کاربردی با این نام در پایگاه داده ذخیره نشده است.",
                "راهنما",
               FMessegeBox.FMessegeBoxButtons.Ok,
               FMessegeBox.FMessegeBoxIcons.Information,
               FMessegeBox.FMessegeBoxDefaultButton.button1);
            }
            else
            {





                try
                {

                    using (cnn = new SqlConnection(connectionString))
                    {

                        string sql = null;
                        sql = "insert into Customers ([Gender],[Address],[PhoneNum],[Email]) values" +"(@g,@a,@p,@e)";

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

                                   if(csex.Text != "--انتخاب کنید--")
                                    cmd3.Parameters.Add("@g", SqlDbType.NVarChar).Value = csex.SelectedItem.ToString();
                                   if(adds.Text != null)
                                    cmd3.Parameters.Add("@a", SqlDbType.NVarChar).Value = adds.Text;
                                   if(txtphone.Text != null)
                                    cmd3.Parameters.Add("@p", SqlDbType.VarChar).Value = txtphone.Text;
                                   if(txtemail.Text != null)
                                    cmd3.Parameters.Add("@e", SqlDbType.VarChar).Value = txtemail.Text;



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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                FMessegeBox.FarsiMessegeBox.Show("اطلاعات با موفقیت تغییر کرد.",
               "راهنما",
              FMessegeBox.FMessegeBoxButtons.Ok,
              FMessegeBox.FMessegeBoxIcons.Information,
              FMessegeBox.FMessegeBoxDefaultButton.button1);
            }
        }
    }
}

