using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_1
{
    class Circle
    {
        private double radius;
        private string color;


        public string toString()
        {
            return "Circle[radius=" + radius + " color=" + color + "]";
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public void setColor(string color)
        {
            this.color = color;
        }


        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double r)
        {
            radius = r;
            color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public string getColor()
        {
            return color;
        }
    }

    class ex1_1
    {
        public static void Mainx()
        {
            Circle c1 = new Circle();
            Console.WriteLine($"The circle has radius of {c1.getRadius()} and area of {c1.getArea()}");
            Circle c2 = new Circle(2.0);
            Console.WriteLine($"The circle has radius of {c2.getRadius()} and area of {c2.getArea()} ");
            Circle c3 = new Circle(3.0, "Red");
            Console.WriteLine($"The circle has radius of {c3.getRadius()} and area of {c3.getArea()} and color of {c3.getColor()} ");
            Circle c4 = new Circle(4.0, "blue");
            Console.WriteLine(c4.getRadius() + " " + c4.getColor());
            Circle c5 = new Circle(5.0);
            Console.WriteLine(c5.toString());


        }
    }

}
