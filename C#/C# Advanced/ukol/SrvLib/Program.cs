using System;


namespace SrvLib
{
    public class SrvClass : MarshalByRefObject
    {
        


        public string sum(int a, int b)
        {
            return "Server počítá součet číásel " + a + " a " + b + " = " + Convert.ToInt32(a + b);
        }

        public static void Main()
        {

        }

    }
}
