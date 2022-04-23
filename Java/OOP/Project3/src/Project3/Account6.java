package Project3;

class Account6 {


	public static void main (String[] args) {

        Person p1 = new Person(new Date(1, 5, 1990), "Petr"); Person p2 = new Person(new Date(3, 12, 1992), "Michal");
        Account u1 = new Account(0, p1);
        Account u2 = new Account(100, new Person(new Date(11, 1, 1999), "radim"));
        Account u3 = new Account(75, p1);
        u1.insertInto(100); u2.insertInto(100);
        u1.transferTo(u2, 50);
        u1.writeBalance(); u2.writeBalance();
        u1.insertInto(-10);
        u1.transferTo(u2, 10);
        //System.out.print(nameof(u1)+ ": ");
        u1.writeBalance();
       // System.out.print(nameof(u2)+ ": ");
        u2.writeBalance();
        writeBalance2(u1, u2);
        
        System.out.println();
        System.out.println(u1.owner.name);
        System.out.println(p1.myAccounts[0].balance);

        u3.writeBalance();

        System.out.println();

        System.out.println(p1.name + " má " + p1.countOfAccounts + " úèty");
        System.out.println(p2.name + " má " + p2.countOfAccounts + " úèet");

        System.out.println();

        System.out.println(p1.writeAccounts());
        System.out.println(u1.owner.name);

        System.out.println();
        System.out.println(p1.writeAccounts2());
        System.out.println(u1.owner.name);

        System.out.println(u1.owner.dateOfBirth.day);

                    
        
    }


    static void writeBalance2(Account u1, Account u2) {
        u1.writeBalance(); u2.writeBalance();
    }

}

