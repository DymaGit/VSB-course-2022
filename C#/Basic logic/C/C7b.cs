using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class C7b
    {

        static void Mainx(string[] args)
        {
            string pocet = "";

            for (int i = 1; i <= 20; i++)
            {
                if (i % 5 == 0)
                    pocet = pocet + i + "\n";
                else
                    pocet = pocet + i + " ";
            }
            Console.WriteLine(pocet);

            //for (int i = 1; i <= 20; i++)
            //   if (i % 5 == 0)
            //        Console.Write(i+ "\n");
            //   else
            //        Console.Write(i + " ");
        }

    }
}
