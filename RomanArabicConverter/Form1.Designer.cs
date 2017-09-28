namespace RomanArabicConverter
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
            this.tbRomanIn = new System.Windows.Forms.TextBox();
            this.tbArabicIn = new System.Windows.Forms.TextBox();
            this.bRoman = new System.Windows.Forms.Button();
            this.rArabic = new System.Windows.Forms.Button();
            this.tbRomanOut = new System.Windows.Forms.TextBox();
            this.tbArabicOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRomanIn
            // 
            this.tbRomanIn.Location = new System.Drawing.Point(12, 12);
            this.tbRomanIn.Name = "tbRomanIn";
            this.tbRomanIn.Size = new System.Drawing.Size(100, 20);
            this.tbRomanIn.TabIndex = 0;
            // 
            // tbArabicIn
            // 
            this.tbArabicIn.Location = new System.Drawing.Point(172, 12);
            this.tbArabicIn.Name = "tbArabicIn";
            this.tbArabicIn.Size = new System.Drawing.Size(100, 20);
            this.tbArabicIn.TabIndex = 1;
            // 
            // bRoman
            // 
            this.bRoman.Location = new System.Drawing.Point(25, 38);
            this.bRoman.Name = "bRoman";
            this.bRoman.Size = new System.Drawing.Size(75, 23);
            this.bRoman.TabIndex = 2;
            this.bRoman.Text = "Convert Roman";
            this.bRoman.UseVisualStyleBackColor = true;
            // 
            // rArabic
            // 
            this.rArabic.Location = new System.Drawing.Point(186, 38);
            this.rArabic.Name = "rArabic";
            this.rArabic.Size = new System.Drawing.Size(75, 23);
            this.rArabic.TabIndex = 3;
            this.rArabic.Text = "Convert";
            this.rArabic.UseVisualStyleBackColor = true;
            // 
            // tbRomanOut
            // 
            this.tbRomanOut.Location = new System.Drawing.Point(12, 67);
            this.tbRomanOut.Name = "tbRomanOut";
            this.tbRomanOut.Size = new System.Drawing.Size(100, 20);
            this.tbRomanOut.TabIndex = 4;
            // 
            // tbArabicOut
            // 
            this.tbArabicOut.Location = new System.Drawing.Point(172, 67);
            this.tbArabicOut.Name = "tbArabicOut";
            this.tbArabicOut.Size = new System.Drawing.Size(100, 20);
            this.tbArabicOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.tbArabicOut);
            this.Controls.Add(this.tbRomanOut);
            this.Controls.Add(this.rArabic);
            this.Controls.Add(this.bRoman);
            this.Controls.Add(this.tbArabicIn);
            this.Controls.Add(this.tbRomanIn);
            this.Name = "Form1";
            this.Text = "RomanArabicConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRomanIn;
        private System.Windows.Forms.TextBox tbArabicIn;
        private System.Windows.Forms.Button bRoman;
        private System.Windows.Forms.Button rArabic;
        private System.Windows.Forms.TextBox tbRomanOut;
        private System.Windows.Forms.TextBox tbArabicOut;
    }
}

