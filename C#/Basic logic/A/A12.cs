using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cšarp_příklady
{
    internal class A12
    {
        static void Mainx(string[] args)
        {

            Console.WriteLine("zadej průměr bazénu (m)");
            int prumer =int.Parse(Console.ReadLine());
            Console.WriteLine("zadej výšku bazénu (m)");
            int vyska =int.Parse(Console.ReadLine());
            double vypocet = Math.PI * Math.Pow(prumer/2, 2) * vyska;
            Console.WriteLine("objem bazénu je: " + Math.Round(vypocet,3) + "m2");

        }

    }
}
