namespace khayati_nakhchin
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDate3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimyze2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboxDokht3 = new System.Windows.Forms.ComboBox();
            this.txtMobail3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSabtsefaresh3 = new System.Windows.Forms.Button();
            this.txtNamemoshtari3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate3
            // 
            this.txtDate3.Location = new System.Drawing.Point(311, 160);
            this.txtDate3.Name = "txtDate3";
            this.txtDate3.Size = new System.Drawing.Size(176, 39);
            this.txtDate3.TabIndex = 0;
            this.txtDate3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.btnminimyze2);
            this.panel1.Controls.Add(this.btnClear2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 111);
            this.panel1.TabIndex = 3;
            // 
            // btnminimyze2
            // 
            this.btnminimyze2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnminimyze2.Location = new System.Drawing.Point(1119, 16);
            this.btnminimyze2.Name = "btnminimyze2";
            this.btnminimyze2.Size = new System.Drawing.Size(36, 23);
            this.btnminimyze2.TabIndex = 3;
            this.btnminimyze2.Text = "-";
            this.btnminimyze2.UseVisualStyleBackColor = true;
            this.btnminimyze2.Click += new System.EventHandler(this.btnminimyze2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear2.Location = new System.Drawing.Point(1161, 16);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(36, 23);
            this.btnClear2.TabIndex = 2;
            this.btnClear2.Text = "X";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "برگشت";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(513, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "ثبت سفارشات ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(517, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "نوع دوخت ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.comboxDokht3);
            this.panel2.Controls.Add(this.txtMobail3);
            this.panel2.Controls.Add(this.txtNamemoshtari3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSabtsefaresh3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDate3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(475, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 461);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboxDokht3
            // 
            this.comboxDokht3.FormattingEnabled = true;
            this.comboxDokht3.Location = new System.Drawing.Point(311, 234);
            this.comboxDokht3.Name = "comboxDokht3";
            this.comboxDokht3.Size = new System.Drawing.Size(176, 39);
            this.comboxDokht3.TabIndex = 14;
            this.comboxDokht3.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMobail3
            // 
            this.txtMobail3.Location = new System.Drawing.Point(311, 307);
            this.txtMobail3.Name = "txtMobail3";
            this.txtMobail3.Size = new System.Drawing.Size(176, 39);
            this.txtMobail3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(502, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "شماره همراه ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSabtsefaresh3
            // 
            this.btnSabtsefaresh3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(86)))));
            this.btnSabtsefaresh3.Location = new System.Drawing.Point(123, 345);
            this.btnSabtsefaresh3.Name = "btnSabtsefaresh3";
            this.btnSabtsefaresh3.Size = new System.Drawing.Size(112, 52);
            this.btnSabtsefaresh3.TabIndex = 11;
            this.btnSabtsefaresh3.Text = "ثبت سفارش";
            this.btnSabtsefaresh3.UseVisualStyleBackColor = false;
            this.btnSabtsefaresh3.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNamemoshtari3
            // 
            this.txtNamemoshtari3.Location = new System.Drawing.Point(308, 84);
            this.txtNamemoshtari3.Name = "txtNamemoshtari3";
            this.txtNamemoshtari3.Size = new System.Drawing.Size(176, 39);
            this.txtNamemoshtari3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(550, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(502, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام مشتری  ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::khayati_nakhchin.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSabtsefaresh3;
        private System.Windows.Forms.TextBox txtNamemoshtari3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnminimyze2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtMobail3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboxDokht3;
        private System.Windows.Forms.Label label3;
    }
}