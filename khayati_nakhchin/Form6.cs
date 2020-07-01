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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
//==========================================btn_Clear_6===========================================
        private void btnClear6_Click(object sender, EventArgs e)
        {

            if (txtNamKarbri6.Text != "" && txtRmzOboor6.Text != "")
            {
                txtNamKarbri6.Text = "";
                txtRmzOboor6.Text = "";
            }
            else if (txtNamKarbri6.Text != "" || txtRmzOboor6.Text != "")
            {
                txtNamKarbri6.Text = "";
                txtRmzOboor6.Text = "";
            }
        }
//==========================================btn_x_6===========================================
        private void btnClear5_Click(object sender, EventArgs e)
        {

            BTN_X6.BackColor = Color.Transparent;
            //btnminimyze4.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
//==========================================btn_minimyze_5===========================================
        private void btnminimyze5_Click(object sender, EventArgs e)
        {

            btnminimyze6.BackColor = Color.Transparent;
            btnminimyze6.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;
        }
//==========================================bTN_BACK_6===========================================
        private void button1_Click(object sender, EventArgs e)
        {

            Form4 aa = new Form4();
            aa.ShowDialog();
            this.Close();
        }
//==========================================bTN_LOGIN_6===========================================

        private void bTNLOGIN6_Click(object sender, EventArgs e)
        {

            if (txtNamKarbri6.Text.Trim() == "" && txtRmzOboor6.Text.Trim() == "")
            {
                MessageBox.Show("نام کاربری یا رمز عبور خالی است ");
            }
            else
            {
                if (txtNamKarbri6.Text == "Admin" && txtRmzOboor6.Text == "Admin")
                {
                    Form7 ww = new Form7();
                    ww.ShowDialog();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است ");
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
    
    }

