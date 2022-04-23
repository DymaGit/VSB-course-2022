using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program6c {
        public static int[] data = new int[15];


        public static Form6c formular = new Form6c(data);
        public static int counterIn = 0;
        public static int counterOut = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {

            bubbleSortOptim();


            for (int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]);

            Console.WriteLine("vnitřní smyčka: " + counterIn + "   vnější smyčka: " + counterOut);

            System.Threading.Thread.Sleep(3000);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        public static void bubbleSortOptim() {
            int uschovna;
            Random rnd = new Random();
            int lastSwapIndex = data.Length;
            int currentSwapIndex;


            for (int z = 0; z < data.Length; z++)
                data[z] = rnd.Next(0, 101);

            formular.Show();

            do {
                currentSwapIndex = 0;
                for (int i = 0; i < lastSwapIndex - 1; i++) {

                    if (data[i] > data[i + 1]) {

                        uschovna = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = uschovna;
                        currentSwapIndex = i + 1;

                    }
                    formular.showData(i, i + 1);
                    System.Threading.Thread.Sleep(30);
                    counterIn++;
                }
                lastSwapIndex = currentSwapIndex;

                counterOut++;
            } while (lastSwapIndex > 0);
        }

    }
}
