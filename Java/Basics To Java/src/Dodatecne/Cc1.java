package Dodatecne;

import java.util.Scanner;

public class Cc1 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadej ��slo a propgram zjist� kolikr�t jsou v n�m 2 sedmi�ky vedle sebe");
		String cislo = sc.next();
		int delka = cislo.length();
		int pocitadlo = 0;
		for (int i = 1; i <= delka - 1; i++)

			if ((cislo.charAt(i) == 55) && (cislo.charAt(i - 1) == 55))
				pocitadlo++;
		System.out.println("sedmi�ky jsou vedle sebe " + pocitadlo + "x");
	}
}
