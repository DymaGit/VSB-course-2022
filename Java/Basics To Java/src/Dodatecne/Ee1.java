package Dodatecne;

import java.util.Scanner;

public class Ee1 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.println("zadej dvojznakov� �et�zec");

		String ret = sc.next();
		int cislo1 = ret.charAt(0);
		int cislo2 = ret.charAt(1);
		if ((cislo1 > 64 && cislo1 < 91) && (cislo2 > 64 && cislo2 < 91))
			System.out.println("oba znaky jsou velk� p�smena");
		else
			System.out.println("jeden ze znak� nebo oba nejsou velk� p�smena");
	}
}
