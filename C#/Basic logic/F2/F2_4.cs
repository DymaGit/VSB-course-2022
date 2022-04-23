using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_4
    {
        static void Mainx(string[] args)
        {
            int[] polecisla = new int[8];
            int cislo;
            int vystup, sub;
            string vypis = "";
            Random r = new Random();

            Console.WriteLine("zadej které číslo tě zajímá");
            cislo = int.Parse(Console.ReadLine());

            for (int i = 0; i <= polecisla.Length - 1; i++)
            {
                polecisla[i] = r.Next(1, 11);
                vypis = vypis + polecisla[i] + " ";
            }
            vystup = pocetvyskytuF(polecisla, cislo); //funkce
            pocetvyskytuS(polecisla, cislo, out sub); //subrutina

            Console.WriteLine("padlé čísla: {0}\nkolikrát padlo zadané číslo: {1}x", vypis, vystup); //funkce
            Console.WriteLine("padlé čísla: {0}\nkolikrát padlo zadané číslo: {1}x", vypis, sub); //subrutina
        }
        static int pocetvyskytuF(int[] policko, int pocet) //funkce
        {
            int x = 0;

            for (int i = 0; i <= policko.Length - 1; i++)
            {
                if (policko[i] == pocet)
                    x += 1;
            }
            return x;
        }

        static void pocetvyskytuS(int[] policko, int pocet, out int s) //subrutina
        {
            int x = 0;

            for (int i = 0; i <= policko.Length - 1; i++)
            {
                if (policko[i] == pocet)
                    x += 1;
            }
            s = x;
        }
    }
}
