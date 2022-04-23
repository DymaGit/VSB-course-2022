using SrvInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrvLib {
    public class SrvAuth : MarshalByRefObject, ISrvAuth {

        public int Sum(int num1, int num2) {
            Console.WriteLine($"Server vypočítá součet {num1} & {num2}");
            return num1 + num2;
        }


    }
}
