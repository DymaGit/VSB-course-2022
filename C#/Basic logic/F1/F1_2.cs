using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_2
    {
        static void Mainx(string[] args)
        {
            char znak;
            int odkaz, sub;

            Console.WriteLine("zadej znak");
            znak = char.Parse(Console.ReadLine());
            odkaz = asciF(znak); //funkce   
            asciS(znak, out sub); //subrutina

            Console.WriteLine(odkaz); //funkce
            Console.WriteLine(sub); //subrutina
        }
        static int asciF(char klavesa) //funkce
        {
            int vystup;
            vystup = klavesa;
            return vystup;
        }

        static void asciS(char klavesa, out int s) //subrutina
        {
            s = klavesa;
        }
    }
}
