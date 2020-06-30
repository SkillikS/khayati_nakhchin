namespace khayati_nakhchin
{
    partial class Form9
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.BTN_BACK_9 = new System.Windows.Forms.Button();
            this.btnminimyze9 = new System.Windows.Forms.Button();
            this.BTN_X9 = new System.Windows.Forms.Button();
            this.labelModir9 = new System.Windows.Forms.Label();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataSet = new khayati_nakhchin.DataSet();
            this.showAll = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.AutoSize = true;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(86)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.BTN_BACK_9);
            this.panel9.Controls.Add(this.btnminimyze9);
            this.panel9.Controls.Add(this.BTN_X9);
            this.panel9.Controls.Add(this.labelModir9);
            this.panel9.Location = new System.Drawing.Point(20, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2149, 176);
            this.panel9.TabIndex = 3;
            // 
            // BTN_BACK_9
            // 
            this.BTN_BACK_9.ForeColor = System.Drawing.Color.Black;
            this.BTN_BACK_9.Location = new System.Drawing.Point(-4, -4);
            this.BTN_BACK_9.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_BACK_9.Name = "BTN_BACK_9";
            this.BTN_BACK_9.Size = new System.Drawing.Size(141, 52);
            this.BTN_BACK_9.TabIndex = 7;
            this.BTN_BACK_9.Text = "برگشت";
            this.BTN_BACK_9.UseVisualStyleBackColor = true;
            this.BTN_BACK_9.Click += new System.EventHandler(this.BTN_BACK_9_Click);
            // 
            // btnminimyze9
            // 
            this.btnminimyze9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnminimyze9.Location = new System.Drawing.Point(1997, 6);
            this.btnminimyze9.Margin = new System.Windows.Forms.Padding(6);
            this.btnminimyze9.Name = "btnminimyze9";
            this.btnminimyze9.Size = new System.Drawing.Size(66, 42);
            this.btnminimyze9.TabIndex = 6;
            this.btnminimyze9.Text = "-";
            this.btnminimyze9.UseVisualStyleBackColor = true;
            this.btnminimyze9.Click += new System.EventHandler(this.btnminimyze9_Click);
            // 
            // BTN_X9
            // 
            this.BTN_X9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_X9.Location = new System.Drawing.Point(2074, 6);
            this.BTN_X9.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_X9.Name = "BTN_X9";
            this.BTN_X9.Size = new System.Drawing.Size(66, 42);
            this.BTN_X9.TabIndex = 5;
            this.BTN_X9.Text = "X";
            this.BTN_X9.UseVisualStyleBackColor = true;
            this.BTN_X9.Click += new System.EventHandler(this.BTN_X9_Click);
            // 
            // labelModir9
            // 
            this.labelModir9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelModir9.AutoSize = true;
            this.labelModir9.Font = new System.Drawing.Font("B Nazanin", 36F, System.Drawing.FontStyle.Bold);
            this.labelModir9.ForeColor = System.Drawing.Color.Red;
            this.labelModir9.Location = new System.Drawing.Point(836, 6);
            this.labelModir9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelModir9.Name = "labelModir9";
            this.labelModir9.Size = new System.Drawing.Size(474, 133);
            this.labelModir9.TabIndex = 1;
            this.labelModir9.Text = "صفحه جستجو";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Location = new System.Drawing.Point(20, 537);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersWidth = 72;
            this.customersDataGridView.RowTemplate.Height = 31;
            this.customersDataGridView.Size = new System.Drawing.Size(2142, 655);
            this.customersDataGridView.TabIndex = 4;
            this.customersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellContentClick);
            this.customersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGridView_CellDoubleClick);
            this.customersDataGridView.SelectionChanged += new System.EventHandler(this.customersDataGridView_SelectionChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(1867, 407);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(295, 101);
            this.showAll.TabIndex = 5;
            this.showAll.Text = "نمایش همه";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2182, 1204);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form9";
            this.Text = "Form9";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BTN_BACK_9;
        private System.Windows.Forms.Button btnminimyze9;
        private System.Windows.Forms.Button BTN_X9;
        private System.Windows.Forms.Label labelModir9;
        private DataSet dataSet;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button showAll;
    }
}