package project;

abstract class Person {
    public int age;
    protected static int count = 0;

    public int GetAge() {
        return age;

    }
    //public void SetAge(int age) {
    //    this.age = age;
    //}

    public int GetCount() {
        return count;
    }

    public Person() {
        count++;
    }
    public Person(int age) {
        this.age = age;
        count++;
    }
    public abstract void writeInfo(); //{

    //      Info();
    // Console.Write($"vìk osoby je {age}, inkrementace: {count}");
    //}

    //public void Info() {
    //    Console.Write($"vìk osoby je {age}, ");
    //}

    public String ToString() {
        return "Person to string";
    }


}