using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_1
    {
        static void Mainx(string[] args)
        {
            int[] poleuspory = new int[5];
            int[] pole2;
            int[] sub;
            int procenta;

            Console.WriteLine("zadej úspory 5ti osob");
            for (int i = 0; i <= 4; i++)
            {
                poleuspory[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("zadej úrok v procentech");
            procenta = int.Parse(Console.ReadLine());

            pole2 = sporeniF(poleuspory, procenta); //funkce
            sporeniS(poleuspory, procenta,out sub); //subrutina

            for (int i = 0; i <= 4; i++)       //funkce
                Console.WriteLine(pole2[i]);
            for (int i = 0; i <= 4; i++)       //subrutina
                Console.WriteLine(sub[i]);
        }

        static int[] sporeniF(int[] pole, int navyseni) //funkce
        {
            int[] uschovna = new int[pole.Length];

            for (int i = 0; i <= 4; i++)
            {
                uschovna[i] = pole[i] + (pole[i] / 100 * navyseni);
            }
            return uschovna;
        }
        static void sporeniS(int[] pole, int navyseni,out int[] s) //subrutina
        {
            int[] uschovna = new int[pole.Length];

            for (int i = 0; i <= 4; i++)
            {
                uschovna[i] = pole[i] + (pole[i] / 100 * navyseni);
            }
            s = uschovna;
        }
    }
}
