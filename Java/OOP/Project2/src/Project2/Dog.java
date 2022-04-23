package Project2;

class Dog extends Animal implements IsoundAble {
    public Boolean isPedigree;
    public Dog(String name) { super(name);
    }
    public void sound() {
    	System.out.println(" haf  ");
    }

    //public string getName() { return name; }


    public String getName(){
    	return name;
    }
    
    public void setName(String name) {
    	this.name=name;
    }
}