using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class C5
    {
        static void Mainx(string[] args)
        {
            Random r;
            float nahoda;
            r = new Random();
            string vypis = "";

            for (int i = 0; i <= 19; i++)
            {
                nahoda = r.Next(10, 51);
                vypis = vypis + nahoda + "\n";
            }

            Console.WriteLine(vypis);

        }


    }
}
