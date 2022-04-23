//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
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

        public override string ToString() {
            return "Person to string";
        }


    }
}


