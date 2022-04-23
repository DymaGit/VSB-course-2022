using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class C9
    {


        static void Mainx(string[] args)
        {
            string vypis = "";

            Console.WriteLine("zadej celé číslo. (do 100)");
            int cislo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cislo; i++)
            {
                if (cislo % i == 0)
                    vypis = vypis + i + ", ";
            }

            //Console.WriteLine("číslo "+cislo+ " je dělitelné čísly: "+ vypis);
            Console.WriteLine("číslo {0}, je dělitelné čísly: {1}", cislo,vypis);
            
        }

    }
}
