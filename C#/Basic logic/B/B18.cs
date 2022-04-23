using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class B18
    {

        static void Mainx(string[] args)
        {

            Console.WriteLine("zadej číslo měsíce");
            byte mesic = byte.Parse(Console.ReadLine());

            switch (mesic)
            {
                case 1: 
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: Console.WriteLine("měsíc má 31 dní");break;
                case 2: Console.WriteLine("měsíc má 28 dní");break;
                default: Console.WriteLine("měsíc má 30 dní");break;
            
            }


        }

    }
}
