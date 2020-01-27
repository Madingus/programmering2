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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnMålrikast = new System.Windows.Forms.Button();
            this.tbxMålrikast = new System.Windows.Forms.TextBox();
            this.dvgMatcher = new System.Windows.Forms.DataGridView();
            this.Hemmalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MålA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MålB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnMålrikast
            // 
            this.btnMålrikast.Location = new System.Drawing.Point(131, 398);
            this.btnMålrikast.Name = "btnMålrikast";
            this.btnMålrikast.Size = new System.Drawing.Size(75, 23);
            this.btnMålrikast.TabIndex = 1;
            this.btnMålrikast.Text = "button1";
            this.btnMålrikast.UseVisualStyleBackColor = true;
            // 
            // tbxMålrikast
            // 
            this.tbxMålrikast.Location = new System.Drawing.Point(277, 401);
            this.tbxMålrikast.Name = "tbxMålrikast";
            this.tbxMålrikast.Size = new System.Drawing.Size(100, 20);
            this.tbxMålrikast.TabIndex = 2;
            // 
            // dvgMatcher
            // 
            this.dvgMatcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMatcher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hemmalag,
            this.Bortalag,
            this.MålA,
            this.MålB});
            this.dvgMatcher.Location = new System.Drawing.Point(131, 131);
            this.dvgMatcher.Name = "dvgMatcher";
            this.dvgMatcher.Size = new System.Drawing.Size(446, 186);
            this.dvgMatcher.TabIndex = 3;
            // 
            // Hemmalag
            // 
            this.Hemmalag.HeaderText = "Hemmalag";
            this.Hemmalag.Name = "Hemmalag";
            // 
            // Bortalag
            // 
            this.Bortalag.HeaderText = "Bortalag";
            this.Bortalag.Name = "Bortalag";
            // 
            // MålA
            // 
            this.MålA.HeaderText = "Mål(A)";
            this.MålA.Name = "MålA";
            // 
            // MålB
            // 
            this.MålB.HeaderText = "Mål(B)";
            this.MålB.Name = "MålB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgMatcher);
            this.Controls.Add(this.tbxMålrikast);
            this.Controls.Add(this.btnMålrikast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tbxMålrikast;
        private System.Windows.Forms.Button btnMålrikast;
        private System.Windows.Forms.DataGridView dvgMatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemmalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn MålA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MålB;
    }
}

