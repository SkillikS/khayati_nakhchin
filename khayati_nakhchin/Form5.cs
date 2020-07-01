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
    public partial class Form5 : Form
    {
        String connectionString;
        SqlConnection cnn;
        int id = 0;
        public Form5(int id)
        {
            this.id = id;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;

            txtGHad5.MaxLength = 3;
            txtSarshane5.MaxLength = 3;
            txtGHadblooz5.MaxLength = 3;
            txtYagha5.MaxLength = 3;
            txtBazoo5.MaxLength = 3;
            txtSina5.MaxLength = 3;
            txtGHadpantol5.MaxLength = 3;
            txtKamar5.MaxLength = 3;
            txtGHadshalvar.MaxLength = 3;
            txtBasan5.MaxLength = 3;
            txtFaghPA5.MaxLength = 3;


        }

        private void FShow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKhraejshodan5_Click(object sender, EventArgs e)
        {
        }

        private void btnClear5_Click(object sender, EventArgs e)
        {

            btnClear5.BackColor = Color.Transparent;
            //btnminimyze4.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimyze5_Click(object sender, EventArgs e)
        {

            btnminimyze5.BackColor = Color.Transparent;
            btnminimyze5.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            Form3 aa = new Form3();
            aa.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }







        private void btnPakkardan5_Click(object sender, EventArgs e)
        {
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از پاک کردن همه اطلاعات اطمینان دارید؟",
               "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
               FMessegeBox.FMessegeBoxIcons.Question,
               FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {


                if (txtBasan5.Text != "" && txtBazoo5.Text != "" &&
                    txtFaghPA5.Text != "" && txtGHad5.Text != "" &&
                    txtGHadblooz5.Text != "" && txtGHadpantol5.Text != "" &&
                    txtGHadshalvar.Text != "" && txtKamar5.Text != "" &&
                    txtSarshane5.Text != "" && txtSina5.Text != "" &&
                    txtYagha5.Text != "" && txtEzafi5.Text !="")
                {
                    txtEzafi5.Text = "";
                    txtBasan5.Text = "";
                    txtBazoo5.Text = "";
                    txtFaghPA5.Text = "";
                    txtGHad5.Text = "";
                    txtGHadblooz5.Text = "";
                    txtGHadpantol5.Text = "";
                    txtGHadshalvar.Text = "";
                    txtKamar5.Text = "";
                    txtSarshane5.Text = "";
                    txtSina5.Text = "";
                    txtYagha5.Text = "";
                }
                else if (
                    txtBasan5.Text != "" || txtBazoo5.Text != "" ||
                    txtFaghPA5.Text != "" || txtGHad5.Text != "" ||
                    txtGHadblooz5.Text != "" || txtGHadpantol5.Text != "" ||
                    txtGHadshalvar.Text != "" || txtKamar5.Text != "" ||
                    txtSarshane5.Text != "" || txtSina5.Text != "" ||
                    txtYagha5.Text != "" || txtEzafi5.Text != "")
                {
                    txtEzafi5.Text = "";
                    txtBasan5.Text = "";
                    txtBazoo5.Text = "";
                    txtFaghPA5.Text = "";
                    txtGHad5.Text = "";
                    txtGHadblooz5.Text = "";
                    txtGHadpantol5.Text = "";
                    txtGHadshalvar.Text = "";
                    txtKamar5.Text = "";
                    txtSarshane5.Text = "";
                    txtSina5.Text = "";
                    txtYagha5.Text = "";
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {




            // ifs






            try
            {

                using (cnn = new SqlConnection(connectionString))
                {

                    string sql = null;
                    sql = "insert into Sizing ([CustomersID],[H],[Shold],[BloozH],[Clo],[Arm],[Chest],[PantoH],[Back],[PantyH],[Butt],[Fagh],[Expl]) values" +
                                                 "(@cId,@hght,@shold,@looz,@cl,@bazo,@tits,@pantol,@back,@shl,@ass,@fagh,@expl)";

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
                                cmd3.Parameters.Add("@cId", SqlDbType.Int).Value = id;
                                cmd3.Parameters.Add("@expl", SqlDbType.NVarChar).Value = txtEzafi5.Text;
                                cmd3.Parameters.Add("@bazo", SqlDbType.Int).Value = txtBazoo5.Text;
                                cmd3.Parameters.Add("@fagh", SqlDbType.Int).Value = txtFaghPA5.Text;
                                cmd3.Parameters.Add("@ass", SqlDbType.Int).Value = txtBasan5.Text;
                                cmd3.Parameters.Add("@shl", SqlDbType.Int).Value = txtGHadshalvar.Text;
                                cmd3.Parameters.Add("@back", SqlDbType.Int).Value = txtKamar5.Text;
                                cmd3.Parameters.Add("@pantol", SqlDbType.Int).Value = txtGHadpantol5.Text;
                                cmd3.Parameters.Add("@tits", SqlDbType.Int).Value = txtSina5.Text;
                                cmd3.Parameters.Add("@cl", SqlDbType.Int).Value = txtYagha5.Text;
                                cmd3.Parameters.Add("@looz", SqlDbType.Int).Value = txtGHadblooz5.Text;
                                cmd3.Parameters.Add("@shold", SqlDbType.Int).Value = txtSarshane5.Text;
                                cmd3.Parameters.Add("@hght", SqlDbType.Int).Value = txtGHad5.Text;

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

        private void txtGHadpantol5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGHad5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}