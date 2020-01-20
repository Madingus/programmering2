namespace övning3._6
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
            this.ribxResult = new System.Windows.Forms.RichTextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.rbnLeft = new System.Windows.Forms.RadioButton();
            this.rbnMiddle = new System.Windows.Forms.RadioButton();
            this.rbnRight = new System.Windows.Forms.RadioButton();
            this.rbnColor = new System.Windows.Forms.RadioButton();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // ribxResult
            // 
            this.ribxResult.Location = new System.Drawing.Point(12, 104);
            this.ribxResult.Name = "ribxResult";
            this.ribxResult.Size = new System.Drawing.Size(776, 334);
            this.ribxResult.TabIndex = 0;
            this.ribxResult.Text = "";
            this.ribxResult.TextChanged += new System.EventHandler(this.RibxResult_TextChanged);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(12, 43);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Teckensnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // rbnLeft
            // 
            this.rbnLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnLeft.AutoSize = true;
            this.rbnLeft.Location = new System.Drawing.Point(174, 43);
            this.rbnLeft.Name = "rbnLeft";
            this.rbnLeft.Size = new System.Drawing.Size(32, 23);
            this.rbnLeft.TabIndex = 2;
            this.rbnLeft.TabStop = true;
            this.rbnLeft.Text = "<---";
            this.rbnLeft.UseVisualStyleBackColor = true;
            this.rbnLeft.CheckedChanged += new System.EventHandler(this.RbnLeft_CheckedChanged);
            // 
            // rbnMiddle
            // 
            this.rbnMiddle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnMiddle.AutoSize = true;
            this.rbnMiddle.Location = new System.Drawing.Point(239, 43);
            this.rbnMiddle.Name = "rbnMiddle";
            this.rbnMiddle.Size = new System.Drawing.Size(35, 23);
            this.rbnMiddle.TabIndex = 3;
            this.rbnMiddle.TabStop = true;
            this.rbnMiddle.Text = "<-->";
            this.rbnMiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbnMiddle.UseVisualStyleBackColor = true;
            this.rbnMiddle.CheckedChanged += new System.EventHandler(this.RbnMiddle_CheckedChanged);
            // 
            // rbnRight
            // 
            this.rbnRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnRight.AutoSize = true;
            this.rbnRight.Location = new System.Drawing.Point(313, 43);
            this.rbnRight.Name = "rbnRight";
            this.rbnRight.Size = new System.Drawing.Size(29, 23);
            this.rbnRight.TabIndex = 4;
            this.rbnRight.TabStop = true;
            this.rbnRight.Text = "-->";
            this.rbnRight.UseVisualStyleBackColor = true;
            this.rbnRight.CheckedChanged += new System.EventHandler(this.RbnRight_CheckedChanged);
            // 
            // rbnColor
            // 
            this.rbnColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnColor.AutoSize = true;
            this.rbnColor.BackColor = System.Drawing.Color.Lime;
            this.rbnColor.ForeColor = System.Drawing.Color.Crimson;
            this.rbnColor.Location = new System.Drawing.Point(382, 43);
            this.rbnColor.Name = "rbnColor";
            this.rbnColor.Size = new System.Drawing.Size(23, 23);
            this.rbnColor.TabIndex = 5;
            this.rbnColor.TabStop = true;
            this.rbnColor.Text = "  ";
            this.rbnColor.UseVisualStyleBackColor = false;
            this.rbnColor.CheckedChanged += new System.EventHandler(this.RbnColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbnColor);
            this.Controls.Add(this.rbnRight);
            this.Controls.Add(this.rbnMiddle);
            this.Controls.Add(this.rbnLeft);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.ribxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ribxResult;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.RadioButton rbnLeft;
        private System.Windows.Forms.RadioButton rbnMiddle;
        private System.Windows.Forms.RadioButton rbnRight;
        private System.Windows.Forms.RadioButton rbnColor;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

