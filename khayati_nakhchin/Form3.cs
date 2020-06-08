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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNamemoshtari3.Text.Trim() == "" )
            {
                MessageBox.Show("نام مشتری خالی است ");
            }
            else if (txtDate3.Text.Trim() == "")
            {
                MessageBox.Show("تاریخ سفارش خالی است ");
            }
            else if (comboxDokht3.Text.Trim() == "")
            {
                MessageBox.Show("نوع سفارش مشخص نشده است ");
            }
            else if (txtMobail3.Text.Trim() == "")
            {
                MessageBox.Show("شماره موبایل ثبت نشده است ");
            }
            else
            {
                if (txtNamemoshtari3.Text != "" && txtMobail3.Text != "" 
                    && comboxDokht3.Text !="" && txtDate3.Text != "")
                {
                    Form5 dd = new Form5();
                    dd.ShowDialog();
                }
               

            }



           

        }
//==========================================btn_Model_Dokht3===========================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboxDokht3.Items.Add("");
         
            comboxDokht3.Items.Add("رانکو چوخه");
            comboxDokht3.Items.Add("بلوز پانتول");
            comboxDokht3.Items.Add("مرادخانی");
            comboxDokht3.Items.Add("نچیروانی");
            comboxDokht3.Items.Add("بارزانی");
            comboxDokht3.Items.Add("ستارخانی");
            comboxDokht3.Items.Add("کت و شلوار");
            comboxDokht3.Items.Add("پیراهن ساده");
          
            comboxDokht3.Items.Add("سایر");


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
