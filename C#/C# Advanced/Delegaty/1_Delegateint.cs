using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty {

    public delegate int Calculate(int x, int y);

    internal class Program {

        static int Add(int a, int b) {
            return a + b;
        }

        static int Subtract(int a, int b) {
            return a - b;
        }



        static void Mainx(string[] args) {
            Calculate calc = Subtract;

            calc += Add;
            Console.WriteLine(calc(1,5));

            Delegate[] dels = calc.GetInvocationList();
            foreach (Delegate item in dels) {
                Console.WriteLine(item.DynamicInvoke(1,2));
                Console.WriteLine(item.Method.ToString());
            }
        }
    }
}
