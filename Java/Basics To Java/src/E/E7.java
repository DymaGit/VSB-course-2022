package E;

import java.util.Scanner;

public class E7 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadej 5 slov");
		String[] pole1 = new String[9];
		int i = -1;
		int pocet = 0;
		String slovo;
		do {
			i++;
			pole1[i] = sc.next();
		} while (i < 4);

		System.out.println("zadej jedno z t�ch slov znovu");
		slovo = sc.next();

		for (int x = 0; x <= 4; x++) {
			if (slovo.equals(pole1[x])) {
				pocet = x + 1;
			}
		}
		System.out.println("zadan� slovo bylo naps�no v " + pocet + ". po�ad�.");
	}
}
