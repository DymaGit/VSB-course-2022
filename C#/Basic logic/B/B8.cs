using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class B8
    {
        static void Mainx(string[] args)
        {


            Console.WriteLine("zadej jakýkoliv znak");
            char znak = char.Parse(Console.ReadLine());

            if (znak >= 48 && znak<=57)
                Console.WriteLine("znak je číslo");
            else if (znak >=65 && znak<=90)
                Console.WriteLine("znak je velké písmeno");
            else if (znak>=97 && znak<=122)
                Console.WriteLine("znak je malé písmeno");

        }

    }
}
