using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class D1
    {
        static void Mainx(string[] args)
        {
            int soucet = 0, pocet;
            byte pocitadlo = 0, pocettrid;
            bool ok;
            Console.WriteLine("zadej kolik je ve třídě žáků. 0=konec");

            //do
            //{
            //    pocet = int.Parse(Console.ReadLine());
            //    soucet = soucet + pocet;
            //    pocitadlo += 1;
            //}

            //while (pocet != 0);

            //pocettrid = (byte)(pocitadlo - 1);
            //float prumer = (float)soucet / pocettrid;
            //Console.WriteLine("celkem žáků: " + soucet + "\n" + "průměr: " + prumer);

            pocet = int.Parse(Console.ReadLine());
            soucet = soucet + pocet;
            pocitadlo += 1;
            ok = false;

            while (pocet != 0)
            {
                ok = true;
                pocet = int.Parse(Console.ReadLine());
                soucet = soucet + pocet;
                pocitadlo += 1;
            }

            if (ok == true)
            {
                pocettrid = (byte)(pocitadlo - 1);
                float prumer = (float)soucet / pocettrid;
                Console.WriteLine("celkem žáků: " + soucet + "\n" + "průměr: " + prumer);
            }
        }
    }
}
