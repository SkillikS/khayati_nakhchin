namespace khayati_nakhchin
{
    partial class FormShow
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
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show
            // 
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(12, 12);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.RowHeadersWidth = 72;
            this.dgv_show.RowTemplate.Height = 31;
            this.dgv_show.Size = new System.Drawing.Size(776, 205);
            this.dgv_show.TabIndex = 0;
            this.dgv_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_show_CellContentClick);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(351, 223);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(89, 58);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "نمایش";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dgv_show);
            this.Name = "FormShow";
            this.Text = "FormShow";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Button btn_show;
    }
}