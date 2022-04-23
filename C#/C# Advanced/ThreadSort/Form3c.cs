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

    public class Form3c : Form {
        ProgressBar[] pBar = new ProgressBar[15];
        public Form3c() {

            int rowHeight = 10;
            int spaceBetweenRows = 10;
            int rowWidth = 300;

           
            for (int i = 0; i <= 14; i++) {
               
                pBar[i] = new System.Windows.Forms.ProgressBar();
                this.pBar[i].Location = new System.Drawing.Point(rowHeight, spaceBetweenRows);
                spaceBetweenRows = spaceBetweenRows + 25;
                this.pBar[i].Name = "pBar" + i;
                this.pBar[i].Size = new System.Drawing.Size(rowWidth, 23);
                this.pBar[i].TabIndex = i;
                this.Controls.Add(this.pBar[i]);
                this.ClientSize = new System.Drawing.Size(rowWidth + 20, spaceBetweenRows + 10);
            }


            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }



    }



}
