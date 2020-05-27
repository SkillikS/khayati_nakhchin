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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
    }
}