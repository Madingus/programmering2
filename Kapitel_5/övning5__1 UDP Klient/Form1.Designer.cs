namespace övning5__1_UDP_Klient
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIpAdress = new System.Windows.Forms.TextBox();
            this.tbxServerPortnummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(77, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Ip-Adress";
            // 
            // tbxIpAdress
            // 
            this.tbxIpAdress.Location = new System.Drawing.Point(110, 95);
            this.tbxIpAdress.Name = "tbxIpAdress";
            this.tbxIpAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxIpAdress.TabIndex = 2;
            // 
            // tbxServerPortnummer
            // 
            this.tbxServerPortnummer.Location = new System.Drawing.Point(110, 139);
            this.tbxServerPortnummer.Name = "tbxServerPortnummer";
            this.tbxServerPortnummer.Size = new System.Drawing.Size(100, 20);
            this.tbxServerPortnummer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servern portnummer";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(52, 185);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(158, 93);
            this.tbxMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxServerPortnummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxIpAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIpAdress;
        private System.Windows.Forms.TextBox tbxServerPortnummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMessage;
    }
}

