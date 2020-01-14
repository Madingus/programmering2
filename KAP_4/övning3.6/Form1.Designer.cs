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
            this.rbxResult = new System.Windows.Forms.RichTextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.rbnLeft = new System.Windows.Forms.RadioButton();
            this.rbnMiddle = new System.Windows.Forms.RadioButton();
            this.rbnRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbxResult
            // 
            this.rbxResult.Location = new System.Drawing.Point(12, 104);
            this.rbxResult.Name = "rbxResult";
            this.rbxResult.Size = new System.Drawing.Size(776, 334);
            this.rbxResult.TabIndex = 0;
            this.rbxResult.Text = "";
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
            this.rbnMiddle.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbnRight);
            this.Controls.Add(this.rbnMiddle);
            this.Controls.Add(this.rbnLeft);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.rbxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbxResult;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.RadioButton rbnLeft;
        private System.Windows.Forms.RadioButton rbnMiddle;
        private System.Windows.Forms.RadioButton rbnRight;
    }
}

