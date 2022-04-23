using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane
{

    class Person
    {
        public string gender;
        public int height;
        public int age;

        public int getWeight()
        {
            return height - 100;

        }
        public Person(string gender, int height, int age)
        {
            this.gender = gender;
            this.height = height;
            this.age = age;
        }

    }

    class Animal
    {
        public string druh;
        public double vaha = 0;
        public double getWeight()
        {
            return vaha;
         
        }
        public Animal(string druh)
        {
            

            this.druh = druh;
            if (druh == "savci")
               vaha= 50;
            if (druh == "plazi")
                vaha = 10;
            if (druh == "ryby")
                vaha = 5;
            if (druh == "ptaci")
                vaha = 3;
            if (druh == "hmyz")
                vaha = 0.1;
        }
    }

    class Thing
    {
        public int height;
        public int length;
        public int width;

        public double getWeight()
        {
            return (height * length * width) * 2;
        }


        public Thing(int height, int length,int width)
        {
            this.height=height;
            this.length=length;
            this.width=width;
        }
    }

    class Aeroplane
    {

        public static void Mainx()
        {
            Person p1 = new Person("muž", 180, 20);
            Person p2 = new Person("žena", 150, 25);
            Person p3 = new Person("muž", 186, 31);
            Animal a1 = new Animal("savci");
            Animal a2 = new Animal("plazi");
            Animal a3 = new Animal("hmyz");
            Thing t1 = new Thing(30,20,20);
            Thing t2 = new Thing(15, 20, 15);
            Thing t3 = new Thing(18, 22,18);


            Console.WriteLine(p1.getWeight());


            List<double> seznam = new List<double>();
            seznam.Add(p1.getWeight());
            seznam.Add(p2.getWeight());
            seznam.Add(p3.getWeight());
            seznam.Add(a1.getWeight());
            seznam.Add(a2.getWeight());
            seznam.Add(a3.getWeight());
            seznam.Add(t1.getWeight());
            seznam.Add(t2.getWeight());
            seznam.Add(t3.getWeight());

            double soucet=0;
            foreach (double s in seznam)
            {
                Console.WriteLine(s);
                soucet = soucet + s;
            }
            Console.WriteLine(soucet+ " kg");

        }
    }
}