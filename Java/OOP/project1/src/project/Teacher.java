package project;

class Teacher extends Employee {
    private int teachingTime;

//    public int TeachingTime {
//        get => teachingTime;
//        set {
//            if (value > 40)
//                System.out.println("chybn� zad�n�.. Teaching time > 40");   //vy�e�eno: zobrazuje "chybn� zad�n� i "0"
//            else {                                      // chyb� 3.t� krok    (9c) -> hotovo, snad dob�e.
//                teachingTime = value;
//            }
//
//        }
//    }
    
    public int getTeachingTime(){
    	return teachingTime;
    }
    
    public void setTeachingTime(int teachingTime) {
    	this.teachingTime=teachingTime;
    }
    

    public Teacher(int age, int salary, int teachingTime) { super (age, salary) ;
        //this.age = age;   toto a druhy ��dek nahrazuje d�d�n� kontruktoru base(age,salary)
        //this.salary = salary;
        this.teachingTime = teachingTime;
    }
    public  void writeInfo() {
        super.writeInfo();
        System.out.println(" jeho �vazek je "+  getTeachingTime()+ " hod");
    }
}