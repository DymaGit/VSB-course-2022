using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cšarp_příklady
{
    internal class A13
    {
        static void Mainx(string[] args)
        {

            Console.WriteLine("Zadej délky odvěsen pravoúhlého trojuhelníka. (cm)");
            int odvesna1= int.Parse(Console.ReadLine());
            int odvesna2 = int.Parse(Console.ReadLine());
            double prepona = Math.Sqrt(Math.Pow(odvesna1,2)+Math.Pow(odvesna2,2));
            Console.WriteLine("prepona: " + prepona);
 
        }

    }
}
