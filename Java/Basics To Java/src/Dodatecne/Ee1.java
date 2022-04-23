package Dodatecne;

import java.util.Scanner;

public class Ee1 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.println("zadej dvojznakovı øetìzec");

		String ret = sc.next();
		int cislo1 = ret.charAt(0);
		int cislo2 = ret.charAt(1);
		if ((cislo1 > 64 && cislo1 < 91) && (cislo2 > 64 && cislo2 < 91))
			System.out.println("oba znaky jsou velká písmena");
		else
			System.out.println("jeden ze znakù nebo oba nejsou velká písmena");
	}
}
