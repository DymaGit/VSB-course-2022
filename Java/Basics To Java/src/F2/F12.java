package F2;

import java.util.Scanner;

public class F12 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		int i = -1;
		String[] vyslednepole = new String[9];
		String[] poleslov = new String[9];
		String vystup = "";

		do {
			i++;
			poleslov[i] = sc.nextLine();
		} while (!poleslov[i].equals("0"));

		vyslednepole = kodovanislovF(poleslov, i); // funkce

		for (int x = 0; x <= i - 1; x++) // funkce
		{
			vystup = vystup + vyslednepole[x] + "\n";
		}
		System.out.println(vystup);
	}

	static String[] kodovanislovF(String[] p, int pocet) // funkce
	{
		String slovo;
		char pismeno;
		String vypis = "";
		String[] novepole = new String[pocet];

		// jednoduché kódování +1 znak bez "-26"
		for (int b = 0; b < pocet; b++) {
			slovo = p[b];
			for (int x = 0; x <= slovo.length() - 1; x++) {
				pismeno = slovo.charAt(x);
				vypis = vypis + (char) (pismeno + 1);
			}
			novepole[b] = vypis;
			vypis = "";
		}
		return novepole;
	}
}
