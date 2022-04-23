package Dodatecne;

import java.util.Scanner;

public class Ee3 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		String vstup = sc.next();
		String vypis = "";
		char pismeno1 = vstup.charAt(0);
		char pismeno2 = vstup.charAt(1);

		for (int i = pismeno1; i <= pismeno2; i++)
			vypis = vypis + (char) i;

		System.out.println(vypis);
	}

}
