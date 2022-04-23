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
    public partial class ControlPanel : Form
    {
        private implementation.Clock c2 = new implementation.Clock();
       
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {

            c2.show();
           
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDoNotShow_Click(object sender, EventArgs e)
        {
            c2.doNotShow();
            
        }
    }
}
