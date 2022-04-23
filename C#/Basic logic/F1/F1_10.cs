using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_10
    {
        static void Mainx(string[] args)
        {
            string vystup;
            string text, sub;
            Console.WriteLine("zadej text s mezerama");
            text = Console.ReadLine();
            vystup = bezmezerF(text); //funkce
            bezmezerS(text, out sub); //subrutina
            Console.WriteLine(vystup); //funkce
            Console.WriteLine(sub); //subrutina
        }

        static string bezmezerF(string veta) //funkce
        {
            //string presun = "";
            //char pismeno;

            //for (int i = 0; i < veta.Length ; i++)
            //{
            //    if (veta[i] == ' ')
            //        pismeno = 'x';
            //    else
            //        pismeno = veta[i];
            //    presun = presun + pismeno;
            //}
            veta = veta.Replace(" ", string.Empty);
            return veta;
        }

        static void bezmezerS(string veta, out string s) //subrutina
        {
            veta = veta.Replace(" ", string.Empty);
            s = veta;
        }
    }
}
