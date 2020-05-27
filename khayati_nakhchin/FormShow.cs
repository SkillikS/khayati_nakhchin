using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace khayati_nakhchin
{
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("Server = localhost; Database = khayati_nakhchin; Uid = root; Pwd = 225848485822@ق;");
                String sqlcom = "select * from moshtari";
                MySqlCommand com = new MySqlCommand(sqlcom, con);
                con.Open();

                DataTable dt = new DataTable();
                dt.Load(com.ExecuteReader());

                dgv_show.DataSource = dt;
                con.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
