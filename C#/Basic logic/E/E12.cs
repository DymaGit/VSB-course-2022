using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E12
    {
        static void Mainx(string[] args)
        {
            int[] pole1 = new int[9];
            Random r = new Random();

            for (int i = 0; i <= 8; i++)
            {
                pole1[i] = r.Next(1, 11);

                Console.Write("{0,-3}", pole1[i]);
            }

            Console.WriteLine();

            for (int i = 1; i <= 7; i++)
            {
                if ((pole1[i] > pole1[i - 1]) && (pole1[i] > pole1[i + 1]))
                    Console.WriteLine("{0, -3}", pole1[i]);
            }
        }
    }
}
