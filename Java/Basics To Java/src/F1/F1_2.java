package F1;

import java.util.Scanner;

public class F1_2 {
	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);
		char znak;
		int odkaz;

		System.out.println("zadej znak");
		znak = sc.next().charAt(0);
		odkaz = asciF(znak); // funkce

		System.out.println(odkaz); // funkce
	}

	static int asciF(char klavesa) // funkce
	{
		int vystup;
		vystup = klavesa;
		return vystup;
	}
}
