using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class B15
    {
        static void Mainx(string[] args)
        {
            Console.WriteLine("jak je venku?");
            string odpoved = Console.ReadLine();

            switch (odpoved)
            {
                case "zima": Console.WriteLine("se obleč..");break;
                case "vedro": Console.WriteLine("se vysleč..");break;
            }
        }
    }
}
