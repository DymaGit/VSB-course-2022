using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_2
{
    class Circle
    {
        private double radius = 1.0;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public string toString()
        {
            return "Circle[radius=" + radius + "]";

        }
    }

    class ex1_2
    {
        public static void Mainx()
        {
            Circle c1 = new Circle(5);
            Console.WriteLine(c1.toString());
            Circle c2 = new Circle(10);
            Console.WriteLine("radius= "+ c2.getArea() +" obvod= "+ c2.getCircumference());
        }
    }


}
