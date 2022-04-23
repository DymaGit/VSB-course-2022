using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_11
    {

        static void Mainx(string[] args)
        {
            string slovo;
            string vystup, sub;
            slovo = Console.ReadLine();

            vystup = sifraF(slovo); //funkce
            sifraS(slovo, out sub); //subrutina
            Console.WriteLine(vystup); //funkce
            Console.WriteLine(sub); //subrutina
        }

        static string sifraF(string text) //funkce
        {
            char znak;
            string prevod = "";

            //tady neřeším přesah nad Z.. a jenom easy šifrování o 1
            for (int i = 0; i < text.Length; i++)
            {
                znak = text[i];
                prevod = prevod + (char)(znak + 1);
            }
            return prevod;
        }

        static void sifraS(string text, out string s) //subrutina
        {
            char znak;
            string prevod = "";

            //tady neřeším přesah nad Z.. a jenom easy šifrování o 1
            for (int i = 0; i < text.Length; i++)
            {
                znak = text[i];
                prevod = prevod + (char)(znak + 1);
            }
            s = prevod;
        }
    }
}
