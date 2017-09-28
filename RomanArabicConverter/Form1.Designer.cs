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
            this.tbRoman = new System.Windows.Forms.TextBox();
            this.tbArabic = new System.Windows.Forms.TextBox();
            this.lRoman = new System.Windows.Forms.Label();
            this.lArabic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRoman
            // 
            this.tbRoman.Location = new System.Drawing.Point(12, 33);
            this.tbRoman.Name = "tbRoman";
            this.tbRoman.Size = new System.Drawing.Size(100, 20);
            this.tbRoman.TabIndex = 0;
            this.tbRoman.TextChanged += new System.EventHandler(this.tbRoman_TextChanged);
            // 
            // tbArabic
            // 
            this.tbArabic.Location = new System.Drawing.Point(172, 33);
            this.tbArabic.Name = "tbArabic";
            this.tbArabic.Size = new System.Drawing.Size(100, 20);
            this.tbArabic.TabIndex = 5;
            this.tbArabic.TextChanged += new System.EventHandler(this.tbArabic_TextChanged);
            // 
            // lRoman
            // 
            this.lRoman.AutoSize = true;
            this.lRoman.Location = new System.Drawing.Point(40, 17);
            this.lRoman.Name = "lRoman";
            this.lRoman.Size = new System.Drawing.Size(41, 13);
            this.lRoman.TabIndex = 7;
            this.lRoman.Text = "Roman";
            // 
            // lArabic
            // 
            this.lArabic.AutoSize = true;
            this.lArabic.Location = new System.Drawing.Point(207, 17);
            this.lArabic.Name = "lArabic";
            this.lArabic.Size = new System.Drawing.Size(37, 13);
            this.lArabic.TabIndex = 8;
            this.lArabic.Text = "Arabic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.lArabic);
            this.Controls.Add(this.lRoman);
            this.Controls.Add(this.tbArabic);
            this.Controls.Add(this.tbRoman);
            this.Name = "Form1";
            this.Text = "RomanArabicConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRoman;
        private System.Windows.Forms.TextBox tbArabic;
        private System.Windows.Forms.Label lRoman;
        private System.Windows.Forms.Label lArabic;
    }
}

