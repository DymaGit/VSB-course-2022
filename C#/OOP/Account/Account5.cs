using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account5 {



    class Account {
        public int balance;
        public Person owner;

        public Account() {

        }

        public Account(int balance, Person owner) {
            this.balance = balance;
            this.owner = owner;
            
            owner.myAccounts[owner.countOfAccounts] = this;
            owner.myAccounts2.Add(this);
            owner.countOfAccounts++;
            
        }



        public void insertInto(int amount) {
            balance += amount;

        }

        public void writeBalance() {

            Console.WriteLine($"na účtě je: {balance} {owner.name} věk majitele: { DateTime.Today.Year - owner.dateOfBirth.year} ");  

        }


        public void transferTo(Account ucet, int castka) {
            ucet.balance += castka;
            this.balance -= castka;

        }

        //public void transferTo(Account ucet) {
        //    ucet.balance += this.balance;
        //    this.balance -= this.balance;
        //transferTo(ucet, this.balance); //<-- druhý způsob
        //}




    }


    class Person {
        public int age;
        public string name;
        public Account[] myAccounts = new Account[5];
        public List<Account> myAccounts2 = new List<Account>();
        public int countOfAccounts = 0;
        public Date dateOfBirth;

      

  
        public Person() {

        }
        public Person(Date dateOfBirth, string name) {
            this.dateOfBirth = dateOfBirth;
            this.name = name;

        }

        public string writeAccounts() {
            string ucty = "";
            for (int i = 0; i <= countOfAccounts - 1; i++)
            {
                
                ucty += myAccounts[i].balance + " "+ dateOfBirth.year+ " ";
            }
            return ucty;
        }

        public string writeAccounts2() {
            string ucty2 = "";



            for (int i = 0; i <= countOfAccounts - 1; i++) {
                ucty2 = ucty2 + myAccounts2[i].balance + " ";   //<---- for
            }
            return ucty2;


            //foreach (Account x in myAccounts2) {
            //    ucty2 = ucty2 + x.balance + " ";     // <--- for each
            //}
            //return ucty2;

        }

    }


    class Date
    {
        public int day;
        public int month;
        public int year;    


        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }

    }
    class Account5 {
        

        public static void Mainx() {

            Person p1 = new Person(new Date(1,5,1990), "Petr"); Person p2 = new Person(new Date(3, 12, 1992), "Michal");  
            Account u1 = new Account(0, p1);
            Account u2 = new Account(100,new Person(new Date(11,1,1999), "radim"));
            Account u3 = new Account(75, p1);
            u1.insertInto(100); u2.insertInto(100);
            u1.transferTo(u2, 50);
            u1.writeBalance(); u2.writeBalance();
            u1.insertInto(-10);
            u1.transferTo(u2, 10);
            Console.Write($"{nameof(u1)}:");
            u1.writeBalance();
            Console.Write($"{nameof(u2)}:");
            u2.writeBalance();
            writeBalance2(u1, u2);

            Console.WriteLine();
            Console.WriteLine(u1.owner.name);
            Console.WriteLine(p1.myAccounts[0].balance);

            u3.writeBalance();

            Console.WriteLine();

            Console.WriteLine(p1.name + " má " + p1.countOfAccounts + " účty");
            Console.WriteLine(p2.name + " má " + p2.countOfAccounts + " účet");

            Console.WriteLine();

            Console.WriteLine(p1.writeAccounts());
            Console.WriteLine(u1.owner.name);

            Console.WriteLine();
            Console.WriteLine(p1.writeAccounts2());
            Console.WriteLine(u1.owner.name);

            Console.WriteLine(u1.owner.dateOfBirth.day);


        }


        static void writeBalance2(Account u1, Account u2) {
            u1.writeBalance(); u2.writeBalance();
        }

    }
}
