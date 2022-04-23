using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_6
    {
        static void Mainx(string[] args)
        {
            string vystup = "", sub;

            int cislo;
            cislo = int.Parse(Console.ReadLine());
            vystup = denF(cislo); //funkce
            denS(cislo, out sub); //subrutina
            Console.WriteLine(vystup); //funkce
            Console.WriteLine(sub); //subrutina
        }
        static string denF(int number) //funkce
        {
            string vyber;

            switch (number)
            {
                case 1: vyber = "Pondělí"; break;
                case 2: vyber = "Úterý"; break;
                case 3: vyber = "Středa"; break;
                case 4: vyber = "Čtvrtek"; break;
                case 5: vyber = "Pátek"; break;
                case 6: vyber = "Sobota"; break;
                case 7: vyber = "Neděle"; break;
                default: vyber = "Špatné zadání"; break;
            }
            return vyber;
        }

        static void denS(int number, out string s) //subrutina
        {
            string vyber;

            switch (number)
            {
                case 1: vyber = "Pondělí"; break;   //nemusím vytvářet "vyber", mohl bych ty možnosti
                case 2: vyber = "Úterý"; break;     //hodit přímo do "s"
                case 3: vyber = "Středa"; break;
                case 4: vyber = "Čtvrtek"; break;
                case 5: vyber = "Pátek"; break;
                case 6: vyber = "Sobota"; break;
                case 7: vyber = "Neděle"; break;
                default: vyber = "Špatné zadání"; break;
            }
            s = vyber;
        }
    }
}
