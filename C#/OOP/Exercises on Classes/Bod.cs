using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bod
{
    class Bod1
    {
        private double x;
        private double y;


        //public double getX()
        //{
        //    return x;
        //}

        public double X
        {
            get { return x; }
            set
            {
                if (value > 0)
                { x = value; }
                else
                {   
                    x = 0;
                }

            }

        }

        public double Y
        {
            get { return y; }
            set
            {
                if (value > 0)
                { y = value; }
                else
                {
                    y = 0;
                }

            }

        }

        public Bod1(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static double vzdXY(double X, double Y)
        {
            return (Math.Sqrt(X * X + Y * Y));

        }

        public double vzdBod()
        {
            return (Math.Sqrt(X * X + Y * Y));

        }

        public void vzd()
        {
            Console.WriteLine(Math.Sqrt(X * X + Y * Y));
        }

        //public double vzdKBodu(double x, double y)
        //{
        //    return (Math.Sqrt(x * x + y * y));
        //}

        //public double vzdKBodu(Bod1 neco)            s tímhle nevim co dělat.. bod 3.
        //{


        //    return (Math.Sqrt(x * x + y * y));
        //}
    }




    class Bod
    {
        public static void Mainx()
        {
            Bod1 b1 = new Bod1(3, 6);
            //Console.WriteLine(vzdXY(5, 3));
            Console.WriteLine(b1.vzdBod());
            b1.vzd();
            Console.WriteLine(b1.X);
            //Console.WriteLine(b1.vzdKBodu(3,6));
        }

    }
}
