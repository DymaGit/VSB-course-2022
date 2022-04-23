using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_3
    {
        static void Mainx(string[] args)
        {
            char znak;
            int pocet, presun, sub;

            Console.WriteLine("zadej znak a bude zakódován");
            znak = char.Parse(Console.ReadLine());
            Console.WriteLine("zadej o kolik se posune");
            pocet = int.Parse(Console.ReadLine());
            presun = kodovaniF(znak, pocet); //funkce
            kodovaniS(znak, pocet, out sub); //subrutina
            Console.WriteLine("původní znak: {0} \nposunutí: {1} \nzakódování: {2}", znak, pocet, (char)presun); //fce
            Console.WriteLine("původní znak: {0} \nposunutí: {1} \nzakódování: {2}", znak, pocet, (char)sub); //sbrtn
        }
        static int kodovaniF(char klavesa, int cislo) //funkce
        {
            int vystup;
            vystup = klavesa + cislo;
            if (vystup > 122)
                vystup = vystup - 26;
            return vystup;
        }

        static void kodovaniS(char klavesa, int cislo, out int s) //subrutina
        {
            int vystup;
            vystup = klavesa + cislo;
            if (vystup > 122)
                vystup = vystup - 26;
            s = vystup;
        }
    }
}
