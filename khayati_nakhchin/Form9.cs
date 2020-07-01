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
    public partial class Form9 : Form
    {

        bool flag = false;
        public delegate void delPassData(String id);



        public string id;
        String connectionString;
        SqlConnection cnn;
        public Form9()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["khayati_nakhchin.Properties.Settings.scn"].ConnectionString;
         //   customersDataGridView.Hide();
            customersDataGridView.Visible = false;
        }

        private void BTN_X9_Click(object sender, EventArgs e)
        {


            BTN_X9.BackColor = Color.Transparent;
            //btnminimyze4.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_BACK_9_Click(object sender, EventArgs e)
        {
            Form4 asa = new Form4();
            asa.ShowDialog();
            this.Close();
        }

        private void btnminimyze9_Click(object sender, EventArgs e)
        {

            btnminimyze9.BackColor = Color.Transparent;
            btnminimyze9.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;
        }

    
      

        private void Form9_Load(object sender, EventArgs e)
        {
            

        }

     

        private void showAll_Click(object sender, EventArgs e)
        {
            try
            {
                
                using(cnn = new SqlConnection(connectionString))
                using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", cnn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                  
                    customersDataGridView.DataSource = dt;
               //     customersDataGridView.Show();
                    customersDataGridView.Visible = true;
              
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                //...
                MessageBox.Show("contentclick event calls");

            }
        }
        private void customersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("CEll Double_Click event calls");
            int rowIndex = e.RowIndex;
            DataGridViewRow row = customersDataGridView.Rows[rowIndex];
            String s = row.Cells[1].Value.ToString();
        }
        public string _id
        {
            get { return id; }
        }

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
                {

                    id = row.Cells[0].Value.ToString();
                    string value2 = row.Cells[1].Value.ToString();


                    FShow frm = new FShow(id);
                    frm.Value = id;
                    frm.ShowDialog();
                }
            }
            else
            {
                foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
                {

                    id = row.Cells[1].Value.ToString();
                    string value2 = row.Cells[1].Value.ToString();


                    FShow frm = new FShow(id);
                    frm.Value = id;
                    frm.ShowDialog();
                }
            }
        }

        private void showAll_o_Click(object sender, EventArgs e)
        {
            flag = true;
            try
            {

                using (cnn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders", cnn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    customersDataGridView.DataSource = dt;
                    //     customersDataGridView.Show();
                    customersDataGridView.Visible = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
