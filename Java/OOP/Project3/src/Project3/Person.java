package Project3;

import java.util.ArrayList;

public class Person {
	public int age;
    public String name;
    public Account[] myAccounts = new Account[5];
    public ArrayList<Account> myAccounts2 = new ArrayList<Account>();
    public int countOfAccounts = 0;
    public Date dateOfBirth;
   



    public Person() {

    }
    public Person(Date dateOfBirth, String name) {
        this.dateOfBirth = dateOfBirth;
        this.name = name;

    }

    public Person(String name,int day,int month,int year) {this ( new Date(day,month,year), name) ;
        //this.name=name;
        //dateOfBirth.year= year;
        //dateOfBirth.month = month;
        //dateOfBirth.day = day;  
    }

    public String writeAccounts() {
        String ucty = "";
        for (int i = 0; i <= countOfAccounts - 1; i++) {

            ucty += myAccounts[i].balance + " " + dateOfBirth.year + " ";
        }
        return ucty;
    }


    public String writeAccounts2() {
       String ucty2 = "";



        for (int i = 0; i <= countOfAccounts - 1; i++) {
            ucty2 = ucty2 + myAccounts2.get(i).balance + " ";   //<---- for
        }
        return ucty2;







        //foreach (Account x in myAccounts2) {
        //    ucty2 = ucty2 + x.balance + " ";     // <--- for each
        //}
        //return ucty2;

    }

}
