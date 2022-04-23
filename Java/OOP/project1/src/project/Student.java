package project;

class Student extends Person {

    public int scholarship;

    public Student() {

    }

    public Student(int age, int scholarship) { super (age); 
        //this.age = age;  toto nahrazuje dìdìní konstruktoru base(age)
        this.scholarship = scholarship;
    }

    //public Student(int age) : base(age) {
    //    this.age = age;
    //}

    public  void writeInfo() {
        //base.writeInfo();
    	System.out.print(age);   //tady jsem místo geteru a seteru pøedìlal prostì age na public.. at stihám. Ale jinak bych musel použít get/set protože age má být private
        System.out.println(" školné je " + scholarship+ "Kè");
    }


    public String ToString() {
        return String.format("Student to string.. s overridem pøepsal i puvodni. Takže je to vypsané 2x");
    }


}