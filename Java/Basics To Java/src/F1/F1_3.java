package F1;

import java.util.Scanner;

public class F1_3 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		char znak;
		int pocet, presun, sub;

		System.out.println("zadej znak a bude zakódován");
		znak = sc.next().charAt(0);
		System.out.println("zadej o kolik se posune");
		pocet = sc.nextInt();
		presun = kodovaniF(znak, pocet); // funkce
		System.out.printf("pùvodní znak: %c %nposunutí: %d %nzakódování: %c", znak, pocet,presun); // fce
	}

	public static int kodovaniF(char klavesa, int cislo) // funkce
	{
		int vystup;
		vystup = klavesa + cislo;
		if (vystup > 122)
			vystup = vystup - 26;
		return vystup;
	}
}
