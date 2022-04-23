using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//>>>>>>>>Zároveň i rozhraní 4!!!!<<<<<<
//akorát nemám to ternární rozhraní!!!!!!!!!!!!<<<<<<<<<<<<<<

namespace Rozhrani3 {
    interface IsoundAble {

        void sound();


    }

    abstract class Animal {
        public string name;
        public static int countOfAnimals;



        public Animal(string name) {
            this.name = name;
            countOfAnimals++;
        }
    }
    class Dog : Animal, IsoundAble {
        public Boolean isPedigree;
        public Dog(string name) : base(name) {
        }
        public void sound() {
            Console.WriteLine($" haf  ");
        }
    }
    class Cat : Animal, IsoundAble {
        public Boolean isPedigree;
        public Cat(string name) : base(name) {
        }
        public void sound() {
            Console.WriteLine($" mňau");
        }
    }
    class Turtle : Animal {
        public int speed;
        public Turtle(string name) : base(name) {
        }

    }




    class Rozhrani3 {
        public static void Mainx() {
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
            IsoundAble[] zv3 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna") };



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

            //Předělávka na foreach a vypsání z: Animal[] animals = { p1, p2, k1, k2, t1, t2 };
            foreach (Animal ani in animals) {
                Console.Write(ani.GetType().Name);
                Console.WriteLine(" " + ani.name);
            }

            Console.WriteLine();
            // vypsýbí z: Animal[] zv2 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };
            foreach (Animal ani in zv2) {
                Console.Write(ani.GetType().Name);
                Console.WriteLine(" " + ani.name);
            }

            Console.WriteLine();


            //Předělávka na Kolekci

            //na jednom řádku
            //List<Animal> seznam = new List<Animal>() { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };

            //Přehlednější způsob(pro mě)
            List<Animal> seznam = new List<Animal>();
            seznam.Add(p1);
            seznam.Add(p2);
            seznam.Add(k1);
            seznam.Add(k2);
            seznam.Add(t1);
            seznam.Add(t2);

            foreach (Animal vypis in seznam) {
                Console.Write(vypis.GetType().Name);

                Console.WriteLine(" " + vypis.name);
            }

            Console.WriteLine();

            Console.WriteLine("------as--------");
            Console.Write(animals[0].name);
            (animals[0] as Dog).sound();
            Console.WriteLine("------as---------");
            Console.WriteLine();
            Console.WriteLine("---přetypování?--");
            Console.Write(animals[0].name);
            ((Dog)animals[1]).sound();
            Console.WriteLine("---přetypování?--");
            Console.WriteLine();
            Console.WriteLine("------is ve smyčce----------");

            for (int i = 0; i <= animals.Count() - 1; i++) {
                if (animals[i] is Dog) {
                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    p1.sound();
                }
                else if (animals[i] is Cat) {

                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    k2.sound();
                }
                else
                    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");
            }


            Console.WriteLine();
            Console.WriteLine("----přetypování sme smyčce jen pro psa?----");
            for (int i = 0; i <= animals.Count() - 1; i++) {
                if (animals[i] is Dog) {
                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    ((Dog)animals[1]).sound(); ;
                }
                else if (animals[i] is Cat) {

                    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");

                }
                else
                    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");
            }
            Console.WriteLine("----přetypování sme smyčce jen pro psa?----");

            Console.WriteLine();

            Console.WriteLine("---is as ve smyčce-");
            for (int i = 0; i <= animals.Count() - 1; i++) {
                if (animals[i] is Dog) {

                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    (animals[i] as Dog).sound();
                }
                else if (animals[i] is Cat) {

                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    (animals[i] as Cat).sound();
                }
                else
                    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");
            }
            Console.WriteLine("---is as ve smyčce-");



            ;
            Console.WriteLine();
            Console.WriteLine("---------is + as-------------");
            for (int i = 0; i <= animals.Count() - 1; i++) {
                if (animals[i] is Dog) {
                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    (animals[i] as Dog).sound();
                }

                else if (animals[i] is Cat) {
                    Console.Write($"{animals[i].name} {animals[i].GetType().Name}");
                    (animals[i] as Cat).sound();
                }
                else
                    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");
            }
            Console.WriteLine("---------is + as-------------");

            Console.WriteLine();

            Console.WriteLine("-----interface-----");
            for (int i = 0; i <= 3; i++) {
                Console.Write(zv3[i].GetType().Name);
                zv3[i].sound();
            }
            Console.WriteLine("-----interface-----");

            for (int i = 0; i <= 3; i++) {
                Console.Write(zv3[i].GetType().Name);
                Console.Write(" " + zv2[i].name);
                zv3[i].sound();
            }

  

        }

        
    }
}
