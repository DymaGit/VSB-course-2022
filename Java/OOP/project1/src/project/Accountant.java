package project;

class Accountant extends Employee {

    public Accountant() {

    }
    public Accountant(int age, int salary) { super (age, salary); 
        //this.age = age;   toto a druhy øádek nahrazuje dìdìní kontruktoru base(age,salary)
        //this.salary = salary;
    }

    public void writeInfo() {
        super.writeInfo();

        System.out.println();
    }
}
