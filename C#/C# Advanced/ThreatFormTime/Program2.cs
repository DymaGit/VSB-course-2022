using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreatFormTime
{
    internal static class Program2
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx()
        {
         

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            implementation.Clock c1 = new implementation.Clock();
            Application.Run(new ControlPanel2(c1));
            Thread.Sleep(1000);
            
            c1.loop();
            //Thread t1 = new Thread(new ThreadStart(c1.loop));
            //t1.Start();
      


        }
    }
}
