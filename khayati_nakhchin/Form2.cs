using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace khayati_nakhchin
{
    public partial class Form2 : Form
    {
        String pHash;
        String uHash;
        public Form2(String phash,String uhash)
        {
            this.pHash = phash;
            this.uHash = uhash;
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 18;
            textUSER.MaxLength = 25;
        }
        public Form2()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 18;
            textUSER.MaxLength = 25;
        }

        //==========================================btnbtn_X2===========================================
        private void button3_Click(object sender, EventArgs e)
        {
            btn_X.BackColor = Color.Transparent;
            btn_X.FlatStyle = FlatStyle.Flat;
            if (FMessegeBox.FarsiMessegeBox.Show("آیا از خروج اطمینان دارید؟",
                "هشدار !", FMessegeBox.FMessegeBoxButtons.YesNo,
                FMessegeBox.FMessegeBoxIcons.Question,
                FMessegeBox.FMessegeBoxDefaultButton.button2) == DialogResult.Yes)
            {
                Application.Exit();
            }



        }
 //==========================================btnMinimayze2===========================================
        private void btn_minimayze_Click(object sender, EventArgs e)
        {
            btn_minimayze.BackColor = Color.Transparent;
            btn_minimayze.FlatStyle = FlatStyle.Flat;
            WindowState = FormWindowState.Minimized;


        }
//==========================================label1===========================================
        private void label1_Click(object sender, EventArgs e)
        {

        }
 //=====================================================================================
        private void label2_Click(object sender, EventArgs e)
        {

        }
 //==========================================btnVrood2===========================================
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textUSER.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                MessageBox.Show("نام کاربری یا رمز عبور خالی است ");
            }
            else
            {
                var uresult = SecurePasswordHasher.Verify(textUSER.Text, uHash);
                var presult = SecurePasswordHasher.Verify(txtPass.Text, pHash);
                if (uresult && presult)
                {
                  
                    Form4 ww = new Form4();
                    ww.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است ");
                }
            }
        }
 //=====================================================================================
        private void button5_Click(object sender, EventArgs e)
        {
            FMessegeBox.FarsiMessegeBox.Show("نام کاربری و رمز عبور برای بار اول هردو  " + " Admin " + "هستند وبرای ثبت سفارشات خود میتوانید به صفحه ثبت سفارش بروید  ",
                 "راهنما",
                FMessegeBox.FMessegeBoxButtons.Ok,
                FMessegeBox.FMessegeBoxIcons.Information,
                FMessegeBox.FMessegeBoxDefaultButton.button1);
        }
 //==========================================btnRahnma2===========================================
        private void button6_Click(object sender, EventArgs e)
        {
            if (FMessegeBox.FarsiMessegeBox.Show("ایرج ولی پور 9617023144 و انیران محمدپور 9617023136", "راهنما", FMessegeBox.FMessegeBoxButtons.Ok,
                FMessegeBox.FMessegeBoxIcons.Information,
                FMessegeBox.FMessegeBoxDefaultButton.button1) == DialogResult.Yes)
            {
                Form2 d = new Form2();
                d.Show();
            
        }
    }
 //==========================================btnPakkardan2===========================================
        private void button4_Click(object sender, EventArgs e)
        {
         
           
            if (textUSER.Text != "" && txtPass.Text != "")
            {
                textUSER.Text = "";
                txtPass.Text = "";
            }
            else if(textUSER.Text !="" || txtPass.Text != "")
            {
                textUSER.Text = "";
                txtPass.Text = "";
            }
          //  btnClear.FlatStyle = FlatStyle.Flat;
          //  btnClear.FlatAppearance.BorderColor = Color.White;
          //  btnClear.ForeColor = Color.White;
        }
 //==========================================2===========================================
        private void textUSER_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
        }
    }
}
