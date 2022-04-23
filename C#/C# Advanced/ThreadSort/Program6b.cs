using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program6b {
        //public static int[] data = new int[15];
        public static int[] data = { 20, 50, 70, 40, 60, 70, 80, 90 };
        public static Form6b formular = new Form6b(data);
        public static int counterIn = 0;
        public static int counterOut = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {

            bubbleSort();


            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);

            Console.WriteLine("vnitřní smyčka: "+ counterIn + "   vnější smyčka: " + counterOut);

            System.Threading.Thread.Sleep(6000);
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        public static void bubbleSort() {
            int uschovna;
            //Random rnd = new Random();
            bool swapOccured;
            

            //for (int z = 0; z < data.Length; z++)
            //    data[z] = rnd.Next(0, 101);

            formular.Show();

            do {
                swapOccured = false;
                for (int i = 0; i < data.Length - 1; i++) {

                    if (data[i] > data[i + 1]) {

                        uschovna = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = uschovna;
                        swapOccured = true;

                    }
                    formular.showData(i, i + 1);
                    System.Threading.Thread.Sleep(500);
                    counterIn++;
                }
                counterOut++;
            } while (swapOccured);
        }

    }
}
