package Project3;

import java.sql.Date;
import java.util.Calendar;

public class Account {

	public int balance;
    public Person owner;

    public Account() {

    }

    public Account(int balance, Person owner) {
        this.balance = balance;
        this.owner = owner;

        owner.myAccounts[owner.countOfAccounts] = this;
        owner.myAccounts2.add(this);
        owner.countOfAccounts++;

    }



    public void insertInto(int amount) {
        balance += amount;

    }

    public void writeBalance() {

    	System.out.println("na úètì je: " + balance +" " + owner.name+ " vìk majitele: "+  (Calendar.getInstance().get(Calendar.YEAR) - owner.dateOfBirth.year));

    }


    public void transferTo(Account ucet, int castka) {
        ucet.balance += castka;
        this.balance -= castka;

    }

    //public void transferTo(Account ucet) {
    //    ucet.balance += this.balance;
    //    this.balance -= this.balance;
    //transferTo(ucet, this.balance); //<-- druhý zpùsob
    //}

}
