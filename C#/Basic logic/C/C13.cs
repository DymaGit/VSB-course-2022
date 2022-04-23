using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class C13
    {


        static void Mainx(string[] args)
        {

            string vypis = "    ";
            string vypis2 = "     ";

            for (int i = 1; i <= 10; i++)
                if (i == 10)
                    vypis = vypis + i + "\n";
                else if (i == 9)
                    vypis = vypis + i + "   ";
                else
                    vypis = vypis + i + "    ";

            for (int i = 1; i <= 10; i++)
            {
                if (i == 10)
                    vypis = vypis + i + "";
                else
                    vypis = vypis + i + " ";

                for (int y = 1; y <= 10; y++)
                    if (y % 10 == 0)
                        vypis = vypis + " " + y * i + "\n";
                    else

                    if (y * i >= 90)
                        vypis = vypis + "  " + y * i + "";
                    else if (y * i >= 10)
                        vypis = vypis + "  " + y * i + " ";
                    else if (y * i == 90)
                        vypis = vypis + " " + y * i + " ";
                    else
                        vypis = vypis + "  " + y * i + "  ";
            }

            Console.WriteLine(vypis);

            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    Console.Write("     ");
                }
                if (i == 10)
                    Console.Write("{0,4}", i);
                else
                    Console.Write("{0,5}", i);
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0,5}", i);

                for (int y = 1; y <= 10; y++)
                if (y == 10)
                    Console.Write("{0,5}", y * i + "\n");
                else
                    Console.Write("{0,5}", y * i);
        }



            Console.WriteLine();


            for (int i = 1; i <= 10; i++)
            {
                if (i == 10)
                    vypis2 = vypis2 + string.Format("{0,5}", i + "\n");
                else
                    vypis2 = vypis2 + string.Format("{0,5}", i);
            }
            for (int i = 1; i <= 10; i++)
            {
                vypis2 = vypis2 + string.Format("{0,5}", i);

                for (int y = 1; y <= 10; y++)
                {
                    if (y == 10)
                        vypis2 = vypis2 + string.Format("{0,5}", i * y + "\n");
                    else
                        vypis2 = vypis2 + string.Format("{0,5}", i * y);
                }
            }
            Console.WriteLine(vypis2);
        }

    }
}
