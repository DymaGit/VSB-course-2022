using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    
    public class Form2 : Form {
        private ProgressBar pBar1;
        private ProgressBar pBar2;
        public Form2() {
         

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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.pBar2);
            this.Controls.Add(this.pBar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }



    }
  


}
