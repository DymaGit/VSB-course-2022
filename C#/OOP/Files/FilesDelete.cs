using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files {
     class FilesDelete {
        public static void Mainx() {

           
            DirectoryInfo di = new DirectoryInfo("C:\\Kurs\\");  //cesta
           
            FileInfo[] seznamSoub = di.GetFiles();  //soubory
            foreach (FileInfo fi in seznamSoub) {
                Console.WriteLine(fi.FullName);
            }

            DirectoryInfo[] subdir = di.GetDirectories();  //složky
            foreach (DirectoryInfo sub in subdir) {
                Console.WriteLine(sub.FullName);
            }

            
            Console.WriteLine("který soubor chceš smazat");
            string keSmazani = Console.ReadLine();


            string cesta = "C:\\Kurs\\";

            Console.WriteLine(File.Exists(cesta+keSmazani) ? "soubor existuje" : "soubor neexistuje");
            if (File.Exists(cesta+keSmazani)) {
                File.Delete(cesta+keSmazani);
                Console.WriteLine(File.Exists(cesta+keSmazani) ? "soubor nebyl smazán" : "soubor byl smazán");

            }



        }

    }
}
