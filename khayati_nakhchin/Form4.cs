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
    public partial class Form4 : Form
    {
        int x = 5;
        public Form4()
        {
            InitializeComponent();
        }
 //==========================================btnClear4===========================================
        private void btnclear4_Click(object sender, EventArgs e)
        {

            btnclear4.BackColor = Color.Transparent;
            //btnminimyze4.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
 //==========================================btnMinimyze4===========================================
        private void btnminimyze2_Click(object sender, EventArgs e)
        {


            btnminimyze4.BackColor = Color.Transparent;
            btnminimyze4.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;

        }
 //==========================================btnBack4===========================================
        private void btnback4_Click(object sender, EventArgs e)
        {
            Form2 aa = new Form2();
            aa.ShowDialog();
        }
//==========================================btnSave4===========================================
        private void btnSave4_Click(object sender, EventArgs e)
        {
            Form3 aa = new Form3();
            aa.ShowDialog();
        }
 //==========================================btnCoustomer4===========================================
        private void btnCoustumer4_Click(object sender, EventArgs e)
        {

        }

        private void btnManger_Click(object sender, EventArgs e)
        {
            Form6 aa = new Form6();
            aa.ShowDialog();
        }
    }
}
