using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni6 {
    class Person {
        public int age;

        //public Person() {

        //}
        public Person(int age) {
            this.age = age;
        }
        public virtual void writeInfo() {
            Console.Write($"věk osoby je {age}, ");
        }
    }


    class Employee : Person {
        public int salary;

        //public Employee() {

        //}
        public Employee(int age, int salary) : base(age) {
            //this.age = age; toto nahrazuje dědění konstruktoru base(age)
            this.salary = salary;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.Write($" plat zaměstnance je  {salary} Kč");
        }
    }


    class Student : Person {

        public int scholarship;

        public Student(int age, int scholarship) : base(age) {
            //this.age = age;  toto nahrazuje dědění konstruktoru base(age)
            this.scholarship = scholarship;
        }

        //public Student(int age) : base(age) {
        //    this.age = age;
        //}
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine($" školné je  {scholarship} Kč");
        }
    }


    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
            //this.age = age;   toto a druhy řádek nahrazuje dědění kontruktoru base(age,salary)
            //this.salary = salary;
        }

        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine();
        }
    }


    class Teacher : Employee {
        public int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            //this.age = age;   toto a druhy řádek nahrazuje dědění kontruktoru base(age,salary)
            //this.salary = salary;
            this.teachingTime = teachingTime;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine($" jeho úvazek je { teachingTime} hod");
        }
    }


    class Prvni6 {
        public static void Mainx() {
            Console.Title = "první 5";
            Student s1 = new Student(20, 5000);
            Accountant a1 = new Accountant(25, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            
        }
    }
}


