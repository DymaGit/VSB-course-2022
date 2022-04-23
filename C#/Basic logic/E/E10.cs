using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class E10
    {
        static void Mainx(string[] args)
        {
            int[,] pole1 = new int[4, 4];
            int min, radek = 0, sloupec = 0;
            string vypis = "";
            Random r = new Random();

            Console.WriteLine("vygenerováno 16 čísel");

            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x <= 3; x++)

                    pole1[x, y] = r.Next(1, 11);
            }

            min = pole1[0, 0];
            for (int y = 0; y <= 3; y++)
            {
                for (int x = 0; x <= 3; x++)
                {

                    if (pole1[x, y] <= min)
                    {
                        min = pole1[x, y];
                        sloupec = x + 1;
                        radek = y + 1;
                    }

                    //if (x == 3)
                    //    vypis = vypis + pole1[x, y] + "   " + "\n";
                    //else
                    //    vypis = vypis + pole1[x, y] + "   ";

                    if (x == 3)
                       Console.Write("{0,-3} \n", pole1[x, y]);
                    else
                       Console.Write("{0,-3}", pole1[x, y]);
                }
           }

            Console.WriteLine("minimum je: {0} \nsloupec: {1} \nradek: {2}", min, sloupec, radek);


        }

    }
}
