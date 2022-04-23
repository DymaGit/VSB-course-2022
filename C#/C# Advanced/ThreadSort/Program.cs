using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            Random rnd = new Random();
            int[] data = new int[15];
            for (int i = 0; i < data.Length; i++) { 
            data[i] = rnd.Next(0, 101);
            
            
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4(data)); // kdbych chtěl použít form1-3d musel bych smazat "data"
     

        }
    }
}
