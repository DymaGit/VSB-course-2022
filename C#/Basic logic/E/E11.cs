using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E11
    {
        static void Mainx(string[] args)
        {
            int[,] pole1 = new int[4, 4];
            int z = 1;
 
            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x <= 3; x++)
                {
                    pole1[x, y] =z;
                    z += 1;
                    if (x == 3)
                        Console.Write("{0,-4} \n", pole1[x, y]);
                    else
                        Console.Write("{0,-4}", pole1[x, y]);
                }
            }

            Console.WriteLine();

            z = 1;
            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x <= 3; x++)
                {

                    pole1[x, y] = z;
                    z += 1;
                    if (x == 3)
                        Console.Write("{0,-4} \n", pole1[y, x]);
                    else
                        Console.Write("{0,-4}", pole1[y, x]);
                }
            }
        }
    }
}
