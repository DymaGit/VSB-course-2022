using System;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
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
}


