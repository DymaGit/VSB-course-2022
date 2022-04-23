using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreatFormTime
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx()
        {
         

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlPanel());

            implementation.Clock c1 = new implementation.Clock();
            c1.loop();

            //Thread t1 = new Thread(new ThreadStart(c1.loop));
            //t1.Start();
      


        }
    }
}
