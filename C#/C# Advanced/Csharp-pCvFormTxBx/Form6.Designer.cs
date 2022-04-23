namespace FormTextBox {
    partial class Form6 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(59, 40);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 23);
            this.tb1.TabIndex = 0;
            this.tb1.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(59, 86);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 23);
            this.tb2.TabIndex = 1;
            this.tb2.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(59, 179);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(100, 23);
            this.tb3.TabIndex = 2;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(59, 136);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(100, 23);
            this.b1.TabIndex = 3;
            this.b1.Text = "sečti";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 230);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button b1;
    }
}
