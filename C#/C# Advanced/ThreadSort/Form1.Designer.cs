namespace ThreadSort
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
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.pBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(145, 49);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 23);
            this.pBar1.TabIndex = 0;
            // 
            // pBar2
            // 
            this.pBar2.Location = new System.Drawing.Point(145, 97);
            this.pBar2.Name = "pBar2";
            this.pBar2.Size = new System.Drawing.Size(100, 23);
            this.pBar2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.pBar2);
            this.Controls.Add(this.pBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.ProgressBar pBar2;
    }
}

