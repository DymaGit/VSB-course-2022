using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty {
    internal class _5_Action {

        static void writeSum(int a, int b) {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args) {
            Action<int, int> writeIt = writeSum;
            writeIt += (a, b) => Console.WriteLine(a * b);
            writeIt(20, 12);

            List<string> words = new List<string> { "dog", "parrot", "goose" };
            foreach (var item in words) {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            words.ForEach(w => Console.WriteLine(w)); //jiný způsob jak vypsat foreach (1 řádek)
                                                      //využívá Action  

            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.ForEach(n => n++);
            numbers.ForEach(n => Console.WriteLine(n));
        }


    }
}
