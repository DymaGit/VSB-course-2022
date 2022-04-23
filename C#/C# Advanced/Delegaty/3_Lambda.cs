using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty {
    public delegate int CalculateAl(int x, int y);






    internal class _3_Lambda {
        static int Add(int a, int b) {
            return a + b;
        }



        static void Mainx(string[] args) {
            CalculateAl addC = Add;
            Console.WriteLine(addC(8, 2));


            //anonymní metoda
            CalculateAl addAnon = delegate (int a, int b) {
                Console.WriteLine("toto je prikaz z anonymni metody");
                return a + b;
            };
            Console.WriteLine(addAnon(5, 7));


            //Lambda výraz

            CalculateAl add = (a, b) => a + b;
            CalculateAl multiply = (a, b) => a * b;
            multiply += (a, b) => a - b;
            Console.WriteLine(multiply(5,10));

      
        }

    }
}
