using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//v tomhle jsem měl trochu bordel, kdyžtak checknout doma

namespace Prvni12 {
    class Prvni12 {
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
            Teacher t2 = new Teacher(30, 20000, 41);  //nesmí být víc jak 40 jinak hlásí "chybu" a "0"

            t2.writeInfo();
            Console.WriteLine($"  {s1.GetAge()}  {a1.GetCount()} <-- toto je výpis z mainu, přes set/get kdy jsem šáhl po private datových složkách");
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToString());
        }
    }
}


