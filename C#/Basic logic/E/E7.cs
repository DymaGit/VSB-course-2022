using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E7
    {


        static void Mainx(string[] args)
        {
            Console.WriteLine("zadej 5 slov");
            string[] pole1 = new string[9];
            int i = -1;
            int pocet = 0;
            string slovo;
            do
            {
                i++;
                pole1[i] = Console.ReadLine();
            }
            while (i < 4);

            Console.WriteLine("zadej jedno z těch slov znovu");
            slovo= Console.ReadLine();

            for (int x = 0; x <= 4; x++)
            {
                if (slovo == pole1[x])
                {
                    pocet = x + 1;
                }
            }
            Console.WriteLine("zadané slovo bylo napsáno v " + pocet + ". pořadí.");
        }
    }
}
