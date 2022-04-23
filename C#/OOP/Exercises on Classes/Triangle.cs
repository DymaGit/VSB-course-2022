using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle1
    {
        public float a;
        public float b;
        public float c;
        public bool ok;
        public string type;
        public Triangle1(float a)
        {
            this.a = a;
            this.b = a;
            this.c = a;

            if (a + b > c && b + c > a && c > b)
                ok = true;
            type = "rovnostranny";

        }

        public Triangle1(float a, float b)
        {
            this.a = a;
            this.b = b;
            this.c = b;

            if (a + b > c && b + c > a && c > b)
                ok = true;
            type = "rovnoramenny";
        }

        public Triangle1(float a, float b, float c)
        {


            this.a = a;
            this.b = b;
            this.c = c;

            if (a + b > c && b + c > a && c > b)
                ok = true;

            type = "normalni";

        }

        public bool exist()
        {
            return ok;
        }

        public float perimetr()
        {
            return a + b + c;

        }

        public string getType()
        {
            return type;

        }

    }

    class Triangle
    {
        public static void Mainx()
        {
            Triangle1 t1 = new Triangle1(100,1,1);
            Triangle1 t2 = new Triangle1(3,4,5);
            Triangle1 t3 = new Triangle1(3,4);
            Triangle1 t4 = new Triangle1(3);
            Triangle1 t5 = new Triangle1(3,4);

            Console.WriteLine(t1.exist() + " " + t1.perimetr() + " " + t1.getType());
            Console.WriteLine(t2.exist() + " " + t2.perimetr() + " " + t2.getType());
            Console.WriteLine(t3.exist() + " " + t3.perimetr() + " " + t3.getType());
            Console.WriteLine(t4.exist() + " " + t4.perimetr() + " " + t4.getType());
            Console.WriteLine(t5.exist() + " " + t5.perimetr() + " " + t5.getType());
        }

    }
}
