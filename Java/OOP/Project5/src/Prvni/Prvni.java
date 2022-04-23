package Prvni;




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
        // Console.Write($"v�k osoby je {age}, inkrementace: {count}");
        //}

        //public void Info() {
        //    Console.Write($"v�k osoby je {age}, ");
        //}

        public   String toString() {
            return "Person to string";
        }
    

    
    abstract class Employee extends Person {
        private int salary;



//        public int Salary {
//            get { return salary; }
//            set {
//                salary = value;
//            }
//        }
        
        
        public int getSalary() {
        	
        	return salary;
        }
        
        public void setSalary(int salary) {
        	
        	this.salary= salary;
        }
        
        
        public Employee() {

        }
        public Employee(int age, int salary) { 
        	super(age); 
            //this.age = age; toto nahrazuje d�d�n� konstruktoru base(age)
            this.salary = salary;
        }



        public   void writeInfo() {
            //base.writeInfo();
        	System.out.print(age);
        	System.out.print("plat zam�stnance je"+  getSalary()+" K�"+ GetAge()+" "+ GetCount() );  // get/set
        }
    }
    class Student extends Person {

        public int scholarship;

        public Student() {

        }

        public Student(int age, int scholarship) {super(age);
            //this.age = age;  toto nahrazuje d�d�n� konstruktoru base(age)
            this.scholarship = scholarship;
        }

//        public Student(int age) : base(age) {
//            this.age = age;
//        }

        public void writeInfo() {
            //base.writeInfo();
        	System.out.print(age);   //tady jsem m�sto geteru a seteru p�ed�lal prost� age na public.. at stih�m. Ale jinak bych musel pou��t get/set proto�e age m� b�t private
            System.out.println(" �koln� je  "+ scholarship+ "K�");
        }


        public  String toString() {
            return String.format("Student to string.. s overridem p�epsal i puvodni. Tak�e je to vypsan� 2x");
        }


    }
    class Accountant extends Employee {

        public Accountant() {

        }
        public Accountant(int age, int salary) {
        	super(age, salary); 
            //this.age = age;   toto a druhy ��dek nahrazuje d�d�n� kontruktoru base(age,salary)
            //this.salary = salary;
        }

        public   void writeInfo() {
            super.writeInfo();
            
            System.out.println();
        }
    }
    class Teacher extends Employee {
        private int teachingTime;

//        public int TeachingTime; {
//            get => teachingTime;
//            set {
//                if (value > 40)
//                	System.out.println("chybn� zad�n�.. Teaching time > 40");   //vy�e�eno: zobrazuje "chybn� zad�n� i "0"
//                else {                                      // chyb� 3.t� krok    (9c) -> hotovo, snad dob�e.
//                    teachingTime = value;
//                }
//
//            }
//        }
        
        public int TeachingTime() {
        	
        	return teachingTime;
        }
        
        public void SetTeachingtime(int teachingTime) {
        	this.teachingTime = teachingTime;
        }
        

        public Teacher(int age, int salary, int teachingTime) {super(age, salary); 
            //this.age = age;   toto a druhy ��dek nahrazuje d�d�n� kontruktoru base(age,salary)
            //this.salary = salary;
            this.teachingTime = teachingTime;
        }
        public   void writeInfo() {
            super.writeInfo();
            System.out.println(" jeho �vazek je" + teachingTime + " hod");
        }
    }
    class Prvni11 {
        public static void main() {
            
            Student s1 = new Student(20, 5000);
            Student s2 = new Student();
            Accountant a1 = new Accountant(25, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);

            s1.writeInfo();
            s2.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Teacher t2 = new Teacher(30, 20000, 41);  //nesm� b�t v�c jak 40

            t2.writeInfo();
            System.out.println(s1.GetAge() + " " +a1.GetCount() + "<-- toto je v�pis z mainu, p�es set/get kdy jsem ��hl po private datov�ch slo�k�ch");
            System.out.println(s1);
            System.out.println(s1.toString());
        }
    }
}


