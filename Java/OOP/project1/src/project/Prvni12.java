

package project ;
    class Prvni12 {
        public static void mainx(String[] args) {
        	 
            Student s1 = new Student(20, 5000);
            Student s2 = new Student();
            Accountant a1 = new Accountant(25, 25000);
            Teacher t1 = new Teacher(40, 27000, 21);

            s1.writeInfo();
            s2.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Teacher t2 = new Teacher(30, 20000, 41);  //nesm� b�t v�c jak 40 jinak hl�s� "chybu" a "0"

            t2.writeInfo();
            System.out.println(  s1.GetAge()+" "+  a1.GetCount()+ "<-- toto je v�pis z mainu, p�es set/get kdy jsem ��hl po private datov�ch slo�k�ch");
            System.out.println(s1.ToString());
            System.out.println(s1.ToString());
        }
    }





