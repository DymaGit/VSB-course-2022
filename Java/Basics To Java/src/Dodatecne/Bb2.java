package Dodatecne;

import java.util.Scanner;

public class Bb2 {

	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("zadej øetìzec o 3 písmenech");
		String retezec = sc.next();
		int pismeno1 = retezec.charAt(0);
		int pismeno2 = retezec.charAt(1);
		int pismeno3 = retezec.charAt(2);

		if ((pismeno2 - 1 == pismeno1) || (pismeno2 + 1 == pismeno3) || (pismeno2 + 1 == pismeno1)
				|| (pismeno2 - 1 == pismeno3))
			System.out.println("Platí");
		else
			System.out.println("Neplatí");
	}

}
