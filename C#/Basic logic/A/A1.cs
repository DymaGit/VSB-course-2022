using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cšarp_příklady
{
    internal class A1
    {
        static void Mainx(string[] args)
        {

            int den, hodin;
            int vypocet;

            Console.WriteLine("zadej počet dnů a hodin");
            den = int.Parse(Console.ReadLine());
            hodin = int.Parse(Console.ReadLine());
            vypocet = den * 24 + hodin;

            Console.WriteLine("{0} dnu a {1} hodin {2}", den, hodin, den * 24 + hodin);
            Console.WriteLine(den +"dnů"+"+" + hodin + "hodin"+"=" + (den * 24 + hodin));
            Console.WriteLine("{0}", vypocet);

        }

    }
}
