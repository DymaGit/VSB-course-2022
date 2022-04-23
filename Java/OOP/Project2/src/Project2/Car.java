package Project2;

class Car implements IsoundAble
{
    public String name;
    public int speed;

    public Car(String name)
    {
        this.name = name;
    }
    public void sound()
    {
       System.out.println(" brm brm  ");
    }
    //public string getName() { return name; }
    public String getName(){
    	return name;
    }
    
    public void setName(String name) {
    	this.name=name;
    }
}