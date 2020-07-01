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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            label1.Text = "نام کاربری و رمز عبور برای بار اول هردو Admin هستند وبرای ثبت سفارشات خود میتوانید به صفحه ثبت سفارش بروید";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
