namespace övning5._3_TCP_Klient
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerAdress = new System.Windows.Forms.TextBox();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klient";
            // 
            // tbxInbox
            // 
            this.tbxInbox.Location = new System.Drawing.Point(105, 130);
            this.tbxInbox.Multiline = true;
            this.tbxInbox.Name = "tbxInbox";
            this.tbxInbox.Size = new System.Drawing.Size(197, 85);
            this.tbxInbox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inkorg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Serverns portnummer";
            // 
            // tbxServerAdress
            // 
            this.tbxServerAdress.Location = new System.Drawing.Point(202, 62);
            this.tbxServerAdress.Name = "tbxServerAdress";
            this.tbxServerAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxServerAdress.TabIndex = 19;
            // 
            // btnRecieve
            // 
            this.btnRecieve.Enabled = false;
            this.btnRecieve.Location = new System.Drawing.Point(71, 247);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(231, 30);
            this.btnRecieve.TabIndex = 18;
            this.btnRecieve.Text = "skicka";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.BtnRecieve_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(218, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxInbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxServerAdress);
            this.Controls.Add(this.btnRecieve);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerAdress;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.Button btnConnect;
    }
}

