package Project2;

class Cat extends Animal implements IsoundAble {
    public Boolean isPedigree;
    public Cat(String name) {super(name); 
    }
    public void sound() {
    	System.out.println(" m�au");
    }
   // public string getName() { return name; }
    
    
    public String getName(){
    	return name;
    }
    
    public void setName(String name) {
    	this.name=name;
    }
    

}