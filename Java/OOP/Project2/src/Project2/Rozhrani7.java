package Project2;
import java.util.*;

class Rozhrani7{

public static void main (String[] args)

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


    IsoundAble[] zv3 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Car("Fabia") };

    System.out.println(animals.length + " zvíøat");



    //animals[0] = p1;
    //animals[1] = p2; 
    //animals[2] = k1;
    //animals[3] = k2;
    //animals[4] = t1;
    //animals[5] = t2;

    //Console.WriteLine(Animal.countOfAnimals);


    //for (int i=0; i<=Animal.countOfAnimals-1;i++)
    //    Console.WriteLine($"{animals[i].name} {animals[i].GetType().Name}");

    for (int i = 0; i <= animals.length - 1; i++)
    	System.out.println(animals[i].name+ " "+ animals[i].getClass().getSimpleName());

    System.out.println();

    //Pøedìlávka na foreach a vypsání z: Animal[] animals = { p1, p2, k1, k2, t1, t2 };
    for (Animal ani : animals) {
    	System.out.print(ani.getClass().getSimpleName());
        System.out.println(" " + ani.name);
    }

    System.out.println();
    // vypsýbí z: Animal[] zv2 = { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };
    for (Animal ani : zv2) {
    	System.out.print(ani.getClass().getSimpleName());
        System.out.println(" " + ani.name);
    }

    System.out.println();


    //Pøedìlávka na Kolekci

    //na jednom øádku
    //List<Animal> seznam = new List<Animal>() { new Dog("Rex"), new Dog("Valda"), new Cat("Mourek"), new Cat("Skvrna"), new Turtle("Kvido"), new Turtle("Max") };

    //Pøehlednìjší zpùsob(pro mì)
    
    ArrayList<Animal> sezn = new ArrayList<Animal>();
    sezn.add(p1);
    sezn.add(p2);
    sezn.add(k1);
    sezn.add(k1);
    sezn.add(t1);
    sezn.add(t1);
    
           


    for (Animal vypis : sezn) {
    	System.out.print(vypis.getClass().getSimpleName());

        System.out.println(" " + vypis.name);
    }

    System.out.println();

    System.out.println("------as--------");
    System.out.print(animals[0].name);
    if(animals[0] instanceof Dog)
    	((Dog)animals[0]).sound();
    System.out.println("------as---------");
    System.out.println();
    System.out.println("---pøetypování?--");
    System.out.print(animals[0].name);
    ((Dog)animals[1]).sound();
    System.out.println("---pøetypování?--");
    System.out.println();
    System.out.println("------is ve smyèce----------");

    for (int i = 0; i <= animals.length - 1; i++) {
        if (animals[i] instanceof Dog) {
        	System.out.print(animals[i].name+ " "+ animals[i].getClass().getSimpleName());
            p1.sound();
        }
        else if (animals[i] instanceof Cat) {

        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
            k2.sound();
        }
        else
        	System.out.println(animals[i].name+ " " +animals[i].getClass().getSimpleName());
    }


    System.out.println();
    System.out.println("----pøetypování sme smyèce jen pro psa?----");
    for (int i = 0; i <= animals.length - 1; i++) {
        if (animals[i] instanceof Dog) {
        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
            ((Dog)animals[1]).sound();
        }
        else if (animals[i] instanceof Cat) {

        	System.out.println(animals[i].name+" "+animals[i].getClass().getSimpleName());

        }
        else
        	System.out.println(animals[i].name+" "+ animals[i].getClass().getSimpleName());
    }
    System.out.println("----pøetypování sme smyèce jen pro psa?----");

    System.out.println();

    System.out.println("---is as ve smyèce-");
    for (int i = 0; i <= animals.length - 1; i++) {
        if (animals[i] instanceof Dog) {

        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
        	((Dog)animals[i]).sound();
        	
        }
        else if (animals[i] instanceof Cat) {

        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
        	((Cat)animals[i]).sound();
        }
        else
        	System.out.println(animals[i].name+" "+ animals[i].getClass().getSimpleName());
    }
    System.out.println("---is as ve smyèce-");



    
    System.out.println();
    System.out.println("---------is + as-------------");
    for (int i = 0; i <= animals.length - 1; i++) {
        if (animals[i] instanceof Dog) {
        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
        	((Dog)animals[i]).sound();
        }

        else if (animals[i] instanceof Cat) {
        	System.out.print(animals[i].name+" "+ animals[i].getClass().getSimpleName());
        	((Cat)animals[i]).sound();
        }
        else
        	System.out.println(animals[i].name+" "+ animals[i].getClass().getSimpleName());
    }
    System.out.println("---------is + as-------------");

    System.out.println();

    System.out.println("-----interface-----");
    for (int i = 0; i <= 3; i++) {
    	System.out.print(zv3[i].getClass().getSimpleName());
        zv3[i].sound();
    }
    System.out.println("-----interface-----");

    for (int i = 0; i <= 3; i++) {
    	System.out.print(zv3[i].getClass().getSimpleName());
    	System.out.print(" " + zv2[i].name);
        zv3[i].sound();
    }


    System.out.println("-----interface-----");
    for (int i = 0; i <= 3; i++) {
    	System.out.print(zv3[i].getClass().getSimpleName());
        zv3[i].sound();
    }
    System.out.println("-----interface-----");

    System.out.println(zv3[4].getClass().getSimpleName());
    zv3[4].sound();
    //Console.WriteLine(zv3[4].getName());

    System.out.println("-----interface-2---");
    for (int i = 0; i <= 4; i++) {
    	System.out.print(zv3[i].getClass().getSimpleName() + " ");
        //Console.Write(zv3[i].getName() + " ");
        System.out.print(zv3[i].getName() + " ");
        zv3[i].sound();
   }

    System.out.println("-----interface-2---");

  
}
}
