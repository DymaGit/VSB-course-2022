using System;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
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


        public override string ToString() {
            return String.Format("Student to string.. s overridem přepsal i puvodni. Takže je to vypsané 2x");
        }


    }
}


