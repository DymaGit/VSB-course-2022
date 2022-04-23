using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class B12
    {

        static void Mainx(string[] args)
        {
            Console.WriteLine("je den? a/n");
            char odpoved1=char.Parse(Console.ReadLine());
            Console.WriteLine("je horko? a/n");
            char odpoved2 = char.Parse(Console.ReadLine());

            if ((odpoved1 =='a'||odpoved1=='A') && (odpoved2 =='a' || odpoved2 =='A'))
                Console.WriteLine("bež si tedy zaplavat");
            else
                Console.WriteLine("tak nic, zůstaň doma");
        }

    }
}
