using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E6
    {
        static void Mainx(string[] args)
        {
            char[] pole1 = new char[9];
            Random r = new Random();
            string vypis = "";
            int i = -1, x, n;

            do
            {
                i++;
                Console.WriteLine("zadej písmeno. 0 = konec");
                pole1[i] = char.Parse(Console.ReadLine());
            }
            while (pole1[i] != '0');

            for (x = 0; x <= i - 1; x++)
            {
                n = r.Next(0, i - 1);
                vypis = vypis + pole1[n];
            }

            Console.WriteLine(vypis);
        }
    }
}
