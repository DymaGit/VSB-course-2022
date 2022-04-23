using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program7 {
        public static int[] data1 = new int[15];
        public static int[] data2 = new int[15];

        public static Form7 formular1 = new Form7(data1);
        public static Form7 formular2 = new Form7(data2);
        public static int counterIn = 0;
        public static int counterOut = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {

            bubbleSortOptim();
            bubbleSortSimple();

           

            Console.WriteLine("vnitřní smyčka: " + counterIn + "   vnější smyčka: " + counterOut);

            System.Threading.Thread.Sleep(500);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        public static void bubbleSortOptim() {
            int uschovna;
            Random rnd = new Random();
            int lastSwapIndex = data1.Length;
            int currentSwapIndex;


            for (int z = 0; z < data1.Length; z++) {
                data1[z] = rnd.Next(0, 101);
                data2[z] = data1[z];
            }

            formular1.Show();
            formular1.Location = new System.Drawing.Point(50, 50);
            //formular2.StartPosition = FormStartPosition.CenterScreen;

            formular2.Show();
            formular2.Location = new System.Drawing.Point(formular1.Width + 40, 50);
            do {
                currentSwapIndex = 0;
                for (int i = 0; i < lastSwapIndex - 1; i++) {

                    if (data1[i] > data1[i + 1]) {

                        uschovna = data1[i];
                        data1[i] = data1[i + 1];
                        data1[i + 1] = uschovna;
                        currentSwapIndex = i + 1;

                    }
                    formular1.showData(i, i + 1);
                    System.Threading.Thread.Sleep(30);
                    counterIn++;
                }
                lastSwapIndex = currentSwapIndex;

                counterOut++;
            } while (lastSwapIndex > 0);
        }





        public static void bubbleSortSimple() {
            int uschovna;
            //Random rnd = new Random();


            //for (int z = 0; z < data2.Length; z++)
            //    data2[z] = rnd.Next(0, 101);



            for (int j = 0; j < data2.Length - 1; j++) {
                for (int i = 0; i < data2.Length - 1; i++) {

                    if (data2[i] > data2[i + 1]) {

                        uschovna = data2[i];
                        data2[i] = data2[i + 1];
                        data2[i + 1] = uschovna;

                    }
                    formular2.showData(i, i + 1);
                    System.Threading.Thread.Sleep(30);
                    counterIn++;
                }
                counterOut++;
            }
        }

    }
}
