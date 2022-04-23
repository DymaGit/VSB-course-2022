package project;

class Teacher extends Employee {
    private int teachingTime;

//    public int TeachingTime {
//        get => teachingTime;
//        set {
//            if (value > 40)
//                System.out.println("chybné zadání.. Teaching time > 40");   //vyøešeno: zobrazuje "chybné zadání i "0"
//            else {                                      // chybí 3.tí krok    (9c) -> hotovo, snad dobøe.
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
        //this.age = age;   toto a druhy øádek nahrazuje dìdìní kontruktoru base(age,salary)
        //this.salary = salary;
        this.teachingTime = teachingTime;
    }
    public  void writeInfo() {
        super.writeInfo();
        System.out.println(" jeho úvazek je "+  getTeachingTime()+ " hod");
    }
}