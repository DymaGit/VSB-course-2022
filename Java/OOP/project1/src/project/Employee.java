package project;

abstract class Employee extends Person {
    private int salary;




        
        
        public int getSalary() {
        	return salary;
             }
        
        public void setSalaty(int salary) {
        	this.salary = salary;
        	
        }
    
    public Employee() {

    }
    public Employee(int age, int salary) { super (age) ;
        //this.age = age; toto nahrazuje d�d�n� konstruktoru base(age)
        this.salary = salary;
    }



    public void writeInfo() {
        //base.writeInfo();
        System.out.println(age);
        System.out.print(" plat zam�stnance je "+  getSalary() + " K� " + GetAge()+" "+  GetCount() );  // get/set
    }
}