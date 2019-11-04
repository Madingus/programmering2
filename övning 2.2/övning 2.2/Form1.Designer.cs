namespace övning_2._2
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
            this.tbxFörsäljareNamn = new System.Windows.Forms.TextBox();
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSäljare = new System.Windows.Forms.Button();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxLön = new System.Windows.Forms.ListBox();
            this.btnKonsult = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKontorist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFörsäljareProvision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFörsäljareFörsäljning = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxKonsultArbetadTid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxKonsultLön = new System.Windows.Forms.TextBox();
            this.tbxKonsultNamn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxKontoristMånadslön = new System.Windows.Forms.TextBox();
            this.tbxKontoristNamn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFörsäljareNamn
            // 
            this.tbxFörsäljareNamn.Location = new System.Drawing.Point(75, 35);
            this.tbxFörsäljareNamn.Name = "tbxFörsäljareNamn";
            this.tbxFörsäljareNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFörsäljareNamn.TabIndex = 0;
            // 
            // gbx1
            // 
            this.gbx1.Controls.Add(this.label5);
            this.gbx1.Controls.Add(this.tbxFörsäljareFörsäljning);
            this.gbx1.Controls.Add(this.label4);
            this.gbx1.Controls.Add(this.tbxFörsäljareProvision);
            this.gbx1.Controls.Add(this.label1);
            this.gbx1.Controls.Add(this.tbxFörsäljareNamn);
            this.gbx1.Controls.Add(this.btnSäljare);
            this.gbx1.Location = new System.Drawing.Point(8, 8);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(217, 210);
            this.gbx1.TabIndex = 1;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Försäljare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // btnSäljare
            // 
            this.btnSäljare.Location = new System.Drawing.Point(56, 172);
            this.btnSäljare.Name = "btnSäljare";
            this.btnSäljare.Size = new System.Drawing.Size(128, 23);
            this.btnSäljare.TabIndex = 1;
            this.btnSäljare.Text = "Registrera försäljning";
            this.btnSäljare.UseVisualStyleBackColor = true;
            this.btnSäljare.Click += new System.EventHandler(this.BtnSäljare_Click);
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(19, 272);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(120, 95);
            this.lbxReg.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnKonsult);
            this.groupBox2.Controls.Add(this.tbxKonsultArbetadTid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxKonsultNamn);
            this.groupBox2.Controls.Add(this.tbxKonsultLön);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konsult";
            // 
            // lbxLön
            // 
            this.lbxLön.FormattingEnabled = true;
            this.lbxLön.Location = new System.Drawing.Point(319, 272);
            this.lbxLön.Name = "lbxLön";
            this.lbxLön.Size = new System.Drawing.Size(120, 95);
            this.lbxLön.TabIndex = 2;
            // 
            // btnKonsult
            // 
            this.btnKonsult.Location = new System.Drawing.Point(55, 168);
            this.btnKonsult.Name = "btnKonsult";
            this.btnKonsult.Size = new System.Drawing.Size(126, 23);
            this.btnKonsult.TabIndex = 1;
            this.btnKonsult.Text = "Registrera Arbetspass";
            this.btnKonsult.UseVisualStyleBackColor = true;
            this.btnKonsult.Click += new System.EventHandler(this.BtnKonsult_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnKontorist);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbxKontoristNamn);
            this.groupBox3.Controls.Add(this.tbxKontoristMånadslön);
            this.groupBox3.Location = new System.Drawing.Point(558, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 210);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontorist";
            // 
            // btnKontorist
            // 
            this.btnKontorist.Location = new System.Drawing.Point(72, 168);
            this.btnKontorist.Name = "btnKontorist";
            this.btnKontorist.Size = new System.Drawing.Size(75, 23);
            this.btnKontorist.TabIndex = 1;
            this.btnKontorist.Text = "Kontorist";
            this.btnKontorist.UseVisualStyleBackColor = true;
            this.btnKontorist.Click += new System.EventHandler(this.BtnKontorist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Provision";
            // 
            // tbxFörsäljareProvision
            // 
            this.tbxFörsäljareProvision.Location = new System.Drawing.Point(75, 78);
            this.tbxFörsäljareProvision.Name = "tbxFörsäljareProvision";
            this.tbxFörsäljareProvision.Size = new System.Drawing.Size(100, 20);
            this.tbxFörsäljareProvision.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Försäljning";
            // 
            // tbxFörsäljareFörsäljning
            // 
            this.tbxFörsäljareFörsäljning.Location = new System.Drawing.Point(75, 120);
            this.tbxFörsäljareFörsäljning.Name = "tbxFörsäljareFörsäljning";
            this.tbxFörsäljareFörsäljning.Size = new System.Drawing.Size(100, 20);
            this.tbxFörsäljareFörsäljning.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Arbetad tid";
            // 
            // tbxKonsultArbetadTid
            // 
            this.tbxKonsultArbetadTid.Location = new System.Drawing.Point(81, 116);
            this.tbxKonsultArbetadTid.Name = "tbxKonsultArbetadTid";
            this.tbxKonsultArbetadTid.Size = new System.Drawing.Size(100, 20);
            this.tbxKonsultArbetadTid.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Timlön";
            // 
            // tbxKonsultLön
            // 
            this.tbxKonsultLön.Location = new System.Drawing.Point(81, 74);
            this.tbxKonsultLön.Name = "tbxKonsultLön";
            this.tbxKonsultLön.Size = new System.Drawing.Size(100, 20);
            this.tbxKonsultLön.TabIndex = 9;
            // 
            // tbxKonsultNamn
            // 
            this.tbxKonsultNamn.Location = new System.Drawing.Point(81, 31);
            this.tbxKonsultNamn.Name = "tbxKonsultNamn";
            this.tbxKonsultNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxKonsultNamn.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Månadslön";
            // 
            // tbxKontoristMånadslön
            // 
            this.tbxKontoristMånadslön.Location = new System.Drawing.Point(92, 77);
            this.tbxKontoristMånadslön.Name = "tbxKontoristMånadslön";
            this.tbxKontoristMånadslön.Size = new System.Drawing.Size(100, 20);
            this.tbxKontoristMånadslön.TabIndex = 15;
            // 
            // tbxKontoristNamn
            // 
            this.tbxKontoristNamn.Location = new System.Drawing.Point(92, 34);
            this.tbxKontoristNamn.Name = "tbxKontoristNamn";
            this.tbxKontoristNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxKontoristNamn.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lönebetalningar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total lönekostnad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Namn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Namn";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(582, 337);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Beräkna löner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxLön);
            this.Controls.Add(this.lbxReg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFörsäljareNamn;
        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFörsäljareFörsäljning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFörsäljareProvision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSäljare;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKonsult;
        private System.Windows.Forms.TextBox tbxKonsultArbetadTid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxKonsultNamn;
        private System.Windows.Forms.TextBox tbxKonsultLön;
        private System.Windows.Forms.ListBox lbxLön;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKontorist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxKontoristNamn;
        private System.Windows.Forms.TextBox tbxKontoristMånadslön;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
    }
}

