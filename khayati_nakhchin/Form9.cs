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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
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
        }

        private void btnminimyze9_Click(object sender, EventArgs e)
        {

            btnminimyze9.BackColor = Color.Transparent;
            btnminimyze9.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;
        }
    }
}
