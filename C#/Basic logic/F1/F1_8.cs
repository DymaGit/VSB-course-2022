using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_8
    {
        static void Mainx(string[] args)
        {
            int mesic;
            string vystup, sub;

            mesic = int.Parse(Console.ReadLine());
            vystup = pocetdnimesiceF(mesic); //funkce
            pocetdnimesiceS(mesic, out sub); //subrutina
            Console.WriteLine("{0}. měsíc má: {1} dnů", mesic, vystup); //funkce
            Console.WriteLine("{0}. měsíc má: {1} dnů", mesic, sub); //subrutina
        }
        static string pocetdnimesiceF(int cislo) //funkce
        {
            string vyber;

            switch (cislo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: vyber = "31"; break;
                case 2: vyber = "28"; break;
                case 4:
                case 6:
                case 9:
                case 11: vyber = "30"; break;
                default: vyber = "špatný vstup"; break;
            }
            return vyber;
        }
        static void pocetdnimesiceS(int cislo, out string s) //subrutina
        {
            switch (cislo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: s = "31"; break;
                case 2: s = "28"; break;
                case 4:
                case 6:
                case 9:
                case 11: s = "30"; break;
                default: s = "špatný vstup"; break;
            }
        }
    }
}
