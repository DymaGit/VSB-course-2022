using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_9
    {
        static void Mainx(string[] args)
        {
            int[] pole1 = new int[10];
            int i = -1;
            bool vystup, sub;
            do
            {
                i++;
                pole1[i] = int.Parse(Console.ReadLine());
            }
            while (pole1[i] != 0);

            vystup = pravdanepravdaF(pole1, i);
            pravdanepravdaS(pole1, i, out sub);
            Console.WriteLine(vystup);
            Console.WriteLine(sub);
        }

        static bool pravdanepravdaF(int[] p, int pocet)
        {
            int rozdil;
            bool vysledek = true;
            rozdil = p[1] - p[0];

            for (int i = 0; i <= pocet - 2; i++)
            {
                if (p[i + 1] - p[i] != rozdil)
                    vysledek = false;
            }
            return vysledek;
        }

        static void pravdanepravdaS(int[] p, int pocet, out bool s)
        {
            int rozdil;
            bool vysledek = true;
            rozdil = p[1] - p[0];

            for (int i = 0; i <= pocet - 2; i++)
            {
                if (p[i + 1] - p[i] != rozdil)
                    vysledek = false;
            }
            s = vysledek;
        }
    }
}
