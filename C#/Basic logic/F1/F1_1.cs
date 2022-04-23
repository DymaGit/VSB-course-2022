using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_1
    {
        static void Mainx(string[] args)
        {
            float vstup, vystup,sub;

            Console.WriteLine("zadej stupně --> převedou se na radiány");
            vstup = float.Parse(Console.ReadLine());
            vystup = radianF(vstup); //funkcee
            radianS(vstup,out sub); //subrutina

            Console.WriteLine("{0} stupňů je {1:f3} radiánů", vstup, vystup);  //funkce
            Console.WriteLine("{0} stupňů je {1:f3} radiánů", vstup, sub);  //subrutina

        }
        static float radianF(float stupne)  //funkce
        {
            float vypocet;
            vypocet = (float)(Math.PI / 180) * stupne;
            return vypocet;
        }

        static void radianS(float stupne,out float s) //subrutina
        {
            s = (float)(Math.PI / 180) * stupne;
        }
    }
}
