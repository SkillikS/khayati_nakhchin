using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace khayati_nakhchin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(5000);
            Form2 aa = new Form2();
            t.Abort();
            aa.ShowDialog();
        }
        private void splash()
        {
            Application.Run(new SplashForm());
        }
      
    }
}
