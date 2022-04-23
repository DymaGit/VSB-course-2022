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

    public class Form3bb : Form {


        public Form3bb() {

            int rowHeight = 10;
            int spaceBetweenRows = 10;


            for (int i = 0; i <= 14; i++) {
                ProgressBar pBar = new ProgressBar();
                pBar = new ProgressBar();
                pBar.Location = new Point(rowHeight, spaceBetweenRows);
                spaceBetweenRows = spaceBetweenRows + 25;
                pBar.Name = "pBar" + i;
                pBar.Size = new Size(300, 23);
                pBar.TabIndex = i;
                Controls.Add(pBar);

            }


            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 400);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }



    }



}
