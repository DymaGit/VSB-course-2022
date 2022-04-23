
package Project4;
import java.io.*;

class Account {
	
    public int balance;
    public int x;
    public int y;
    
    public void insertInto(int amount)throws Exception {

        //balance += amount;


        x = balance + amount;
        if (x < 0) {
            throw new Exception("nedostatek penìz pro výbìr. " + "zùstatek: " + balance);
        }
        else
            balance += amount;
    }




    public void writeBalance() {

        System.out.println("na úètì je: " + balance );
    }


    public void transferTo(Account ucet, int castka)throws Exception {

        
        y = this.balance - castka;



        

            if (castka < 0) {
                throw new Exception("Nemùžeš posílat mínusové hodnoty " + "zùstatek: " + this.balance);
            }

            else if (y < 0) {

                throw new Exception("nedostatek penìz pro transfer. " + "zùstatek: " + this.balance);
            }
            else if (castka == 0) {

                throw new Exception("nelze posílat 0 " + "zùstatek: " + this.balance);
            }
            else if (this == ucet)
                throw new Exception("nelz eposílat sám sobì. " + "zùstatek: " + this.balance);
            else {
                ucet.balance += castka;
                this.balance -= castka;
           }
    }
    
            public void transferTo(Account ucet) {
                ucet.balance += this.balance;
                this.balance -= this.balance;
                //transferTo(ucet, this.balance); //<-- druhý zpùsob
            }

    
    
}