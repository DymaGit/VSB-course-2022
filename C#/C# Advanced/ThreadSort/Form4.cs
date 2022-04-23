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

    public class Form4 : Form {
        ProgressBar[] pBar = new ProgressBar[15];
        public Form4(int[] data) {

            int rowHeight = 10;
            int spaceBetweenRows = 10;
            int rowWidth = 300;


            for (int i = 0; i <= pBar.Length-1; i++) {

                pBar[i] = new System.Windows.Forms.ProgressBar();
                pBar[i].Location = new System.Drawing.Point(rowHeight, spaceBetweenRows);
                spaceBetweenRows = spaceBetweenRows + 25;
                pBar[i].Name = "pBar" + i;
                pBar[i].Size = new System.Drawing.Size(rowWidth, 23);
                pBar[i].TabIndex = i;
                this.Controls.Add(pBar[i]);
                pBar[i].Value = data[i]; // form1-3d data[i] > i + 1
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
