namespace övning3._7
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Hemmalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.målH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MålB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hemmalag,
            this.Bortalag,
            this.målH,
            this.MålB});
            this.dataGridView1.Location = new System.Drawing.Point(119, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Hemmalag
            // 
            this.Hemmalag.HeaderText = "Hemmalag";
            this.Hemmalag.Name = "Hemmalag";
            this.Hemmalag.ReadOnly = true;
            // 
            // Bortalag
            // 
            this.Bortalag.HeaderText = "Bortalag";
            this.Bortalag.Name = "Bortalag";
            this.Bortalag.ReadOnly = true;
            // 
            // målH
            // 
            this.målH.HeaderText = "Mål (H)";
            this.målH.Name = "målH";
            this.målH.ReadOnly = true;
            // 
            // MålB
            // 
            this.MålB.HeaderText = "Mål (B)";
            this.MålB.Name = "MålB";
            this.MålB.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemmalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn målH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MålB;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

