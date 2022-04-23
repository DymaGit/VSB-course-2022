package B;

import java.util.Scanner;

public class B4 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadje 3 èísla");
		int cislo1= sc.nextInt();
		int cislo2= sc.nextInt();
		int cislo3= sc.nextInt();
		
        if (cislo1 > cislo2 && cislo1> cislo3)
            System.out.println("èíslo " + cislo1 + " je nejvìtší");
        if (cislo2> cislo1 && cislo2>cislo3)
        	System.out.println("èíslo " + cislo2 + " je nejvìtší");
        if (cislo3 > cislo1 && cislo3 > cislo2)
        	System.out.println("èíslo " + cislo3 + " je nejvìtší");
        if (cislo1 < cislo2 && cislo1 < cislo3)
        	System.out.println("èíslo " + cislo1 + " je nejmenší");
        if (cislo2 < cislo1 && cislo2 < cislo3)
        	System.out.println("èíslo " + cislo2 + " je nejmenší");
        if (cislo3 < cislo1 && cislo3 < cislo2)
        	System.out.println("èíslo " + cislo3 + " je nejmenší");
	}
}
