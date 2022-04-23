using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    class Mycka
    {
        public double umyj()
        {
            return 500;
        }

        public double navoskovat()
        {
            return 300;
        }

        public virtual double kompletniProgram()
        {
            return (umyj() + navoskovat()) * 0.80;
        }

    }

    class RucniMycka: Mycka
    {
        public double vycistiInterier()
        {
            return 250;
        }

        public override double kompletniProgram()
        {
            return (umyj() + navoskovat()+ vycistiInterier()) * 0.80;
        }

    }

    class MyckaSUdrzbou:RucniMycka
    {
        public double provedUdrzbuSpodku()
        {
            return 400;
        }
        public override double kompletniProgram()
        {
            return (umyj() + navoskovat() + vycistiInterier()+ provedUdrzbuSpodku()) * 0.80;
        }

    }


    class Inheritance
    {
        public static void Mainx()
        {  
            MyckaSUdrzbou b = new MyckaSUdrzbou();
            Console.WriteLine(b.umyj());
            Mycka c = new Mycka();
            Console.WriteLine(c.kompletniProgram());

        }

    }
}
