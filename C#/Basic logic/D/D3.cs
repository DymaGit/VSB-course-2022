using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class D3
    {
        static void Mainx(string[] args)
        {
            string vypis = "";
            int cisla, rozdil=0;

            Console.WriteLine("zadej první člen posloupnosti");
            int prvni = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej druhý člen posloupnosti");
            int druhy = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej poslední člen posloupnosti");
            int posledni = int.Parse(Console.ReadLine());
            cisla = prvni;

            cisla = cisla + rozdil;
            vypis = vypis + cisla + " ";
            do
            {
                rozdil = druhy - prvni;
                cisla = cisla + rozdil;
                if (cisla <= posledni)
                    vypis = vypis + cisla + " ";
            }

            while (cisla < posledni);

            Console.WriteLine();
            Console.WriteLine("lineární posloupnost: " + vypis);

            //cisla = cisla + rozdil;
            //vypis = vypis + cisla + " ";
            //while (cisla < posledni)
            //{

            //    rozdil = druhy - prvni;
            //    cisla = cisla + rozdil;
            //    if (cisla <= posledni)
            //        vypis = vypis + cisla + " ";
            //}



            //Console.WriteLine();
            //Console.WriteLine("lineární posloupnost: " + vypis);
        }
    }
}
