using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point6 {
    //dodělat vlastní vyjímku

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

        public Circle(int r) : this(new Point(0, 0), r) {

            this.r = r;


        }


        public Circle(double x, double y, int r) : base(x, y) {
            this.r = r;




        }

        public override string ToString() {
            return $"Kruh ma polomer {r} a stred v bode {Center}";

        }

        public override void writeInfo() {
            if (r < 0)
                throw new ArgumentOutOfRangeException("zadals mínusový průměr");
            else {
                base.writeInfo();
                Console.WriteLine(r + "---> kruh.. obvod: " + perimeter());
            }

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
            if ((a < 0) || (b < 0))
                throw new ArgumentOutOfRangeException("zadals mínusovou hodnotu stran");

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

    class TestPoint6 {

        public static void Mainx() {
            int prumer;
            bool ok;


            Point p1 = new Point(3.456, 2.765);
            Circle c1 = new Circle(3);
            Circle c2 = new Circle(4.5, 2.1, 10);
            Circle c3 = new Circle(p1, 4);
            Circle c4 = new Circle(6);
            Point p2 = new Point(3.123, 4.098);

            Point p3 = new Point(7.321, 9.45);





            Rectangle r1 = new Rectangle(5);
            Rectangle r2 = new Rectangle(p3, 7, 2);
            Rectangle r3 = new Rectangle(p3, 10);
            Rectangle r4 = new Rectangle(2, 10);

            
            // Rectangle r5 = new Rectangle(-6, 10);
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


            do {

                try {
                    Console.WriteLine("zadej prumer: ");
                    prumer = int.Parse(Console.ReadLine());
                    Circle c5 = new Circle(prumer);
                    c5.writeInfo();
                    ok = true;
                }
                catch (ArgumentOutOfRangeException e) {
                    Console.WriteLine(e.Message);
                    ok = false;
                }
                catch (FormatException) {
                    ok = false;
                    Console.WriteLine("nelze zadat nečíslo");
                }
                //dodělat TryParse
            }
            while (ok == false);


            bool OKParse;
            do {
                OKParse = true;
                Console.WriteLine("Zadej stranu dalsiho ctverce:");
                string ss = Console.ReadLine();
                int x;
                bool b = int.TryParse(ss, out x);                            //Strany obdélníka pomoci TryParse
                if (x == 0 && !b) {
                    OKParse = false;
                    Console.WriteLine("Zadej znovu");
                }
                else {
                    Rectangle r6 = new Rectangle(x);
                    Console.WriteLine(r6.ToString());
                }
            } while (OKParse == false);

            //alternativni reseni
            //do {
            //	Console.WriteLine("Zadej stranu A ctverce2 ");
            //} while (!int.TryParse(Console.ReadLine(), out sideA));

            //Rectangle r2 = new Rectangle(p3, 7, 2);
            //Rectangle r3 = new Rectangle(p3, 10);
            //Console.WriteLine(r2.ToString());
            //Console.WriteLine(r3.ToString());
            //Console.WriteLine(s2.ToString());

            Console.WriteLine("Konec!");




            Shape[] s = new Shape[] { c1, c2, c3, r1, r2, r3, r4 };

            for (int i = 0; i < s.Length; i++)
                Console.WriteLine("obvod " + s[i].GetType().Name + " " + s[i].perimeter());



            List<Shape> seznam = new List<Shape>();
            seznam.Add(c1);
            seznam.Add(c2);
            seznam.Add(c3);
            seznam.Add(r1);
            seznam.Add(r2);
            seznam.Add(r3);
            seznam.Add(r4);

            foreach (Shape h in seznam)
                Console.WriteLine("(List) " + h.perimeter());



            ArrayList sez = new ArrayList() { c1, c2, c3, r1, r2, r3, r4 };

              
            foreach(Shape hh in sez)
                Console.WriteLine("(Array List) "+ hh.perimeter());



        }




        


       

    }
}
