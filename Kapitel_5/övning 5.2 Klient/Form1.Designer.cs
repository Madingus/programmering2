namespace övning_5._2_Klient
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
            this.tbxServerAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.tbxKlientMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxServerAdress
            // 
            this.tbxServerAdress.Location = new System.Drawing.Point(235, 91);
            this.tbxServerAdress.Name = "tbxServerAdress";
            this.tbxServerAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxServerAdress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serverns IP-Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Klient";
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(260, 117);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(75, 23);
            this.btnSayHi.TabIndex = 15;
            this.btnSayHi.Text = "Anslut";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.BtnSayHi_Click);
            // 
            // tbxKlientMessage
            // 
            this.tbxKlientMessage.Location = new System.Drawing.Point(59, 144);
            this.tbxKlientMessage.Multiline = true;
            this.tbxKlientMessage.Name = "tbxKlientMessage";
            this.tbxKlientMessage.Size = new System.Drawing.Size(182, 83);
            this.tbxKlientMessage.TabIndex = 16;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(91, 233);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(119, 23);
            this.btnSendMessage.TabIndex = 17;
            this.btnSendMessage.Text = "Skicka meddelande";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbxKlientMessage);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxServerAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxServerAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.TextBox tbxKlientMessage;
        private System.Windows.Forms.Button btnSendMessage;
    }
}

