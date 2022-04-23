using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_9
    {

        static void Mainx(string[] args)
        {
            string text, vystup, sub;

            text = Console.ReadLine();
            vystup = obrattextF(text); //funkce
            obrattextS(text, out sub); //subrutina
            Console.WriteLine(vystup); //funkce
            Console.WriteLine(sub); //subrutina
        }

        static string obrattextF(string slovo) //funkce
        {
            int delka = slovo.Length;
            string vypis = "";
            for (int i = delka - 1; i >= 0; i--)
            {
                vypis = vypis + slovo[i];
            }
            return vypis;
        }

        static void obrattextS(string slovo, out string s) //subrutina
        {
            int delka = slovo.Length;
            string vypis = "";
            for (int i = delka - 1; i >= 0; i--)
            {
                vypis = vypis + slovo[i];
            }
            s = vypis;
        }
    }
}
