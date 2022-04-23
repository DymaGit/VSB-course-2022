using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreatFormTime
{
    public partial class ControlPanel2 : Form
    {
        private implementation.Clock c1 = new implementation.Clock();


         public ControlPanel2(implementation.Clock c1) {
            this.c1 = c1;
            InitializeComponent();
        }

        public ControlPanel2()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {

            c1.show();

        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btDoNotShow_Click(object sender, EventArgs e)
        {
            c1.doNotShow();
            

        }
    }
}
