using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_on_Classes
{

    class ClassRoom
    {
        
        private Teacher teacher;
        private Student[] students = new Student[5];
        private int currentNumberOfStudents;

        public ClassRoom(int currentNumberOfStudents)
        {
            this.currentNumberOfStudents = currentNumberOfStudents;
            
        }

        public bool addStudent()
        {
            currentNumberOfStudents++;
            if (currentNumberOfStudents < 5)
                return true;
            else
                return false;

        }

        public bool removeStudent()
        {
            currentNumberOfStudents--;
            if (currentNumberOfStudents > 0)
                return true;
            else
                return false;

        }

        public string toString()
        {
            return teacher.tName + students[0];
        }

    }


    class Teacher
    {
        public string tName;

        public Teacher(string tName)
        {
            this.tName = tName;
        }

    }


    class Student
    {
        private string firstName;
        private string lastName;
        private double age;
        private double average;

        public Student(string firstName, string lastName, double age, double average)
        {
            this.average = average;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string toString()
        {
            return firstName + " " + lastName + " " + age + " " + average;

        }
    }




    class Composition
    {


        public static void Mainx()
        {
            Student s1 = new Student("Fero","Lakatoš", 15, 2.5);
            Console.WriteLine(s1.toString());

        }



    }
}
