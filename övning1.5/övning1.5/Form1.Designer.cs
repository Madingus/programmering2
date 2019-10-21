namespace övning1._5
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
            this.tbxReg = new System.Windows.Forms.TextBox();
            this.rbxCar = new System.Windows.Forms.RadioButton();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMark = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.comboBoxDrop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbxMC = new System.Windows.Forms.RadioButton();
            this.rbxAll = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxReg
            // 
            this.tbxReg.Location = new System.Drawing.Point(100, 116);
            this.tbxReg.Name = "tbxReg";
            this.tbxReg.Size = new System.Drawing.Size(100, 20);
            this.tbxReg.TabIndex = 0;
            // 
            // rbxCar
            // 
            this.rbxCar.AutoSize = true;
            this.rbxCar.Location = new System.Drawing.Point(402, 346);
            this.rbxCar.Name = "rbxCar";
            this.rbxCar.Size = new System.Drawing.Size(45, 17);
            this.rbxCar.TabIndex = 1;
            this.rbxCar.Text = "Bilar";
            this.rbxCar.UseVisualStyleBackColor = true;
            this.rbxCar.CheckedChanged += new System.EventHandler(this.RbxAll_CheckedChanged);
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(306, 96);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(224, 186);
            this.lbxReg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reg-nr";
            // 
            // tbxMark
            // 
            this.tbxMark.Location = new System.Drawing.Point(100, 168);
            this.tbxMark.Name = "tbxMark";
            this.tbxMark.Size = new System.Drawing.Size(100, 20);
            this.tbxMark.TabIndex = 4;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(100, 217);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 5;
            // 
            // comboBoxDrop
            // 
            this.comboBoxDrop.FormattingEnabled = true;
            this.comboBoxDrop.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.comboBoxDrop.Location = new System.Drawing.Point(100, 261);
            this.comboBoxDrop.Name = "comboBoxDrop";
            this.comboBoxDrop.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDrop.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "typ";
            // 
            // rbxMC
            // 
            this.rbxMC.AutoSize = true;
            this.rbxMC.Location = new System.Drawing.Point(510, 346);
            this.rbxMC.Name = "rbxMC";
            this.rbxMC.Size = new System.Drawing.Size(41, 17);
            this.rbxMC.TabIndex = 10;
            this.rbxMC.Text = "MC";
            this.rbxMC.UseVisualStyleBackColor = true;
            this.rbxMC.CheckedChanged += new System.EventHandler(this.RbxAll_CheckedChanged);
            // 
            // rbxAll
            // 
            this.rbxAll.AutoSize = true;
            this.rbxAll.Checked = true;
            this.rbxAll.Location = new System.Drawing.Point(292, 346);
            this.rbxAll.Name = "rbxAll";
            this.rbxAll.Size = new System.Drawing.Size(42, 17);
            this.rbxAll.TabIndex = 11;
            this.rbxAll.TabStop = true;
            this.rbxAll.Text = "Alla";
            this.rbxAll.UseVisualStyleBackColor = true;
            this.rbxAll.CheckedChanged += new System.EventHandler(this.RbxAll_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(90, 332);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 45);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rbxAll);
            this.Controls.Add(this.rbxMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDrop);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxReg);
            this.Controls.Add(this.rbxCar);
            this.Controls.Add(this.tbxReg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReg;
        private System.Windows.Forms.RadioButton rbxCar;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMark;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.ComboBox comboBoxDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbxMC;
        private System.Windows.Forms.RadioButton rbxAll;
        private System.Windows.Forms.Button btnRegister;
    }
}

