using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{

    abstract class RealEstate
    {
        public int day, month, year;

        public RealEstate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

    }

    class House : RealEstate
    {
        public double sazba = 1.27;

        public House(int day, int month, int year) : base(day, month, year)
        {
        }

        public double tax()
        {
            return sazba * day;
        }
    }

    class Flat : RealEstate
    {
        public double sazba = 1.15;

        public Flat(int day, int month, int year) : base(day, month, year)
        {
        }

        public double tax()
        {
            return sazba * (month - 1 + day) * 30;
        }




    }



    abstract class Vehicle
    {

    }

    class Car : Vehicle
    {
        public double tax()
        {
            return 1500;
        }
    }

    class Motorcycle : Vehicle
    {
        public double tax()
        {
            return 1500;
        }
    }

    class Trolleybus : Vehicle
    {
        private double sazba = 0.9;
        public double tax()
        {
            return 1500 * sazba;
        }
    }





    class Tax
    {
        public static void Mainx()
        {

            House h1 = new House(1, 8, 1992);
            Flat f1 = new Flat(5, 12, 2001);
            Car c1 = new Car();
            Motorcycle m1 = new Motorcycle();
            Trolleybus t1 = new Trolleybus();

            string[] pole = new string[5];

            pole[0] = h1.GetType().Name + " " + h1.sazba + " " + h1.tax();
            pole[1] = f1.GetType().Name + " " + f1.sazba + " " + f1.tax();
            pole[2] = c1.GetType().Name + " " + c1.tax();
            pole[3] = m1.GetType().Name + " " + m1.tax();
            pole[4] = t1.GetType().Name + " " + t1.tax();


            List<double> seznam = new List<double>();
            seznam.Add(h1.tax());
            seznam.Add(f1.tax());
            seznam.Add(c1.tax());
            seznam.Add(m1.tax());
            seznam.Add(t1.tax());


            for (int i = 0; i <= 4; i++)
                Console.WriteLine(pole[i]);

            double soucet = 0;
            foreach (double s in seznam)
            {
                Console.WriteLine(s);
                soucet = soucet + s;
            }
            Console.WriteLine("celkem: " + soucet + " kč");

        }

    }

}
