using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1 {
    abstract class Animal {
        public string name;
        public static int countOfAnimals;
        public Animal(string name) {
            this.name = name;
            countOfAnimals++;
        }
    }

    class Dog : Animal {
        public Boolean isPedigree;
        public Dog(string name) : base(name) {
        }

        public void sound() {
            Console.WriteLine($"{name} haf  ");
        }
    }

    class Cat : Animal {
        public Boolean isPedigree;
        public Cat(string name) : base(name) {
        }

        public void sound() {
            Console.WriteLine($"{name} mňau");
        }
    }

    class Turtle : Animal {
        public int speed;
        public Turtle(string name) : base(name) {
        }
    }



    class Rozhrani1 {
        public static void Mainx() {
            Animal[] animals = new Animal[6];

            Dog Rex = new Dog("Rex");
            Dog Valda = new Dog("Valda");
            Rex.sound();
            Valda.sound();
            Cat Mourek = new Cat("Mourek");
            Cat Skvrna = new Cat("Skvrna");
            Mourek.sound();
            Skvrna.sound();
            Turtle Kvido = new Turtle("Kvido");
            Turtle Max = new Turtle("Max");

            Console.WriteLine(Animal.countOfAnimals);

            animals[0] = Rex;
            animals[1] = Valda;
            animals[2] = Mourek;
            animals[3] = Skvrna;
            animals[4] = Kvido;
            animals[5] = Max;


            for (int i=0; i<=Animal.countOfAnimals-1;i++)
                Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");

            Console.WriteLine();

            for (int i = 0; i <= 5; i++)
                Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");
        }
    }
}

