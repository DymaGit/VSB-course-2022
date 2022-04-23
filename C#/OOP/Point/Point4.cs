using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point4 {


    //interface inter {

    //    double perimeter();
    //    double area();
    //}


    class Point {

        private double x;
        private double y;

        #region Getters and Setters
        public double getX() {
            return x;
        }
        public double getY() {
            return y;
        }

        public void setY(double y) {
            this.y = y;
        }

        public Point(double x, double y) {

            this.x = x;
            this.y = y;
        }
        #endregion

        public override string ToString() {

            return (Math.Round(x, 2) + " ; " + Math.Round(y, 2));
        }

    }


    abstract class Shape {

        private Point center;

        public Point Center {

            get { return center; }
            set { center = value; }

        }

        public Shape(Point center) //: this(center.getX(),center.getY())
                                   {

            this.center = center;   //??????
        }

        public Shape(double x, double y) //: this(new Point(x,y))
             {
            Point center = new Point(x, y);
            this.center = center;

        }

        public virtual void writeInfo() {

            Console.Write(center + " ");
        }
        public abstract double perimeter();
        public abstract double area();

    }

    class Circle : Shape {


        public int r;

        public Circle(Point center, int r) : base(center) {

            this.r = r;
        }

        public Circle(int r) : this(new Point(0, 0), r) { //??? později zkontrolovat

            this.r = r;
        }


        public Circle(double x, double y, int r) : base(x, y) {
            this.r = r;
        }

        public override string ToString() {
            return $"Kruh ma polomer {r} a stred v bode {Center}";

        }

        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(r + "---> kruh.. obvod: " + perimeter());
        }

        public override double perimeter() {

            return Math.Round(2 * Math.PI * r, 2);
        }

        public override double area() {

            return Math.PI * r * r;
        }


    }

    class Rectangle : Shape {

        public int a;
        public int b;


        public Rectangle(Point center, int a, int b) : base(center) {
            this.a = a;
            this.b = b;

        }

        public Rectangle(int a, int b) : base(new Point(a, b)) {
            this.a = a;
            this.b = b;

        }

        public Rectangle(Point center, int a) : this(center, a, a) {

            //this.a = this.b = a;
        }
        public Rectangle(int a) : this(new Point(a, a), a, a) {
            this.a = a;
            this.b = a;
        }

        public override string ToString() {
            return $"Ctyruhelnik ma stranu A o delce {a}, stranu B o delce {b} a stred v bode {Center}";
        }

        public override void writeInfo() {
            base.writeInfo();
            if (a == b) {

                Console.WriteLine(a + " " + b + " " + "---> čtverec.. obvod: " + perimeter());
            }
            else {

                Console.WriteLine(a + " " + b + "---> obdélník.. obvod: " + perimeter());
            }
        }

        public override double perimeter() {

            return (a + b) * 2;
        }

        public override double area() {

            return a * b;
        }
    }

    class TestPoint4 {

        public static void Mainx() {
            Point p1 = new Point(3.456, 2.765);
            Circle c1 = new Circle(3);
            Circle c2 = new Circle(4.5, 2.1, 10);
            Circle c3 = new Circle(p1, 4);
            Point p2 = new Point(3.123, 4.098);

            Point p3 = new Point(7.321, 9.45);
            Rectangle r1 = new Rectangle(5);
            Rectangle r2 = new Rectangle(p3, 7, 2);
            Rectangle r3 = new Rectangle(p3, 10);
            Rectangle r4 = new Rectangle(2, 10);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            //Console.WriteLine(s2.ToString());
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            p1.setY(4);
            Console.WriteLine(p1.getX());
            Console.WriteLine(p1.getY());


            Console.WriteLine();



            c3.writeInfo();
            r1.writeInfo();
            r4.writeInfo();
        }


    }
}
