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
using System.Configuration;

namespace khayati_nakhchin
{
    public partial class FShow : Form
    {
        public String Value { get; set; }

        String idc = "not set";
        String connectionString;
        SqlConnection cnn;
        public FShow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
            try
            {
                String a = "SELECT * FROM Sizing ";
               String adapt = " WHERE CustomersID = ";

                String adaptor = a + adapt + idc ;
                MessageBox.Show(adaptor);
                MessageBox.Show(idc);

                using (cnn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(adaptor, cnn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FShow(String idcv)
        {
            InitializeComponent();

            this.Value = idcv;


            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
            try
            {
                String a = "SELECT * FROM Sizing ";
                String adapt = " WHERE CustomersID = ";

                String adaptor = a + adapt + idcv;
                MessageBox.Show(adaptor);
                MessageBox.Show(idcv);
                using (cnn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(adaptor, cnn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetN.Sizing' table. You can move, or remove it, as needed.
            idc = Value;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnBack5_Click(object sender, EventArgs e)
        {
            Form3 aa = new Form3();
            aa.ShowDialog();
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}