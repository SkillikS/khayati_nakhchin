using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khayati_nakhchin
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
 //==========================================BTN_BACK_8_Click=======================     
        private void BTN_BACK_8_Click(object sender, EventArgs e)
        {
            Form4 asa = new Form4();
            asa.ShowDialog();
            this.Close();
        }
 //==========================================BTN_X8_Click===========================
        private void BTN_X8_Click(object sender, EventArgs e)
        {

            BTN_X8.BackColor = Color.Transparent;
            //btnminimyze4.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
//==========================================btnminimyze8_Click======================
        private void btnminimyze8_Click(object sender, EventArgs e)
        {


            btnminimyze8.BackColor = Color.Transparent;
            btnminimyze8.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;
        }
    }
}
