
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
            throw new Exception("nedostatek pen�z pro v�b�r. " + "z�statek: " + balance);
        }
        else
            balance += amount;
    }




    public void writeBalance() {

        System.out.println("na ��t� je: " + balance );
    }


    public void transferTo(Account ucet, int castka)throws Exception {

        
        y = this.balance - castka;



        

            if (castka < 0) {
                throw new Exception("Nem��e� pos�lat m�nusov� hodnoty " + "z�statek: " + this.balance);
            }

            else if (y < 0) {

                throw new Exception("nedostatek pen�z pro transfer. " + "z�statek: " + this.balance);
            }
            else if (castka == 0) {

                throw new Exception("nelze pos�lat 0 " + "z�statek: " + this.balance);
            }
            else if (this == ucet)
                throw new Exception("nelz epos�lat s�m sob�. " + "z�statek: " + this.balance);
            else {
                ucet.balance += castka;
                this.balance -= castka;
           }
    }
    
            public void transferTo(Account ucet) {
                ucet.balance += this.balance;
                this.balance -= this.balance;
                //transferTo(ucet, this.balance); //<-- druh� zp�sob
            }

    
    
}