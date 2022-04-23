using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files {
    internal class A1FileStr {

        public static void Mainx() {
            
            
            int vypocet;
            Console.WriteLine("zadje dny");
            int dny = int.Parse(Console.ReadLine());
            Console.WriteLine("zadje hodiny");
            int hodiny = int.Parse(Console.ReadLine());
            vypocet = hodiny + dny * 24;
            Console.WriteLine(vypocet);
            StreamWriter vystup = new StreamWriter("C:\\Kurs\\A1.txt");
            vystup.Write(vypocet);
            vystup.Close();


            string cesta = "C:/kurs/A1.txt";

            StreamReader vstup = new StreamReader(cesta);
            string ret = vstup.ReadToEnd();
            Console.WriteLine(ret);

            //StreamWriter vystup = new StreamWriter("C:\\Kurs\\A2.txt");
            //vystup.Write(ret);
            //vystup.Close();





        }
    }
}
