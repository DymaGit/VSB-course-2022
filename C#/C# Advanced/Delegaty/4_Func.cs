using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty {
    internal class _4_Func {
        static int Add(int a, int b) { return a + b; }




        static void Mainx(string[] args) {


            Func<bool> func = () => 1 == 2;
            Console.WriteLine(func());



            // 2 vstupní a 1 výstupní.. int a, int b, return a+b
            Func<int, int, int> addFunc = Add;
            Console.WriteLine(addFunc(8, 2));


            Func<string, bool> startsWithB = (s) => s.StartsWith("B");
            Console.WriteLine(startsWithB("Babovka")); // true.. začíná na B

            Func<string, bool> isShort = (s) => s.Length < 4;
            Console.WriteLine(isShort("lopatka")); //false.. lopatka má více písmen než 4
            Console.WriteLine(isShort("had"));  // true.. had má méně písmen než 4



            List<string> words = new List<string> { "ewerr", "rdfs", "g", "kohpppt", "ejcix" };

            var beginsWithE = words.Where(w => w.StartsWith("e"));  //které slovo začíná na "e"
            foreach (var item in beginsWithE) {
                Console.WriteLine(item);
            }
            var shortWords = words.Where(isShort);  //které slovo je nejkratší
            foreach (var item in shortWords) {
                Console.WriteLine(item);
            }
            List<int> numbers = new List<int> { 1, 8, 93, 22, 4, 57, 963, 457, 44 };
            var even = numbers.Where(n => n % 2 == 0);  // které číslo je sudé (dělitelné 2mi se zbytkem 0)
            foreach (var item in even) {
                Console.WriteLine(item);
            }
        }



    }
}
