package project;

class Student extends Person {

    public int scholarship;

    public Student() {

    }

    public Student(int age, int scholarship) { super (age); 
        //this.age = age;  toto nahrazuje d�d�n� konstruktoru base(age)
        this.scholarship = scholarship;
    }

    //public Student(int age) : base(age) {
    //    this.age = age;
    //}

    public  void writeInfo() {
        //base.writeInfo();
    	System.out.print(age);   //tady jsem m�sto geteru a seteru p�ed�lal prost� age na public.. at stih�m. Ale jinak bych musel pou��t get/set proto�e age m� b�t private
        System.out.println(" �koln� je " + scholarship+ "K�");
    }


    public String ToString() {
        return String.format("Student to string.. s overridem p�epsal i puvodni. Tak�e je to vypsan� 2x");
    }


}