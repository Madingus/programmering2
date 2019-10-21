namespace Övning_2._1
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
            this.tbxBokSidor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBok = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxBokTitel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLjudTitel = new System.Windows.Forms.TextBox();
            this.btnLjud = new System.Windows.Forms.Button();
            this.tbxLjudSpeltid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFilmSpeltid = new System.Windows.Forms.TextBox();
            this.tbxFilmTitel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFilmUpplösning = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // tbxBokSidor
            // 
            this.tbxBokSidor.Location = new System.Drawing.Point(104, 120);
            this.tbxBokSidor.Name = "tbxBokSidor";
            this.tbxBokSidor.Size = new System.Drawing.Size(100, 20);
            this.tbxBokSidor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxBokTitel);
            this.groupBox1.Controls.Add(this.btnBok);
            this.groupBox1.Controls.Add(this.tbxBokSidor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bok";
            // 
            // btnBok
            // 
            this.btnBok.Location = new System.Drawing.Point(85, 159);
            this.btnBok.Name = "btnBok";
            this.btnBok.Size = new System.Drawing.Size(148, 23);
            this.btnBok.TabIndex = 3;
            this.btnBok.Text = "Registrera bok";
            this.btnBok.UseVisualStyleBackColor = true;
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(44, 308);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(940, 251);
            this.lbxLista.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxLjudSpeltid);
            this.groupBox2.Controls.Add(this.tbxLjudTitel);
            this.groupBox2.Controls.Add(this.btnLjud);
            this.groupBox2.Location = new System.Drawing.Point(366, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ljudspår";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbxFilmUpplösning);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxFilmSpeltid);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tbxFilmTitel);
            this.groupBox3.Location = new System.Drawing.Point(686, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 198);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film";
            // 
            // tbxBokTitel
            // 
            this.tbxBokTitel.Location = new System.Drawing.Point(104, 76);
            this.tbxBokTitel.Name = "tbxBokTitel";
            this.tbxBokTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxBokTitel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antal sidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Speltid";
            // 
            // tbxLjudTitel
            // 
            this.tbxLjudTitel.Location = new System.Drawing.Point(109, 69);
            this.tbxLjudTitel.Name = "tbxLjudTitel";
            this.tbxLjudTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxLjudTitel.TabIndex = 9;
            // 
            // btnLjud
            // 
            this.btnLjud.Location = new System.Drawing.Point(80, 159);
            this.btnLjud.Name = "btnLjud";
            this.btnLjud.Size = new System.Drawing.Size(129, 23);
            this.btnLjud.TabIndex = 8;
            this.btnLjud.Text = "Registrera ljudspår";
            this.btnLjud.UseVisualStyleBackColor = true;
            // 
            // tbxLjudSpeltid
            // 
            this.tbxLjudSpeltid.Location = new System.Drawing.Point(109, 123);
            this.tbxLjudSpeltid.Name = "tbxLjudSpeltid";
            this.tbxLjudSpeltid.Size = new System.Drawing.Size(100, 20);
            this.tbxLjudSpeltid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Speltid";
            // 
            // tbxFilmSpeltid
            // 
            this.tbxFilmSpeltid.Location = new System.Drawing.Point(127, 99);
            this.tbxFilmSpeltid.Name = "tbxFilmSpeltid";
            this.tbxFilmSpeltid.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmSpeltid.TabIndex = 12;
            // 
            // tbxFilmTitel
            // 
            this.tbxFilmTitel.Location = new System.Drawing.Point(127, 62);
            this.tbxFilmTitel.Name = "tbxFilmTitel";
            this.tbxFilmTitel.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmTitel.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Registrera film";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 55);
            this.label7.TabIndex = 16;
            this.label7.Text = "BIBLIOTEK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Titel";
            // 
            // tbxFilmUpplösning
            // 
            this.tbxFilmUpplösning.Location = new System.Drawing.Point(127, 134);
            this.tbxFilmUpplösning.Name = "tbxFilmUpplösning";
            this.tbxFilmUpplösning.Size = new System.Drawing.Size(100, 20);
            this.tbxFilmUpplösning.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Upplösning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBokSidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBokTitel;
        private System.Windows.Forms.Button btnBok;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLjudSpeltid;
        private System.Windows.Forms.TextBox tbxLjudTitel;
        private System.Windows.Forms.Button btnLjud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxFilmUpplösning;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFilmSpeltid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxFilmTitel;
        private System.Windows.Forms.Label label7;
    }
}

