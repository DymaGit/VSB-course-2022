using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class D6
    {
        static void Mainx(string[] args)
        {
            Random r = new Random();
            int odhad;
            int nahoda;

            do
            {
                nahoda = r.Next(1, 11);
                Console.WriteLine("Hádej co padlo..");
                odhad = int.Parse(Console.ReadLine());

                if (odhad == nahoda)
                    Console.WriteLine("TREFA!");
                else
                    Console.WriteLine("špatně!");
            }
            while (odhad != nahoda);
        }
    }
}