using System;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
    abstract class Employee : Person {
        private int salary;



        public int Salary {
            get { return salary; }
            set {
                salary = value;
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
}


