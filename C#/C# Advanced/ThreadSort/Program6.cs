using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program6 {
        public static int[] data = new int[15];
        public static Form6 formular = new Form6(data);
        public static int counterIn = 0;
        public static int counterOut = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {

            bubbleSortSimple();


            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);

            Console.WriteLine("vnitřní smyčka: " + counterIn + "   vnější smyčka: " + counterOut);
            System.Threading.Thread.Sleep(3000);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        public static void bubbleSortSimple() {
            int uschovna;
            Random rnd = new Random();


            for (int z = 0; z < data.Length; z++)
                data[z] = rnd.Next(0, 101);

            formular.Show();

            for (int j = 0; j < data.Length - 1; j++) {
                for (int i = 0; i < data.Length - 1; i++) {

                    if (data[i] > data[i + 1]) {

                        uschovna = data[i];
                        data[i] = data[i+1];
                        data[i+1] = uschovna;

                    }
                    formular.showData(i, i + 1);
                    System.Threading.Thread.Sleep(30);
                    counterIn++;
                }
                counterOut++;
            }
        }
    }
}
