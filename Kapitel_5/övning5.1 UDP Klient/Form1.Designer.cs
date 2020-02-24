namespace övning5._1_UDP_Klient
{
    partial class Form1Klient
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
            this.tbxServerIpAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxServerPortnummer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxServerIpAdress
            // 
            this.tbxServerIpAdress.Location = new System.Drawing.Point(136, 32);
            this.tbxServerIpAdress.Name = "tbxServerIpAdress";
            this.tbxServerIpAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxServerIpAdress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serverns IP - adress";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(10, 264);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(231, 30);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serverns portnummer";
            // 
            // tbxServerPortnummer
            // 
            this.tbxServerPortnummer.Location = new System.Drawing.Point(136, 79);
            this.tbxServerPortnummer.Name = "tbxServerPortnummer";
            this.tbxServerPortnummer.Size = new System.Drawing.Size(100, 20);
            this.tbxServerPortnummer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Utkorg";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(34, 167);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(183, 91);
            this.tbxMessage.TabIndex = 7;
            // 
            // Form1Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxServerPortnummer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxServerIpAdress);
            this.Name = "Form1Klient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxServerIpAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxServerPortnummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMessage;
    }
}

