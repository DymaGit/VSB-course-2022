using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cšarp_příklady
{
    internal class A6
    {
        static void Mainx(string[] args)
        {
            int polomer;
            double obvod, plocha;
            
            Console.WriteLine("zadej poloměr kruhu");
            polomer=int.Parse(Console.ReadLine());
            obvod = 2 * Math.PI * polomer;
            plocha = Math.PI * Math.Pow(polomer,2);
            Console.WriteLine("obvod kruhu je " + (double)obvod+ "\n" + "plocha kruhu je " + (double)plocha);

        }
    }
}
