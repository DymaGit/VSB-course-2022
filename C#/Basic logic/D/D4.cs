using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class D4
    {
        static void Mainx(string[] args)
        {
            int max, vyska;
            string nejvyssi, jmeno;

            Console.WriteLine("zadej jméno žáka. prázné jméno = konec");
            jmeno = Console.ReadLine();
            Console.WriteLine("zadej výšku žáka.");
            vyska = int.Parse(Console.ReadLine());
            max = vyska;
            nejvyssi = jmeno;

            do
            {
                Console.WriteLine("zadej jméno žáka. prázné jméno = konec");
                jmeno = Console.ReadLine();
                if (jmeno != "")
                {
                    Console.WriteLine("zadej výšku žáka.");
                    vyska = int.Parse(Console.ReadLine());

                    if (vyska > max)
                    {
                        max = vyska;
                        nejvyssi = jmeno;
                    }
                }
            }
            while (jmeno != "");
            Console.WriteLine("nejvyšší žák je: " + nejvyssi + "\n" + "výška: " + max);

        }
    }
}
