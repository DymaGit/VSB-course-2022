package B;

import java.util.Scanner;

public class B4 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadje 3 ��sla");
		int cislo1= sc.nextInt();
		int cislo2= sc.nextInt();
		int cislo3= sc.nextInt();
		
        if (cislo1 > cislo2 && cislo1> cislo3)
            System.out.println("��slo " + cislo1 + " je nejv�t��");
        if (cislo2> cislo1 && cislo2>cislo3)
        	System.out.println("��slo " + cislo2 + " je nejv�t��");
        if (cislo3 > cislo1 && cislo3 > cislo2)
        	System.out.println("��slo " + cislo3 + " je nejv�t��");
        if (cislo1 < cislo2 && cislo1 < cislo3)
        	System.out.println("��slo " + cislo1 + " je nejmen��");
        if (cislo2 < cislo1 && cislo2 < cislo3)
        	System.out.println("��slo " + cislo2 + " je nejmen��");
        if (cislo3 < cislo1 && cislo3 < cislo2)
        	System.out.println("��slo " + cislo3 + " je nejmen��");
	}
}
