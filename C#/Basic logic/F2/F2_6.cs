using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_6
    {
        static void Mainx(string[] args)
        {
            int[] pole1 = new int[19];
            int[] polevystup;
            int[] sub;
            string vypis2 = "";
            string vypis1 = "";
            string vypis3 = "";
            Random r = new Random();

            for (int i = 0; i <= 18; i++)
            {
                pole1[i] = r.Next(1, 11);
                vypis1 = vypis1 + pole1[i] + " ";
            }
            polevystup = sudacislazpoleF(pole1); //funkce
            sudacislazpoleS(pole1,out sub); //subrutina

            foreach (int i in polevystup) //funkce
            {
                if (i != 0)
                    vypis2 = vypis2 + i + " ";
            }
            Console.WriteLine("padlé čísla: {0} \npouze sudá čísla: {1}", vypis1, vypis2);

            foreach (int i in sub) //subrutina
            {
                if (i != 0)
                    vypis3 = vypis3 + i + " ";
            }
            Console.WriteLine("padlé čísla: {0} \npouze sudá čísla: {1}", vypis1, vypis3);
        }
        static int[] sudacislazpoleF(int[] p)
        {
            int[] sude = new int[19];

            for (int i = 0; i <= 18; i++)
            {
                if (p[i] % 2 == 0)
                    sude[i] = p[i];
            }
            return sude;
        }

        static void sudacislazpoleS(int[] p, out int[] s)
        {
            int[] sude = new int[19];

            for (int i = 0; i <= 18; i++)
            {
                if (p[i] % 2 == 0)
                    sude[i] = p[i];
            }
            s = sude;
        }
    }
}
