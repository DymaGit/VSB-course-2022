using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ThreadSort {
    internal static class Program8b {
        private static int[] data1 = new int[15];
        private static int[] data2 = new int[15];
        private static int uschovna;


        private static int currentSwapIndex;
        private static int lastSwapIndex = data1.Length;

        private static Form7 formular1 = new Form7(data1);
        private static Form7 formular2 = new Form7(data2);
        //private static int counterIn = 0;
        //private static int counterOut = 0;
        private static Thread thread1;
        private static Thread thread2;
        private static bool ready1 = false;
        private static bool ready2 = false;
        private static bool konec1 = false;
        private static bool konec2 = false;

        private static int indexA;
        private static int indexB;
        private static int indexC;
        private static int indexD;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
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

            //str 106


            while (!konec1 || !konec2) {
                formular2.showData(indexC, indexD);
                formular1.showData(indexA, indexB);
                do {

                    Thread.Sleep(30);


                } while (!ready1 || !ready2);

                Thread.Sleep(10);
                if (!konec1) thread1.Resume();
                if (!konec2) thread2.Resume();
            }

            System.Threading.Thread.Sleep(500);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

        }

        [Obsolete]
        public static void bubbleSortOptim() {
            do {
                currentSwapIndex = 0;

                for (int i = 0; i < lastSwapIndex - 1; i++) {
                    ready2 = false;
                    if (data1[i] > data1[i + 1]) {

                        uschovna = data1[i];
                        data1[i] = data1[i + 1];
                        data1[i + 1] = uschovna;
                        currentSwapIndex = i + 1;

                    }

                    // formular1.showData(i, i + 1);
                    System.Threading.Thread.Sleep(10);
                    indexC = i;
                    indexD = i + 1;
                    //counterIn++;
                    ready2 = true;
                    thread2.Suspend();

                }
                lastSwapIndex = currentSwapIndex;
                //counterOut++;


            } while (lastSwapIndex > 0);
            konec2 = true;
        }

        [Obsolete]
        public static void bubbleSortSimple() {
            int uschovna;

            for (int j = 0; j < data2.Length - 1; j++) {

                for (int i = 0; i < data2.Length - 1; i++) {
                    ready1 = false;

                    if (data2[i] > data2[i + 1]) {

                        uschovna = data2[i];
                        data2[i] = data2[i + 1];
                        data2[i + 1] = uschovna;

                    }

                    //formular2.showData(i, i + 1);
                    System.Threading.Thread.Sleep(10);
                    indexA = i;
                    indexB = i + 1;

                    //counterIn++;
                    ready1 = true;
                    thread1.Suspend();

                }
                //counterOut++;


            }
            konec1 = true;
        }

    }
}
