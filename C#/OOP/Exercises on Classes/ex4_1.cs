using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_1

{
    class Circle
    {

        private double radius ;
        private string color ;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double radius)
        {
            this.radius=radius;
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

        public void setRadius(double radius)
        {
            this.radius = radius;   
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }


        public virtual string toString()
        {
            return "radius = " + radius + " color = " + color + " area = " + getArea();
        }
    }

    class Cylinder:Circle
    {
        private double height;

        public Cylinder():base()
        {
            
            height = 1.0;
        }

        public Cylinder(double height):base()
        {
            this.height = height;
        }

        public Cylinder(double radius, double height):base(radius)
        {
            this.height=height;
        }


        public Cylinder(double radius, double height, string color):base(radius,color)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            return getArea() * height;
        }

        public override string toString()
        {
            return base.toString() + " " + height;
            

        }

    }

    class ex4_1
    {
        public static void Mainx()
        {
            Circle c1 = new Circle();
            Console.WriteLine(c1.toString());
            Cylinder c2 = new Cylinder();
            Console.WriteLine(c2.getVolume());
            Circle c3 = new Circle(5);
            Console.WriteLine(c3.toString());
            Cylinder c4 = new Cylinder(2,5);
            Console.WriteLine(c4.getVolume());
            Cylinder c5 = new Cylinder(2,2,"blue");
            Console.WriteLine(c5.getVolume()+" "+c5.getColor());
            Cylinder c6 = new Cylinder();
            Console.WriteLine(c6.toString());
        }
    }
}
