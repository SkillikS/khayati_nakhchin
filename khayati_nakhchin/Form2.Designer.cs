namespace khayati_nakhchin
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_minimayze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.bTNLOGIN = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.textUSER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_X
            // 
            this.btn_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_X.Location = new System.Drawing.Point(2096, 0);
            this.btn_X.Margin = new System.Windows.Forms.Padding(6);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(66, 42);
            this.btn_X.TabIndex = 6;
            this.btn_X.Text = " X";
            this.btn_X.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_minimayze
            // 
            this.btn_minimayze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimayze.Location = new System.Drawing.Point(2026, 0);
            this.btn_minimayze.Margin = new System.Windows.Forms.Padding(6);
            this.btn_minimayze.Name = "btn_minimayze";
            this.btn_minimayze.Size = new System.Drawing.Size(66, 42);
            this.btn_minimayze.TabIndex = 7;
            this.btn_minimayze.Text = " --";
            this.btn_minimayze.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_minimayze.UseVisualStyleBackColor = true;
            this.btn_minimayze.Click += new System.EventHandler(this.btn_minimayze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(554, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 63);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "نام کاربری";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(578, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 63);
            this.label2.TabIndex = 8;
            this.label2.Text = " رمز عبور";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.bTNLOGIN);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textUSER);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1122, 198);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 949);
            this.panel1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.panel1, "برای ورود باید نام کاربری و رمزعبور را وارد کنید.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Yekan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(299, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 85);
            this.label4.TabIndex = 9;
            this.label4.Text = "صفحه ورود";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.Location = new System.Drawing.Point(0, 888);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 61);
            this.button6.TabIndex = 13;
            this.button6.Text = "درباره ما";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.Location = new System.Drawing.Point(695, 888);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 61);
            this.button5.TabIndex = 12;
            this.button5.Text = " راهنما";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.Location = new System.Drawing.Point(260, 610);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 61);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "پاک کردن";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // bTNLOGIN
            // 
            this.bTNLOGIN.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bTNLOGIN.Location = new System.Drawing.Point(501, 610);
            this.bTNLOGIN.Margin = new System.Windows.Forms.Padding(6);
            this.bTNLOGIN.Name = "bTNLOGIN";
            this.bTNLOGIN.Size = new System.Drawing.Size(152, 61);
            this.bTNLOGIN.TabIndex = 10;
            this.bTNLOGIN.Text = " ورود";
            this.bTNLOGIN.UseVisualStyleBackColor = true;
            this.bTNLOGIN.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPass.Location = new System.Drawing.Point(260, 474);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(393, 63);
            this.txtPass.TabIndex = 9;
            // 
            // textUSER
            // 
            this.textUSER.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textUSER.Location = new System.Drawing.Point(260, 314);
            this.textUSER.Margin = new System.Windows.Forms.Padding(6);
            this.textUSER.Multiline = true;
            this.textUSER.Name = "textUSER";
            this.textUSER.Size = new System.Drawing.Size(393, 63);
            this.textUSER.TabIndex = 0;
            this.textUSER.TextChanged += new System.EventHandler(this.textUSER_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Yekan", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(353, 733);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(613, 170);
            this.label3.TabIndex = 8;
            this.label3.Text = "خیاطی نخچین";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
       
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::khayati_nakhchin.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2158, 1194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_minimayze);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_minimayze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button bTNLOGIN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox textUSER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}