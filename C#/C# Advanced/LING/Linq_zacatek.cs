using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    internal class Linq_zacatek {
        static void Mainx(string[] args) {
            List<int> number = new List<int>() { 56, 34, 6, 11, 58, 22, 125, 74, 39, 0, 12 };
            var sum = number.Sum();
            Console.WriteLine(sum);

            Console.WriteLine("vzestupně");
            var ordered = number.OrderBy(x => x);
            foreach (var item in ordered) {
                Console.WriteLine(item);
            }
            ordered.ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine("sestupně");
            var orderedDescend = number.OrderByDescending(x => x);
            foreach (var item in orderedDescend) {
                Console.WriteLine(item);
            }
            var max = number.Max();
            Console.WriteLine("maximum = " + max);

            var min = number.Min();
            Console.WriteLine("minimum = " + min);

            var average = number.Average();
            Console.WriteLine("průměr = " + average);

            Console.WriteLine();
            Console.WriteLine("sudé čísla");
            var even = number.Where(n => n % 2 == 0);
            foreach (var item in even) {
                Console.WriteLine(item);
            }

            var evenMax = number.Where(n => n % 2 == 0).Max();  //největší sudé číslo
            //var evenMax = number.Where(n => n % 2 == 0).OrderByDescending(n => n).First();   //komplikovanější...
            Console.WriteLine("největší sudé = " + evenMax);

            List<string> slova = new List<string>() { "kompresor", "krtek", "vzácnost", "herečka", "kapsa", "mnich", "sféra", "vila", "žurnalistika", "popelnice", "počítač", "instalatér", "motyka", "dcera", "tygr", "sluchátka", "hlína", "sopka", "rubín", "flétna" };

            var longest = slova.Max();
            Console.WriteLine("slovo s nejvyšší pozicí prvního písmene v abecedě = " + longest);
            var shortest = slova.Min();
            Console.WriteLine("slovo s nejnižší pozicí prvního písmene v abecedě = " + shortest);

            var beginsWithK = slova.Where(w => w.StartsWith("k"));
            foreach (var item in beginsWithK) {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("podle abecedy: ");
            var orderedByAbc = slova.OrderBy(x => x);
            foreach (var item in orderedByAbc) {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("podle délky: ");
            var orderedByLength = slova.OrderBy(x => x.Length);
            foreach (var item in orderedByLength) {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("slova obsahující ?znak? ");

            var containsLetters = slova.Where(w => w.Contains("č"));
            foreach (var item in containsLetters) {
                Console.WriteLine(item);

            }

            Console.WriteLine();
            Console.WriteLine("podle abecedy: ");
            var orderedByAbcd = slova.OrderBy(x => x).OrderBy(x => x.Length);
            foreach (var item in orderedByAbcd) {
                Console.WriteLine(item);
            }




        }
    }
}
