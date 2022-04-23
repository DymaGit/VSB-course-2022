using System;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
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
}


