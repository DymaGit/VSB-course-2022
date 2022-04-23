using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account10 {



    class Account {
        public int balance;
        public int x;
        public int y;
        public void insertInto(int amount) {

            //balance += amount;
           

                x = balance + amount;
                if (x < 0) {
                    throw new ArgumentOutOfRangeException("nedostatek peněz pro výběr. " + "zůstatek: " + balance);
                }
                else
                    balance += amount;
        }




        public void writeBalance() {

            Console.WriteLine($"na účtě je: {balance} ");
        }


        public void transferTo(Account ucet, int castka) {


            y = this.balance - castka;



            try {

                if (castka < 0) {
                    throw new ArgumentOutOfRangeException("Nemůžeš posílat mínusové hodnoty " + "zůstatek: " + this.balance);
                }

                else if (y < 0) {

                    throw new ArgumentOutOfRangeException("nedostatek peněz pro transfer. " + "zůstatek: " + this.balance);
                }
                else if (y == 0) {

                    throw new ArgumentOutOfRangeException("nelze posílat 0 " + "zůstatek: " + this.balance);
                }
                else if (this == ucet)
                    throw new ArgumentOutOfRangeException("nelz eposílat sám sobě. " + "zůstatek: " + this.balance);
                else {
                    ucet.balance += castka;
                    this.balance -= castka;
                }
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);

            }

        }

        public void transferTo(Account ucet) {
            //ucet.balance += this.balance;
            //this.balance -= this.balance;
            transferTo(ucet, this.balance); //<-- druhý způsob
        }

    }

    class Account10 {
        public static void Mainx() {
            int presun;
            int vklad;
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
            Console.Write($"{nameof(u1)}:");
            u1.writeBalance();
            Console.Write($"{nameof(u2)}:");
            u2.writeBalance();
            u1.transferTo(u2);
            u1.writeBalance(); u2.writeBalance();

            //u3.balance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("účet " + "3 má " + u3.balance + " kč");
            //u1.writeBalance(); u2.writeBalance();

            //amount = Int32.Parse(Console.ReadLine());
            //u3.insertInto(amount);                       <--- druhý způsob
            //Console.WriteLine(u3.balance);


            u4.balance = 100;
            



            
            Console.WriteLine("zdaej vklad");
            vklad = int.Parse(Console.ReadLine());
            try {
               
                u4.insertInto(vklad);
            }

            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("balance u4: "+ u4.balance);







            Console.WriteLine();
            u1.balance = 0;

            u5.balance = 250;
            u1.balance = 175;
            Console.WriteLine("balance u1: " + u1.balance);
            Console.WriteLine("balance u5: " + u5.balance);
           
            presun = int.Parse(Console.ReadLine());
            u5.transferTo(u1, presun);
            Console.WriteLine("balance u1: " + u1.balance);
            Console.WriteLine("balance u5: " + u5.balance);


        }

    }
}
