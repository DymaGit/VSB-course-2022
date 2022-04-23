using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_4
{
    class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;


        public Employee()
        {
            id = 1;
            firstName = "John";
            lastName = "Smith";
            salary = 20000;
        }

        public int getID()
        {
            return id;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getName()
        {
            return firstName + " " + lastName;
        }

        public int getSalary()
        {
            return salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;

        }

        public int AnnualSalary()
        {
            return salary * 12;
        }

        public int raiseSalary()
        {
            return salary + (salary / 100 * 10);
        }

        public string toString()
        {
            return "id= " + id + " name= " + getName() + " salary= " + raiseSalary();
        }
    }
    class ex1_4
    {
        public static void Mainx()
        {
            Employee e1 = new Employee();
            Console.WriteLine(e1.toString());
        }
    }
}
