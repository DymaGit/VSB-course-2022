package F2;

import java.util.Random;
import java.util.Scanner;

public class F4 {
	public static void mainx(String[] args) {

		Scanner sc = new Scanner(System.in);
		int[] polecisla = new int[8];
		int cislo;
		int vystup;
		String vypis = "";
		Random r = new Random();

		System.out.println("zadej které èíslo tì zajímá");
		cislo = sc.nextInt();

		for (int i = 0; i <= polecisla.length - 1; i++) {
			polecisla[i] = r.nextInt(1, 11);
			vypis = vypis + polecisla[i] + " ";
		}
		vystup = pocetvyskytuF(polecisla, cislo); // funkce

		System.out.printf("padlé èísla: %s%nkolikrát padlo zadané èíslo: %dx", vypis, vystup); // funkce

	}

	public static int pocetvyskytuF(int[] policko, int pocet) // funkce
	{
		int x = 0;

		for (int i = 0; i <= policko.length - 1; i++) {
			if (policko[i] == pocet)
				x += 1;
		}
		return x;
	}
}
