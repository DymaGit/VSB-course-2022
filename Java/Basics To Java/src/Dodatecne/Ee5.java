package Dodatecne;

import java.util.Scanner;

public class Ee5 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		int vypocet = 0;
		System.out.println("zadej bin�rn� ��slo");
		String bin = sc.next();
		int cislo;
		int delka = bin.length();
		int x = delka - 1;
		for (int i = 0; i <= delka - 1; i++) {

			cislo = bin.charAt(i) - 48;
			vypocet = vypocet + (int) (cislo * (Math.pow(2, x)));
			x--;
		}
		System.out.printf("bin�rn� ��slo %s %nDecim�ln� ��slo %d", bin, vypocet);
	}
}
