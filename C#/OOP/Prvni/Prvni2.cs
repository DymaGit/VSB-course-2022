using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni2 {
    class Student {

        public int age;
        public int scholarship;

        public Student(int age, int scholarship) {
            this.age = age;
            this.scholarship = scholarship;
        }

        public void writeInfo() {
            Console.WriteLine($"věk studenta je {age} a jeho stipendium je {scholarship}");
        }
    }

    class Accountant {
        public int age;
        public int salary;

        public Accountant(int age, int salary) {
            this.age = age;
            this.salary = salary;
        }
        public void writeInfo() {
            Console.WriteLine($"věk ucetniho je {age} a jeho plat je {salary}");
        }
    }
    class Teacher {
        public int age;
        public int salary;
        public int teachingTime;

        public Teacher(int age, int salary, int teachingTime) {
            this.age = age;
            this.salary = salary;
            this.teachingTime = teachingTime;
        }
        public void writeInfo() {
            Console.WriteLine($"věk učitele je {age} a jeho plat je {salary} a jednoúvazek je {teachingTime}");
        }
    }
    class Prvni2 {
        public static void Mainx() {
            Console.Title = "první 2";
            Student s1 = new Student(20, 5000);
            Accountant a1 = new Accountant(20, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
        }
    }
}


