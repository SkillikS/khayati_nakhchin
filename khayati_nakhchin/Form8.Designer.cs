using System;

namespace khayati_nakhchin
{
    partial class Form8
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
        private void Form8_Load(object sender ,EventArgs e)
        {

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_BACK_8 = new System.Windows.Forms.Button();
            this.btnminimyze8 = new System.Windows.Forms.Button();
            this.BTN_X8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelModir8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_BACK_8
            // 
            this.BTN_BACK_8.ForeColor = System.Drawing.Color.Black;
            this.BTN_BACK_8.Location = new System.Drawing.Point(-2, -2);
            this.BTN_BACK_8.Name = "BTN_BACK_8";
            this.BTN_BACK_8.Size = new System.Drawing.Size(77, 28);
            this.BTN_BACK_8.TabIndex = 7;
            this.BTN_BACK_8.Text = "برگشت";
            this.BTN_BACK_8.UseVisualStyleBackColor = true;
            this.BTN_BACK_8.Click += new System.EventHandler(this.BTN_BACK_8_Click);
            // 
            // btnminimyze8
            // 
            this.btnminimyze8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnminimyze8.Location = new System.Drawing.Point(1219, 3);
            this.btnminimyze8.Name = "btnminimyze8";
            this.btnminimyze8.Size = new System.Drawing.Size(36, 23);
            this.btnminimyze8.TabIndex = 6;
            this.btnminimyze8.Text = "-";
            this.btnminimyze8.UseVisualStyleBackColor = true;
            this.btnminimyze8.Click += new System.EventHandler(this.btnminimyze8_Click);
            // 
            // BTN_X8
            // 
            this.BTN_X8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_X8.Location = new System.Drawing.Point(1261, 3);
            this.BTN_X8.Name = "BTN_X8";
            this.BTN_X8.Size = new System.Drawing.Size(36, 23);
            this.BTN_X8.TabIndex = 5;
            this.BTN_X8.Text = "X";
            this.BTN_X8.UseVisualStyleBackColor = true;
            this.BTN_X8.Click += new System.EventHandler(this.BTN_X8_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(86)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BTN_BACK_8);
            this.panel1.Controls.Add(this.btnminimyze8);
            this.panel1.Controls.Add(this.BTN_X8);
            this.panel1.Controls.Add(this.labelModir8);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 97);
            this.panel1.TabIndex = 2;
            // 
            // labelModir8
            // 
            this.labelModir8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelModir8.AutoSize = true;
            this.labelModir8.Font = new System.Drawing.Font("B Nazanin", 36F, System.Drawing.FontStyle.Bold);
            this.labelModir8.ForeColor = System.Drawing.Color.Red;
            this.labelModir8.Location = new System.Drawing.Point(521, 3);
            this.labelModir8.Name = "labelModir8";
            this.labelModir8.Size = new System.Drawing.Size(395, 76);
            this.labelModir8.TabIndex = 1;
            this.labelModir8.Text = "صفحه نمایش تعرفه ها";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_BACK_8;
        private System.Windows.Forms.Button btnminimyze8;
        private System.Windows.Forms.Button BTN_X8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelModir8;
    }
}