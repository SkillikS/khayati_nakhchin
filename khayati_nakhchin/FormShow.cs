using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace khayati_nakhchin
{
    public partial class FormShow : Form
    {
        String connectionString;
        SqlConnection cnn;
        public FormShow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                using (cnn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", cnn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_show.DataSource = dt;
                }



                /*
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = khayati_nakhchin; Uid = root; Pwd = 225848485822@ق;");
                String sqlcom = "select * from moshtari";
                MySqlCommand com = new MySqlCommand(sqlcom, con);
                con.Open();
                
                DataTable dt = new DataTable();
                dt.Load(com.ExecuteReader());

                dgv_show.DataSource = dt;
                con.Close();
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormShow_Load(object sender, EventArgs e)
        {

        }

        private void FormShow_Load_1(object sender, EventArgs e)
        {

        }
    }
}
