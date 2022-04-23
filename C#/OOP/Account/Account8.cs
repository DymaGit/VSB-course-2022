using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account8 {



    class Account {
        public int balance;
        public int kurz;
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

        public int writeBalanceDollars(int kurz) {

            return kurz;

        }

        public double writeBalanceDollarsDouble(double kurzDbl) {

            return kurzDbl;

        }

    }

    class Account8 {
        public static void Mainx() {

            //int amount;
            int vypocet;
            double vypocet2;
            int cisloInt;
            double cisloDbl;
            Account u1 = new Account();
            Account u2 = new Account();
            Account u3 = new Account();
            Account u4 = new Account();

            u1.insertInto(100); u2.insertInto(100);
            u1.transferTo(u2, 50);
            u1.writeBalance(); u2.writeBalance();
            u1.insertInto(-10);
            u1.transferTo(u2, 10);
            Console.Write($"{nameof(u1)}:");
            u1.writeBalance();
            Console.Write($"{nameof(u2)}:");
            u2.writeBalance();
            u1.transferTo(u2);
            u1.writeBalance(); u2.writeBalance();

            Console.WriteLine("zadej balance..");
            u3.balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("účet " + "3 má " + u3.balance + " kč");


            //amount = Int32.Parse(Console.ReadLine());
            //u3.insertInto(amount);                       <--- druhý způsob
            //Console.WriteLine(u3.balance);


            Console.WriteLine("zadej kurz..");
            cisloInt = int.Parse(Console.ReadLine());


            try {
                vypocet = u3.balance / u3.writeBalanceDollars(cisloInt);
                Console.WriteLine(u3.balance + "Kč je " + vypocet + " dolarů");
            }
            catch (System.SystemException e) {
                Console.WriteLine("dělení nulou.. CHYBA!! " + e.Message);
            }



            u4.balance = 600;
            Console.WriteLine("zadej kurz..");
            cisloDbl = double.Parse(Console.ReadLine());


            if (cisloDbl == 0) 
                throw new DivideByZeroException();
            else {
                vypocet2 = u4.balance / u4.writeBalanceDollarsDouble(cisloDbl);
                Console.WriteLine(u3.balance + "Kč je " + vypocet2 + " dolarů");
            }


        }

    }
}
