package Project2;

abstract class Animal {
    public String name;
    public static int countOfAnimals;



    public Animal(String name) {
        this.name = name;
        countOfAnimals++;
    }
}