package Dodatecne;

import java.util.Scanner;

public class Ee1zdokonaleni {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.println("zadej dvojznakov� �et�zec");
		boolean velke = false;
		String ret = sc.next();
		int pismeno;
		for (int i = 0; i <= ret.length() - 1; i++) {
			pismeno = ret.charAt(i);
			if (pismeno < 65 || pismeno > 90) {
				velke = false;
				break;
			} else
				velke = true;
		}
		if (velke == true)
			System.out.println("v�echna p�smena bylya velk�");
		else
			System.out.println("jedno z p�smen bylo mal�");
	}
}
