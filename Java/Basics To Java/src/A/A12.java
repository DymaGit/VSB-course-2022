package A;

import java.util.Scanner;

public class A12 {

	public static void mainx(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.println("jak� je pr�m�r tvojeho baz�nu?");
		int prumer = sc.nextInt();
		System.out.println("zadej v��ku baz�nu");
		int vyska = sc.nextInt();
		float vypocet = (float) (Math.PI * Math.pow(prumer / 2, 2) * vyska);
		System.out.printf("objem baz�nu je %.3f m3", vypocet);
	}
}
