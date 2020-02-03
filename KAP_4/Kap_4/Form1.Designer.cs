namespace Kap_4
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
            this.tbxFöre = new System.Windows.Forms.TextBox();
            this.tbxEfter = new System.Windows.Forms.TextBox();
            this.btnErsätt = new System.Windows.Forms.Button();
            this.lbxResultat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFöre
            // 
            this.tbxFöre.Location = new System.Drawing.Point(225, 46);
            this.tbxFöre.Name = "tbxFöre";
            this.tbxFöre.Size = new System.Drawing.Size(100, 20);
            this.tbxFöre.TabIndex = 0;
            // 
            // tbxEfter
            // 
            this.tbxEfter.Location = new System.Drawing.Point(423, 46);
            this.tbxEfter.Name = "tbxEfter";
            this.tbxEfter.Size = new System.Drawing.Size(100, 20);
            this.tbxEfter.TabIndex = 1;
            // 
            // btnErsätt
            // 
            this.btnErsätt.Location = new System.Drawing.Point(630, 43);
            this.btnErsätt.Name = "btnErsätt";
            this.btnErsätt.Size = new System.Drawing.Size(75, 23);
            this.btnErsätt.TabIndex = 2;
            this.btnErsätt.Text = "Ersätt";
            this.btnErsätt.UseVisualStyleBackColor = true;
            // 
            // lbxResultat
            // 
            this.lbxResultat.FormattingEnabled = true;
            this.lbxResultat.Location = new System.Drawing.Point(107, 122);
            this.lbxResultat.Name = "lbxResultat";
            this.lbxResultat.Size = new System.Drawing.Size(636, 316);
            this.lbxResultat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "-->";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.stängToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nyttToolStripMenuItem.Text = "Nytt";
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxResultat);
            this.Controls.Add(this.btnErsätt);
            this.Controls.Add(this.tbxEfter);
            this.Controls.Add(this.tbxFöre);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFöre;
        private System.Windows.Forms.TextBox tbxEfter;
        private System.Windows.Forms.Button btnErsätt;
        private System.Windows.Forms.ListBox lbxResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
    }
}

