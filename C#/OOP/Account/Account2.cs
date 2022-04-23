﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account2 {



    class Account {
        public int balance;
        public Person owner;

        public Account() {

        }

        public Account(int balance, Person owner) {
            this.balance = balance;
            this.owner = owner;
        }

        public void insertInto(int amount) {
            balance += amount;

        }

        public void writeBalance() {

            Console.WriteLine($"na účtě je: {balance} {owner.name} ");

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

        public Person() {

        }
        public Person(int age, string name) {
            this.age = age;
            this.name = name;
        }



    }

    class Account2 {
        public static void Mainx() {

            Person p1 = new Person(50, "petr"); Person p2 = new Person(23, "Michal"); Person p3 = new Person(31, "Zdena");
            Account u1 = new Account(0, p1);
            Account u2 = new Account(0, p2);

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
        

        }


        static void writeBalance2(Account u1, Account u2) {
            u1.writeBalance(); u2.writeBalance();
        }

    }
}
