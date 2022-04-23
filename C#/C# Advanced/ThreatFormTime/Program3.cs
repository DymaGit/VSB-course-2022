using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreatFormTime {
    internal static class Program3 {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            implementation.Clock c1 = new implementation.Clock();

            

            
            Thread t1 = new Thread(new ThreadStart(c1.loop));
            t1.Start();
            ControlPanel2 op = new ControlPanel2(c1);
            Application.Run(op);

            t1.Abort();
            //Thread.Sleep(1000);

            //c1.loop();





        }
    }
}
