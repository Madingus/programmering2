namespace övning3._3
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
            this.components = new System.ComponentModel.Container();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontigareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontigastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.ContextMenuStrip = this.contextMenuStrip1;
            this.btnFont.Location = new System.Drawing.Point(231, 179);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(338, 185);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "välj font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnFolder
            // 
            this.btnFolder.ContextMenuStrip = this.contextMenuStrip1;
            this.btnFolder.Location = new System.Drawing.Point(231, 134);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Text = "välj mapp";
            this.btnFolder.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btnColor.Location = new System.Drawing.Point(231, 86);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "välj en färg";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.fontigareToolStripMenuItem,
            this.fontigastToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // fontigareToolStripMenuItem
            // 
            this.fontigareToolStripMenuItem.Name = "fontigareToolStripMenuItem";
            this.fontigareToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fontigareToolStripMenuItem.Text = "Fontigare";
            // 
            // fontigastToolStripMenuItem
            // 
            this.fontigastToolStripMenuItem.Name = "fontigastToolStripMenuItem";
            this.fontigastToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fontigastToolStripMenuItem.Text = "Fontigast";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(661, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontigareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontigastToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

