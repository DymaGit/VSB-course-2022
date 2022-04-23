package Project4;

import java.util.Scanner;

import java.io.*;
class Account11 {
    public static void mainx(String[] args) throws Exception {
    	Scanner sc = new Scanner(System.in);
        int presun;
        int vklad;
        boolean ok;
    //int amount;       
    Account u1 = new Account();
        Account u2 = new Account();
        //Account u3 = new Account();
        Account u4 = new Account();
        Account u5 = new Account();
        u1.insertInto(100); u2.insertInto(100);
        u1.transferTo(u2, 50);
        u1.writeBalance(); u2.writeBalance();
        u1.insertInto(-10);
        u1.transferTo(u2, 10);
        //System.out.print(nameof(u1));    // toto není v javì, jde to ale obejít
        u1.writeBalance();
        //System.out.print(nameof(u2));		// toto není v javì, jde to ale obejít
        u2.writeBalance();
        u1.balance = 100;
       // u1.transferTo(u2);
        u1.writeBalance(); u2.writeBalance();

        //u3.balance = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("úèet " + "3 má " + u3.balance + " kè");
        //u1.writeBalance(); u2.writeBalance();

        //amount = Int32.Parse(Console.ReadLine());
        //u3.insertInto(amount);                       <--- druhý zpùsob
        //Console.WriteLine(u3.balance);


        u4.balance = 100;

        System.out.println("na úètì u4 je " + u4.balance);

        do {
            

        	System.out.println("zadej vklad");
            vklad =sc.nextInt(); //<<<<<<<<
            try {

                u4.insertInto(vklad);
                break;
            }

            catch (Exception e) {
            	System.out.println(e.getMessage());
            	System.out.println(e.getStackTrace());
            }
            System.out.println("balance u4: " + u4.balance);


        }
        while (u4.balance > 0);

        System.out.println("balance u4: " + u4.balance);




        System.out.println();
        u1.balance = 0;

        u5.balance = 250;
        u1.balance = 175;
        System.out.println("balance u1: " + u1.balance);
        System.out.println("balance u5: " + u5.balance);

        do {
        	System.out.println("zadej kolik chceš poslat na cizí úèet");
            presun = sc.nextInt();
            try {
                
                u5.transferTo(u1, presun);
                ok = false;
                System.out.println("balance u1: " + u1.balance);
                System.out.println("balance u5: " + u5.balance);
            }


            catch (Exception e) {
            	System.out.println(e.getMessage());
                ok = true;
            }

        }

        while (ok==true);

    }
}