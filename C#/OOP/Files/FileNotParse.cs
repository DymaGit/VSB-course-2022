using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files {
    class FileNotParse {
        public static void Mainx() {


     

            StreamReader vstup = new StreamReader("C:\\Kurs\\lala.txt");
            string ret = vstup.ReadToEnd();
            string ret2 = vstup.ReadToEnd();
            Console.WriteLine(ret + " " + ret2);

            StreamWriter vystup = new StreamWriter("C:\\Kurs\\lolo.txt");
            vystup.Write(ret);
            vystup.Close();


			//Console.WriteLine("Napiste neco:");
			//string zprava = Console.ReadLine();
			string[] poleS = new string[] { "pes", "kocka", "medved", "koza" };

			string cesta = "C:/kurs/zvirata.txt";  //Full Name souboru

			FileInfo fi = new FileInfo(cesta);

			if (fi.Directory.Exists) {
                //zapis pomoci metody WriteAllLines

                File.WriteAllLines(cesta, poleS);
                //zapis pomoci metody WriteAllText
                //File.WriteAllText(cesta, zprava);

                //cteni pomoci ReadAllLines(cele az po konec else)
                Console.WriteLine("Nasleduje precteni souboru pomoci metody ReadAllLines.");
                string[] poleS2 = File.ReadAllLines(cesta);
                for (int i = 0; i < poleS2.Length; i++) {
                    Console.WriteLine(poleS2[i]);
                }
                Console.WriteLine("Precteno!");
            }
            else
                Console.WriteLine("cesta " + fi.Directory + " neexistuje");

            //cteni pomoci ReadAllText
            Console.WriteLine("Nasleduje precteni souboru pomoci metody ReadAllText.");
			string coSePrecetlo = File.ReadAllText(cesta);
			Console.WriteLine(coSePrecetlo);


		}

    }
}
