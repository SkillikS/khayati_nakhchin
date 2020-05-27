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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int second = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.Hide();
            if(second == 10)
            {
                Form3 a = new Form3();
                a.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

          


            Form2 aa = new Form2();
            aa.ShowDialog();
        }
    }
}
