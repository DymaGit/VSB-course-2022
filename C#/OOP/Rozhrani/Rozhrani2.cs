using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani2
{
    abstract class Animal
    {
        public string name;
        public static int countOfAnimals;



        public Animal(string name)
        {
            this.name = name;
            countOfAnimals++;
        }
    }
    class Dog : Animal
    {
        public Boolean isPedigree;
        public Dog(string name) : base(name)
        {
        }
        public void sound()
        {
            Console.WriteLine($" haf  ");
        }


    }
    class Cat : Animal
    {
        public Boolean isPedigree;
        public Cat(string name) : base(name)
        {
        }
        public void sound()
        {
            Console.WriteLine($" mňau");
        }
    }
    class Turtle : Animal
    {
        public int speed;
        public Turtle(string name) : base(name)
        {
        }
    }
    class Rozhrani2
    {
        public static void Mainx()
        {
            //Animal[] animals = new Animal[6];

            Dog p1 = new Dog("Rex");
            Dog p2 = new Dog("Valda");
            Cat k1 = new Cat("Mourek");
            Cat k2 = new Cat("Skvrna");

            p1.sound();
            p2.sound();
            k1.sound();
            k2.sound();

            Turtle t1 = new Turtle("Kvido");
            Turtle t2 = new Turtle("Max");

            Animal[] animals = { p1, p2, k1, k2, t1, t2 };
            Animal[] zv2 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };
            Console.WriteLine(animals.Count() + " zvířat");

            //animals[0] = p1;
            //animals[1] = p2; 
            //animals[2] = k1;
            //animals[3] = k2;
            //animals[4] = t1;
            //animals[5] = t2;

            //Console.WriteLine(Animal.countOfAnimals);


            //for (int i=0; i<=Animal.countOfAnimals-1;i++)
            //    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");

            for (int i = 0; i <= animals.Count() - 1; i++)
                Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");

            Console.WriteLine();


            Console.Write(animals[0].name + " ");
            p1.sound();

            Console.WriteLine("------as--------");
            Console.Write(animals[0].name);
            (animals[0] as Dog).sound();
            Console.WriteLine("------as---------");


            Console.WriteLine("---přetypování?--");
            Console.Write(animals[0].name);
            ((Dog)animals[1]).sound();
            Console.WriteLine("---přetypování?--");

            //Předělávka na foreach a vypsání z: Animal[] animals = { p1, p2, k1, k2, t1, t2 };
            foreach (Animal ani in animals)
            {
                Console.Write(ani.GetType().Name);
                Console.WriteLine(" " + ani.name);
            }

            Console.WriteLine();
            // vypsýbí z: Animal[] zv2 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };
            foreach (Animal ani in zv2)
            {
                Console.Write(ani.GetType().Name);
                Console.WriteLine(" " + ani.name);
            }

            Console.WriteLine();


            //Předělávka na Kolekci

            //na jednom řádku
            List<Animal> seznam = new List<Animal>() { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };

            //Přehlednější způsob (pro mě)
            //List<Animal> seznam = new List<Animal>();
            //seznam.Add(p1);
            //seznam.Add(p2);
            //seznam.Add(k1);
            //seznam.Add(k2);
            //seznam.Add(t1);
            //seznam.Add(t2);

            foreach (Animal vypis in seznam)
            {
                Console.Write(vypis.GetType().Name);
                Console.WriteLine(" " + vypis.name);
            }





        }
    }
}
