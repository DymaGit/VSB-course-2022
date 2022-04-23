using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni {
    class Student {
        public int age;
        public int scholarship;
        public void writeInfo() {
            Console.WriteLine($"věk studenta je {age} a jeho stipendium je {scholarship}");

        }
    }

    class Accountant {
        public int age;
        public int salary;
        public void writeInfo() {
            Console.WriteLine($"věk ucetniho je {age} a jeho plat je {salary}");
        }
    }
    class Teacher {
        public int age;
        public int salary;
        public int teachingTime;
        public void writeInfo() {
            Console.WriteLine($"věk učitele je {age} a jeho plat je {salary} a jehoúvazek je {teachingTime}");
        }
    }
        class Prvni1 {
            public static void Mainx() {
            Console.Title = "první 1";
            Student s1 = new Student();
                s1.age = 20;
                s1.scholarship = 5000;
                Accountant a1 = new Accountant();
                a1.age = 20;
                a1.salary = 25000;
                Teacher t1 = new Teacher();
                t1.age = 40;
                t1.salary = 27000;
                t1.teachingTime = 21;
                s1.writeInfo();
                a1.writeInfo();
                t1.writeInfo();

            }
        }
    }


