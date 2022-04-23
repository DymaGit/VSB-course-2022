using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class C14
    {


        static void Main(string[] args)
        {
            string vypis = "";

            for (int i = 1; i <= 10; i++)
            {
                for (int y = 1; y <= i; y++)
                    vypis = vypis + "*";
                vypis = vypis + "\n";
            }

            for (int i = 9; i >= 1; i--)
            {
                for (int y = 1; y <= i; y++)
                    vypis = vypis + "*";
                vypis = vypis + "\n";
            }

            Console.WriteLine(vypis);

        }

    }
}
