using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni10 {
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
           // Console.Write($"věk osoby je {age}, inkrementace: {count}");
        //}

        //public void Info() {
        //    Console.Write($"věk osoby je {age}, ");
        //}
    }
   abstract class Employee : Person {
        private int salary;



        public int Salary {
            get { return salary; }
            set { salary = value;
            }
        }
        public Employee() {

        }
        public Employee(int age, int salary) : base(age) {
            //this.age = age; toto nahrazuje dědění konstruktoru base(age)
            this.Salary = salary;
        }

        

        public override void writeInfo() {
            //base.writeInfo();
            Console.Write(age);
            Console.Write($" plat zaměstnance je  {Salary} Kč {GetAge()} {GetCount()} ");  // get/set
        }
    }
     class Student : Person {

        public int scholarship;

        public Student() {

        }

        public Student(int age, int scholarship) : base(age) {
            //this.age = age;  toto nahrazuje dědění konstruktoru base(age)
            this.scholarship = scholarship;
        }

        //public Student(int age) : base(age) {
        //    this.age = age;
        //}

        public override void writeInfo() {
            //base.writeInfo();
            Console.Write(age);   //tady jsem místo geteru a seteru předělal prostě age na public.. at stihám. Ale jinak bych musel použít get/set protože age má být private
        Console.WriteLine($" školné je  {scholarship} Kč");
        }
    }
    class Accountant : Employee {

        public Accountant() {

        }
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
        private int teachingTime;

        public int TeachingTime {
            get => teachingTime;
            set {
                if (value > 40)
                    Console.WriteLine("chybné zadání.. Teaching time > 40");   //vyřešeno: zobrazuje "chybné zadání i "0"
                else {                                      // chybí 3.tí krok    (9c) -> hotovo, snad dobře.
                    teachingTime = value;
                }
                
            }
        }

        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            //this.age = age;   toto a druhy řádek nahrazuje dědění kontruktoru base(age,salary)
            //this.salary = salary;
            this.TeachingTime = teachingTime;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine($" jeho úvazek je { TeachingTime} hod");
        }
    }
    class Prvni10 {
        public static void Mainx() {
            Console.Title = "první 5";
            Student s1 = new Student(20, 5000);
            Student s2 = new Student();
            Accountant a1 = new Accountant(25, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);

            s1.writeInfo();
            s2.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Teacher t2 = new Teacher(30, 20000, 41);  //nesmí být víc jak 40

            t2.writeInfo();
            Console.WriteLine($"  {s1.GetAge()}  {a1.GetCount()} <-- toto je výpis z mainu, přes set/get kdy jsem šáhl po private datových složkách");
        }
    }
}


