namespace övning1_4
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
            this.tbxList = new System.Windows.Forms.TextBox();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.cbxUnderline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxList
            // 
            this.tbxList.Location = new System.Drawing.Point(97, 62);
            this.tbxList.Multiline = true;
            this.tbxList.Name = "tbxList";
            this.tbxList.ReadOnly = true;
            this.tbxList.Size = new System.Drawing.Size(240, 113);
            this.tbxList.TabIndex = 0;
            this.tbxList.Text = "What is love? Baby dont hurt me, dont hurt me, no more. dun dun dun dundundun dun" +
    " dun dun dundundun dun dun dundunudn dundu";
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(97, 229);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 1;
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFet.Location = new System.Drawing.Point(129, 288);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(44, 17);
            this.cbxFet.TabIndex = 2;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // cbxKursiv
            // 
            this.cbxKursiv.AutoSize = true;
            this.cbxKursiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKursiv.Location = new System.Drawing.Point(129, 339);
            this.cbxKursiv.Name = "cbxKursiv";
            this.cbxKursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxKursiv.TabIndex = 3;
            this.cbxKursiv.Text = "Kursiv";
            this.cbxKursiv.UseVisualStyleBackColor = true;
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Location = new System.Drawing.Point(237, 229);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 20);
            this.tbxStorlek.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teckensnitt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Textstorlek";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(325, 298);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 7;
            this.btnKör.Text = "OK";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.BtnKör_Click);
            // 
            // cbxUnderline
            // 
            this.cbxUnderline.AutoSize = true;
            this.cbxUnderline.Location = new System.Drawing.Point(129, 311);
            this.cbxUnderline.Name = "cbxUnderline";
            this.cbxUnderline.Size = new System.Drawing.Size(77, 17);
            this.cbxUnderline.TabIndex = 8;
            this.cbxUnderline.Text = "Underlined";
            this.cbxUnderline.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxUnderline);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.tbxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxList;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.TextBox tbxStorlek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.CheckBox cbxUnderline;
    }
}

