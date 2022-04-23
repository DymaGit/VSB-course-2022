using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ThreadSort {
    internal static class Program8a {
        public static int[] data1 = new int[15];
        public static int[] data2 = new int[15];
        public static int uschovna;


        public static int currentSwapIndex;
        public static int lastSwapIndex = data1.Length;

        public static Form7 formular1 = new Form7(data1);
        public static Form7 formular2 = new Form7(data2);
        public static int counterIn = 0;
        public static int counterOut = 0;
        private static Thread thread1;
        private static Thread thread2;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            formular1.Show();
            formular1.Location = new System.Drawing.Point(50, 50);

            formular2.Show();
            formular2.Location = new System.Drawing.Point(formular1.Width + 40, 50);

            Random rnd = new Random();
            for (int z = 0; z < data1.Length; z++) {
                data1[z] = rnd.Next(0, 101);
                data2[z] = data1[z];
            }

            thread1 = new Thread(bubbleSortSimple);
            thread2 = new Thread(bubbleSortOptim);
            thread1.Start();
            thread2.Start();
            // bubbleSortOptim();
            // bubbleSortSimple();





            System.Threading.Thread.Sleep(500);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        public static void bubbleSortOptim() {


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
