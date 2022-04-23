using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni5b {
    class Person {
        public int age;

        //public Person() {

        //}
        public Person(int age) {
            this.age = age;
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
    }


    class Student : Person {

        public int scholarship;

        public Student(int age, int scholarship) : base(age) {
            //this.age = age;  toto nahrazuje dědění konstruktoru base(age)
            this.scholarship = scholarship;
        }

        public Student(int age) : base(age) {
            this.age = age;
        }


        public void writeInfo() {
            Console.WriteLine($"věk studenta je {age} a jeho stipendium je {scholarship}");
        }
    }


    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
            //this.age = age;   toto a druhy řádek nahrazuje dědění kontruktoru base(age,salary)
            //this.salary = salary;
        }
        public void writeInfo() {
            Console.WriteLine($"věk ucetniho je {age} a jeho plat je {salary}");
        }
    }


    class Teacher : Employee {
        public int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            //this.age = age;   toto a druhy řádek nahrazuje dědění kontruktoru base(age,salary)
            //this.salary = salary;
            this.teachingTime = teachingTime;
        }
        public void writeInfo() {
            Console.WriteLine($"věk učitele je {age} a jeho plat je {salary} a jeho úvazek je {teachingTime} hodin");
        }
    }


    class Prvni5b {
        public static void Mainx() {
            Console.Title = "první 5";
            Student s1 = new Student(20, 5000);
            Student s2 = new Student(18);
            Accountant a1 = new Accountant(20, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            s2.writeInfo();
        }
    }
}


