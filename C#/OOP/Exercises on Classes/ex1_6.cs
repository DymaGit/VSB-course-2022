using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_6
{
    class Account
    {
        private string id;
        private string name;
        private int balance = 0;


        public Account()
        {
            id = "1";
            name = "John Smith";
        }

        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getBalance()
        {
            return balance;
        }

        public int credit()
        {
            return balance = 10000;
        }

        public int debit()
        {
            int amount = int.Parse(Console.ReadLine());
            balance = credit();
            if (amount <= balance)
                balance = balance - amount;
            else
                Console.WriteLine("Amount exceeded balance");
            return balance;
        }

        public int transferTo()
        {
            balance = credit();
            int amount = int.Parse(Console.ReadLine());
            if (amount <= balance)
                balance = balance - amount;
            else
                Console.WriteLine("Amount exceeded balance");
            return balance;

        }
        public string toString()
        {
            return "id: " + id + " name= " + name + " balance= " + balance;
        }


        public string toString2()
        {
            return "id: " + id + " name= " + name + " balance= " + debit();
        }
    }
    class ex1_6
    {
        public static void Mainx()
        {
            Account a1 = new Account();
            Console.WriteLine(a1.toString());
            Account a2= new Account();
            Console.WriteLine(a2.toString2());

        }
    }


}
