using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program5b {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Mainx() {
            int temp;
            Random rnd = new Random();
            int[] data = new int[15];
            Form5b formular = new Form5b(data);
           

            for (int z = 0; z < data.Length; z++) 
                data[z] = rnd.Next(0, 101);
           
            formular.Show();

            for (int j = 0; j <= data.Length - 2; j++) {
                for (int i = 0; i <= data.Length - 2; i++) {
                    if (data[i] > data[i + 1]) {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                        
                        
                        formular.showData();
                        System.Threading.Thread.Sleep(100);
                    }
                    
                }
                
            }

            System.Threading.Thread.Sleep(1000);



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form5b(data));

            //Application.Run(formular);

            System.Threading.Thread.Sleep(2000);

        }
    }
}
