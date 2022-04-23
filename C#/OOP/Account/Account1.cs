using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1 {



    class Account {
       public int balance;

        public void insertInto(int amount) {
             balance += amount;
            
        }

        public void writeBalance() {

            Console.WriteLine($"na účtě je: {balance} ");
        }


        public void transferTo(Account ucet, int castka) {
            ucet.balance += castka;
            this.balance -= castka;
   
        }

        public void transferTo(Account ucet) {
            //ucet.balance += this.balance;
            //this.balance -= this.balance;
            transferTo(ucet, this.balance); //<-- druhý způsob
        }

    }

    class Account1 {
        public static void Mainx() {

           Account u1 = new Account();
           Account u2 = new Account();

            u1.insertInto(100);u2.insertInto(100);
            u1.transferTo(u2, 50);
            u1.writeBalance();u2.writeBalance();
            u1.insertInto(-10);
            u1.transferTo(u2, 10);
            Console.Write($"{nameof(u1)}:");
            u1.writeBalance();
            Console.Write($"{nameof(u2)}:");
            u2.writeBalance();
            u1.transferTo(u2);
            u1.writeBalance(); u2.writeBalance();

        }

    }
}
