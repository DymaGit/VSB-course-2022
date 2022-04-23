using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E1
    {
        static void Mainx(string[] args)
        {
            int[] pole1 = new int[9];
            byte i = 0;
            byte min, y = 0;

            Console.WriteLine("zadej číslo. 0=konec");
            pole1[i] = int.Parse(Console.ReadLine());

            min = (byte)pole1[0];
            y++;
            do
            {
                i++;
                Console.WriteLine("zadej číslo. 0=konec");
                pole1[i] = int.Parse(Console.ReadLine());

                if (pole1[i] != 0)
                {
                    if (pole1[i] <= min)
                    {
                        if (pole1[i] < min)
                        {
                            y = 0;
                        }
                        min = (byte)pole1[i];
                        y++;
                    }
                }
            }
            while (pole1[i] != 0);

            Console.WriteLine("nejmenší číslo je :" + min + "\n" + "opakuje se :" + y + "x");
        }
    }
}
