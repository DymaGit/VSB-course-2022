package F2;

import java.util.Scanner;

public class F9 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		int[] pole1 = new int[10];
		int i = -1;
		boolean vystup;
		System.out.println("zadej øadu èísle a zjistí se jesi sou lineární");
		do {
			i++;
			pole1[i] = sc.nextInt();
		} while (pole1[i] != 0);

		vystup = pravdanepravdaF(pole1, i);

		System.out.println(vystup);

	}

	static boolean pravdanepravdaF(int[] p, int pocet) {
		int rozdil;
		boolean vysledek = true;
		rozdil = p[1] - p[0];

		for (int i = 0; i <= pocet - 2; i++) {
			if (p[i + 1] - p[i] != rozdil)
				vysledek = false;
		}
		return vysledek;
	}
}
