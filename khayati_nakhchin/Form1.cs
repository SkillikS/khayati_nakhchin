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

using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace khayati_nakhchin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(5000);

            var phash = SecurePasswordHasher.Hash("Admin");
            var uhash = SecurePasswordHasher.Hash("Admin");
            Form2 aa = new Form2(phash,uhash);
            t.Abort();
            aa.ShowDialog();
        }
        private void splash()
        {
            Application.Run(new SplashForm());
        }

        private void InitializeComponent()
        {
         
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(276, 236);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hash = SecurePasswordHasher.Hash("Admin");
        }
    }
}
