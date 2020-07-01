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
    public partial class AddEditCustom : Form
    {
        public AddEditCustom()
        {
            InitializeComponent();
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
            if (txtfullname.Text.Trim() == "" )
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
                    this.Close();
                }
               

            }



           

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
        //=====================================================================================


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 aa = new Form4();
            aa.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 
    }
}
