using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_12
    {
        static void Mainx(string[] args)
        {
            int i = -1;
            string[] vyslednepole = new string[9];
            string[] poleslov = new string[9];
            string[] sub;
            string vystup = "", vystup2 = "";

            do
            {
                i++;
                poleslov[i] = Console.ReadLine();
            }
            while (poleslov[i] != "0");

            vyslednepole = kodovanislovF(poleslov, i); //funkce
            kodovanislovS(poleslov, i, out sub); //subrutina

            for (int x = 0; x <= i - 1; x++) //funkce
            {
                vystup = vystup + vyslednepole[x] + "\n";
            }
            Console.WriteLine(vystup);

            for (int x = 0; x <= i - 1; x++) //subrutina
            {
                vystup2 = vystup2 + sub[x] + "\n";
            }
            Console.WriteLine(vystup2);

        }

        static string[] kodovanislovF(string[] p, int pocet) //funkce
        {
            string slovo;
            char pismeno;
            string vypis = "";
            string[] novepole = new string[pocet];

            // jednoduché kódování +1 znak bez "-26"
            for (int b = 0; b < pocet; b++)
            {
                slovo = p[b];
                for (int x = 0; x <= slovo.Length - 1; x++)
                {
                    pismeno = slovo[x];
                    vypis = vypis + (char)(pismeno + 1);
                }
                novepole[b] = vypis;
                vypis = "";
            }
            return novepole;
        }

        static void kodovanislovS(string[] p, int pocet, out string[] s) //subrutina
        {
            string slovo;
            char pismeno;
            string vypis = "";
            string[] novepole = new string[pocet];

            // jednoduché kódování +1 znak bez "-26"
            for (int b = 0; b < pocet; b++)
            {
                slovo = p[b];
                for (int x = 0; x <= slovo.Length - 1; x++)
                {
                    pismeno = slovo[x];
                    vypis = vypis + (char)(pismeno + 1);
                }
                novepole[b] = vypis;
                vypis = "";
            }
            s = novepole;
        }
    }
}
