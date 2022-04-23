using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class B4
    {
        static void Mainx(string[] args)
        {
            Console.WriteLine("zadej 3 čísla");
            int cislo1 = int.Parse(Console.ReadLine());
            int cislo2 = int.Parse(Console.ReadLine());
            int cislo3 = int.Parse(Console.ReadLine());

            if (cislo1 > cislo2 && cislo1> cislo3)
                Console.WriteLine("číslo " + cislo1 + " je největší");
            if (cislo2> cislo1 && cislo2>cislo3)
                Console.WriteLine("číslo " + cislo2 + " je největší");
            if (cislo3 > cislo1 && cislo3 > cislo2)
                Console.WriteLine("číslo " + cislo3 + " je největší");
            if (cislo1 < cislo2 && cislo1 < cislo3)
                Console.WriteLine("číslo " + cislo1 + " je nejmenší");
            if (cislo2 < cislo1 && cislo2 < cislo3)
                Console.WriteLine("číslo " + cislo2 + " je nejmenší");
            if (cislo3 < cislo1 && cislo3 < cislo2)
                Console.WriteLine("číslo " + cislo3 + " je nejmenší");


        }
    }
}
