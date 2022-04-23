using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty {

    public delegate void WriteCalculation(int x, int y);

    internal class _2_Delegatevoid {

        static void WriteSum(int a, int b) {
            Console.WriteLine(a + b);
        }
        static void WriteDifference(int a, int b) {
            Console.WriteLine(a - b);
        }


        static void Mainx(string[] args) {
            WriteCalculation writeCalc = null;
            writeCalc += WriteSum;
            writeCalc += WriteDifference;
            writeCalc(5, 10);
        }

    }
}
